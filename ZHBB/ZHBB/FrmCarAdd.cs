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
    public partial class FrmCarAdd : Form
    {
        public bool IsAdded = false;  // 是否添加过用户

        public FrmCarAdd()
        {
            InitializeComponent();
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

            // 验证：车牌号
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
            if(company != "")
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

            /* 判断登陆名是否重复 */
            string sql_count = "select COUNT(*) as total from Cars where chepai = @p_chepai";
            DataRow row = SqlHelper.GetFirstRowBySQL(sql_count, p_chepai);
            if (Convert.ToInt32(row["total"]) > 0)
            {
                MessageBox.Show("操作失败：该项“车牌号”存在！");
                return;
            }

            /* 执行添加操作 */
            SqlParameter[] paras = new SqlParameter[] { p_chepai, p_owner, p_phone, p_address, p_beizhu, p_likevalue };            
            string sql = @"INSERT 
                            INTO Cars(chepai, owner, phone, address, beizhu, Likevalue, weight, company) 
                            VALUES (@p_chepai, @p_owner, @p_phone, @p_address, @p_beizhu, @p_likevalue, @p_weight, @p_company)";
            int affect = SqlHelper.ExecuteNonQuery(sql, paras);
            if (affect == 1)
            {
                MessageBox.Show("添加成功！");
                //Util.console_log(string.Format("添加项目：{0}（{1}） {2}", tb_xingming.Text, tb_uname.Text, cbProject_bd.Text));
                tb_chepai.Text = "";
                tb_owner.Text = "";
                tb_phone.Text = "";
                tb_address.Text = "";
                tb_beizhu.Text = "";
                tb_company.Text = "";
                tb_weight.Text = "";
                this.IsAdded = true;
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        // 窗体关闭事件
        private void FrmProjectAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.IsAdded == true)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }


        private void FrmCarAdd_Load(object sender, EventArgs e)
        {

        }

    }
}
