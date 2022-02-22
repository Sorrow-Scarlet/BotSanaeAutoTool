using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 早苗日刷工具
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }  

        private void Form1_Load(object sender, EventArgs e)
        {
            GetConfig configCheck = new GetConfig();
            configCheck.OnInitializing();//生成一个GetConfig对象，在窗口启动时立刻检查Config.
            GetTIMdata TimChecker = new GetTIMdata();
            TimChecker.WhetherTIMisOn();//检查TIM是否已运行

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime currentDT = new DateTime();
            currentDT.GetDateTimeFormats('t')[0].ToString();//XX:YY格式，为对接Config做准备
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
