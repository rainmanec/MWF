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
        public Point p;
        public int id;
        public bool IsSensor = true;

        public FrmRecordOut()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 表单加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRecordOut_Load(object sender, EventArgs e)
        {
            this.IsSensor = Util.GetDbConfig("IsSensor") == "1" ? true : false;
            this.btn_getWeight.Visible = this.IsSensor;
            this.tb_OutWeight.ReadOnly = this.IsSensor;
            Util.InitComboBox(cb_kind, "Kinds", "Title");
            this.p = new Point(tb_chepai.Left + this.groupBox_out.Left, this.groupBox_out.Top + tb_chepai.Top + tb_chepai.Height);
            this.refreshInRecords();
            lb_id.Text = "";
        }

        /// <summary>
        /// 车牌号文本框：根据车牌号搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_chepai_TextChanged(object sender, EventArgs e)
        {
            this.FrmReset();
            bool IsResetDgv = true;
            string search = tb_chepai.Text.Trim().Replace("'", "");
            DataGridView dgv = this.dgv_suggest;

            if (search.Length > 1)
            {
                string sql = string.Format(@"
                        SELECT TOP 10 ID AS '流水号', chepai AS '车牌号', InTime as '进入时间', InWeight as '进入重量', Company
                        FROM Records WHERE likevalue LIKE '%{0}%' AND IsClose <> 1 ORDER BY ID DESC", search);
                DataTable table = SqlHelper.GetDataTableBySQL(sql);
                if (table.Rows.Count > 0)
                {
                    IsResetDgv = false;
                    dgv.DataSource = table;
                    dgv.Visible = true;
                    dgv.Location = this.p;
                    dgv.BringToFront();
                    dgv.Visible = true;
                    dgv.Columns["Company"].Visible = false;
                    dgv.Height = dgv.Rows.Count * dgv.RowTemplate.Height + dgv.ColumnHeadersHeight + 2;
                }
            }
            if(IsResetDgv)
            {
                dgv.DataSource = null;
                dgv.Visible = false;
            }
        }


        // 车牌号文本框：Enter键
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
                        tb_chepai.Text = dgv.Rows[rowIndex].Cells[1].Value.ToString().Trim();
                        this.tb_chepai.TextChanged += new System.EventHandler(this.tb_chepai_TextChanged);

                        tb_InTime.Text = dgv.Rows[rowIndex].Cells[2].Value.ToString().Trim();
                        tb_InWeight.Text = dgv.Rows[rowIndex].Cells[3].Value.ToString().Trim();
                        tb_cp.Text = dgv.Rows[rowIndex].Cells["Company"].Value.ToString().Trim();
                        lb_id.Text = dgv.Rows[rowIndex].Cells[0].Value.ToString().Trim();

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

        private void tb_OutWeight_TextChanged(object sender, EventArgs e)
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
                tb_NetWeight.Text = "进厂重量不合法";
            }
            else
            {
                net_weight = out_weight - in_weight;
                if (net_weight <= 0)
                {
                    tb_NetWeight.Text = "出厂重量不能小于进厂重量";
                }
                else
                {
                    tb_NetWeight.Text = net_weight.ToString();
                }
            }

        }


        // 重量文本框：Enter键
        private void tb_OutWeight_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tb_other.Focus();
            }
        }

        // 价格文本框：Enter键
        private void tb_price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.FrmSubmit();
            }
        }

        private void FrmReset()
        {
            lb_id.Text = "";
            tb_cp.Text = "";
            tb_InTime.Text = "";
            tb_InWeight.Text = "";
            cb_kind.Text = "";
            tb_NetWeight.Text = "";
        }

        // 表单提交
        private void FrmSubmit()
        {
            // 进厂车辆是否选择
            string id = lb_id.Text.Trim();
            if (id == "")
            {
                MessageBox.Show("请选择进厂车辆");
                tb_chepai.Focus();
                return;
            }

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
            if(net_weight <= 0)
            {
                MessageBox.Show("出厂重量不能小于入厂重量");
                tb_OutWeight.Focus();
                return;
            }


            SqlParameter p_OutTime = Util.NewSqlParameter("@p_OutTime", SqlDbType.DateTime, DateTime.Now);
            SqlParameter p_OutWeight = Util.NewSqlParameter("@p_OutWeight", SqlDbType.Decimal, out_weight);
            SqlParameter p_NetWeight = Util.NewSqlParameter("@p_NetWeight", SqlDbType.Decimal, net_weight);
            SqlParameter p_kind = Util.NewSqlParameter("@p_kind", SqlDbType.Char, kind, 50);
            SqlParameter p_other = Util.NewSqlParameter("@p_other", SqlDbType.VarChar, tb_other.Text, 100);
            SqlParameter p_ID = Util.NewSqlParameter("@p_ID", SqlDbType.Int, id);

            string sql = string.Format(
                        @"
                            update Records
                            set
                                OutTime = @p_OutTime,
                                OutWeight = @p_OutWeight,
                                NetWeight = @p_NetWeight,
                                kind = @p_kind,
                                other = @p_other,
                                IsClose = 1,
                                OutUname = '{0}'
                            where ID = {1}
                        ", AppData.uname, id);

            int affect = SqlHelper.ExecuteNonQuery(sql, p_OutTime, p_OutWeight, p_NetWeight, p_kind, p_other);
            if (affect > 0)
            {
                lb_id.Text = "";
                tb_chepai.Text = "";
                tb_OutWeight.Text = "";
                tb_NetWeight.Text = "";
                tb_other.Text = "";
                MessageBox.Show("录入成功");
                this.refreshInRecords();
                tb_chepai.Focus();
            }
        }


        public void refreshInRecords()
        {
            Util.DgvClear(dgv_out_records);

            string sql = string.Format(@"
                            SELECT TOP 100
                                ID,
                                chepai as '车牌号',
                                Company as '采购单位',
                                InWeight as '进厂重量',
                                OutWeight as '出厂重量',
                                NetWeight as '净重量',
                                Kind as '种类',
                                other as '其他',
                                InTime as '进厂时间',
                                OutTime as '出厂时间'
                            FROM Records 
                            WHERE IsClose = 1 AND OutUname = '{0}' ORDER BY OutTime DESC", AppData.uname);
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
            dgv_button_col_edit.Name = "撤销";
            dgv_button_col_edit.UseColumnTextForButtonValue = true;
            dgv_button_col_edit.Text = "撤销";
            dgv_button_col_edit.HeaderText = "撤销";
            dgv_out_records.Columns.Insert(dgv_out_records.Columns.Count, dgv_button_col_edit);
            dgv_out_records.Columns["撤销"].Width = 75;
            dgv_out_records.Columns["撤销"].DefaultCellStyle.Padding = new Padding(5, 0, 5, 0);
        }

        private void dgv_out_records_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 如果点击的是表头则退出
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgv_out_records.Rows[e.RowIndex];
            this.id = Convert.ToInt32(row.Cells["ID"].Value);

            if (dgv_out_records.Columns[e.ColumnIndex].Name == "撤销")
            {
                string sql = string.Format(@"
                                UPDATE Records
                                SET
	                                OutTime = NULL, OutWeight = NULL, NetWeight = NULL,
	                                other = '', Kind = '', OutUname = '', IsClose = 0
                                WHERE ID = {0}", this.id);
                if (SqlHelper.ExecuteNonQuery(sql) == 1)
                {
                    MessageBox.Show("撤销成功");
                    this.refreshInRecords();
                }
                else
                {
                    MessageBox.Show("撤销失败");
                }
            }
            else if (dgv_out_records.Columns[e.ColumnIndex].Name == "打印")
            {
                Util.PrintRecord(this.id);
            }

        }
        /// <summary>
        /// 提交按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_submit_Click(object sender, EventArgs e)
        {
            this.FrmSubmit();
        }

        private void btn_getWeight_Click(object sender, EventArgs e)
        {
            this.tb_OutWeight.Text = Util.GetSensorWeight().ToString();
        }

        /// <summary>
        /// 料种选择后，焦点转移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_kind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.IsSensor == true)
                {
                    this.btn_getWeight.Focus();
                }
                else
                {
                    this.tb_OutWeight.Focus();
                }
            }
        }



    }
}
