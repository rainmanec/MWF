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
    public partial class FrmCarEdit : Form
    {
        public int id;

        public FrmCarEdit()
        {
            InitializeComponent();
        }

        private void FrmCarEdit_Load(object sender, EventArgs e)
        {
            this.Copy(this.id);
        }

        /// <summary>
        /// 取消按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// 提交按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OK_Click(object sender, EventArgs e)
        {
            /* 验证项目是否重复 */
            string chepai = tb_chepai.Text.Trim();
            string owner = tb_owner.Text.Trim();
            string phone = tb_phone.Text.Trim();
            string address = tb_address.Text.Trim();
            string beizhu = tb_beizhu.Text.Trim();
            string weight = tb_weight.Text.Trim();
            string company = tb_company.Text.Trim();

            // 验证：车牌
            if (chepai == "")
            {
                MessageBox.Show("车牌号不能为空");
                tb_chepai.Focus();
                return;
            }
            string likevalue = Util.GetLikeValue(chepai);

            // 验证：车重
            if (weight == "")
            {
                MessageBox.Show("请填写车重量");
                tb_weight.Focus();
                return;
            }
            decimal dweight;
            Boolean isDecimal = Decimal.TryParse(weight, out dweight);
            if (isDecimal == false)
            {
                MessageBox.Show("车重输入错误");
                tb_weight.Focus();
                return;
            }

            // 所属单位
            if (company != "")
            {
                Util.AddCompany(company);
            }

            // 整理参数
            SqlParameter p_chepai = Util.NewSqlParameter("@p_chepai", SqlDbType.VarChar, chepai.ToUpper(), 50);
            SqlParameter p_owner = Util.NewSqlParameter("@p_owner", SqlDbType.VarChar, owner, 50);
            SqlParameter p_phone = Util.NewSqlParameter("@p_phone", SqlDbType.VarChar, phone, 50);
            SqlParameter p_address = Util.NewSqlParameter("@p_address", SqlDbType.VarChar, address,50);
            SqlParameter p_beizhu = Util.NewSqlParameter("@p_beizhu", SqlDbType.VarChar, beizhu, 50);
            SqlParameter p_likevalue = Util.NewSqlParameter("@p_likevalue", SqlDbType.VarChar, likevalue, 100);
            SqlParameter p_weight = Util.NewSqlParameter("@p_weight", SqlDbType.Decimal, dweight);
            SqlParameter p_company = Util.NewSqlParameter("@p_company", SqlDbType.VarChar, company, 50);
            SqlParameter p_id = Util.NewSqlParameter("@p_id", SqlDbType.Int, this.id);

            /* 判断登陆名是否重复 */
            string sql_count = "select COUNT(*) as total from Cars where chepai = @p_chepai AND ID <> " + this.id;
            DataRow row = SqlHelper.GetFirstRowBySQL(sql_count, p_chepai);
            if (Convert.ToInt32(row["total"]) > 0)
            {
                MessageBox.Show("操作失败：车牌号已存在！");
                return;
            }

            /* 执行添加操作 */
            /* 执行编辑操作 */
            SqlParameter[] paras = new SqlParameter[] { p_chepai, p_owner, p_phone, p_address, p_beizhu, p_likevalue, p_id };   
            string sql = string.Format(@"
                            update Cars
                            set
                                chepai = @p_chepai,
                                owner = @p_owner,
                                phone = @p_phone,
                                address = @p_address,
                                beizhu = @p_beizhu,
                                likevalue = @p_likevalue，
                                weight = @p_weight,
                                company = @p_company
                            where ID = @p_id
                        ");
            int affect = SqlHelper.ExecuteNonQuery(sql, paras);
            if (affect == 1)
            {
                MessageBox.Show("编辑成功！");
                //Util.console_log(string.Format("添加项目：{0}（{1}） {2}", tb_xingming.Text, tb_uname.Text, cbProject_bd.Text));
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("编辑失败！");
            }
        }

        /// <summary>
        /// 根据项目ID拉取信息
        /// </summary>
        /// <param name="pid"></param>
        private void Copy(int id)
        {
            string sql = "select * from Cars where ID = " + id;
            DataTable table = SqlHelper.GetDataTableBySQL(sql);
            if (table.Rows.Count != 1)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            DataRow row = table.Rows[0];

            tb_chepai.Text = row["chepai"].ToString();
            tb_owner.Text = row["owner"].ToString();
            tb_phone.Text = row["phone"].ToString();
            tb_address.Text = row["address"].ToString();
            tb_beizhu.Text = row["beizhu"].ToString();
        }
    }
}
