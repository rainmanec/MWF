using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace ZHBB
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.Text = string.Format(this.Text, AppData.Company);
        }

        private void txtUname_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                this.login();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.login();
        }

        private void login()
        {
            SqlParameter[] parms = new SqlParameter[]{
                Util.NewSqlParameter("@p_uname", SqlDbType.VarChar, txtUname.Text.Trim(), 50),
                Util.NewSqlParameter("@p_password", SqlDbType.VarChar, txtPassword.Text.Trim(), 50)
            };

            DataTable table = SqlHelper.GetDataTableBySQL("select * from Users where uname = @p_uname and password = @p_password", parms);
            if (table.Rows.Count == 1)
            {
                AppData.Uname = table.Rows[0]["uname"].ToString();
                AppData.XingMing = table.Rows[0]["xingming"].ToString();
                AppData.Uroleid = Util.IntTryParse(table.Rows[0]["roleid"].ToString());
                //Util.console_log("登陆系统");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.lb_tip.Visible = true;
                int left = this.lb_tip.Left;
                this.lb_tip.Left = left + 2;
                Thread.Sleep(100);
                this.lb_tip.Left = left;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }

    }
}
