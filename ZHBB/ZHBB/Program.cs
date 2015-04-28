using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
            // 连接字符串
            //SqlHelper.ConnectionString = Util.decode(System.Web.HttpUtility.UrlDecode(TransferData.CntString));
            SqlHelper.ConnectionString = System.Web.HttpUtility.UrlDecode(AppData.CntString);
            Application.Run(new FrmMain());
        }
    }
}
