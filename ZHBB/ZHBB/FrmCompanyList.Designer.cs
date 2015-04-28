namespace ZHBB
{
    partial class FrmCompanyList
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
            this.btn_car_add = new System.Windows.Forms.Button();
            this.tb_serch = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.paginator1 = new MYUI.Paginator();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.paginator1);
            this.panel1.Controls.Add(this.btn_car_add);
            this.panel1.Controls.Add(this.tb_serch);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 50);
            this.panel1.TabIndex = 0;
            // 
            // btn_car_add
            // 
            this.btn_car_add.Location = new System.Drawing.Point(374, 12);
            this.btn_car_add.Name = "btn_car_add";
            this.btn_car_add.Size = new System.Drawing.Size(93, 23);
            this.btn_car_add.TabIndex = 2;
            this.btn_car_add.Text = "添加采购单位";
            this.btn_car_add.UseVisualStyleBackColor = true;
            this.btn_car_add.Click += new System.EventHandler(this.btn_car_add_Click);
            // 
            // tb_serch
            // 
            this.tb_serch.Location = new System.Drawing.Point(13, 13);
            this.tb_serch.Name = "tb_serch";
            this.tb_serch.Size = new System.Drawing.Size(254, 21);
            this.tb_serch.TabIndex = 1;
            this.tb_serch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_serch_KeyUp);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(284, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "搜索";
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
            this.dgv_main.Size = new System.Drawing.Size(906, 336);
            this.dgv_main.TabIndex = 1;
            this.dgv_main.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_main_CellContentClick);
            // 
            // paginator1
            // 
            this.paginator1.Location = new System.Drawing.Point(483, 11);
            this.paginator1.Name = "paginator1";
            this.paginator1.Size = new System.Drawing.Size(382, 23);
            this.paginator1.TabIndex = 5;
            this.paginator1.PageChanged += new MYUI.Paginator.PageChangeHandle(this.paginator1_PageChanged);
            this.paginator1.ExportExcel += new MYUI.Paginator.ExportExcelHandle(this.paginator1_ExportExcel);
            // 
            // FrmCompanyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 386);
            this.Controls.Add(this.dgv_main);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCompanyList";
            this.Tag = "FrmCompanyList";
            this.Text = "采购单位管理";
            this.Load += new System.EventHandler(this.FrmListUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_main;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_serch;
        private System.Windows.Forms.Button btn_car_add;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MYUI.Paginator paginator1;
    }
}