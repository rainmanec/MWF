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
    public partial class FrmCarList : Form
    {
        public int id;
        public string sql_query;
        public string sql_count;

        public FrmCarList()
        {
            InitializeComponent();
        }

        private void FrmListUser_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        /// <summary>
        /// 重置分页，并加载数据
        /// </summary>
        public void LoadData()
        {
            string search = tb_serch.Text.Trim().Replace("'", "").ToUpper();
            this.sql_query = string.Format(@"
                                SELECT 
                                    ROW_NUMBER() OVER(ORDER BY ID DESC) AS  '序号',
                                    ID,
                                    chepai as '车牌号',
                                    owner as '车主',
                                    weight as '车重',
                                    company as '所属单位',
                                    phone as '电话',
                                    address as '地址',
                                    beizhu as '备注'
                                FROM Cars WHERE likevalue like '%{0}%' OR owner like '%{0}%'", search);
            this.sql_count = string.Format(@"SELECT ISNULL(COUNT(*), 0) FROM Cars WHERE likevalue like '%{0}%' OR owner like '%{0}%'", search);
            this.paginator1.Init(Util.IntTryParse(SqlHelper.GetFirstCellStringBySQL(this.sql_count)), 100);
        }

        /// <summary>
        /// 回车键执行搜索
        /// </summary>
        private void tb_serch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.LoadData();
            }
        }

        /// <summary>
        /// 添加车辆
        /// </summary>
        private void btn_car_add_Click(object sender, EventArgs e)
        {
            FrmCarAdd frm = new FrmCarAdd();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.paginator1.Refresh();
            }
        }      

        /// <summary>
        /// 编辑和删除事件
        /// </summary>
        private void dgv_main_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 如果点击的是表头则退出
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgv_main.Rows[e.RowIndex];
            this.id = Convert.ToInt32(row.Cells["ID"].Value);

            if (dgv_main.Columns[e.ColumnIndex].Name == "编辑")
            {
                FrmCarEdit frm = new FrmCarEdit();
                frm.id = this.id;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.paginator1.Refresh();
                }
            }
            else if (dgv_main.Columns[e.ColumnIndex].Name == "删除")
            {
                if (MessageBox.Show("您确定要删除这条记录吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    SqlParameter p_id = Util.NewSqlParameter("@p_id", SqlDbType.Int, this.id);
                    int affect = SqlHelper.ExecuteNonQuery("DELETE FROM Cars WHERE ID = @p_id", p_id);
                    if (affect == 1)
                    {
                        MessageBox.Show("删除成功！");
                        this.paginator1.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                }
            }

        }

        /// <summary>
        /// 分页事件
        /// </summary>
        private void paginator1_PageChanged(object sender, int total, int cur, int per)
        {
            DataTable table = SqlHelper.GetDataTableBySQL(Util.PaginatorSQL(sql_query, cur, per));

            Util.DgvClear(dgv_main);
            dgv_main.DataSource = table;
            Util.DgvColHide(dgv_main, "ID");
            Util.DgvColWidth(dgv_main, "序号", 60);

            DataGridViewButtonColumn dgv_button_col_edit = new DataGridViewButtonColumn();
            dgv_button_col_edit.Name = "编辑";
            dgv_button_col_edit.UseColumnTextForButtonValue = true;
            dgv_button_col_edit.Text = "编辑";
            dgv_button_col_edit.HeaderText = "编辑";
            dgv_main.Columns.Insert(dgv_main.Columns.Count, dgv_button_col_edit);
            dgv_main.Columns["编辑"].Width = 75;
            dgv_main.Columns["编辑"].DefaultCellStyle.Padding = new Padding(5, 0, 5, 0);

            DataGridViewButtonColumn dgv_button_col_del = new DataGridViewButtonColumn();
            dgv_button_col_del.Name = "删除";
            dgv_button_col_del.UseColumnTextForButtonValue = true;
            dgv_button_col_del.Text = "删除";
            dgv_button_col_del.HeaderText = "删除";
            dgv_main.Columns.Insert(dgv_main.Columns.Count, dgv_button_col_del);
            dgv_main.Columns["删除"].Width = 75;
            dgv_main.Columns["删除"].DefaultCellStyle.Padding = new Padding(5, 0, 5, 0);
        }

        /// <summary>
        /// 导出数据
        /// </summary>
        private void paginator1_ExportExcel(object sender, int total, int cur, int per)
        {
            this.saveFileDialog1.Title = "导出数据";
            this.saveFileDialog1.Filter = "Excel工作簿|*.xls";
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // 整理数据
                DataTable table = SqlHelper.GetDataTableBySQL(this.sql_query);
                Util.DataTableRemoveCol(table, "ID");
                // 数量过大
                if (table.Rows.Count > 50000)
                {
                    if (MessageBox.Show("记录数大于5万条，确定要继续吗？", "提示", MessageBoxButtons.OKCancel) != DialogResult.OK)
                    {
                        return;
                    }
                }
                // 导出数据
                string filename = this.saveFileDialog1.FileName;
                if (Util.ExportExcelWithAspose(table, filename, "车辆"))
                {
                    MessageBox.Show("导出成功！", "提示");
                }
                else
                {
                    MessageBox.Show("导出失败", "提示");
                }
            }
        }

    }
}
