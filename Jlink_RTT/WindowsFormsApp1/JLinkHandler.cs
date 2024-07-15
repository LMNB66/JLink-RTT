using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace JLink_ARM
{
    class JLinkHandler
    {
        [DllImport("JLinkARM.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern void JLINKARM_Open();

        [DllImport("JLinkARM.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern void JLINKARM_Close();

        [DllImport("JLinkARM.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern void JLINKARM_Connect();

        [DllImport("JLinkARM.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern bool JLINKARM_IsOpen();

        [DllImport("JLinkARM.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern bool JLINKARM_IsHalted();

        [DllImport("JLinkARM.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern bool JLINKARM_IsConnected();

        [DllImport("JLinkARM.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern UInt32 JLINKARM_GetDLLVersion();

        [DllImport("JLinkARM.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern UInt32 JLINKARM_GetHardwareVersion();

        [DllImport("JLinkARM.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern UInt32 JLINKARM_GetSN();

        [DllImport("JLinkARM.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern int JLINKARM_GetId();

        [DllImport("JLinkARM.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern void JLINKARM_TIF_Select(int type);

        [DllImport("JLinkARM.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern void JLINKARM_SetSpeed(int speed);

        [DllImport("JLinkARM.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern void JLINKARM_ExecCommand([In(), MarshalAs(UnmanagedType.LPArray)] byte[] oBuffer, int a, int b);

        [DllImport("JLinkARM.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern void JLINKARM_WriteMem(UInt32 addr, UInt32 size, byte[] buf);

        [DllImport("JLinkARM.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern int JLINKARM_ReadMem(UInt32 addr, UInt32 size, [Out(), MarshalAs(UnmanagedType.LPArray)] byte[] buf);

        [DllImport("JLinkARM.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern void JLINKARM_ReadMemU32(UInt32 addr, UInt32 leng, ref UInt32 buf, ref byte status);

        [DllImport("JLinkARM.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern void JLINKARM_WriteU32(UInt32 addr, UInt32 dat);

        [DllImport("JLinkARM.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern void JLINKARM_ReadMemU16(UInt32 addr, UInt32 leng, ref UInt16 buf, ref byte status);

        [DllImport("JLinkARM.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern void JLINKARM_WriteU16(UInt32 addr, UInt32 dat);

        [DllImport("JLinkARM.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern void JLINKARM_ReadMemU8(UInt32 addr, UInt32 leng, ref byte buf, ref byte status);

        [DllImport("JLinkARM.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern void JLINKARM_WriteU8(UInt32 addr, byte dat);

        [DllImport("JLinkARM.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern int JLINKARM_GetMemSize();
        


        public static UInt32 JLINKARM_ReadU32(UInt32 addr)
        {
            UInt32 dat = 0;
            byte stu = 0;
            JLINKARM_ReadMemU32(addr, 1, ref dat, ref stu);
            return dat;
        }

        public static UInt16 JLINKARM_ReadU16(UInt32 addr)
        {
            UInt16 dat = 0;
            byte stu = 0;
            JLINKARM_ReadMemU16(addr, 1, ref dat, ref stu);
            return dat;
        }

        public static byte JLINKARM_ReadU8(UInt32 addr)
        {
            byte dat = 0;
            byte stu = 0;
            JLINKARM_ReadMemU8(addr, 1, ref dat, ref stu);
            return dat;
        }

        public static string GetHardwareVersion()
        {
            string HW_str;
            UInt32 hw = JLINKARM_GetHardwareVersion();
            HW_str = 'V' + (hw / 100).ToString();
            HW_str = HW_str.Insert(2, ".");
            return HW_str;
        }

        public static string GetDLLVersion()
        {
            string DLL_str;
            UInt32 dll = JLINKARM_GetDLLVersion();
            DLL_str = 'V' + (dll / 100).ToString();
            DLL_str = DLL_str.Insert(2, ".");
            char i = (char)(dll % 10 + 96);
            if (i != 96) DLL_str += i;
            return DLL_str;
        }
    }
}
