using System;
using System.Runtime.InteropServices;

namespace 早苗日刷工具
{
    public class ProgramAI
    {
        ///读取Config中的变量
        //设定变量 接收Config
        //需要读取Config，并且根据config为变量赋值



        void UniversalContentInput()
        {
            string DailyContents;
            string RegularContents;
            string Contents;
        }
        //由于win版TIM采用与win版QQ一致的自绘发送按钮，只能通过键盘来实现发送
        //参考https://www.cnblogs.com/T-ARF/p/9471887.html
        [DllImport("user32.dll")]
        static extern IntPtr FindWindow(string ClassName, string WindwosName);

        [DllImport("user32.dll")]
        static extern void kbd_event(byte vk, byte vsacn, int flag, int wram);

        [DllImport("user32.dll")]
        static extern void PostMsg(IntPtr hwnd, uint msg, int w, string l);
        [DllImport("user32.dll")]
        static extern void PostMsg(IntPtr hwnd, uint msg, int w, int l);
        void UniversalSndButton()
        {


            GetConfig ConfigReader = new GetConfig();
            
            
            //var win = FindWindow(null, name);

            //kbd_event(0x01, 0, 0, 0);
            //PostMsg(win, 0x0302, 0, 0);
                                                 
            //PostMsg(win, 0x0100, 13, 0);
            //PostMsg(win, 0x0101, 13, 0);
            //kbd_event(0x11, 0, 0x0002, 0);
        }

        void TimeComparer()
        {
            string[] RC_TimeSection;
        }
    }
}
