namespace ZHBB
{
    partial class FrmCarEdit
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_owner = new System.Windows.Forms.TextBox();
            this.tb_chepai = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_beizhu = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_company = new System.Windows.Forms.TextBox();
            this.tb_weight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_company = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_company)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "电话：";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(100, 242);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(115, 23);
            this.btn_OK.TabIndex = 8;
            this.btn_OK.Text = "提交";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(243, 242);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(115, 23);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(365, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 12);
            this.label17.TabIndex = 60;
            this.label17.Text = "(必填）";
            // 
            // tb_owner
            // 
            this.tb_owner.Location = new System.Drawing.Point(100, 47);
            this.tb_owner.Name = "tb_owner";
            this.tb_owner.Size = new System.Drawing.Size(259, 21);
            this.tb_owner.TabIndex = 2;
            // 
            // tb_chepai
            // 
            this.tb_chepai.Location = new System.Drawing.Point(100, 18);
            this.tb_chepai.Name = "tb_chepai";
            this.tb_chepai.Size = new System.Drawing.Size(259, 21);
            this.tb_chepai.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(48, 175);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 14;
            this.label18.Text = "地址：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(48, 51);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 12);
            this.label19.TabIndex = 12;
            this.label19.Text = "车主：";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(36, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 11;
            this.label20.Text = "车牌号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "备注：";
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(100, 140);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(259, 21);
            this.tb_phone.TabIndex = 5;
            // 
            // tb_beizhu
            // 
            this.tb_beizhu.Location = new System.Drawing.Point(100, 204);
            this.tb_beizhu.Name = "tb_beizhu";
            this.tb_beizhu.Size = new System.Drawing.Size(258, 21);
            this.tb_beizhu.TabIndex = 7;
            this.tb_beizhu.Tag = "UserAdd";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(100, 171);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(259, 21);
            this.tb_address.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(360, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 72;
            this.label6.Text = "（必填）";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 71;
            this.label5.Text = "吨";
            // 
            // tb_company
            // 
            this.tb_company.Location = new System.Drawing.Point(99, 107);
            this.tb_company.Name = "tb_company";
            this.tb_company.Size = new System.Drawing.Size(259, 21);
            this.tb_company.TabIndex = 4;
            this.tb_company.TextChanged += new System.EventHandler(this.tb_company_TextChanged);
            this.tb_company.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_company_KeyDown);
            this.tb_company.Leave += new System.EventHandler(this.tb_company_Leave);
            // 
            // tb_weight
            // 
            this.tb_weight.Location = new System.Drawing.Point(99, 76);
            this.tb_weight.Name = "tb_weight";
            this.tb_weight.Size = new System.Drawing.Size(259, 21);
            this.tb_weight.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 70;
            this.label3.Text = "所属单位：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 69;
            this.label4.Text = "车重：";
            // 
            // dgv_company
            // 
            this.dgv_company.AllowUserToAddRows = false;
            this.dgv_company.AllowUserToDeleteRows = false;
            this.dgv_company.AllowUserToResizeColumns = false;
            this.dgv_company.AllowUserToResizeRows = false;
            this.dgv_company.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_company.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_company.Location = new System.Drawing.Point(417, 111);
            this.dgv_company.MultiSelect = false;
            this.dgv_company.Name = "dgv_company";
            this.dgv_company.ReadOnly = true;
            this.dgv_company.RowHeadersVisible = false;
            this.dgv_company.RowTemplate.Height = 23;
            this.dgv_company.Size = new System.Drawing.Size(264, 246);
            this.dgv_company.TabIndex = 73;
            this.dgv_company.Visible = false;
            // 
            // FrmCarEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 312);
            this.Controls.Add(this.dgv_company);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_company);
            this.Controls.Add(this.tb_weight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tb_beizhu);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tb_owner);
            this.Controls.Add(this.tb_chepai);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCarEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "FrmCarEdit";
            this.Text = "编辑车辆";
            this.Load += new System.EventHandler(this.FrmCarEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_company)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_owner;
        private System.Windows.Forms.TextBox tb_chepai;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_beizhu;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_company;
        private System.Windows.Forms.TextBox tb_weight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_company;
    }
}