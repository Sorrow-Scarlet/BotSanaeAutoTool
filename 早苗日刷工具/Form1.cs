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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetConfig configCheck = new GetConfig();
            configCheck.OnInitializing();//生成一个GetConfig对象，在窗口启动时立刻检查Config.
            GC.Collect();
            GetTIMdata TimChecker = new GetTIMdata();
            TimChecker.WhetherTIMisOn();
        }
    }
}
