using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZHBB
{
    public partial class FrmMain : Form
    {
        public int maxYear;     // 最大年
        public int minYear;     // 最小年
        public string uname;    // 用户名


        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 执行登录和版本检测
        /// </summary>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            // 版本检测
            DataRow data = SqlHelper.GetFirstRowBySQL("SELECT * FROM Config WHERE K = 'Version'");
            double version_t = Convert.ToDouble(data["V"].ToString());
            bool isVersion = true;
            if (AppData.version < version_t)
            {
                MessageBox.Show("您当前的软件版本过低，请联系管理员更新至V" + version_t.ToString("F1") + "！");
                isVersion = false;
            }
            else if (AppData.version > version_t)
            {
                MessageBox.Show("您当前的软件版本不正确，请联系管理员！");
                isVersion = false;
            }

            // 登陆
            if (isVersion == false)
            {
                this.Close();    // 关闭主窗体
            }
            else
            {
                FrmLogin frm = new FrmLogin();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.WindowState = FormWindowState.Maximized;
                    this.InitInterface();
                }
                else
                {
                    this.Close();    // 关闭主窗体
                }
            }

        }

        #region 辅助函数

        /// <summary>
        /// 辅助函数：关闭所有MdiChild窗体
        /// </summary>
        /// <param name="tag">窗体的类名</param>
        /// <returns></returns>
        public bool CloseMdiChildren(string tag)
        {
            foreach (Form frm in this.MdiChildren)
            {
                string type = frm.GetType().ToString();
                if (type.Substring(type.LastIndexOf(".") + 1) == tag)
                {
                    //frm.Activate();
                    frm.Close();
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 根据用户角色显示界面
        /// </summary>
        public void InitInterface()
        {
            int roleid = AppData.uroleid;
            if (roleid != 1)
            {
                用户管理ToolStripMenuItem.Visible = false;
                种类管理ToolStripMenuItem.Visible = false;
                查询ToolStripMenuItem.Visible = false;
                系统配置ToolStripMenuItem.Visible = false;

                this.CloseMdiChildren("FrmRecordIn");
                FrmRecordIn frm = new FrmRecordIn();
                frm.WindowState = FormWindowState.Maximized;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                this.CloseMdiChildren("FrmSearchMingXi");
                FrmSearchMingXi frm = new FrmSearchMingXi();
                frm.WindowState = FormWindowState.Maximized;
                frm.MdiParent = this;
                frm.Show();
            }
        }

        #endregion


        /// <summary>
        /// 帮助按钮
        /// </summary>
        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout frm = new FrmAbout();
            frm.ShowDialog();
        }

        /// <summary>
        /// 退出
        /// </summary>
        private void tsmi_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要退出吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Util.console_log("退出系统");
                this.Close();
            }
        }

        /// <summary>
        /// 密码修改按钮
        /// </summary>
        private void 密码修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPasswordEdit frm = new FrmPasswordEdit();
            frm.ShowDialog();
        }

        private void 车辆进厂ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseMdiChildren("FrmRecordIn");
            FrmRecordIn frm = new FrmRecordIn();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void 车辆出厂ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseMdiChildren("FrmRecordOut");
            FrmRecordOut frm = new FrmRecordOut();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseMdiChildren("FrmUserList");
            FrmUserList frm = new FrmUserList();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void 车辆管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseMdiChildren("FrmCarList");
            FrmCarList frm = new FrmCarList();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void 种类管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseMdiChildren("FrmKindList");
            FrmKindList frm = new FrmKindList();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void 采购单位管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseMdiChildren("FrmCompanyList");
            FrmCompanyList frm = new FrmCompanyList();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void 明细查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseMdiChildren("FrmSearchMingXi");
            FrmSearchMingXi frm = new FrmSearchMingXi();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void 汇总查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseMdiChildren("FrmSearchHuiZongKind");
            FrmSearchHuiZongKind frm = new FrmSearchHuiZongKind();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void 年报ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseMdiChildren("FrmSearchYear");
            FrmSearchYear frm = new FrmSearchYear();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void 月报ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseMdiChildren("FrmSearchMonth");
            FrmSearchMonth frm = new FrmSearchMonth();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void 未出厂记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseMdiChildren("FrmSearchNotOut");
            FrmSearchNotOut frm = new FrmSearchNotOut();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void 系统配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSysConfig frm = new FrmSysConfig();
            frm.ShowDialog();
        }

    
    }
}
