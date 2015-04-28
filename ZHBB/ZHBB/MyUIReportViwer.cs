using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using Microsoft.Reporting.WinForms;
namespace ZHBB
{
    public partial class MyUIReportViwer : Form
    {

        public ReportDataSource MainDataSource;   // 报表DataSource
        public ReportParameter[] ReportParms;     // 报表Parameter
        public string ReportID;                   // 唯一的ID保存打印设置
        public string ReportPath;                 // Rdlc文件路径
        private PrintDocument PrintDoc = new PrintDocument();

        public MyUIReportViwer()
        {
            InitializeComponent();
        }

        #region 辅助函数
        /// <summary>
        /// 根据PrintDocument刷新报表的显示
        /// </summary>
        private void RefreshReportViewerByPrintDocument()
        {
            this.reportViewer1.PrinterSettings.PrinterName = this.PrintDoc.PrinterSettings.PrinterName;
            this.reportViewer1.SetPageSettings(this.PrintDoc.DefaultPageSettings);
            this.reportViewer1.RefreshReport();
        }

        #endregion

        private void ReportViwer_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = this.ReportPath;
            reportViewer1.LocalReport.DataSources.Clear();
            if (this.MainDataSource != null)
            {
                this.reportViewer1.LocalReport.DataSources.Add(this.MainDataSource);
            }
            if (this.ReportParms != null)
            {
                this.reportViewer1.LocalReport.SetParameters(this.ReportParms);
            }
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            Util.SetPrintDocumentByConfig(this.PrintDoc, this.ReportID);
            this.RefreshReportViewerByPrintDocument();
        }

        // 页面设置
        private void tsb_PrintSetting_Click(object sender, EventArgs e)
        {
            MyUIPrintSetting frm = new MyUIPrintSetting();
            frm.ReportID = this.ReportID;
            frm.PrintDoc = this.PrintDoc;
            frm.ShowDialog();
            this.RefreshReportViewerByPrintDocument();
        }

        // 打印事件
        private void tsb_Print_Click(object sender, EventArgs e)
        {
            this.reportViewer1.PrintDialog();
        }
    }
}
