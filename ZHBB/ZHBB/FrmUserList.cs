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
    public partial class FrmUserList : Form
    {
        public int id;

        public FrmUserList()
        {
            InitializeComponent();
        }

        private void FrmListUser_Load(object sender, EventArgs e)
        {
            this.LoadUsers();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.LoadUsers();
        }
        // 刷新最新录入的10条记录
        public void LoadUsers()
        {
            string sql = string.Format(@"
                            SELECT 
                                ID,
                                uname as '登录名',
                                xingming as '姓名',
                                password as '密码',
                                phone as '电话',
                                beizhu as '备注',
                                roleid,
                                '' as '角色'
                            FROM Users");
            DataTable table = SqlHelper.GetDataTableBySQL(sql);
            for (int i = 0;i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                if (row["roleid"].ToString() == "0")
                {
                    table.Rows[i]["角色"] = "操作员";
                }
                else
                {
                    table.Rows[i]["角色"] = "管理员";
                }
            }

            Util.DgvClear(dgv_main);
            dgv_main.DataSource = table;
            dgv_main.Columns["ID"].Visible = false;
            dgv_main.Columns["roleid"].Visible = false;

            DataGridViewButtonColumn dgv_button_col_edit = new DataGridViewButtonColumn();
            dgv_button_col_edit.Name = "编辑";
            dgv_button_col_edit.UseColumnTextForButtonValue = true;
            dgv_button_col_edit.Text = "编辑";
            dgv_button_col_edit.HeaderText = "编辑";
            dgv_main.Columns.Insert(dgv_main.Columns.Count, dgv_button_col_edit);
            dgv_main.Columns["编辑"].Width = 75;
            dgv_main.Columns["编辑"].DefaultCellStyle.Padding = new Padding(5, 0, 5, 0);

            DataGridViewButtonColumn dgv_button_col_del = new DataGridViewButtonColumn();
            dgv_button_col_del.Name = "删除";
            dgv_button_col_del.UseColumnTextForButtonValue = true;
            dgv_button_col_del.Text = "删除";
            dgv_button_col_del.HeaderText = "删除";
            dgv_main.Columns.Insert(dgv_main.Columns.Count, dgv_button_col_del);
            dgv_main.Columns["删除"].Width = 75;
            dgv_main.Columns["删除"].DefaultCellStyle.Padding = new Padding(5, 0, 5, 0);

        }

        private void dgv_main_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 如果点击的是表头则退出
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgv_main.Rows[e.RowIndex];
            this.id = Convert.ToInt32(row.Cells["ID"].Value);

            if (dgv_main.Columns[e.ColumnIndex].Name == "编辑")
            {
                FrmUserEdit frm = new FrmUserEdit();
                frm.id = this.id;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.LoadUsers();
                }
            }
            else if (dgv_main.Columns[e.ColumnIndex].Name == "删除")
            {
                if (MessageBox.Show("您确定要删除这条记录吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    SqlParameter p_id = new SqlParameter("@p_pid", SqlDbType.Int);
                    p_id.Value = this.id;
                    int affect = SqlHelper.ExecuteNonQuery("DELETE FROM Users WHERE ID = @p_pid", p_id);
                    if (affect == 1)
                    {
                        MessageBox.Show("删除成功！");
                        this.LoadUsers();
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                }
            }

        }

        /// <summary>
        /// 按钮：添加用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_user_add_Click(object sender, EventArgs e)
        {
            FrmUserAdd frm = new FrmUserAdd();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.LoadUsers();
            }
        }
    }
}
