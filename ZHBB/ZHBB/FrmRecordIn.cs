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
    public partial class FrmRecordIn : Form
    {
        private Point p_car;
        private Point p_cp;

        private int id;
        private bool IsSensor = true;

        public FrmRecordIn()
        {
            InitializeComponent();
        }

        private void FrmRecordAdd_Load(object sender, EventArgs e)
        {
            this.IsSensor = Util.GetDbConfig("IsSensor") == "1" ? true : false;
            this.btn_getWeight.Visible = this.IsSensor;
            this.tb_InWeight.ReadOnly = this.IsSensor;
            this.p_car = new Point(tb_chepai.Left, tb_chepai.Top + tb_chepai.Height);
            this.p_cp = new Point(tb_cp.Left, tb_cp.Top + tb_cp.Height);
            this.refreshInRecords();
        }

        // 车牌号文本框：根据车牌号搜索
        private void tb_chepai_TextChanged(object sender, EventArgs e)
        {
            bool IsResetDgv = true;
            string search = tb_chepai.Text.Trim().Replace("'", "");
            if (search.Length > 1)
            {
                string sql = string.Format(@"SELECT TOP 10  chepai AS '车牌号', owner as '车主' FROM Cars WHERE likevalue LIKE '%{0}%'", search);
                DataTable table = SqlHelper.GetDataTableBySQL(sql);
                if (table.Rows.Count > 0)
                {
                    dgv_cars.DataSource = table;
                    dgv_cars.Visible = true;
                    dgv_cars.Location = this.p_car;
                    dgv_cars.BringToFront();
                    dgv_cars.Visible = true;
                    dgv_cars.Height = dgv_cars.Rows.Count * dgv_cars.RowTemplate.Height + dgv_cars.ColumnHeadersHeight + 10;
                    IsResetDgv = false;
                }
            }
            if (IsResetDgv)
            {
                dgv_cars.DataSource = null;
                dgv_cars.Visible = false;
            }
        }


        // 车牌号文本框：Enter键
        private void tb_chepai_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            DataGridView dgv = this.dgv_cars;
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                int rowsCount = dgv.Rows.Count;
                if (rowsCount > 0)
                {
                    int rowIndex = dgv.CurrentCell.RowIndex;
                    if (e.KeyCode == System.Windows.Forms.Keys.Down)
                    {
                        rowIndex = (rowIndex < rowsCount - 1) ? rowIndex + 1 : 0;
                    }
                    else if (e.KeyCode == System.Windows.Forms.Keys.Up)
                    {
                        rowIndex = (rowIndex == 0) ? rowsCount - 1 : rowIndex - 1;
                    }
                    dgv.CurrentCell = dgv.Rows[rowIndex].Cells[0];
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (dgv.Rows.Count > 0)
                {
                    int rowIndex = dgv.CurrentCell.RowIndex;
                    if (rowIndex >= 0)
                    {
                        //tb_chepai_TextChanged
                        this.tb_chepai.TextChanged -= new System.EventHandler(this.tb_chepai_TextChanged);
                        tb_chepai.Text = dgv.Rows[rowIndex].Cells[0].Value.ToString().Trim();
                        this.tb_chepai.TextChanged += new System.EventHandler(this.tb_chepai_TextChanged);
                        //other
                        tb_chepai.Select(tb_chepai.Text.Length, 0);
                        dgv.DataSource = null;
                        dgv.Visible = false;
                    }
                }
                if (this.IsSensor)
                {
                    this.btn_getWeight.Focus();
                }
                else
                {
                    tb_cp.Focus();
                }
            }
        }
        private void tb_chepai_Leave(object sender, EventArgs e)
        {
            dgv_cars.DataSource = null;
            dgv_cars.Visible = false;

        }

        private void tb_cp_TextChanged(object sender, EventArgs e)
        {
            bool IsResetDgv = true;
            string search = tb_cp.Text.Trim().Replace("'", "");
            if (search.Length > 1)
            {
                string sql = string.Format(@"SELECT TOP 10 Gsm AS '单位名称', Owner as '负责人'  FROM Company WHERE likevalue LIKE '%{0}%'", search);
                DataTable table = SqlHelper.GetDataTableBySQL(sql);
                if (table.Rows.Count > 0)
                {
                    dgv_company.DataSource = table;
                    dgv_company.Visible = true;
                    dgv_company.Location = this.p_cp;
                    dgv_company.BringToFront();
                    dgv_company.Visible = true;
                    dgv_company.Height = dgv_company.Rows.Count * dgv_company.RowTemplate.Height + dgv_company.ColumnHeadersHeight + 10;
                    IsResetDgv = false;
                }
            }
            if (IsResetDgv)
            {
                dgv_company.DataSource = null;
                dgv_company.Visible = false;
            }

        }

        private void tb_cp_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridView dgv = this.dgv_company;
            // 回车
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                int rowsCount = dgv.Rows.Count;
                if (rowsCount > 0)
                {
                    int rowIndex = dgv.CurrentCell.RowIndex;
                    if (e.KeyCode == System.Windows.Forms.Keys.Down)
                    {
                        rowIndex = (rowIndex < rowsCount - 1) ? rowIndex + 1 : 0;
                    }
                    else if (e.KeyCode == System.Windows.Forms.Keys.Up)
                    {
                        rowIndex = (rowIndex == 0) ? rowsCount - 1 : rowIndex - 1;
                    }
                    dgv.CurrentCell = dgv.Rows[rowIndex].Cells[0];
                }
            }
            // Enter
            if (e.KeyCode == Keys.Enter)
            {
                if (dgv.Rows.Count > 0)
                {
                    int rowIndex = dgv.CurrentCell.RowIndex;
                    if (rowIndex >= 0)
                    {
                        // tb_cp_TextChanged
                        this.tb_cp.TextChanged -= new System.EventHandler(this.tb_cp_TextChanged);
                        tb_cp.Text = dgv.Rows[rowIndex].Cells[0].Value.ToString().Trim();
                        this.tb_cp.TextChanged += new System.EventHandler(this.tb_cp_TextChanged);

                        tb_cp.Select(tb_cp.Text.Length, 0);
                        dgv.DataSource = null;
                        dgv.Visible = false;
                    }
                }
                if (this.IsSensor == true)
                {
                    this.btn_getWeight.Focus();
                }
                else
                {
                    this.tb_InWeight.Focus();
                }
            }

        }
        private void tb_cp_Leave(object sender, EventArgs e)
        {
            this.dgv_company.DataSource = null;
            this.dgv_company.Visible = false;
        }

        // 重量文本框：Enter键
        private void tb_InWeight_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.IsSensor == false)
                {
                    FrmSubmit();
                }
            }
        }

        // 刷新最新录入的10条记录
        public void refreshInRecords()
        {
            string sql = string.Format(@"
                            SELECT TOP 30
                                ID,
                                chepai as '车牌号',
                                Company as '采购单位',
                                InWeight as '进入重量',
                                InTime as '进入时间'
                            FROM Records 
                            WHERE IsClose = 0 ORDER BY ID DESC");

            Util.DgvClear(dgv_in_records);
            dgv_in_records.DataSource = SqlHelper.GetDataTableBySQL(sql);

            DataGridViewButtonColumn dgv_button_col_del = new DataGridViewButtonColumn();
            dgv_button_col_del.Name = "删除";
            dgv_button_col_del.UseColumnTextForButtonValue = true;
            dgv_button_col_del.Text = "删除";
            dgv_button_col_del.HeaderText = "删除";
            dgv_in_records.Columns.Insert(dgv_in_records.Columns.Count, dgv_button_col_del);
            dgv_in_records.Columns["删除"].Width = 75;
            dgv_in_records.Columns["删除"].DefaultCellStyle.Padding = new Padding(5, 0, 5, 0);

        }

        private void dgv_in_records_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 如果点击的是表头则退出
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgv_in_records.Rows[e.RowIndex];
            this.id = Convert.ToInt32(row.Cells["ID"].Value);

            if (dgv_in_records.Columns[e.ColumnIndex].Name == "删除")
            {
                if (MessageBox.Show("您确定要删除这条记录吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    SqlParameter p_id = new SqlParameter("@p_pid", SqlDbType.Int);
                    p_id.Value = this.id;
                    int affect = SqlHelper.ExecuteNonQuery("DELETE FROM Records WHERE ID = @p_pid", p_id);
                    if (affect == 1)
                    {
                        MessageBox.Show("删除成功！");
                        this.refreshInRecords();
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                }
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            this.FrmSubmit();
        }

        // 表单提交
        private void FrmSubmit()
        {
            string chepai = tb_chepai.Text.Trim();
            string in_weight = tb_InWeight.Text.Trim();
            string company = tb_cp.Text.Trim();

            // 车牌
            if (chepai == "")
            {
                MessageBox.Show("请输入车牌");
                tb_chepai.Focus();
                return;
            }

            // 重量
            decimal weight;
            Boolean isDecimal = Decimal.TryParse(in_weight, out weight);
            if (isDecimal == false)
            {
                MessageBox.Show("重量输入错误");
                tb_InWeight.Focus();
                return;
            }

            if(company == "")
            {
                MessageBox.Show("请选择采购单位");
                tb_cp.Focus();
                return;
            }

            // 检测车牌是否存在，不存在则放入Cars表
            string likevalue = Util.AddCar(chepai);
            // 检测采购单位是否存在，不存在则放入Company表
            Util.AddCompany(company);

            SqlParameter p_chepai = Util.NewSqlParameter("@p_chepai", SqlDbType.VarChar, chepai, 50);
            SqlParameter p_likevalue = Util.NewSqlParameter("@p_likevalue", SqlDbType.VarChar, likevalue, 100);
            SqlParameter p_InTime = Util.NewSqlParameter("@p_InTime", SqlDbType.DateTime, DateTime.Now);
            SqlParameter p_InWeight = Util.NewSqlParameter("@p_InWeight", SqlDbType.Decimal, weight);
            SqlParameter p_company = Util.NewSqlParameter("@p_company", SqlDbType.VarChar, company, 100);
            string sql = string.Format(@"
                            insert into Records(chepai, likevalue, InTime, InWeight, IsClose, InUname, Company) 
                            values (@p_chepai, @p_likevalue, @p_InTime, @p_InWeight, 0, '{0}', @p_company)"
                        , AppData.uname);
            int affect = SqlHelper.ExecuteNonQuery(sql, p_chepai, p_likevalue, p_InTime, p_InWeight, p_company);
            if (affect > 0)
            {
                tb_chepai.Text = "";
                tb_InWeight.Text = "";
                tb_cp.Text = "";
                MessageBox.Show("录入成功");
                this.refreshInRecords();
                tb_chepai.Focus();
            }
        }

        private void btn_getWeight_Click(object sender, EventArgs e)
        {
            tb_InWeight.Text = Util.GetSensorWeight().ToString();
        }

    }
}
