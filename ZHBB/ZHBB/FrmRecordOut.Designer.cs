namespace ZHBB
{
    partial class FrmRecordOut
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
            this.groupBox_in = new System.Windows.Forms.GroupBox();
            this.tb_InWeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_company = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_NetWeight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox_out = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_chepai = new System.Windows.Forms.TextBox();
            this.cb_kind = new System.Windows.Forms.ComboBox();
            this.tb_OutWeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.tb_other = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_suggest = new System.Windows.Forms.DataGridView();
            this.dgv_out_records = new System.Windows.Forms.DataGridView();
            this.dgv_company = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox_in.SuspendLayout();
            this.groupBox_out.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_suggest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_out_records)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_company)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox_in);
            this.panel1.Controls.Add(this.groupBox_out);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 247);
            this.panel1.TabIndex = 0;
            // 
            // groupBox_in
            // 
            this.groupBox_in.Controls.Add(this.tb_InWeight);
            this.groupBox_in.Controls.Add(this.label7);
            this.groupBox_in.Controls.Add(this.tb_company);
            this.groupBox_in.Controls.Add(this.label6);
            this.groupBox_in.Controls.Add(this.label11);
            this.groupBox_in.Controls.Add(this.label10);
            this.groupBox_in.Controls.Add(this.tb_NetWeight);
            this.groupBox_in.Controls.Add(this.label8);
            this.groupBox_in.Location = new System.Drawing.Point(439, 21);
            this.groupBox_in.Name = "groupBox_in";
            this.groupBox_in.Size = new System.Drawing.Size(379, 206);
            this.groupBox_in.TabIndex = 63;
            this.groupBox_in.TabStop = false;
            this.groupBox_in.Text = "车辆信息";
            // 
            // tb_InWeight
            // 
            this.tb_InWeight.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_InWeight.Location = new System.Drawing.Point(96, 57);
            this.tb_InWeight.Name = "tb_InWeight";
            this.tb_InWeight.Size = new System.Drawing.Size(236, 21);
            this.tb_InWeight.TabIndex = 6;
            this.tb_InWeight.TextChanged += new System.EventHandler(this.tb_InWeight_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(40, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "车  重：";
            // 
            // tb_company
            // 
            this.tb_company.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_company.Location = new System.Drawing.Point(96, 24);
            this.tb_company.Name = "tb_company";
            this.tb_company.Size = new System.Drawing.Size(236, 21);
            this.tb_company.TabIndex = 5;
            this.tb_company.TextChanged += new System.EventHandler(this.tb_company_TextChanged);
            this.tb_company.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_company_KeyDown);
            this.tb_company.Leave += new System.EventHandler(this.tb_company_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "吨";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(28, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 25;
            this.label11.Text = "采购单位：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(40, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 27;
            this.label10.Text = "净重量：";
            // 
            // tb_NetWeight
            // 
            this.tb_NetWeight.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_NetWeight.Location = new System.Drawing.Point(96, 92);
            this.tb_NetWeight.Name = "tb_NetWeight";
            this.tb_NetWeight.ReadOnly = true;
            this.tb_NetWeight.Size = new System.Drawing.Size(236, 21);
            this.tb_NetWeight.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "吨";
            // 
            // groupBox_out
            // 
            this.groupBox_out.Controls.Add(this.label1);
            this.groupBox_out.Controls.Add(this.label2);
            this.groupBox_out.Controls.Add(this.tb_chepai);
            this.groupBox_out.Controls.Add(this.cb_kind);
            this.groupBox_out.Controls.Add(this.tb_OutWeight);
            this.groupBox_out.Controls.Add(this.label4);
            this.groupBox_out.Controls.Add(this.label3);
            this.groupBox_out.Controls.Add(this.btn_submit);
            this.groupBox_out.Controls.Add(this.tb_other);
            this.groupBox_out.Controls.Add(this.label5);
            this.groupBox_out.Location = new System.Drawing.Point(28, 21);
            this.groupBox_out.Name = "groupBox_out";
            this.groupBox_out.Size = new System.Drawing.Size(381, 206);
            this.groupBox_out.TabIndex = 62;
            this.groupBox_out.TabStop = false;
            this.groupBox_out.Text = "出厂信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "车牌号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(24, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "出厂重量：";
            // 
            // tb_chepai
            // 
            this.tb_chepai.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_chepai.Location = new System.Drawing.Point(95, 27);
            this.tb_chepai.Name = "tb_chepai";
            this.tb_chepai.Size = new System.Drawing.Size(236, 21);
            this.tb_chepai.TabIndex = 1;
            this.tb_chepai.TextChanged += new System.EventHandler(this.tb_chepai_TextChanged);
            this.tb_chepai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_chepai_KeyDown);
            this.tb_chepai.Leave += new System.EventHandler(this.tb_chepai_Leave);
            // 
            // cb_kind
            // 
            this.cb_kind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_kind.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_kind.FormattingEnabled = true;
            this.cb_kind.Location = new System.Drawing.Point(95, 60);
            this.cb_kind.Name = "cb_kind";
            this.cb_kind.Size = new System.Drawing.Size(236, 20);
            this.cb_kind.TabIndex = 2;
            this.cb_kind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_kind_KeyDown);
            // 
            // tb_OutWeight
            // 
            this.tb_OutWeight.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_OutWeight.Location = new System.Drawing.Point(95, 92);
            this.tb_OutWeight.Name = "tb_OutWeight";
            this.tb_OutWeight.Size = new System.Drawing.Size(236, 21);
            this.tb_OutWeight.TabIndex = 3;
            this.tb_OutWeight.TextChanged += new System.EventHandler(this.tb_OutWeight_TextChanged);
            this.tb_OutWeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_OutWeight_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(39, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "种  类：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "吨";
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_submit.Location = new System.Drawing.Point(95, 163);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(236, 23);
            this.btn_submit.TabIndex = 8;
            this.btn_submit.Text = "提交";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // tb_other
            // 
            this.tb_other.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_other.Location = new System.Drawing.Point(95, 127);
            this.tb_other.Name = "tb_other";
            this.tb_other.Size = new System.Drawing.Size(236, 21);
            this.tb_other.TabIndex = 4;
            this.tb_other.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_other_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(39, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "其  他：";
            // 
            // dgv_suggest
            // 
            this.dgv_suggest.AllowUserToAddRows = false;
            this.dgv_suggest.AllowUserToDeleteRows = false;
            this.dgv_suggest.AllowUserToResizeColumns = false;
            this.dgv_suggest.AllowUserToResizeRows = false;
            this.dgv_suggest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_suggest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_suggest.Location = new System.Drawing.Point(524, 313);
            this.dgv_suggest.MultiSelect = false;
            this.dgv_suggest.Name = "dgv_suggest";
            this.dgv_suggest.ReadOnly = true;
            this.dgv_suggest.RowHeadersVisible = false;
            this.dgv_suggest.RowTemplate.Height = 23;
            this.dgv_suggest.Size = new System.Drawing.Size(323, 246);
            this.dgv_suggest.TabIndex = 32;
            this.dgv_suggest.Visible = false;
            // 
            // dgv_out_records
            // 
            this.dgv_out_records.AllowUserToAddRows = false;
            this.dgv_out_records.AllowUserToDeleteRows = false;
            this.dgv_out_records.AllowUserToResizeRows = false;
            this.dgv_out_records.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_out_records.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_out_records.Location = new System.Drawing.Point(0, 247);
            this.dgv_out_records.Name = "dgv_out_records";
            this.dgv_out_records.ReadOnly = true;
            this.dgv_out_records.RowTemplate.Height = 23;
            this.dgv_out_records.Size = new System.Drawing.Size(967, 312);
            this.dgv_out_records.TabIndex = 30;
            this.dgv_out_records.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_out_records_CellContentClick);
            // 
            // dgv_company
            // 
            this.dgv_company.AllowUserToAddRows = false;
            this.dgv_company.AllowUserToDeleteRows = false;
            this.dgv_company.AllowUserToResizeColumns = false;
            this.dgv_company.AllowUserToResizeRows = false;
            this.dgv_company.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_company.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_company.Location = new System.Drawing.Point(241, 313);
            this.dgv_company.MultiSelect = false;
            this.dgv_company.Name = "dgv_company";
            this.dgv_company.ReadOnly = true;
            this.dgv_company.RowHeadersVisible = false;
            this.dgv_company.RowTemplate.Height = 23;
            this.dgv_company.Size = new System.Drawing.Size(264, 246);
            this.dgv_company.TabIndex = 31;
            this.dgv_company.Visible = false;
            // 
            // FrmRecordOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 559);
            this.Controls.Add(this.dgv_company);
            this.Controls.Add(this.dgv_suggest);
            this.Controls.Add(this.dgv_out_records);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRecordOut";
            this.Tag = "FrmRecordOut";
            this.Text = "车厂出场";
            this.Load += new System.EventHandler(this.FrmRecordOut_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox_in.ResumeLayout(false);
            this.groupBox_in.PerformLayout();
            this.groupBox_out.ResumeLayout(false);
            this.groupBox_out.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_suggest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_out_records)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_company)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_OutWeight;
        private System.Windows.Forms.TextBox tb_chepai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_suggest;
        private System.Windows.Forms.DataGridView dgv_out_records;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_InWeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_other;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_NetWeight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_kind;
        private System.Windows.Forms.TextBox tb_company;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox_in;
        private System.Windows.Forms.GroupBox groupBox_out;
        private System.Windows.Forms.DataGridView dgv_company;

    }
}