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
    public partial class FrmKindEdit : Form
    {
        public int id;
        public bool IsEdited = false;
        private void FrmKindEdit_Load(object sender, EventArgs e)
        {
            this.Copy(this.id);
        }

        public FrmKindEdit()
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
            string title = tb_Title.Text.Trim();

            if (title == "")
            {
                MessageBox.Show("种类名不能为空");
                tb_Title.Focus();
                return;
            }

            // 整理参数
            SqlParameter p_Title = Util.NewSqlParameter("@p_Title", SqlDbType.VarChar, title, 50);
            SqlParameter p_id = Util.NewSqlParameter("@p_id", SqlDbType.Int, this.id);

            /* 判断登陆名是否重复 */
            string sql_count = "select COUNT(*) as total from Kinds where Title = @p_Title And id <> @p_id";
            DataRow row = SqlHelper.GetFirstRowBySQL(sql_count, p_Title, @p_id);
            if (Convert.ToInt32(row["total"]) > 0)
            {
                MessageBox.Show("操作失败：种类已存在！");
                return;
            }

            /* 执行编辑操作 */
            string sql = string.Format(@"update Kinds set Title = @p_Title where ID = @p_id");
            int affect = SqlHelper.ExecuteNonQuery(sql, p_Title, p_id);
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
            string sql = "select * from Kinds where ID = " + id;
            DataTable table = SqlHelper.GetDataTableBySQL(sql);
            if (table.Rows.Count != 1)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            DataRow row = table.Rows[0];
            
            tb_Title.Text = row["Title"].ToString();
        }

    }
}
