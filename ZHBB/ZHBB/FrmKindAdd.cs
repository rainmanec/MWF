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
    public partial class FrmKindAdd : Form
    {
        public bool IsAdded = false;  // 是否添加过用户

        public FrmKindAdd()
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
                MessageBox.Show("种类不能为空");
                tb_Title.Focus();
                return;
            }

            // 整理参数
            SqlParameter p_Title = Util.NewSqlParameter("@p_Title", SqlDbType.VarChar, title, 50);

            /* 判断登陆名是否重复 */
            string sql_count = "select COUNT(*) as total from Kinds where Title = @p_Title";
            DataRow row = SqlHelper.GetFirstRowBySQL(sql_count, p_Title);
            if (Convert.ToInt32(row["total"]) > 0)
            {
                MessageBox.Show("操作失败：种类已存在！");
                return;
            }

            /* 执行添加操作 */
            SqlParameter[] paras = new SqlParameter[]{p_Title};            
            string sql = @"insert 
                            into Kinds(Title) 
                            values (@p_Title)";
            int affect = SqlHelper.ExecuteNonQuery(sql, paras);
            if (affect == 1)
            {
                MessageBox.Show("添加成功！");
                //Util.console_log(string.Format("添加项目：{0}（{1}） {2}", tb_xingming.Text, tb_uname.Text, cbProject_bd.Text));
                tb_Title.Text = "";
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


        private void FrmKindAdd_Load(object sender, EventArgs e)
        {

        }

    }
}
