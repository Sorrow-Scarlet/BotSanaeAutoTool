using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;

namespace 早苗日刷工具
{
    /*这里负责收集所有需要的TIM信息*/

    public class GetTIMdata
    {
        /// <summary>
        /// 遍历计算机中所有进程，查找判断TIM是否存在
        /// </summary>
        public void WhetherTIMisOn()
        {
            Process [] proDet= Process.GetProcesses();
            bool Detecter = false;
            foreach (var IDs in proDet)
            {
                if (IDs.ProcessName == "TIM")
                {
                    Detecter = true;
                    return;
                }
              
            }
            if(Detecter == false)
            { 
                    MessageBox.Show("TIM未启动，启动TIM后再启动工具");
                    Application.Exit();
             
            }

        }

        /// <summary>
        /// 获取TIM输入窗口句柄
        /// </summary>
        private static void GetTIMInputWindow()
        {

        }
        /// <summary>
        /// 获取TIM发送按钮的句柄
        /// </summary>
        private static void GetTIMSndsButtn()
        {

        }


    }

}
   
