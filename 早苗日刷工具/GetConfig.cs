using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 早苗机器人日刷工具
{
    /// <summary>
    /// 此处负责创建/读取config，用户可在其中进行一系列的设置
    /// </summary>
    public class GetConfig
    {
        static void OnInitializing()
        {
            string pathConfig = @".//config.json";
            if (File.Exists(pathConfig) == true)
            {
                string ReadConfig = File.ReadAllText(pathConfig);
            }
            else
            {
                File.Create(@".//config,json");
            }
        }

    }
}
