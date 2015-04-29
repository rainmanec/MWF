namespace ZHBB
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.车辆管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.种类管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.采购单位管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.车辆出厂ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.明细查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.汇总查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.年报ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.月报ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_config = new System.Windows.Forms.ToolStripMenuItem();
            this.系统配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.密码修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem,
            this.车辆管理ToolStripMenuItem,
            this.种类管理ToolStripMenuItem,
            this.采购单位管理ToolStripMenuItem,
            this.车辆出厂ToolStripMenuItem,
            this.查询ToolStripMenuItem,
            this.tsmi_config,
            this.tsmi_logout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(894, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            this.用户管理ToolStripMenuItem.Click += new System.EventHandler(this.用户管理ToolStripMenuItem_Click);
            // 
            // 车辆管理ToolStripMenuItem
            // 
            this.车辆管理ToolStripMenuItem.Name = "车辆管理ToolStripMenuItem";
            this.车辆管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.车辆管理ToolStripMenuItem.Text = "车辆管理";
            this.车辆管理ToolStripMenuItem.Click += new System.EventHandler(this.车辆管理ToolStripMenuItem_Click);
            // 
            // 种类管理ToolStripMenuItem
            // 
            this.种类管理ToolStripMenuItem.Name = "种类管理ToolStripMenuItem";
            this.种类管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.种类管理ToolStripMenuItem.Text = "料种管理";
            this.种类管理ToolStripMenuItem.Click += new System.EventHandler(this.种类管理ToolStripMenuItem_Click);
            // 
            // 采购单位管理ToolStripMenuItem
            // 
            this.采购单位管理ToolStripMenuItem.Name = "采购单位管理ToolStripMenuItem";
            this.采购单位管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.采购单位管理ToolStripMenuItem.Text = "采购单位管理";
            this.采购单位管理ToolStripMenuItem.Click += new System.EventHandler(this.采购单位管理ToolStripMenuItem_Click);
            // 
            // 车辆出厂ToolStripMenuItem
            // 
            this.车辆出厂ToolStripMenuItem.Name = "车辆出厂ToolStripMenuItem";
            this.车辆出厂ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.车辆出厂ToolStripMenuItem.Text = "车辆出厂";
            this.车辆出厂ToolStripMenuItem.Click += new System.EventHandler(this.车辆出厂ToolStripMenuItem_Click);
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.明细查询ToolStripMenuItem,
            this.汇总查询ToolStripMenuItem,
            this.年报ToolStripMenuItem,
            this.月报ToolStripMenuItem});
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.查询ToolStripMenuItem.Text = "查询";
            // 
            // 明细查询ToolStripMenuItem
            // 
            this.明细查询ToolStripMenuItem.Name = "明细查询ToolStripMenuItem";
            this.明细查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.明细查询ToolStripMenuItem.Text = "明细查询";
            this.明细查询ToolStripMenuItem.Click += new System.EventHandler(this.明细查询ToolStripMenuItem_Click);
            // 
            // 汇总查询ToolStripMenuItem
            // 
            this.汇总查询ToolStripMenuItem.Name = "汇总查询ToolStripMenuItem";
            this.汇总查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.汇总查询ToolStripMenuItem.Text = "汇总查询";
            this.汇总查询ToolStripMenuItem.Click += new System.EventHandler(this.汇总查询ToolStripMenuItem_Click);
            // 
            // 年报ToolStripMenuItem
            // 
            this.年报ToolStripMenuItem.Name = "年报ToolStripMenuItem";
            this.年报ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.年报ToolStripMenuItem.Text = "年报";
            this.年报ToolStripMenuItem.Click += new System.EventHandler(this.年报ToolStripMenuItem_Click);
            // 
            // 月报ToolStripMenuItem
            // 
            this.月报ToolStripMenuItem.Name = "月报ToolStripMenuItem";
            this.月报ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.月报ToolStripMenuItem.Text = "月报";
            this.月报ToolStripMenuItem.Click += new System.EventHandler(this.月报ToolStripMenuItem_Click);
            // 
            // tsmi_config
            // 
            this.tsmi_config.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统配置ToolStripMenuItem,
            this.密码修改ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.tsmi_config.Name = "tsmi_config";
            this.tsmi_config.Size = new System.Drawing.Size(68, 21);
            this.tsmi_config.Text = "系统设置";
            // 
            // 系统配置ToolStripMenuItem
            // 
            this.系统配置ToolStripMenuItem.Name = "系统配置ToolStripMenuItem";
            this.系统配置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.系统配置ToolStripMenuItem.Text = "系统配置";
            this.系统配置ToolStripMenuItem.Click += new System.EventHandler(this.系统配置ToolStripMenuItem_Click);
            // 
            // 密码修改ToolStripMenuItem
            // 
            this.密码修改ToolStripMenuItem.Name = "密码修改ToolStripMenuItem";
            this.密码修改ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.密码修改ToolStripMenuItem.Text = "密码修改";
            this.密码修改ToolStripMenuItem.Click += new System.EventHandler(this.密码修改ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // tsmi_logout
            // 
            this.tsmi_logout.Name = "tsmi_logout";
            this.tsmi_logout.Size = new System.Drawing.Size(44, 21);
            this.tsmi_logout.Text = "退出";
            this.tsmi_logout.Click += new System.EventHandler(this.tsmi_logout_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 363);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "瀚臣采石厂信息管理系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_logout;
        private System.Windows.Forms.ToolStripMenuItem tsmi_config;
        private System.Windows.Forms.ToolStripMenuItem 密码修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 车辆管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 车辆出厂ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 种类管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 采购单位管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 明细查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 汇总查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 年报ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 月报ToolStripMenuItem;

    }
}

