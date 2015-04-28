using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Printing;
using System.Web.Script.Serialization;
 
namespace ZHBB
{
    public partial class MyUIPrintSetting : Form
    {

        /// <summary>
        /// 
        /// </summary>
        public PrintDocument PrintDoc = null;

        /// <summary>
        /// 用于App.config中存储的ID
        /// </summary>
        public string ReportID;

        public MyUIPrintSetting()
        {
            InitializeComponent();
        }

        //窗体加载
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (String printer in PrinterSettings.InstalledPrinters)
            {
                this.cbPrinterList.Items.Add(printer);
            }
            this.UseDefaultPrinter();
            this.InitFormByDocument();
        }

        #region 辅助函数
        /// <summary>
        /// 根据Document初始化窗体内容
        /// </summary>      
        public void InitFormByDocument()
        {
            if (this.PrintDoc == null)
            {
                return;
            }
            Margins mg = this.PrintDoc.DefaultPageSettings.Margins;
            this.tbMgLeft.Text = Util.PrintMgToInch(mg.Left.ToString());
            this.tbMgRight.Text = Util.PrintMgToInch(mg.Right.ToString());
            this.tbMgTop.Text = Util.PrintMgToInch(mg.Top.ToString());
            this.tbMgBottom.Text = Util.PrintMgToInch(mg.Bottom.ToString());

            // 打印机和纸张
            for (int i = 0; i < this.cbPrinterList.Items.Count; i++)
            {
                if (this.cbPrinterList.Items[i].ToString() == this.PrintDoc.PrinterSettings.PrinterName)
                {
                    this.cbPrinterList.SelectedIndex = i;
                    for (int j = 0; j < this.cbPaper.Items.Count; j++)
                    {
                        if (this.cbPaper.Items[j].ToString() == this.PrintDoc.PrinterSettings.DefaultPageSettings.PaperSize.PaperName)
                        {
                            this.cbPaper.SelectedIndex = j;
                            break;
                        }
                    }
                    break;
                }
            }

            // 横纵向
            if (this.PrintDoc.DefaultPageSettings.Landscape == true)
            {
                this.rdHorizon.Checked = true;
            }
            else
            {
                this.rdVertical.Checked = true;
            }

        }

        /// <summary>
        /// 根据窗体的Tag从App.config中读取默认配置，并初始化窗体
        /// </summary>
        public void InitFormByAppConfig()
        {
            Hashtable hash = new Hashtable();
            hash = new JavaScriptSerializer().Deserialize<Hashtable>(Util.GetAppConfig(this.ReportID));
            if (hash != null)
            {
                this.tbMgTop.Text = (hash["MarginTop"] == null) ? "" : hash["MarginTop"].ToString();
                this.tbMgRight.Text = (hash["MarginRight"] == null) ? "" : hash["MarginRight"].ToString();
                this.tbMgBottom.Text = (hash["MarginBottom"] == null) ? "" : hash["MarginBottom"].ToString();
                this.tbMgLeft.Text = (hash["MarginLeft"] == null) ? "" : hash["MarginLeft"].ToString();

                // 打印机和纸张
                if (hash["Printer"] != null)
                {
                    for (int i = 0; i < this.cbPrinterList.Items.Count; i++)
                    {
                        if (this.cbPrinterList.Items[i].ToString() == hash["Printer"].ToString())
                        {
                            this.cbPrinterList.SelectedIndex = i;
                            if (hash["Paper"] != null)
                            {
                                for (int j = 0; j < this.cbPaper.Items.Count; j++)
                                {
                                    if (this.cbPaper.Items[j].ToString() == hash["Paper"].ToString())
                                    {
                                        this.cbPaper.SelectedIndex = j;
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
                    if (hash["LandScape"].ToString().ToUpper() == "H")
                    {
                        this.rdHorizon.Checked = true;
                    }
                    if (hash["LandScape"].ToString().ToUpper() == "V")
                    {
                        this.rdVertical.Checked = true;
                    }
                }
            }
        }

        /// <summary>
        /// 使用默认打印机
        /// </summary>
        public void UseDefaultPrinter()
        {
            PrintDocument pd = new PrintDocument();
            for (int i = 0; i < this.cbPrinterList.Items.Count; i++)
            {
                if (this.cbPrinterList.Items[i].ToString() == pd.PrinterSettings.PrinterName)
                {
                    this.cbPrinterList.SelectedIndex = i;
                    break;
                }
            }
        }

        /// <summary>
        /// 将文本框的值变成2位小数
        /// </summary>
        /// <param name="input">TextBox对象</param>
        public void FormatTextBoxValue(TextBox input)
        {
            decimal d;
            if (decimal.TryParse(input.Text.Trim(), out d))
            {
                input.Text = Math.Round(d, 2).ToString();
            }
            else
            {
                input.Text = "0";
            }
        }

        #endregion

        // 使用默认打印机
        private void btnUseDefaultPrinter_Click(object sender, EventArgs e)
        {
            this.UseDefaultPrinter();
        }

        // 打印机变化
        private void cbPrinterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbPaper.Items.Clear();

            // 纸张
            PrintDocument pd = new PrintDocument();
            pd.PrinterSettings.PrinterName = this.cbPrinterList.Text;
            foreach (PaperSize ps in pd.PrinterSettings.PaperSizes)
            {
                this.cbPaper.Items.Add(ps.PaperName);
            }
            if (this.cbPaper.Items.Count > 0)
            {
                this.cbPaper.SelectedIndex = 0;
            }

            // 纸张方向
            if (pd.DefaultPageSettings.Landscape)
            {
                this.rdHorizon.Checked = true;
            }
            else
            {
                this.rdVertical.Checked = true;
            }
        }

        // 确定按钮
        private void btnOK_Click(object sender, EventArgs e)
        {
            // 纸张方向
            string LandScape = (this.rdHorizon.Checked == true) ? "H" : "V";

            // 格式化值
            this.FormatTextBoxValue(this.tbMgTop);
            this.FormatTextBoxValue(this.tbMgRight);
            this.FormatTextBoxValue(this.tbMgBottom);
            this.FormatTextBoxValue(this.tbMgLeft);

            Hashtable ht = new Hashtable();
            ht.Add("Printer", this.cbPrinterList.Text);
            ht.Add("Paper", this.cbPaper.Text);
            ht.Add("LandScape", LandScape);
            ht.Add("MarginLeft", this.tbMgLeft.Text.Trim());
            ht.Add("MarginRight", this.tbMgRight.Text.Trim());
            ht.Add("MarginTop", this.tbMgTop.Text.Trim());
            ht.Add("MarginBottom", this.tbMgBottom.Text.Trim());
            Util.SetAppConfig(this.ReportID, new JavaScriptSerializer().Serialize(ht));
            Util.SetPrintDocumentByConfig(this.PrintDoc, this.ReportID);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // 取消按钮
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // 上边距
        private void tbMgTop_Leave(object sender, EventArgs e)
        {
            this.FormatTextBoxValue(this.tbMgTop);
        }

        // 下边距
        private void tbMgBottom_Leave(object sender, EventArgs e)
        {
            this.FormatTextBoxValue(this.tbMgBottom);
        }

        // 左边距
        private void tbMgLeft_Leave(object sender, EventArgs e)
        {
            this.FormatTextBoxValue(this.tbMgLeft);
        }

        // 右边距
        private void tbMgRight_Leave(object sender, EventArgs e)
        {
            this.FormatTextBoxValue(this.tbMgRight);
        }
    }
}
