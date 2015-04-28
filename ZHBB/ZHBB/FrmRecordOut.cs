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
    public partial class FrmRecordOut : Form
    {
        public Point p_chepai;
        public Point p_company;
        public int id;

        public FrmRecordOut()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 表单加载事件
        /// </summary>
        private void FrmRecordOut_Load(object sender, EventArgs e)
        {
            Util.InitComboBox(cb_kind, "Kinds", "Title");
            this.p_chepai = new Point(tb_chepai.Left + this.groupBox_out.Left, this.groupBox_out.Top + tb_chepai.Top + tb_chepai.Height);
            this.p_company = new Point(tb_company.Left + this.groupBox_in.Left, this.groupBox_in.Top + tb_company.Top + tb_company.Height);
            this.LoadRecords();
        }

        #region 辅助函数
        /// <summary>
        /// 加载最近50条记录
        /// </summary>
        public void LoadRecords()
        {
            Util.DgvClear(dgv_out_records);

            string sql = string.Format(@"
                            SELECT TOP 50
                                ID,
                                chepai as '车牌号',
                                Company as '采购单位',
                                Kind as '料种',
                                OutWeight as '出厂重量',
                                InWeight as '车重',
                                NetWeight as '净重量',
                                other as '其他',
                                OutTime as '出厂时间'
                            FROM Records 
                            WHERE OutUname = '{0}' ORDER BY OutTime DESC", AppData.uname);
            dgv_out_records.DataSource = SqlHelper.GetDataTableBySQL(sql);


            DataGridViewButtonColumn dgv_button_col_print = new DataGridViewButtonColumn();
            dgv_button_col_print.Name = "打印";
            dgv_button_col_print.UseColumnTextForButtonValue = true;
            dgv_button_col_print.Text = "打印";
            dgv_button_col_print.HeaderText = "打印";
            dgv_out_records.Columns.Insert(dgv_out_records.Columns.Count, dgv_button_col_print);
            dgv_out_records.Columns["打印"].Width = 75;
            dgv_out_records.Columns["打印"].DefaultCellStyle.Padding = new Padding(5, 0, 5, 0);

            DataGridViewButtonColumn dgv_button_col_edit = new DataGridViewButtonColumn();
            dgv_button_col_edit.Name = "删除";
            dgv_button_col_edit.UseColumnTextForButtonValue = true;
            dgv_button_col_edit.Text = "删除";
            dgv_button_col_edit.HeaderText = "删除";
            dgv_out_records.Columns.Insert(dgv_out_records.Columns.Count, dgv_button_col_edit);
            dgv_out_records.Columns["删除"].Width = 75;
            dgv_out_records.Columns["删除"].DefaultCellStyle.Padding = new Padding(5, 0, 5, 0);
        }

        /// <summary>
        /// 车辆净重变化
        /// </summary>
        public void ChangeNetWeightText()
        {
            // 重量
            decimal out_weight;
            decimal in_weight;
            decimal net_weight;
            Boolean isDecimal_out = Decimal.TryParse(tb_OutWeight.Text.Trim(), out out_weight);
            Boolean isDecimal_in = Decimal.TryParse(tb_InWeight.Text.Trim(), out in_weight);
            if (isDecimal_out == false)
            {
                tb_NetWeight.Text = "出厂重量不合法";
                tb_NetWeight.ForeColor = Color.Red;
            }
            else if (isDecimal_in == false)
            {
                tb_NetWeight.Text = "车重不合法";
            }
            else
            {
                net_weight = out_weight - in_weight;
                if (net_weight <= 0)
                {
                    tb_NetWeight.Text = "出厂重量不能小于车重";
                }
                else
                {
                    tb_NetWeight.Text = net_weight.ToString();
                }
            }
        }

        /// <summary>
        /// 重置表单
        /// </summary>
        private void FrmReset()
        {
            tb_InWeight.Text = "";
            tb_company.Text = "";
            cb_kind.Text = "";
            tb_other.Text = "";
            tb_OutWeight.Text = "";
            tb_NetWeight.Text = "";
        }

        // 表单提交
        private void FrmSubmit()
        {
            // 车牌
            string chepai = tb_chepai.Text.Trim();
            if (chepai == "")
            {
                MessageBox.Show("请输入车牌");
                tb_chepai.Focus();
                return;
            }

            // 种类
            string kind = cb_kind.Text.Trim();
            if (kind == "")
            {
                MessageBox.Show("请选择种类");
                cb_kind.Focus();
                return;
            }


            // 出厂重量
            decimal out_weight;
            if (!Util.IsDecimal(tb_OutWeight.Text.Trim()))
            {
                MessageBox.Show("出厂重量不合法");
                tb_OutWeight.Focus();
                return;
            }
            else
            {
                out_weight = Util.DecimalTryParse(tb_OutWeight.Text.Trim());
            }

            // 入厂重量
            decimal in_weight;
            if (!Util.IsDecimal(tb_InWeight.Text.Trim()))
            {
                MessageBox.Show("入厂重量不合法");
                return;
            }
            else
            {
                in_weight = Util.DecimalTryParse(tb_InWeight.Text.Trim());
            }

            // 净重量
            decimal net_weight = out_weight - in_weight;
            if (net_weight <= 0)
            {
                MessageBox.Show("出厂重量不能小于入厂重量");
                tb_OutWeight.Focus();
                return;
            }

            // 采购单位
            string company = tb_company.Text.Trim();
            if (company == "")
            {
                MessageBox.Show("请选择采购单位");
                tb_company.Focus();
                return;
            }


            // 检测车牌是否存在，不存在则放入Cars表
            string likevalue = Util.AddCar(chepai);
            // 检测采购单位是否存在，不存在则放入Company表
            Util.AddCompany(company);

            SqlParameter p_chepai = Util.NewSqlParameter("@p_chepai", SqlDbType.VarChar, chepai, 50);
            SqlParameter p_OutTime = Util.NewSqlParameter("@p_OutTime", SqlDbType.DateTime, DateTime.Now);
            SqlParameter p_InWeight = Util.NewSqlParameter("@p_InWeight", SqlDbType.Decimal, in_weight);
            SqlParameter p_OutWeight = Util.NewSqlParameter("@p_OutWeight", SqlDbType.Decimal, out_weight);
            SqlParameter p_NetWeight = Util.NewSqlParameter("@p_NetWeight", SqlDbType.Decimal, net_weight);
            SqlParameter p_Kind = Util.NewSqlParameter("@p_Kind", SqlDbType.Char, kind, 50);
            SqlParameter p_other = Util.NewSqlParameter("@p_other", SqlDbType.VarChar, tb_other.Text, 100);
            SqlParameter p_Company = Util.NewSqlParameter("@p_Company", SqlDbType.VarChar, company, 50);
            SqlParameter p_likevalue = Util.NewSqlParameter("@p_likevalue", SqlDbType.VarChar, likevalue, 100);

            string sql = string.Format(
                        @"
                            INSERT INTO Records(chepai, OutTime, InWeight, OutWeight, NetWeight, other, Kind, Company, OutUname, likevalue)
                            VALUES(@p_chepai, @p_OutTime, @p_InWeight, @p_OutWeight, @p_NetWeight, @p_other, @p_Kind, @p_Company, '{0}', @p_likevalue)
                        ", AppData.uname);

            int affect = SqlHelper.ExecuteNonQuery(sql, p_chepai, p_OutTime, p_InWeight, p_OutWeight, p_NetWeight, p_other, p_Kind, p_Company, p_likevalue);
            if (affect > 0)
            {
                this.FrmReset();
                MessageBox.Show("录入成功");
                this.LoadRecords();
                tb_chepai.Focus();
            }
        }
        #endregion

        #region 车牌搜索提示

        /// <summary>
        /// 车牌号文本框：根据车牌号搜索
        /// </summary>
        private void tb_chepai_TextChanged(object sender, EventArgs e)
        {
            this.FrmReset();
            bool IsResetDgv = true;
            string search = tb_chepai.Text.Trim().Replace("'", "");
            DataGridView dgv = this.dgv_suggest;

            if (search.Length > 1)
            {
                string sql = string.Format(@"
                        SELECT TOP 10 chepai AS '车牌号', company AS '单位', weight as '车重' 
                        FROM Cars WHERE likevalue LIKE '%{0}%' ORDER BY chepai ASC", search);
                DataTable table = SqlHelper.GetDataTableBySQL(sql);
                if (table.Rows.Count > 0)
                {
                    IsResetDgv = false;
                    dgv.DataSource = table;
                    dgv.Visible = true;
                    dgv.Location = this.p_chepai;
                    dgv.BringToFront();
                    dgv.Visible = true;
                    dgv.Height = dgv.Rows.Count * dgv.RowTemplate.Height + dgv.ColumnHeadersHeight + 2;
                }
            }
            if(IsResetDgv)
            {
                dgv.DataSource = null;
                dgv.Visible = false;
            }
        }


        /// <summary>
        /// 车牌号文本框：Enter键
        /// </summary>
        private void tb_chepai_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            DataGridView dgv = this.dgv_suggest;
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
                        this.tb_chepai.TextChanged -= new System.EventHandler(this.tb_chepai_TextChanged);
                        tb_chepai.Text = dgv.Rows[rowIndex].Cells[0].Value.ToString().Trim();
                        this.tb_chepai.TextChanged += new System.EventHandler(this.tb_chepai_TextChanged);

                        this.tb_company.TextChanged -= new System.EventHandler(this.tb_company_TextChanged);
                        tb_company.Text = dgv.Rows[rowIndex].Cells[1].Value.ToString().Trim();
                        this.tb_company.TextChanged -= new System.EventHandler(this.tb_company_TextChanged);

                        tb_InWeight.Text = dgv.Rows[rowIndex].Cells[2].Value.ToString().Trim();

                        tb_chepai.Select(tb_chepai.Text.Length, 0);
                        dgv.DataSource = null;
                        dgv.Visible = false;
                    }
                }
                cb_kind.Focus();
            }
        }
        private void tb_chepai_Leave(object sender, EventArgs e)
        {
            this.dgv_suggest.DataSource = null;
            this.dgv_suggest.Visible = false;
        }
        #endregion

        #region 采购单位搜索提示

        private void tb_company_KeyDown(object sender, KeyEventArgs e)
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
                        // tb_company_TextChanged
                        this.tb_company.TextChanged -= new System.EventHandler(this.tb_company_TextChanged);
                        tb_company.Text = dgv.Rows[rowIndex].Cells[0].Value.ToString().Trim();
                        this.tb_company.TextChanged += new System.EventHandler(this.tb_company_TextChanged);

                        tb_company.Select(tb_company.Text.Length, 0);
                        dgv.DataSource = null;
                        dgv.Visible = false;
                    }
                }
                this.tb_InWeight.Focus();
            }
        }

        private void tb_company_Leave(object sender, EventArgs e)
        {
            this.dgv_company.DataSource = null;
            this.dgv_company.Visible = false;

        }

        private void tb_company_TextChanged(object sender, EventArgs e)
        {
            bool IsResetDgv = true;
            string search = tb_company.Text.Trim().Replace("'", "");
            if (search.Length > 1)
            {
                string sql = string.Format(@"SELECT TOP 10 Gsm AS '单位名称', Owner as '负责人'  FROM Company WHERE likevalue LIKE '%{0}%'", search);
                DataTable table = SqlHelper.GetDataTableBySQL(sql);
                if (table.Rows.Count > 0)
                {
                    dgv_company.DataSource = table;
                    dgv_company.Visible = true;
                    dgv_company.Location = this.p_company;
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
        #endregion

        /// <summary>
        /// 出厂重量发生变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_OutWeight_TextChanged(object sender, EventArgs e)
        {
            this.ChangeNetWeightText();
        }


        /// <summary>
        /// 重量文本框：Enter键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_OutWeight_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tb_other.Focus();
            }
        }

        /// <summary>
        /// 提交按钮事件
        /// </summary>
        private void btn_submit_Click(object sender, EventArgs e)
        {
            this.FrmSubmit();
        }

        /// <summary>
        /// 料种选择后，焦点转移
        /// </summary>
        private void cb_kind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.tb_OutWeight.Focus();
            }
        }
        
        /// <summary>
        /// 车重发生变化
        /// </summary>
        private void tb_InWeight_TextChanged(object sender, EventArgs e)
        {
            this.ChangeNetWeightText();
        }

        /// <summary>
        /// 列表单元格点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_out_records_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 如果点击的是表头则退出
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgv_out_records.Rows[e.RowIndex];
            this.id = Convert.ToInt32(row.Cells["ID"].Value);

            if (dgv_out_records.Columns[e.ColumnIndex].Name == "删除")
            {
                if (Util.DeleteRecord(this.id))
                {
                    MessageBox.Show("删除成功");
                    this.LoadRecords();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            else if (dgv_out_records.Columns[e.ColumnIndex].Name == "打印")
            {
                Util.PrintRecord(this.id);
            }
        }

        /// <summary>
        /// Enter键提交表单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_other_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.FrmSubmit();
            }
        }

    }
}
