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
    public partial class FrmUserEdit : Form
    {
        public int id;
        public bool IsEdited = false;
        private void FrmUserEdit_Load(object sender, EventArgs e)
        {
            this.Copy(this.id);
        }

        public FrmUserEdit()
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
            string uname = tb_uname.Text.Trim();
            string phone = tb_phone.Text.Trim();
            string xingming = tb_xingming.Text.Trim();
            string password = tb_password.Text.Trim();

            if (uname == "")
            {
                MessageBox.Show("登录名不能为空");
                tb_uname.Focus();
                return;
            }
            if (xingming == "")
            {
                MessageBox.Show("姓名不能为空");
                tb_xingming.Focus();
                return;
            }
            if (password == "")
            {
                MessageBox.Show("密码不能为空");
                tb_xingming.Focus();
                return;
            }

            // 整理参数
            SqlParameter p_uname = Util.NewSqlParameter("@p_uname", SqlDbType.VarChar, uname, 50);
            SqlParameter p_xingming = Util.NewSqlParameter("@p_xingming", SqlDbType.VarChar, xingming, 50);
            SqlParameter p_password = Util.NewSqlParameter("@p_password", SqlDbType.VarChar, password, 50);
            SqlParameter p_phone = Util.NewSqlParameter("@p_phone", SqlDbType.VarChar, tb_phone.Text,50);
            SqlParameter p_beizhu = Util.NewSqlParameter("@p_beizhu", SqlDbType.VarChar, tb_beizhu.Text, 50);
            SqlParameter p_roleid = Util.NewSqlParameter("@p_roleid", SqlDbType.TinyInt, (cb_roleid.Text.Trim() == "操作员") ? 0 : 1);
            SqlParameter p_id = Util.NewSqlParameter("@p_id", SqlDbType.Int, this.id);

            /* 判断登陆名是否重复 */
            string sql_count = "select COUNT(*) as total from Users where uname = @p_uname And id <> @p_id";
            DataRow row = SqlHelper.GetFirstRowBySQL(sql_count, p_uname, @p_id);
            if (Convert.ToInt32(row["total"]) > 0)
            {
                MessageBox.Show("操作失败：“登录名”已存在！");
                return;
            }

            /* 执行编辑操作 */
            SqlParameter[] paras = new SqlParameter[]{p_uname, p_xingming, p_password, p_phone, p_beizhu, p_roleid, p_id};
            string sql = string.Format(@"
                            update Users
                            set
                                uname = @p_uname,
                                password = @p_password,
                                phone = @p_phone,
                                beizhu = @p_beizhu,
                                roleid = @p_roleid,
                                xingming = @p_xingming
                            where ID = @p_ID
                        ");
            int affect = SqlHelper.ExecuteNonQuery(sql, paras);
            if (affect == 1)
            {
                MessageBox.Show("修改成功！");
                //Util.console_log(string.Format("添加项目：{0}（{1}） {2}", tb_xingming.Text, tb_uname.Text, cbProject_bd.Text));
                this.IsEdited = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败！");
            }

        }

        // 窗体关闭事件
        private void FrmProjectAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.IsEdited == true)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        /// <summary>
        /// 根据项目ID拉取信息
        /// </summary>
        /// <param name="pid"></param>
        private void Copy(int id)
        {
            string sql = "select * from Users where ID = " + id;
            DataTable table = SqlHelper.GetDataTableBySQL(sql);
            if (table.Rows.Count != 1)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            DataRow row = table.Rows[0];
            
            tb_uname.Text = row["uname"].ToString();
            tb_xingming.Text = row["xingming"].ToString();
            tb_password.Text = row["password"].ToString();
            tb_phone.Text = row["phone"].ToString();
            tb_beizhu.Text = row["beizhu"].ToString();
            cb_roleid.SelectedIndex = Util.IntTryParse(row["roleid"].ToString());
        }

    }
}
