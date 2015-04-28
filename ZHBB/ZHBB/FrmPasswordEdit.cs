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
    public partial class FrmPasswordEdit : Form
    {
        public FrmPasswordEdit()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string oldpwd = this.txtOldPwd.Text.Trim();
            string newpwd = this.txtNewPwd.Text.Trim();
            string newpwd2 = this.txtNewPwd2.Text.Trim();
            if (oldpwd == "")
            {
                MessageBox.Show("请输入旧密码");
                this.txtOldPwd.Focus();
                return;
            }
            if (newpwd == "")
            {
                MessageBox.Show("请输入新密码！");
                this.txtNewPwd.Focus();
                return;
            }
            if (newpwd2 == "")
            {
                MessageBox.Show("请“重复新密码”！");
                this.txtNewPwd2.Focus();
                return;
            }
            if (newpwd != newpwd2)
            {
                MessageBox.Show("两次输入的密码不一致！");
                return;
            }

            SqlParameter p_uname = Util.NewSqlParameter("@p_uname", SqlDbType.VarChar, AppData.uname, 50);
            SqlParameter p_password = Util.NewSqlParameter("p_password", SqlDbType.VarChar, oldpwd, 50);
            SqlParameter p_password_new = Util.NewSqlParameter("p_password_new", SqlDbType.VarChar, newpwd, 50);

            string sql_check = "select * from Users where uname = @p_uname AND password = @p_password";
            DataTable table_check = SqlHelper.GetDataTableBySQL(sql_check, p_uname, p_password);
            if (table_check.Rows.Count != 1)
            {
                MessageBox.Show("您输入的旧密码不正确，请重新输入！");
                this.txtOldPwd.Text = "";
                this.txtOldPwd.Focus();
                return;
            }

            string sql_update = "update Users set password = @p_password_new where uname = @p_uname";
            if (SqlHelper.ExecuteNonQuery(sql_update, p_uname, p_password_new) == 1)
            {
                MessageBox.Show("修改成功");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void FrmPasswordEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
