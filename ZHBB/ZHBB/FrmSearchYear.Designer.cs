namespace ZHBB
{
    partial class FrmSearchYear
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
            this.lb_year = new System.Windows.Forms.Label();
            this.lb_sum = new System.Windows.Forms.Label();
            this.btn_excel = new System.Windows.Forms.Button();
            this.dtp_year = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.dgv_records = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_records)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_year);
            this.panel1.Controls.Add(this.lb_sum);
            this.panel1.Controls.Add(this.btn_excel);
            this.panel1.Controls.Add(this.dtp_year);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_submit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 57);
            this.panel1.TabIndex = 0;
            // 
            // lb_year
            // 
            this.lb_year.AutoSize = true;
            this.lb_year.Location = new System.Drawing.Point(212, 20);
            this.lb_year.Name = "lb_year";
            this.lb_year.Size = new System.Drawing.Size(29, 12);
            this.lb_year.TabIndex = 25;
            this.lb_year.Text = "年份";
            // 
            // lb_sum
            // 
            this.lb_sum.AutoSize = true;
            this.lb_sum.Location = new System.Drawing.Point(471, 20);
            this.lb_sum.Name = "lb_sum";
            this.lb_sum.Size = new System.Drawing.Size(65, 12);
            this.lb_sum.TabIndex = 24;
            this.lb_sum.Text = "净重合计：";
            // 
            // btn_excel
            // 
            this.btn_excel.AutoSize = true;
            this.btn_excel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_excel.Location = new System.Drawing.Point(371, 15);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(75, 23);
            this.btn_excel.TabIndex = 21;
            this.btn_excel.Text = "导出Excel";
            this.btn_excel.UseVisualStyleBackColor = true;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // dtp_year
            // 
            this.dtp_year.Location = new System.Drawing.Point(79, 16);
            this.dtp_year.Name = "dtp_year";
            this.dtp_year.Size = new System.Drawing.Size(120, 21);
            this.dtp_year.TabIndex = 10;
            this.dtp_year.ValueChanged += new System.EventHandler(this.dtp_begin_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "年份：";
            // 
            // btn_submit
            // 
            this.btn_submit.AutoSize = true;
            this.btn_submit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_submit.Location = new System.Drawing.Point(267, 15);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(79, 23);
            this.btn_submit.TabIndex = 5;
            this.btn_submit.Text = "提交";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // dgv_records
            // 
            this.dgv_records.AllowUserToAddRows = false;
            this.dgv_records.AllowUserToDeleteRows = false;
            this.dgv_records.AllowUserToResizeRows = false;
            this.dgv_records.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_records.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_records.Location = new System.Drawing.Point(0, 57);
            this.dgv_records.Name = "dgv_records";
            this.dgv_records.ReadOnly = true;
            this.dgv_records.RowTemplate.Height = 23;
            this.dgv_records.Size = new System.Drawing.Size(847, 456);
            this.dgv_records.TabIndex = 1;
            this.dgv_records.Tag = "";
            // 
            // FrmSearchYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 513);
            this.Controls.Add(this.dgv_records);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSearchYear";
            this.Tag = "FrmSearchYear";
            this.Text = "汇总查询-年报";
            this.Load += new System.EventHandler(this.FrmRecordAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_records)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.DataGridView dgv_records;
        private System.Windows.Forms.DateTimePicker dtp_year;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lb_sum;
        private System.Windows.Forms.Label lb_year;

    }
}