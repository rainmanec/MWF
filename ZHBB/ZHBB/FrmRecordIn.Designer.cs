namespace ZHBB
{
    partial class FrmRecordIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecordIn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_chepai = new System.Windows.Forms.TextBox();
            this.btn_getWeight = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_cp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.tb_InWeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_cars = new System.Windows.Forms.DataGridView();
            this.dgv_in_records = new System.Windows.Forms.DataGridView();
            this.dgv_company = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_in_records)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_company)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_chepai);
            this.panel1.Controls.Add(this.btn_getWeight);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_cp);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_submit);
            this.panel1.Controls.Add(this.tb_InWeight);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 168);
            this.panel1.TabIndex = 0;
            // 
            // tb_chepai
            // 
            this.tb_chepai.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_chepai.Location = new System.Drawing.Point(101, 24);
            this.tb_chepai.Name = "tb_chepai";
            this.tb_chepai.Size = new System.Drawing.Size(247, 21);
            this.tb_chepai.TabIndex = 1;
            this.tb_chepai.TextChanged += new System.EventHandler(this.tb_chepai_TextChanged);
            this.tb_chepai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_chepai_KeyDown);
            this.tb_chepai.Leave += new System.EventHandler(this.tb_chepai_Leave);
            // 
            // btn_getWeight
            // 
            this.btn_getWeight.FlatAppearance.BorderSize = 0;
            this.btn_getWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_getWeight.Image = ((System.Drawing.Image)(resources.GetObject("btn_getWeight.Image")));
            this.btn_getWeight.Location = new System.Drawing.Point(379, 93);
            this.btn_getWeight.Name = "btn_getWeight";
            this.btn_getWeight.Size = new System.Drawing.Size(24, 22);
            this.btn_getWeight.TabIndex = 4;
            this.btn_getWeight.UseVisualStyleBackColor = true;
            this.btn_getWeight.Click += new System.EventHandler(this.btn_getWeight_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(30, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "采购单位：";
            // 
            // tb_cp
            // 
            this.tb_cp.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_cp.Location = new System.Drawing.Point(101, 61);
            this.tb_cp.Name = "tb_cp";
            this.tb_cp.Size = new System.Drawing.Size(247, 21);
            this.tb_cp.TabIndex = 2;
            this.tb_cp.TextChanged += new System.EventHandler(this.tb_cp_TextChanged);
            this.tb_cp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_cp_KeyDown);
            this.tb_cp.Leave += new System.EventHandler(this.tb_cp_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "吨";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "车牌号：";
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_submit.Location = new System.Drawing.Point(101, 126);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(247, 23);
            this.btn_submit.TabIndex = 5;
            this.btn_submit.Text = "提交";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // tb_InWeight
            // 
            this.tb_InWeight.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_InWeight.Location = new System.Drawing.Point(101, 94);
            this.tb_InWeight.Name = "tb_InWeight";
            this.tb_InWeight.Size = new System.Drawing.Size(247, 21);
            this.tb_InWeight.TabIndex = 3;
            this.tb_InWeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_InWeight_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(30, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "进入重量：";
            // 
            // dgv_cars
            // 
            this.dgv_cars.AllowUserToAddRows = false;
            this.dgv_cars.AllowUserToDeleteRows = false;
            this.dgv_cars.AllowUserToResizeColumns = false;
            this.dgv_cars.AllowUserToResizeRows = false;
            this.dgv_cars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_cars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cars.Location = new System.Drawing.Point(573, 271);
            this.dgv_cars.MultiSelect = false;
            this.dgv_cars.Name = "dgv_cars";
            this.dgv_cars.ReadOnly = true;
            this.dgv_cars.RowHeadersVisible = false;
            this.dgv_cars.RowTemplate.Height = 23;
            this.dgv_cars.Size = new System.Drawing.Size(182, 246);
            this.dgv_cars.TabIndex = 1;
            this.dgv_cars.Visible = false;
            // 
            // dgv_in_records
            // 
            this.dgv_in_records.AllowUserToAddRows = false;
            this.dgv_in_records.AllowUserToDeleteRows = false;
            this.dgv_in_records.AllowUserToResizeRows = false;
            this.dgv_in_records.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_in_records.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_in_records.Location = new System.Drawing.Point(0, 168);
            this.dgv_in_records.Name = "dgv_in_records";
            this.dgv_in_records.ReadOnly = true;
            this.dgv_in_records.RowTemplate.Height = 23;
            this.dgv_in_records.Size = new System.Drawing.Size(906, 460);
            this.dgv_in_records.TabIndex = 100;
            this.dgv_in_records.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_in_records_CellContentClick);
            // 
            // dgv_company
            // 
            this.dgv_company.AllowUserToAddRows = false;
            this.dgv_company.AllowUserToDeleteRows = false;
            this.dgv_company.AllowUserToResizeColumns = false;
            this.dgv_company.AllowUserToResizeRows = false;
            this.dgv_company.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_company.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_company.Location = new System.Drawing.Point(252, 271);
            this.dgv_company.MultiSelect = false;
            this.dgv_company.Name = "dgv_company";
            this.dgv_company.ReadOnly = true;
            this.dgv_company.RowHeadersVisible = false;
            this.dgv_company.RowTemplate.Height = 23;
            this.dgv_company.Size = new System.Drawing.Size(264, 246);
            this.dgv_company.TabIndex = 2;
            this.dgv_company.Visible = false;
            // 
            // FrmRecordIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 628);
            this.Controls.Add(this.dgv_company);
            this.Controls.Add(this.dgv_cars);
            this.Controls.Add(this.dgv_in_records);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRecordIn";
            this.Tag = "FrmRecordIn";
            this.Text = "车辆进厂";
            this.Load += new System.EventHandler(this.FrmRecordAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_in_records)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_company)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_InWeight;
        private System.Windows.Forms.TextBox tb_chepai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_cars;
        private System.Windows.Forms.DataGridView dgv_in_records;
        private System.Windows.Forms.Button btn_getWeight;
        private System.Windows.Forms.TextBox tb_cp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_company;

    }
}