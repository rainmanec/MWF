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

            string[] MacAddress = Util.GetMacAddress();
            string XLH = Util.GetAppConfig("XLH");
            bool IsOK = false;
            foreach (string addr in MacAddress)
            {
                if (Util.EncodeHash(addr) == XLH)
                {
                    IsOK = true;
                    break;
                }
            }
            if (IsOK == false)
            {
                MessageBox.Show("软件序列号不正确，请联系厂商！");
                return;
            }
            // 连接字符串
            //SqlHelper.ConnectionString = Util.decode(System.Web.HttpUtility.UrlDecode(TransferData.CntString));
            SqlHelper.ConnectionString = System.Web.HttpUtility.UrlDecode(AppData.CntString);
            Application.Run(new FrmMain());
        }
    }
}
