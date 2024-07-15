
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Terminal_0 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Terminal_1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.addr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.link_sw = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.SN = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HW = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DLL = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.send_text = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.show_clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.show_time_len = new System.Windows.Forms.TextBox();
            this.show_time = new System.Windows.Forms.CheckBox();
            this.show_hex = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.send_time_len = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.send_time = new System.Windows.Forms.CheckBox();
            this.rn_send = new System.Windows.Forms.CheckBox();
            this.hex_send = new System.Windows.Forms.CheckBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(282, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(669, 444);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Terminal_0);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(661, 415);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Terminal_0
            // 
            this.Terminal_0.BackColor = System.Drawing.Color.Black;
            this.Terminal_0.Font = new System.Drawing.Font("宋体", 12F);
            this.Terminal_0.ForeColor = System.Drawing.Color.Yellow;
            this.Terminal_0.Location = new System.Drawing.Point(0, 0);
            this.Terminal_0.Margin = new System.Windows.Forms.Padding(4);
            this.Terminal_0.Multiline = true;
            this.Terminal_0.Name = "Terminal_0";
            this.Terminal_0.ReadOnly = true;
            this.Terminal_0.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Terminal_0.Size = new System.Drawing.Size(661, 415);
            this.Terminal_0.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Terminal_1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(661, 415);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "调试";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Terminal_1
            // 
            this.Terminal_1.BackColor = System.Drawing.Color.Black;
            this.Terminal_1.Font = new System.Drawing.Font("宋体", 12F);
            this.Terminal_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Terminal_1.Location = new System.Drawing.Point(0, 0);
            this.Terminal_1.Margin = new System.Windows.Forms.Padding(4);
            this.Terminal_1.Multiline = true;
            this.Terminal_1.Name = "Terminal_1";
            this.Terminal_1.ReadOnly = true;
            this.Terminal_1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Terminal_1.Size = new System.Drawing.Size(661, 415);
            this.Terminal_1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.addr);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.link_sw);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Controls.Add(this.SN);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.HW);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DLL);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(236, 265);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "J-Link";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(165, 169);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "...";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // addr
            // 
            this.addr.Location = new System.Drawing.Point(60, 169);
            this.addr.Name = "addr";
            this.addr.Size = new System.Drawing.Size(100, 25);
            this.addr.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "地址:";
            // 
            // link_sw
            // 
            this.link_sw.Location = new System.Drawing.Point(44, 216);
            this.link_sw.Margin = new System.Windows.Forms.Padding(4);
            this.link_sw.Name = "link_sw";
            this.link_sw.Size = new System.Drawing.Size(145, 29);
            this.link_sw.TabIndex = 9;
            this.link_sw.Text = "打开连接";
            this.link_sw.UseVisualStyleBackColor = true;
            this.link_sw.Click += new System.EventHandler(this.button1_Click);
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ID.Location = new System.Drawing.Point(41, 91);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(93, 15);
            this.ID.TabIndex = 3;
            // 
            // SN
            // 
            this.SN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SN.Location = new System.Drawing.Point(41, 59);
            this.SN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SN.Name = "SN";
            this.SN.Size = new System.Drawing.Size(93, 15);
            this.SN.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "HW:";
            // 
            // HW
            // 
            this.HW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HW.Location = new System.Drawing.Point(41, 27);
            this.HW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HW.Name = "HW";
            this.HW.Size = new System.Drawing.Size(60, 15);
            this.HW.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "DLL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "SN:";
            // 
            // DLL
            // 
            this.DLL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DLL.Location = new System.Drawing.Point(159, 27);
            this.DLL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DLL.Name = "DLL";
            this.DLL.Size = new System.Drawing.Size(60, 15);
            this.DLL.TabIndex = 1;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(282, 469);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(673, 150);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.send_text);
            this.tabPage3.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(665, 121);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "单条发送";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(584, 79);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "清除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(584, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "发送";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // send_text
            // 
            this.send_text.Location = new System.Drawing.Point(0, 0);
            this.send_text.Margin = new System.Windows.Forms.Padding(4);
            this.send_text.Multiline = true;
            this.send_text.Name = "send_text";
            this.send_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.send_text.Size = new System.Drawing.Size(576, 116);
            this.send_text.TabIndex = 0;
            this.send_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
            this.send_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(665, 121);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "多条发送";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.show_clear);
            this.groupBox2.Controls.Add(this.save);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.show_time_len);
            this.groupBox2.Controls.Add(this.show_time);
            this.groupBox2.Controls.Add(this.show_hex);
            this.groupBox2.Location = new System.Drawing.Point(17, 311);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(236, 124);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收设置：";
            // 
            // show_clear
            // 
            this.show_clear.Location = new System.Drawing.Point(119, 86);
            this.show_clear.Margin = new System.Windows.Forms.Padding(4);
            this.show_clear.Name = "show_clear";
            this.show_clear.Size = new System.Drawing.Size(100, 29);
            this.show_clear.TabIndex = 5;
            this.show_clear.Text = "清除接收";
            this.show_clear.UseVisualStyleBackColor = true;
            this.show_clear.Click += new System.EventHandler(this.button5_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(11, 86);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 29);
            this.save.TabIndex = 4;
            this.save.Text = "保存窗口";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.button4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(145, 56);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "ms";
            // 
            // show_time_len
            // 
            this.show_time_len.Location = new System.Drawing.Point(95, 52);
            this.show_time_len.Margin = new System.Windows.Forms.Padding(4);
            this.show_time_len.Name = "show_time_len";
            this.show_time_len.Size = new System.Drawing.Size(49, 25);
            this.show_time_len.TabIndex = 2;
            this.show_time_len.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // show_time
            // 
            this.show_time.AutoSize = true;
            this.show_time.Location = new System.Drawing.Point(9, 55);
            this.show_time.Margin = new System.Windows.Forms.Padding(4);
            this.show_time.Name = "show_time";
            this.show_time.Size = new System.Drawing.Size(74, 19);
            this.show_time.TabIndex = 1;
            this.show_time.Text = "时间戳";
            this.show_time.UseVisualStyleBackColor = true;
            this.show_time.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // show_hex
            // 
            this.show_hex.AutoSize = true;
            this.show_hex.Location = new System.Drawing.Point(9, 26);
            this.show_hex.Margin = new System.Windows.Forms.Padding(4);
            this.show_hex.Name = "show_hex";
            this.show_hex.Size = new System.Drawing.Size(105, 19);
            this.show_hex.TabIndex = 0;
            this.show_hex.Text = "16进制显示";
            this.show_hex.UseVisualStyleBackColor = true;
            this.show_hex.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.send_time_len);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.send_time);
            this.groupBox3.Controls.Add(this.rn_send);
            this.groupBox3.Controls.Add(this.hex_send);
            this.groupBox3.Location = new System.Drawing.Point(17, 460);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(236, 111);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送设置：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(133, 82);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "ms";
            // 
            // send_time_len
            // 
            this.send_time_len.Location = new System.Drawing.Point(53, 78);
            this.send_time_len.Margin = new System.Windows.Forms.Padding(4);
            this.send_time_len.Name = "send_time_len";
            this.send_time_len.Size = new System.Drawing.Size(77, 25);
            this.send_time_len.TabIndex = 4;
            this.send_time_len.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 84);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "周期：";
            // 
            // send_time
            // 
            this.send_time.AutoSize = true;
            this.send_time.Location = new System.Drawing.Point(9, 55);
            this.send_time.Margin = new System.Windows.Forms.Padding(4);
            this.send_time.Name = "send_time";
            this.send_time.Size = new System.Drawing.Size(89, 19);
            this.send_time.TabIndex = 2;
            this.send_time.Text = "定时发送";
            this.send_time.UseVisualStyleBackColor = true;
            this.send_time.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // rn_send
            // 
            this.rn_send.AutoSize = true;
            this.rn_send.Location = new System.Drawing.Point(124, 26);
            this.rn_send.Margin = new System.Windows.Forms.Padding(4);
            this.rn_send.Name = "rn_send";
            this.rn_send.Size = new System.Drawing.Size(89, 19);
            this.rn_send.TabIndex = 1;
            this.rn_send.Text = "发送新行";
            this.rn_send.UseVisualStyleBackColor = true;
            this.rn_send.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // hex_send
            // 
            this.hex_send.AutoSize = true;
            this.hex_send.Location = new System.Drawing.Point(9, 26);
            this.hex_send.Margin = new System.Windows.Forms.Padding(4);
            this.hex_send.Name = "hex_send";
            this.hex_send.Size = new System.Drawing.Size(105, 19);
            this.hex_send.TabIndex = 0;
            this.hex_send.Text = "16进制发送";
            this.hex_send.UseVisualStyleBackColor = true;
            this.hex_send.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cortex-M0",
            "Cortex-M3",
            "Cortex-M4"});
            this.comboBox1.Location = new System.Drawing.Point(60, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 23);
            this.comboBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "内核:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 632);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "JLink RTT    @lmnb66    V1.2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox Terminal_1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Terminal_0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label HW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label DLL;
        private System.Windows.Forms.Label SN;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button link_sw;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox send_text;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox show_hex;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox show_time_len;
        private System.Windows.Forms.CheckBox show_time;
        private System.Windows.Forms.Button show_clear;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.CheckBox hex_send;
        private System.Windows.Forms.CheckBox rn_send;
        private System.Windows.Forms.CheckBox send_time;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox send_time_len;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox addr;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

