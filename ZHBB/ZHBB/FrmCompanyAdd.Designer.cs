namespace ZHBB
{
    partial class FrmCompanyAdd
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
            this.tb_Gsm = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_beizhu = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "电话：";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(100, 177);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(110, 23);
            this.btn_OK.TabIndex = 7;
            this.btn_OK.Text = "提交";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(248, 177);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(110, 23);
            this.btn_Cancel.TabIndex = 8;
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
            // tb_Gsm
            // 
            this.tb_Gsm.Location = new System.Drawing.Point(100, 18);
            this.tb_Gsm.Name = "tb_Gsm";
            this.tb_Gsm.Size = new System.Drawing.Size(259, 21);
            this.tb_Gsm.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(48, 110);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 4;
            this.label18.Text = "地址：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(24, 50);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 12);
            this.label19.TabIndex = 2;
            this.label19.Text = "单位负责人：";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(36, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 1;
            this.label20.Text = "采购单位：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "备注：";
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(100, 75);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(259, 21);
            this.tb_phone.TabIndex = 3;
            // 
            // tb_beizhu
            // 
            this.tb_beizhu.Location = new System.Drawing.Point(100, 139);
            this.tb_beizhu.Name = "tb_beizhu";
            this.tb_beizhu.Size = new System.Drawing.Size(258, 21);
            this.tb_beizhu.TabIndex = 6;
            this.tb_beizhu.Tag = "UserAdd";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(100, 106);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(259, 21);
            this.tb_address.TabIndex = 4;
            // 
            // FrmCompanyAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 231);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tb_beizhu);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tb_owner);
            this.Controls.Add(this.tb_Gsm);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCompanyAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "FrmCompanyAdd";
            this.Text = "添加采购单位";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProjectAdd_FormClosing);
            this.Load += new System.EventHandler(this.FrmCompanyAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_owner;
        private System.Windows.Forms.TextBox tb_Gsm;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_beizhu;
        private System.Windows.Forms.TextBox tb_address;
    }
}