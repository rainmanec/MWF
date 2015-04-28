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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecordOut));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_cp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_getWeight = new System.Windows.Forms.Button();
            this.cb_kind = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_NetWeight = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_InTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_InWeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_other = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_OutWeight = new System.Windows.Forms.TextBox();
            this.tb_chepai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_suggest = new System.Windows.Forms.DataGridView();
            this.dgv_out_records = new System.Windows.Forms.DataGridView();
            this.groupBox_out = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_suggest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_out_records)).BeginInit();
            this.groupBox_out.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox_out);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 247);
            this.panel1.TabIndex = 0;
            // 
            // tb_cp
            // 
            this.tb_cp.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_cp.Location = new System.Drawing.Point(96, 60);
            this.tb_cp.Name = "tb_cp";
            this.tb_cp.ReadOnly = true;
            this.tb_cp.Size = new System.Drawing.Size(236, 21);
            this.tb_cp.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(28, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 22;
            this.label11.Text = "采购单位：";
            // 
            // btn_getWeight
            // 
            this.btn_getWeight.FlatAppearance.BorderSize = 0;
            this.btn_getWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_getWeight.Image = ((System.Drawing.Image)(resources.GetObject("btn_getWeight.Image")));
            this.btn_getWeight.Location = new System.Drawing.Point(361, 91);
            this.btn_getWeight.Name = "btn_getWeight";
            this.btn_getWeight.Size = new System.Drawing.Size(24, 22);
            this.btn_getWeight.TabIndex = 4;
            this.btn_getWeight.UseVisualStyleBackColor = true;
            this.btn_getWeight.Click += new System.EventHandler(this.btn_getWeight_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(39, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "种  类：";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(338, 168);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(17, 12);
            this.lb_id.TabIndex = 17;
            this.lb_id.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "吨";
            // 
            // tb_NetWeight
            // 
            this.tb_NetWeight.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_NetWeight.Location = new System.Drawing.Point(96, 128);
            this.tb_NetWeight.Name = "tb_NetWeight";
            this.tb_NetWeight.ReadOnly = true;
            this.tb_NetWeight.Size = new System.Drawing.Size(236, 21);
            this.tb_NetWeight.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(40, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "净重量：";
            // 
            // tb_InTime
            // 
            this.tb_InTime.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_InTime.Location = new System.Drawing.Point(96, 27);
            this.tb_InTime.Name = "tb_InTime";
            this.tb_InTime.ReadOnly = true;
            this.tb_InTime.Size = new System.Drawing.Size(236, 21);
            this.tb_InTime.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(28, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "进厂时间：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "吨";
            // 
            // tb_InWeight
            // 
            this.tb_InWeight.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_InWeight.Location = new System.Drawing.Point(96, 93);
            this.tb_InWeight.Name = "tb_InWeight";
            this.tb_InWeight.ReadOnly = true;
            this.tb_InWeight.Size = new System.Drawing.Size(236, 21);
            this.tb_InWeight.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(28, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "进厂重量：";
            // 
            // tb_other
            // 
            this.tb_other.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_other.Location = new System.Drawing.Point(95, 127);
            this.tb_other.Name = "tb_other";
            this.tb_other.Size = new System.Drawing.Size(236, 21);
            this.tb_other.TabIndex = 5;
            this.tb_other.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_price_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(39, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "其  他：";
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_submit.Location = new System.Drawing.Point(95, 163);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(236, 23);
            this.btn_submit.TabIndex = 6;
            this.btn_submit.Text = "提交";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(24, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "出厂重量：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "车牌号：";
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
            this.dgv_suggest.TabIndex = 1;
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
            this.dgv_out_records.Size = new System.Drawing.Size(901, 312);
            this.dgv_out_records.TabIndex = 1;
            this.dgv_out_records.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_out_records_CellContentClick);
            // 
            // groupBox_out
            // 
            this.groupBox_out.Controls.Add(this.label1);
            this.groupBox_out.Controls.Add(this.label2);
            this.groupBox_out.Controls.Add(this.btn_getWeight);
            this.groupBox_out.Controls.Add(this.tb_chepai);
            this.groupBox_out.Controls.Add(this.cb_kind);
            this.groupBox_out.Controls.Add(this.tb_OutWeight);
            this.groupBox_out.Controls.Add(this.label4);
            this.groupBox_out.Controls.Add(this.label3);
            this.groupBox_out.Controls.Add(this.lb_id);
            this.groupBox_out.Controls.Add(this.btn_submit);
            this.groupBox_out.Controls.Add(this.tb_other);
            this.groupBox_out.Controls.Add(this.label5);
            this.groupBox_out.Location = new System.Drawing.Point(28, 21);
            this.groupBox_out.Name = "groupBox_out";
            this.groupBox_out.Size = new System.Drawing.Size(415, 206);
            this.groupBox_out.TabIndex = 62;
            this.groupBox_out.TabStop = false;
            this.groupBox_out.Text = "出厂信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_InWeight);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tb_cp);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tb_InTime);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tb_NetWeight);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(496, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 206);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "入厂信息";
            // 
            // FrmRecordOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 559);
            this.Controls.Add(this.dgv_suggest);
            this.Controls.Add(this.dgv_out_records);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRecordOut";
            this.Tag = "FrmRecordOut";
            this.Text = "车厂出场";
            this.Load += new System.EventHandler(this.FrmRecordOut_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_suggest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_out_records)).EndInit();
            this.groupBox_out.ResumeLayout(false);
            this.groupBox_out.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.TextBox tb_InTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_kind;
        private System.Windows.Forms.Button btn_getWeight;
        private System.Windows.Forms.TextBox tb_cp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox_out;

    }
}