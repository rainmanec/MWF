namespace ZHBB
{
    partial class FrmSearchNotOut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_delete_all = new System.Windows.Forms.Button();
            this.paginator1 = new MYUI.Paginator();
            this.btn_search = new System.Windows.Forms.Button();
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_delete_all);
            this.panel1.Controls.Add(this.paginator1);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 50);
            this.panel1.TabIndex = 0;
            this.panel1.Tag = "FrmSearchNotOut";
            // 
            // btn_delete_all
            // 
            this.btn_delete_all.Location = new System.Drawing.Point(108, 13);
            this.btn_delete_all.Name = "btn_delete_all";
            this.btn_delete_all.Size = new System.Drawing.Size(95, 23);
            this.btn_delete_all.TabIndex = 4;
            this.btn_delete_all.Text = "删除所有记录";
            this.btn_delete_all.UseVisualStyleBackColor = true;
            this.btn_delete_all.Click += new System.EventHandler(this.btn_delete_all_Click);
            // 
            // paginator1
            // 
            this.paginator1.Location = new System.Drawing.Point(232, 13);
            this.paginator1.Name = "paginator1";
            this.paginator1.Size = new System.Drawing.Size(382, 23);
            this.paginator1.TabIndex = 3;
            this.paginator1.PageChanged += new MYUI.Paginator.PageChangeHandle(this.paginator1_PageChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(12, 13);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "重新检索";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dgv_main
            // 
            this.dgv_main.AllowUserToAddRows = false;
            this.dgv_main.AllowUserToDeleteRows = false;
            this.dgv_main.AllowUserToResizeRows = false;
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_main.Location = new System.Drawing.Point(0, 50);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.RowTemplate.Height = 23;
            this.dgv_main.Size = new System.Drawing.Size(662, 336);
            this.dgv_main.TabIndex = 1;
            this.dgv_main.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_main_CellContentClick);
            // 
            // FrmSearchNotOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 386);
            this.Controls.Add(this.dgv_main);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSearchNotOut";
            this.Tag = "FrmSearchNotOut";
            this.Text = "未出厂车辆";
            this.Load += new System.EventHandler(this.FrmListUser_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_main;
        private System.Windows.Forms.Button btn_search;
        private MYUI.Paginator paginator1;
        private System.Windows.Forms.Button btn_delete_all;
    }
}