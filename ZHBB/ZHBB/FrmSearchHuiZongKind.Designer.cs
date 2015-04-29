namespace ZHBB
{
    partial class FrmSearchHuiZongKind
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
            this.lb_sum = new System.Windows.Forms.Label();
            this.cb_cp = new System.Windows.Forms.CheckBox();
            this.cb_chepai = new System.Windows.Forms.CheckBox();
            this.btn_excel = new System.Windows.Forms.Button();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.dtp_begin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_records = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_records)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_sum);
            this.panel1.Controls.Add(this.cb_cp);
            this.panel1.Controls.Add(this.cb_chepai);
            this.panel1.Controls.Add(this.btn_excel);
            this.panel1.Controls.Add(this.dtp_end);
            this.panel1.Controls.Add(this.dtp_begin);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_submit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 113);
            this.panel1.TabIndex = 0;
            // 
            // lb_sum
            // 
            this.lb_sum.AutoSize = true;
            this.lb_sum.Location = new System.Drawing.Point(437, 76);
            this.lb_sum.Name = "lb_sum";
            this.lb_sum.Size = new System.Drawing.Size(65, 12);
            this.lb_sum.TabIndex = 24;
            this.lb_sum.Text = "净重合计：";
            // 
            // cb_cp
            // 
            this.cb_cp.AutoSize = true;
            this.cb_cp.Checked = true;
            this.cb_cp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_cp.Location = new System.Drawing.Point(91, 44);
            this.cb_cp.Name = "cb_cp";
            this.cb_cp.Size = new System.Drawing.Size(60, 16);
            this.cb_cp.TabIndex = 23;
            this.cb_cp.Text = "采购商";
            this.cb_cp.UseVisualStyleBackColor = true;
            // 
            // cb_chepai
            // 
            this.cb_chepai.AutoSize = true;
            this.cb_chepai.Checked = true;
            this.cb_chepai.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_chepai.Location = new System.Drawing.Point(264, 44);
            this.cb_chepai.Name = "cb_chepai";
            this.cb_chepai.Size = new System.Drawing.Size(60, 16);
            this.cb_chepai.TabIndex = 22;
            this.cb_chepai.Text = "车牌号";
            this.cb_chepai.UseVisualStyleBackColor = true;
            // 
            // btn_excel
            // 
            this.btn_excel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_excel.Location = new System.Drawing.Point(264, 70);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(155, 23);
            this.btn_excel.TabIndex = 21;
            this.btn_excel.Text = "导出Excel";
            this.btn_excel.UseVisualStyleBackColor = true;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(264, 10);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(155, 21);
            this.dtp_end.TabIndex = 11;
            // 
            // dtp_begin
            // 
            this.dtp_begin.Location = new System.Drawing.Point(91, 10);
            this.dtp_begin.Name = "dtp_begin";
            this.dtp_begin.Size = new System.Drawing.Size(155, 21);
            this.dtp_begin.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "时间段：";
            // 
            // btn_submit
            // 
            this.btn_submit.AutoSize = true;
            this.btn_submit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_submit.Location = new System.Drawing.Point(91, 70);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(155, 23);
            this.btn_submit.TabIndex = 5;
            this.btn_submit.Text = "提交";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "汇总口径：";
            // 
            // dgv_records
            // 
            this.dgv_records.AllowUserToAddRows = false;
            this.dgv_records.AllowUserToDeleteRows = false;
            this.dgv_records.AllowUserToResizeRows = false;
            this.dgv_records.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_records.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_records.Location = new System.Drawing.Point(0, 113);
            this.dgv_records.Name = "dgv_records";
            this.dgv_records.ReadOnly = true;
            this.dgv_records.RowTemplate.Height = 23;
            this.dgv_records.Size = new System.Drawing.Size(847, 400);
            this.dgv_records.TabIndex = 1;
            // 
            // FrmSearchHuiZongKind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 513);
            this.Controls.Add(this.dgv_records);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSearchHuiZongKind";
            this.Tag = "FrmSearchMonth";
            this.Text = "汇总查询-料种";
            this.Load += new System.EventHandler(this.FrmRecordAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_records)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_records;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.DateTimePicker dtp_begin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox cb_cp;
        private System.Windows.Forms.CheckBox cb_chepai;
        private System.Windows.Forms.Label lb_sum;

    }
}