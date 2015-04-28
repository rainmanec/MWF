using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace ZHBB
{
    public partial class FrmSearchHuiZongKind : Form
    {
        public Point p_car; // 车牌号的位置
        public Point p_cp;  // 采购单位的位置

        public int id;          // datagridview中行的ID
        public int which = 1;   // 汇总口径

        public string sql_fields = "";      // 搜索列
        public string sql_where = "";       // 搜索条件
        public string sql_group = "";       // 分组条件
        public string sql_order = "";       // 排序列
        public SqlParameter[] sql_parms;    // 搜索参数

        public FrmSearchHuiZongKind()
        {
            InitializeComponent();
        }

        private void FrmRecordAdd_Load(object sender, EventArgs e)
        {
            // 时间
            dtp_begin.Format = DateTimePickerFormat.Custom;
            dtp_begin.CustomFormat = "yyyy'-'MM-dd HH':'mm";
            dtp_end.Format = DateTimePickerFormat.Custom;
            dtp_end.CustomFormat = "yyyy'-'MM-dd HH':'mm"; 
            dtp_begin.Value = Util.DateTimeToDayBegin(DateTime.Now);     // 开始时间
            // other
            this.RefreshRecords();
        }


        /// <summary>
        /// 根据搜索条件设置sql_where和sql_parms两个变量
        /// </summary>
        public void SearchCdnInit()
        {
            //DateTime time_begin = Util.DateTimeToDayBegin(this.dtp_begin.Value);
            //DateTime time_end = Util.DateTimeToDayEnd(this.dtp_end.Value);
            DateTime time_begin = this.dtp_begin.Value;
            DateTime time_end = this.dtp_end.Value;
            bool IsChepai = this.cb_chepai.Checked;
            bool IsCp = this.cb_cp.Checked;

            List<string> Fields = new List<string>();
            List<string> Group = new List<string>();
            List<string> Order = new List<string>();
            List<string> Condition = new List<string>();
            List<SqlParameter> Parms = new List<SqlParameter>();
            if (IsCp)
            {
                Fields.Add("company AS '采购单位'");
                Group.Add("company");
                Order.Add("company ASC");
            }
            if (IsChepai)
            {
                Fields.Add("chepai AS '车牌号'");
                Group.Add("chepai");
                Order.Add("chepai ASC");
            }

            Fields.Add("kind AS '料种'");
            Group.Add("kind");
            Order.Add("kind ASC");

            Condition.Add("OutTime >= @p_time_begin AND OutTime <= @p_time_end");
            Parms.Add(Util.NewSqlParameter("@p_time_begin", SqlDbType.DateTime, time_begin));
            Parms.Add(Util.NewSqlParameter("@p_time_end", SqlDbType.DateTime, time_end));

            this.sql_fields = Util.ListJoin(" , ", Fields);
            this.sql_group = Util.ListJoin(" , ", Group);
            this.sql_order = Util.ListJoin(" , ", Order);
            this.sql_parms = Util.ListToArray(Parms);
            this.sql_where = (Condition.Count > 0) ? " AND " + Util.ListJoin(" AND ", Condition) : "";
        }


        /// <summary>
        /// 根据搜索条件，返回DataTable
        /// </summary>
        /// <returns></returns>
        public DataTable GetResultDataTable()
        {
            this.SearchCdnInit();
            string sql = string.Format(@"
                            SELECT 
                                ROW_NUMBER() OVER(ORDER BY {0}) AS  '序号',
                                {1}, SUM(NetWeight) as '净重' 
                            FROM Records 
                            WHERE IsClose = 1 {2}
                            GROUP BY {3}
                        ", this.sql_order, this.sql_fields, this.sql_where, this.sql_group);
            DataTable table = SqlHelper.GetDataTableBySQL(sql, this.sql_parms);
            return table;
        }

        public void RefreshSum()
        {
            this.SearchCdnInit();
            string sql = string.Format(@"
                            SELECT ISNULL(SUM(NetWeight), 0)
                            FROM Records 
                            WHERE IsClose = 1 {0}
                        ", this.sql_where);
            this.lb_sum.Text = string.Format("净重合计：{0}吨", SqlHelper.GetFirstCellStringBySQL(sql, this.sql_parms));
        }

        /// <summary>
        /// 显示搜索记录
        /// </summary>
        public void RefreshRecords()
        {
            this.RefreshSum();  // 合计
            DataTable table = this.GetResultDataTable();    //查询

            DataGridView dgv = dgv_records;
            Util.DgvClear(dgv);
            dgv.DataSource = table;
            Util.DgvColWidth(dgv, "序号", 60);
        }

        /// <summary>
        /// 搜索按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_submit_Click(object sender, EventArgs e)
        {
            this.RefreshRecords();
        }

        /// <summary>
        /// 导出Excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_excel_Click(object sender, EventArgs e)
        {

            this.saveFileDialog1.Title = "导出数据";
            this.saveFileDialog1.Filter = "Excel工作簿|*.xls";
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // 整理数据
                DataTable table = this.GetResultDataTable();
                Util.DataTableRemoveCol(table, "序号");
                // 导出数据
                string filename = this.saveFileDialog1.FileName;
                if (Util.ExportExcelWithAspose(table, filename, "汇总"))
                {
                    MessageBox.Show("导出成功！", "提示");
                }
                else
                {
                    MessageBox.Show("导出失败", "提示");
                }
            }
        }

        /// <summary>
        /// 删除，撤销，打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_in_records_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 如果点击的是表头则退出
            if (e.RowIndex < 0)
            {
                return;
            }

            this.id = Convert.ToInt32(dgv_records.Rows[e.RowIndex].Cells["ID"].Value);

            if (dgv_records.Columns[e.ColumnIndex].Name == "删除")
            {
                if (MessageBox.Show("您确定要删除这条记录吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (Util.DeleteRecord(this.id) == true)
                    {
                        MessageBox.Show("删除成功！");
                        this.RefreshRecords();
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                    }
                }
            }
            else if (dgv_records.Columns[e.ColumnIndex].Name == "撤销")
            {
                if (Util.CancelRecordOut(this.id) == true)
                {
                    MessageBox.Show("撤销成功！");
                    this.RefreshRecords();
                }
                else
                {
                    MessageBox.Show("撤销失败！");
                }
            }
            else if (dgv_records.Columns[e.ColumnIndex].Name == "打印")
            {
                //FrmRecordPrint frm = new FrmRecordPrint();
                //frm.id = this.id;
                //frm.ShowDialog();
            }
        }

    }
}