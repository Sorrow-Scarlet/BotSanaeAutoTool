using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 早苗日刷工具
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        ///  Windows Only.
        ///  本工具用于对群内机器人日常签到等操作。
        ///  当前程序缺点：只支持TIM，TIM聊天窗口必须常驻（可置于后台）
        ///  GPLV3.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
