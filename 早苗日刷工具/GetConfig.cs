using System.IO;

namespace 早苗日刷工具
{
    /// <summary>
    /// 此处负责创建/读取config，用户可在其中进行一系列的设置
    /// </summary>

    public class GetConfig
    {
        public void OnInitializing()//Config初始化，分为存在与不存在Config
        {
            string pathConfig = @".//Config.json";
            if (File.Exists(pathConfig) == true)//Config存在，非初次使用
            {
                string[] ReadConfig = File.ReadAllLines(pathConfig);//用于接收Config的String数组
            }
            else//无已存在Config的情况下
            {
                //默认的Config板式
                string[] originalConfig = { @"{", "\t\"DailyContents\": \"签到\",", "\t\"RegularContents\": \"喂食\",", "\t\"RC_TimeSection\": [\"07:30\", \"12:05\", \"17:05\", \"23:05\"],", "\t\"Contents\": [\"钓鱼\", \"打工\", \"打工\", \"打工 2\"]", "}" };
                File.Create(@".//Config,json");//因为没有检测到Config.json，创建一个新的Config.json
                File.WriteAllLines(pathConfig, originalConfig);//写入默认的Config板式

            }
            
        }


    }
}
