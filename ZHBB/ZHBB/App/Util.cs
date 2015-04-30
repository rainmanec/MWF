using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO.Ports;
using System.Configuration;
using System.Web.Script.Serialization;
using Microsoft.Reporting.WinForms;
namespace ZHBB
{
    partial class Util
    {

        #region 项目函数库

        /// <summary>
        /// 生成密钥
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string EncodeHash(string str)
        {
            str = AppData.SECRET_KEY + str + AppData.SECRET_KEY;
            return Util.GetMd5(Util.GetMd5(str));
        }

        #endregion

        #region 据库操作-常用表
        /// <summary>
        /// 添加一条日志
        /// </summary>
        /// <param name="uname">登录名</param>
        /// <param name="xingming">姓名</param>
        /// <param name="cnt">内容</param>
        public static void console_log(string uname, string xingming, string cnt)
        {
            SqlParameter[] paras = new SqlParameter[] {
                NewSqlParameter("@p_uname", SqlDbType.VarChar, uname, 20),
                NewSqlParameter("@p_xm", SqlDbType.VarChar, xingming, 20),
                NewSqlParameter("@p_time", SqlDbType.DateTime, DateTime.Now),
                NewSqlParameter("@p_cnt", SqlDbType.VarChar, cnt, 200)
            };
            string sql = "INSERT INTO 日志(uname, 姓名, 时间, 内容) VALUES(@p_uname, @p_xm, @p_time, @p_cnt)";
            int affect = SqlHelper.ExecuteNonQuery(sql, paras);
        }

        /// <summary>
        /// 添加一条日志
        /// </summary>
        /// <param name="cnt">内容</param>
        public static void console_log(string cnt)
        {
            Util.console_log(AppData.Uname, AppData.XingMing, cnt);
        }

        /// <summary>
        /// 如果车辆已存在，则不添加车辆；否则添加车辆；返回chepai的模糊搜索值
        /// </summary>
        /// <param name="chepai"></param>
        /// <returns></returns>
        public static string AddCar(string chepai)
        {
            if (chepai.Trim() == "")
            {
                return "";
            }

            // 车牌号
            chepai = chepai.ToUpper();
            string likevalue = Util.GetLikeValue(chepai);
            SqlParameter p_chepai = Util.NewSqlParameter("@p_chepai", SqlDbType.VarChar, chepai, 50);
            SqlParameter p_likevalue = Util.NewSqlParameter("@p_likevalue", SqlDbType.VarChar, likevalue, 100);

            string sql_count = "SELECT COUNT(*) FROM Cars WHERE chepai = @p_chepai";
            string total = SqlHelper.GetFirstCellStringBySQL(sql_count, p_chepai);
            if (total == "0")
            {
                string sql = @"insert into Cars(chepai, likevalue, owner, phone, address, beizhu) values (@p_chepai, @p_likevalue, '', '', '', '')";
                SqlHelper.ExecuteNonQuery(sql, p_chepai, p_likevalue);
            }
            return likevalue;
        }

        public static string AddCompany(string gsm)
        {
            if (gsm.Trim() == "")
            {
                return "";
            }

            /* 验证项目是否重复 */
            string likevalue = Util.GetLikeValue(gsm);

            // 整理参数
            SqlParameter p_gsm = Util.NewSqlParameter("@p_gsm", SqlDbType.VarChar, gsm, 50);
            SqlParameter p_likevalue = Util.NewSqlParameter("@p_likevalue", SqlDbType.VarChar, likevalue, 100);

            /* 判断登陆名是否重复 */
            string sql_count = "select COUNT(*) as total from Company where gsm = @p_gsm";
            string total = SqlHelper.GetFirstCellStringBySQL(sql_count, p_gsm);
            if (total == "0")
            {
                /* 执行添加操作 */
                string sql = @"insert 
                            into Company(gsm, owner, phone, address, beizhu, Likevalue) 
                            values (@p_gsm, '', '', '', '', @p_likevalue)";
                SqlHelper.ExecuteNonQuery(sql, p_gsm, p_likevalue);
            }
            return likevalue;
        }

        #endregion

        #region 数据库操作-Record表

        /// <summary>
        /// 删除某条记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool DeleteRecord(int id)
        {
            SqlParameter p_id = Util.NewSqlParameter("@p_id", SqlDbType.Int, id);
            int affect = SqlHelper.ExecuteNonQuery("DELETE FROM Records WHERE ID = @p_id", p_id);
            return (affect == 1);
        }
        #endregion

        #region 项目常用函数

        /// <summary>
        /// 打印出库单
        /// </summary>
        /// <param name="id">记录ID</param>
        public static void PrintRecord(int id)
        {
            // 整理Report Data Source
            string sql = string.Format(@"SELECT *, Users.xingming as 'outXingming' FROM Records LEFT JOIN Users ON Records.OutUname = Users.uname  where Records.ID = {0}", id);
            DataTable table = SqlHelper.GetDataTableBySQL(sql);
            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                DataTable tb = new DataTable("DataTable1");
                tb.Columns.Add(new DataColumn() { ColumnName = "col1", DataType = typeof(string) });
                tb.Columns.Add(new DataColumn() { ColumnName = "col2", DataType = typeof(string) });
                tb.Columns.Add(new DataColumn() { ColumnName = "col3", DataType = typeof(string) });
                tb.Columns.Add(new DataColumn() { ColumnName = "col4", DataType = typeof(string) });
                tb.Columns.Add(new DataColumn() { ColumnName = "col5", DataType = typeof(string) });
                tb.Columns.Add(new DataColumn() { ColumnName = "col6", DataType = typeof(string) });
                tb.Columns.Add(new DataColumn() { ColumnName = "col7", DataType = typeof(string) });
                tb.Rows.Add(tb.NewRow());
                tb.Rows[0][0] = row["Company"].ToString();
                tb.Rows[0][1] = row["chepai"].ToString();
                tb.Rows[0][2] = row["Kind"].ToString();
                tb.Rows[0][3] = row["InWeight"].ToString();
                tb.Rows[0][4] = row["OutWeight"].ToString();
                tb.Rows[0][5] = row["NetWeight"].ToString();
                tb.Rows[0][6] = row["other"].ToString();
                ReportParameter p_title = new ReportParameter("p_title", AppData.Company);
                ReportParameter p_outuser = new ReportParameter("p_outuser", "操作员：" + row["outXingming"].ToString());
                ReportParameter p_outtime = new ReportParameter("p_outtime", Convert.IsDBNull(row["OutTime"]) ? "" : "时间：" + Convert.ToDateTime(row["OutTime"]).ToString("yyyy-MM-dd hh:mm") + "    票号：" + row["ID"].ToString());
                ReportParameter[] parms = new ReportParameter[] { p_title, p_outuser, p_outtime };
                ReportDataSource source = new ReportDataSource();
                source.Name = "DataSetRecord";
                source.Value = tb;

                MyUIReportViwer frmRPT = new MyUIReportViwer();
                frmRPT.MainDataSource = source;
                frmRPT.ReportParms = parms;
                frmRPT.ReportID = "PrintSetRecordOut";
                frmRPT.ReportPath = System.Windows.Forms.Application.StartupPath + @"\Rdlc\RdlcRecord.rdlc";
                frmRPT.ShowDialog();
            }
            else
            {
                MessageBox.Show("记录已不存在");
            }
        }

        /// <summary>
        /// 获取传感器的重量
        /// </summary>
        /// <returns></returns>
        public static decimal GetSensorWeight()
        {
            string PortName = Util.GetAppConfig("PortName");
            string BaudRate = Util.GetAppConfig("BaudRate");
            if (PortName == "" || BaudRate == "")
            {
                MessageBox.Show("请选择串口号");
                return 0;
            }

            SerialPort comm = new SerialPort();

            comm.PortName = PortName;
            comm.BaudRate = Util.IntTryParse(BaudRate);
            comm.ReadTimeout = 1000;
            comm.WriteTimeout = 1000;
            comm.Open();
            comm.NewLine = "/r/n";
            comm.RtsEnable = true;//根据实际情况吧。  

            /*
            byte[] data = Encoding.Unicode.GetBytes(textBox1.Text);
            string str = Convert.ToBase64String(data);
            this.comm.WriteLine(str);
            */
            try
            {
                byte[] data = Convert.FromBase64String(comm.ReadLine());
                string result = Encoding.Unicode.GetString(data);
                return Util.DecimalTryParse(result);
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.ToString());
            }
            finally
            {
                comm.Close();
            }
            return 0;
        }

        /// <summary>
        /// 根据数据中的table初始化ComboBox
        /// </summary>
        /// <param name="cb">ComboBox对象</param>
        /// <param name="tb">表格名称</param>
        /// <param name="col">列名</param>
        /// <param name="flag">是否需</param>
        public static void InitComboBox(ComboBox cb, string tb, string col, bool flag)
        {
            DataTable table = SqlHelper.GetDataTableBySQL(string.Format("select * from {0} order by {1} ASC", tb, col));
            if (flag)
            {
                cb.Items.Add("");
            }
            foreach (DataRow row in table.Rows)
            {
                cb.Items.Add(row[col].ToString());
            }
        }

        public static void InitComboBox(ComboBox cb, string tb, string col)
        {
            Util.InitComboBox(cb, tb, col, false);
        }

        public static string GetDbConfig(string key)
        {
            string sql = string.Format("SELECT V FROM Config WHERE K = '{0}'", key);
            string value = SqlHelper.GetFirstCellStringBySQL(sql);
            return value;
        }
        public static bool SetDbConfig(string key, string value)
        {
            SqlParameter p_key = Util.NewSqlParameter("@p_key", SqlDbType.VarChar, key, 50);
            SqlParameter p_val = Util.NewSqlParameter("@p_val", SqlDbType.VarChar, value, 50);
            string sql = string.Format(@"UPDATE Config SET V = @p_val WHERE K = @p_key");
            int affect = SqlHelper.ExecuteNonQuery(sql, p_key, p_val);
            return (affect == 1);
        }


        /// <summary>
        /// 获取App.config
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetAppConfig(string key)
        {
            var config = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None);
            if (!config.HasFile)
            {
                return null;
            }
            System.Configuration.KeyValueConfigurationElement k = config.AppSettings.Settings[key];
            if (k == null)
            {
                return null;
            }
            else
            {
                return System.Configuration.ConfigurationManager.AppSettings[key].ToString();
            }
        }

        /// <summary>
        /// 设置App.config
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool SetAppConfig(string key, string value)
        {
            var config = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None);
            if (!config.HasFile)
            {
                return false;   // throw new ArgumentException("程序配置文件缺失！");
            }
            System.Configuration.KeyValueConfigurationElement k = config.AppSettings.Settings[key];
            if (k == null)
            {
                config.AppSettings.Settings.Add(key, value);
            }
            else
            {
                config.AppSettings.Settings[key].Value = value;
            }
            config.Save(System.Configuration.ConfigurationSaveMode.Modified);
            System.Configuration.ConfigurationManager.RefreshSection("appSettings");
            return true;
        }

        /// <summary>
        /// 百分之一英寸单位，转化为厘米
        /// </summary>
        /// <param name="inch"></param>
        /// <returns></returns>
        public static string PrintMgToInch(string length)
        {
            decimal d = Util.DecimalTryParse(length);
            return Util.DecimalToString(d / 100);
        }

        /// <summary>
        /// 将CM转化为百分之一英寸单位
        /// </summary>
        /// <param name="cm"></param>
        /// <returns></returns>
        public static int InchToPrintMg(string length)
        {
            decimal d = Util.DecimalTryParse(length);
            return Convert.ToInt32(d * 100);
        }


        /// <summary>
        /// Decimal转化为String
        /// </summary>
        /// <param name="d"></param>
        /// <param name="n">位数</param>
        /// <returns></returns>
        public static string DecimalToString(decimal d, int n)
        {
            return Math.Round(d, n).ToString();
        }

        /// <summary>
        /// Decimal转化为String
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static string DecimalToString(decimal d)
        {
            return Math.Round(d, 2).ToString();
        }

        /// <summary>
        /// 根据配置文件重新设置PrintDocument对象
        /// </summary>
        /// <param name="pd"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool SetPrintDocumentByConfig(System.Drawing.Printing.PrintDocument pd, string key)
        {
            string setting = Util.GetAppConfig(key);
            if (setting == null)
            {
                setting = "";
            }
            Hashtable hash = new Hashtable();
            hash = new JavaScriptSerializer().Deserialize<Hashtable>(setting);
            if (hash != null)
            {
                //// 边距
                //int top = (hash["MarginTop"] == null) ? 0 : Util.CmToPrintMg(hash["MarginRight"].ToString());
                //int right = (hash["MarginRight"] == null) ? 0 : Util.CmToPrintMg(hash["MarginRight"].ToString());
                //int bottom = (hash["MarginBottom"] == null) ? 0 : Util.CmToPrintMg(hash["MarginBottom"].ToString());
                //int left = (hash["MarginRight"] == null) ? 0 : Util.CmToPrintMg(hash["MarginRight"].ToString()) ;

                int left = (hash["MarginLeft"] == null) ? 0 : Util.InchToPrintMg(hash["MarginLeft"].ToString());
                int right = (hash["MarginRight"] == null) ? 0 : Util.InchToPrintMg(hash["MarginRight"].ToString());
                int top = (hash["MarginTop"] == null) ? 0 : Util.InchToPrintMg(hash["MarginTop"].ToString());
                int bottom = (hash["MarginBottom"] == null) ? 0 : Util.InchToPrintMg(hash["MarginBottom"].ToString());

                System.Drawing.Printing.Margins mg = new System.Drawing.Printing.Margins(left, right, top, bottom);
                pd.DefaultPageSettings.Margins = mg;

                // 打印机和纸张
                if (hash["Printer"] != null)
                {
                    foreach (String printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                    {
                        if (hash["Printer"].ToString() == printer)
                        {
                            pd.PrinterSettings.PrinterName = printer;
                            if (hash["Paper"] != null)
                            {
                                foreach (System.Drawing.Printing.PaperSize ps in pd.PrinterSettings.PaperSizes)
                                {
                                    if (ps.PaperName == hash["Paper"].ToString())
                                    {
                                        pd.PrinterSettings.DefaultPageSettings.PaperSize = ps;
                                        pd.DefaultPageSettings.PaperSize = ps;
                                        break;
                                    }
                                }
                            }
                            break;
                        }
                    }
                }


                // 横纵向
                if (hash["LandScape"] != null)
                {
                    pd.DefaultPageSettings.Landscape = (hash["LandScape"].ToString().ToUpper() == "H") ? true : false;
                }

            }            
            return true;
        }
        #endregion

    }
}
