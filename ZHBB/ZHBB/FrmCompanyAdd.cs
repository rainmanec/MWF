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
    public partial class FrmCompanyAdd : Form
    {
        public bool IsAdded = false;  // 是否添加过用户

        public FrmCompanyAdd()
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
            string gsm = tb_Gsm.Text.Trim();
            string owner = tb_owner.Text.Trim();
            string phone = tb_phone.Text.Trim();
            string address = tb_address.Text.Trim();
            string beizhu = tb_beizhu.Text.Trim();

            if (gsm == "")
            {
                MessageBox.Show("公司名不能为空");
                tb_Gsm.Focus();
                return;
            }
            string likevalue = Util.GetLikeValue(gsm);

            // 整理参数
            SqlParameter p_gsm = Util.NewSqlParameter("@p_gsm", SqlDbType.VarChar, gsm, 50);
            SqlParameter p_owner = Util.NewSqlParameter("@p_owner", SqlDbType.VarChar, owner, 50);
            SqlParameter p_phone = Util.NewSqlParameter("@p_phone", SqlDbType.VarChar, phone, 50);
            SqlParameter p_address = Util.NewSqlParameter("@p_address", SqlDbType.VarChar, address,50);
            SqlParameter p_beizhu = Util.NewSqlParameter("@p_beizhu", SqlDbType.VarChar, beizhu, 50);
            SqlParameter p_likevalue = Util.NewSqlParameter("@p_likevalue", SqlDbType.VarChar, likevalue, 100);

            /* 判断登陆名是否重复 */
            string sql_count = "select COUNT(*) as total from Company where gsm = @p_gsm";
            DataRow row = SqlHelper.GetFirstRowBySQL(sql_count, p_gsm);
            if (Convert.ToInt32(row["total"]) > 0)
            {
                MessageBox.Show("操作失败：该公司已存在！");
                return;
            }

            /* 执行添加操作 */
            SqlParameter[] paras = new SqlParameter[] { p_gsm, p_owner, p_phone, p_address, p_beizhu, p_likevalue };            
            string sql = @"insert 
                            into Company(gsm, owner, phone, address, beizhu, Likevalue) 
                            values (@p_gsm, @p_owner, @p_phone, @p_address, @p_beizhu, @p_likevalue)";
            int affect = SqlHelper.ExecuteNonQuery(sql, paras);
            if (affect == 1)
            {
                MessageBox.Show("添加成功！");
                tb_Gsm.Text = "";
                tb_owner.Text = "";
                tb_phone.Text = "";
                tb_address.Text = "";
                tb_beizhu.Text = "";
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


        private void FrmCompanyAdd_Load(object sender, EventArgs e)
        {

        }

    }
}
