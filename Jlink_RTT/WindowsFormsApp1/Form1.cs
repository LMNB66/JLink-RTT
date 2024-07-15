using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using JLink_ARM;
using System.Text.RegularExpressions;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public struct Up_Down_addr_t //定义一个包含aUp或aDown的成员的地址结构体
        {
            public UInt32 pBuffer;
            public UInt32 WrOff;
            public UInt32 RdOff;
        }
        public static UInt32 rtt_addr; //_SEGGER_RTT结构体的地址
        public static Up_Down_addr_t aUp_addr; //aUp结构体的地址
        public static Up_Down_addr_t aDown_addr; //aDown_addr结构体的地址             
        public static byte Terminal = 0x30; //选择打印数据的通道
        
        public static byte[] aUp0_buff = new byte[2048];
        public static byte[] aUp1_buff = new byte[2048];
        public static byte[] acID = new byte[10];
        public static UInt32 len_0 = 0, len_1 = 0;//接收的长度

        public static string link_status = "打开连接";

        public static bool ter_change_flag = false; //通道改变的标志

        public static bool RxShow_HEX_0 = false;//通道0开启接收显示16进制标志
        public static bool RxShow_HEX_1 = false;//通道1开启接收显示16进制标志
        public static bool RxShow_Time_0 = false;//通道0开启定时接收标志
        public static bool RxShow_Time_1 = false;//通道1开启定时接收标志
        public static bool time_flag_0 = false;//通道0定时器到达标志标志
        public static bool time_flag_1 = false;//通道1定时器到达标志标志

        public static bool send_new_line = false;//发送新行\r\n标志
        public static bool send_HEX = false;//16进制发送标志

        static volatile bool Thread_stop_flag = true; //多线程任务停止的标志

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //使窗口在屏幕的中间
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Terminal = 0x30; //默认是通道0
            ter_change_flag = false; //不改变通道

            link_status = "打开连接";

            comboBox1.SelectedIndex = comboBox1.Items.IndexOf("Cortex-M0");
            comboBox1.Enabled = true;

            Thread_stop_flag = true;

            show_time_len.Text = "100";
            send_time_len.Text = "1000";
            addr.Text = Properties.Settings.Default.rtt_addr;
            send_text.Text = Properties.Settings.Default.tx_buff;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Thread_stop_flag = true;
            Properties.Settings.Default.rtt_addr = addr.Text;
            Properties.Settings.Default.tx_buff = send_text.Text;
            Properties.Settings.Default.Save();

            Thread.Sleep(20);
            if (JLinkHandler.JLINKARM_IsOpen())
            {
                JLinkHandler.JLINKARM_Close();
            }
        }

        delegate void Change(string s);
        public void updata_button(string s)
        {
            link_sw.Text = s;
        }
        public void updata_texbox_0(string s)
        {
            this.Terminal_0.AppendText(s);
            this.Terminal_0.SelectionStart = this.Terminal_0.Text.Length;
            this.Terminal_0.ScrollToCaret();
        }
        public void updata_texbox_1(string s)
        {
            this.Terminal_1.AppendText(s);
            this.Terminal_1.SelectionStart = this.Terminal_1.Text.Length;
            this.Terminal_1.ScrollToCaret();
        }
        public string byteToHexstr(byte[] a, UInt32 len)
        {
            string s = "";
            for(int i = 0;i<len;i++)
            {
                s += a[i].ToString("X2") + " ";
            }
            return s;
        }

        
        public void Read_RTT()
        {
            while (!Thread_stop_flag)
            {
                read_sta = JLinkHandler.JLINKARM_ReadMem(rtt_addr, 6, acID);
                if (read_sta == 0)
                {
                    //Console.WriteLine(Encoding.ASCII.GetString(acID, 0, 6));
                    if (Encoding.ASCII.GetString(acID, 0, 6) != "SEGGER")
                    {
                        Thread.Sleep(100);
                        search_addr();
                        continue;
                    }
                    UInt32 wr = JLinkHandler.JLINKARM_ReadU32(aUp_addr.WrOff);
                    UInt32 rd = JLinkHandler.JLINKARM_ReadU32(aUp_addr.RdOff);
                    if (wr >= 1024 || rd >= 1024) continue;
                    
                    while (wr != rd)
                    {
                        
                        byte tmp = JLinkHandler.JLINKARM_ReadU8(aUp_addr.pBuffer + rd);
                        
                        rd++;
                        rd &= 0x000003ff;
                        
                        if (tmp == 0xff)
                        {
                            ter_change_flag = true;
                        }
                        else
                        {
                            if (ter_change_flag)
                            {
                                ter_change_flag = false;
                                if (tmp < 0x30 || tmp > 0x32) tmp = 0x30;
                                Terminal = tmp;
                            }
                            else
                            {
                                switch (Terminal)
                                {
                                    case 0x30:
                                        len_0 = len_0 >= 2048 ? 0 : len_0;
                                        aUp0_buff[len_0] = tmp;
                                        len_0++;
                                        break;
                                    case 0x31:
                                        len_1 = len_1 >= 2048 ? 0 : len_1;
                                        aUp1_buff[len_1] = tmp;
                                        len_1++;
                                        break;
                                }
                            }
                        }
                    }
                    JLinkHandler.JLINKARM_WriteU32(aUp_addr.RdOff, rd);

                    string s;
                    UTF8Encoding utf8 = new UTF8Encoding();

                    if (len_0 != 0)
                    {
                        if (RxShow_HEX_0)
                        {
                            s = byteToHexstr(aUp0_buff, len_0);
                        }
                        else
                        {
                            s = utf8.GetString(aUp0_buff, 0, (int)len_0);
                        }
                        if (RxShow_Time_0)
                        {
                            if(time_flag_0)
                            {
                                time_flag_0 = false;
                                s += "\r\n";
                            }
                        }
                        this.BeginInvoke(new Change(updata_texbox_0), s);
                        len_0 = 0;
                    }
                    if (len_1 != 0)
                    {
                        if (RxShow_HEX_1)
                        {
                            s = byteToHexstr(aUp1_buff, len_1);
                        }
                        else
                        {
                            s = utf8.GetString(aUp1_buff, 0, (int)len_1);
                        }
                        if (RxShow_Time_1)
                        {
                            if (time_flag_1)
                            {
                                time_flag_1 = false; 
                                s += "\r\n";
                            }
                        }
                        this.BeginInvoke(new Change(updata_texbox_1), s);
                        len_1 = 0;
                    }
                }
                else
                {
                    Thread.Sleep(200);
                    ter_change_flag = false;
                    Terminal = 0x30;
                    JLinkHandler.JLINKARM_Connect();
                    //Console.WriteLine(JLinkHandler.JLINKARM_IsConnected());
                    if(!JLinkHandler.JLINKARM_IsConnected())
                    {
                        Thread_stop_flag = true;
                        JLinkHandler.JLINKARM_Close();
                        link_status = "打开连接";
                        this.BeginInvoke(new Change(updata_button), link_status);
                        break;
                    }
                }
            }
            Thread.Sleep(10);
        }

        public void search_addr()
        {
            string mapFileContent = System.IO.File.ReadAllText(addr.Text);

            string searchTerm = "_SEGGER_RTT";
            string[] lines = mapFileContent.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (string line in lines)
            {
                if (line.Contains(searchTerm))
                {
                    // 找到包含特定文本的行
                    Console.WriteLine("Found in line: " + line);

                    string pattern = @"0x[0-9A-Fa-f]+";

                    Match match = Regex.Match(line, pattern);
                    if (match.Success)
                    {
                        Console.WriteLine("Match found: " + match.Value);
                        rtt_addr = (UInt32)Convert.ToInt32(match.Value, 16);
                        aUp_addr.pBuffer = JLinkHandler.JLINKARM_ReadU32(rtt_addr + 0x1c);//添加偏移地址，可以在仿真时看到他们的地址就是偏移起始地址这么多
                        aUp_addr.WrOff = rtt_addr + 0x24;
                        aUp_addr.RdOff = rtt_addr + 0x28;
                        aDown_addr.pBuffer = JLinkHandler.JLINKARM_ReadU32(rtt_addr + 0x64);
                        aDown_addr.WrOff = rtt_addr + 0x6c;
                    }
                    else
                    {
                        Console.WriteLine("No match found");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (link_status == "打开连接")
                {
                    JLinkHandler.JLINKARM_Open();
                    if (JLinkHandler.JLINKARM_IsOpen())
                    {
                        HW.Text = JLinkHandler.GetHardwareVersion();
                        DLL.Text = JLinkHandler.GetDLLVersion();
                        SN.Text = JLinkHandler.JLINKARM_GetSN().ToString();
                        JLinkHandler.JLINKARM_TIF_Select(1);
                        JLinkHandler.JLINKARM_SetSpeed(4000);
                        JLinkHandler.JLINKARM_ExecCommand(Encoding.UTF8.GetBytes("device = " + comboBox1.Text), 0, 0);
                        Console.WriteLine("device = " + comboBox1.Text);
                        int id = JLinkHandler.JLINKARM_GetId();
                        Console.WriteLine("id: " + id);
                        ID.Text = "0x" + id.ToString("X8");
                        if (id > 0)
                        {
                            search_addr();
                            if ((0 == JLinkHandler.JLINKARM_ReadMem(rtt_addr, 6, acID)))
                            {
                                string s = Encoding.ASCII.GetString(acID, 0, 6);
                                acID[0] = 0;
                                if (s == "SEGGER")
                                {
                                    link_status = "关闭连接";
                                    addr.Enabled = false;
                                    button6.Enabled = false;
                                    Thread_stop_flag = false;
                                    comboBox1.Enabled = false;
                                    Thread th = new Thread(new ThreadStart(Read_RTT));
                                    th.IsBackground = true;
                                    th.Start();
                                }
                            }
                        }
                    }
                }
                else
                {
                    link_status = "打开连接";
                    Thread_stop_flag = true;
                    comboBox1.Enabled = true;
                    addr.Enabled = true;
                    button6.Enabled = true;
                    Thread.Sleep(20);
                }
                if(link_status == "打开连接") JLinkHandler.JLINKARM_Close();
                link_sw.Text = link_status;
            }
            catch(Exception err)
            {
                Console.WriteLine(err);
            }
        }


        /// <summary>
        /// 勾选16进制显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;
            Console.WriteLine(index);
            if (index == 0)
            {
                RxShow_HEX_0 = show_hex.Checked;
            }
            else if (index == 1)
            {
                RxShow_HEX_1 = show_hex.Checked;
            }
        }


        /// <summary>
        /// 区分接收设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;
            if(index == 0)
            {
                show_hex.Checked = RxShow_HEX_0;
                show_time_len.Text = timer1.Interval.ToString();
                show_time.Checked = RxShow_Time_0;
            }
            else if(index == 1)
            {
                show_hex.Checked = RxShow_HEX_1;
                show_time_len.Text = timer2.Interval.ToString();
                show_time.Checked = RxShow_Time_1;
            }
        }


        /// <summary>
        /// 清除显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;
            if (index == 0)
            {
                Terminal_0.Text = ""; 
            }
            else if (index == 1)
            {
                Terminal_1.Text = "";
            }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;
            if (index == 0)
            {
                RxShow_Time_0 = show_time.Checked;
                timer1.Enabled = RxShow_Time_0;
                show_time_len.Enabled = !RxShow_Time_0;
            }
            else if (index == 1)
            {
                RxShow_Time_1 = show_time.Checked;
                timer2.Enabled = RxShow_Time_1;
                show_time_len.Enabled = !RxShow_Time_1;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;
            Regex reg = new Regex("^[1-9]\\d*$");
            if(!reg.IsMatch(show_time_len.Text)) show_time_len.Text = "100";
            int time_ms = Convert.ToInt32(show_time_len.Text);
            if (time_ms < 10 || time_ms > 2000)
            {
                time_ms = 100;
                show_time_len.Text = "100";
            }
            if (index == 0)
            {
                timer1.Interval = time_ms;
            }
            else if (index == 1)
            {
                timer2.Interval = time_ms;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (link_status == "关闭连接")
            {
                time_flag_0 = true;
            }
            else timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (link_status == "关闭连接")
            {
                time_flag_1 = true;
            }
            else timer2.Enabled = false;
        }
        public static int read_sta = 1;
        private void button2_Click(object sender, EventArgs e)
        {
            string s = send_text.Text;

            if (link_status == "关闭连接" && s != "")
            {
                if (read_sta != 0) return;
                if (Encoding.ASCII.GetString(acID, 0, 6) != "SEGGER") return;
                if (send_HEX)
                {
                    s = hexStrToasciiStr(s);
                }
                if (send_new_line) s += "\r\n";
                byte[] buff = Encoding.UTF8.GetBytes(s);
                Console.WriteLine(s);
                
                UInt32 wr = JLinkHandler.JLINKARM_ReadU32(aDown_addr.WrOff);
                for (int i= 0;i<s.Length;i++)
                {
                    JLinkHandler.JLINKARM_WriteU8(aDown_addr.pBuffer + wr, buff[i]);
                    wr++;
                    wr &= 0x0f;
                    JLinkHandler.JLINKARM_WriteU32(aDown_addr.WrOff, wr);
                }
            }
        }


        public static string hexStrToasciiStr(string s)
        {
            string str = s;
            str = str.Replace(" ", "");
            if (str.Length % 2 != 0) str = str.Insert(str.Length - 1, "0");
            int len = str.Length / 2;
            byte[] buff = new byte[len];
            for (int i=0;i<len;i++)
            {
                buff[i] = Convert.ToByte(str.Substring(i*2, 2), 16);
            }
            str = Encoding.ASCII.GetString(buff);
            return str;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            send_HEX = !send_HEX;
            if(send_HEX)
            {
                byte[] buff = Encoding.UTF8.GetBytes(send_text.Text);
                int i = 0, len = send_text.Text.Length;
                send_text.Text = "";
                for (i = 0; i < len; i++)
                {
                    Console.WriteLine("buff: " + buff[i]);
                    send_text.Text += buff[i].ToString("X2") + " ";
                }
            }
            else
            {
                send_text.Text = hexStrToasciiStr(send_text.Text);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            send_new_line = !send_new_line;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            timer3.Enabled = !timer3.Enabled;
            send_time_len.Enabled = !timer3.Enabled;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (link_status == "关闭连接")
            {
                button2.PerformClick();
            }
        }

        

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;
            Regex reg = new Regex("^[1-9]\\d*$");
            if (!reg.IsMatch(send_time_len.Text)) send_time_len.Text = "1000";
            int time_ms = Convert.ToInt32(send_time_len.Text);
            if (time_ms < 10 || time_ms > 2000)
            {
                time_ms = 1000;
                send_time_len.Text = "1000";
            }
            timer3.Interval = time_ms;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (send_HEX)
            {
                if (!Regex.IsMatch(e.KeyChar.ToString(), "[0-9a-fA-F\b ]"))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (send_HEX)
            {
                if (e.Control && e.KeyCode == Keys.C) // 复制
                {
                    Clipboard.SetText(send_text.SelectedText);
                }
                else if (e.Control && e.KeyCode == Keys.V) // 粘贴
                {
                    send_text.SelectedText = Clipboard.GetText();
                }
                else if (e.Control && e.KeyCode == Keys.X) // 剪切
                {
                    Clipboard.SetText(send_text.SelectedText);
                    send_text.SelectedText = "";
                }
                else if (e.Control && e.KeyCode == Keys.Z) // 撤销
                {
                    send_text.Undo();
                }
                else if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back) // 删除和退格
                {
                    e.Handled = false; // 允许删除和退格
                }
                else
                {
                    e.Handled = true;
                }
            }   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件夹";
            dialog.Filter = "map文件(*.map*)|*.map*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string mapFilePath = dialog.FileName;
                addr.Text = mapFilePath;
                Console.WriteLine(mapFilePath);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;
            string stxt = "";
            if (index == 0) stxt = Terminal_0.Text;
            else if (index == 1) stxt = Terminal_1.Text;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "记事本文件|*.txt";
            saveFileDialog1.Title = "保存窗口";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                // 获取用户选择的文件名
                string fileName = saveFileDialog1.FileName;

                // 保存数据到文件
                using (StreamWriter sw = new StreamWriter(fileName))
                {

                    sw.WriteLine(stxt);
                }
            }
            else
            {
                // 如果用户没有选择文件，可以创建一个新的文件
                using (StreamWriter sw = new StreamWriter("newfile.txt"))
                {
                    sw.WriteLine(stxt);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            send_text.Text = "";
        }


    }
}
