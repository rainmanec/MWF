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
    public partial class FrmCompanyEdit : Form
    {
        public bool IsEdited = false;  // 是否添加过用户

        public int id;

        public FrmCompanyEdit()
        {
            InitializeComponent();
        }

        private void FrmCompanyEdit_Load(object sender, EventArgs e)
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
            string gsm = tb_chepai.Text.Trim();
            string owner = tb_owner.Text.Trim();
            string phone = tb_phone.Text.Trim();
            string address = tb_address.Text.Trim();
            string beizhu = tb_beizhu.Text.Trim();

            if (gsm == "")
            {
                MessageBox.Show("单位名称不能为空");
                tb_chepai.Focus();
                return;
            }
            string likevalue = Util.GetLikeValue(gsm);

            // 整理参数
            SqlParameter p_gsm = Util.NewSqlParameter("@p_gsm", SqlDbType.VarChar, gsm, 50);
            SqlParameter p_owner = Util.NewSqlParameter("@p_owner", SqlDbType.VarChar, owner, 50);
            SqlParameter p_phone = Util.NewSqlParameter("@p_phone", SqlDbType.VarChar, phone, 50);
            SqlParameter p_address = Util.NewSqlParameter("@p_address", SqlDbType.VarChar, address,50);
            SqlParameter p_beizhu = Util.NewSqlParameter("@p_beizhu", SqlDbType.VarChar, beizhu, 50);
            SqlParameter p_id = Util.NewSqlParameter("@p_id", SqlDbType.Int, this.id);
            SqlParameter p_likevalue = Util.NewSqlParameter("@p_likevalue", SqlDbType.VarChar, likevalue, 100);

            /* 判断登陆名是否重复 */
            string sql_count = "select COUNT(*) as total from Company where gsm = @p_gsm AND ID <> " + this.id;
            DataRow row = SqlHelper.GetFirstRowBySQL(sql_count, p_gsm);
            if (Convert.ToInt32(row["total"]) > 0)
            {
                MessageBox.Show("操作失败：公司已存在！");
                return;
            }

            /* 执行编辑操作 */
            SqlParameter[] paras = new SqlParameter[] { p_gsm, p_owner, p_phone, p_address, p_beizhu, p_id, p_likevalue };   
            string sql = string.Format(@"
                            update Company
                            set
                                gsm = @p_gsm,
                                owner = @p_owner,
                                phone = @p_phone,
                                address = @p_address,
                                beizhu = @p_beizhu,
                                likevalue = @p_likevalue
                            where ID = @p_id
                        ");
            int affect = SqlHelper.ExecuteNonQuery(sql, paras);
            if (affect == 1)
            {
                MessageBox.Show("编辑成功！");
                //Util.console_log(string.Format("添加项目：{0}（{1}） {2}", tb_xingming.Text, tb_uname.Text, cbProject_bd.Text));
                this.IsEdited = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        // 窗体关闭事件
        private void FrmProjectAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = (this.IsEdited == true) ? DialogResult.OK : DialogResult.Cancel;
        }

        /// <summary>
        /// 根据项目ID拉取信息
        /// </summary>
        /// <param name="pid"></param>
        private void Copy(int id)
        {
            string sql = "select * from Company where ID = " + id;
            DataTable table = SqlHelper.GetDataTableBySQL(sql);
            if (table.Rows.Count != 1)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            DataRow row = table.Rows[0];

            tb_chepai.Text = row["Gsm"].ToString();
            tb_owner.Text = row["owner"].ToString();
            tb_phone.Text = row["phone"].ToString();
            tb_address.Text = row["address"].ToString();
            tb_beizhu.Text = row["beizhu"].ToString();
        }
    }
}
