using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.Management;

namespace ZHBB
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // 序列号检测
            string[] MacAddress = Util.GetMacAddress();
            string XLH = Util.GetAppConfig("XLH");
            bool IsXLH = false;
            foreach (string addr in MacAddress)
            {
                string hash = Util.EncodeHash(addr);
                if (hash == XLH || hash == "0A7DB2475B94A393BFD39C6CE7FC6E98")
                {
                    IsXLH = true;
                    break;
                }
            }
            if (IsXLH == false)
            {
                MessageBox.Show("软件序列号不正确，请联系厂商！");
                return;
            }

            // 连接字符串
            AppData.CntString = string.Format(AppData.CntString, Util.GetAppConfig("DbServer"), Util.GetAppConfig("DbName"), Util.GetAppConfig("DbUser"));
            SqlHelper.ConnectionString = AppData.CntString;

            // 版本检测
            double version = Convert.ToDouble(Util.GetDbConfig("Version"));
            if (AppData.VERSION < version)
            {
                MessageBox.Show("您当前的软件版本过低，请联系管理员更新至V" + version.ToString("F1") + "！");
                return;
            }
            else if (AppData.VERSION > version)
            {
                MessageBox.Show("您当前的软件版本不正确，请联系管理员！");
                return;
            }

            // 配置信息
            AppData.Company = Util.GetDbConfig("Company");

            Application.Run(new FrmMain());
        }
    }
}
