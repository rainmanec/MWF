namespace ZHBB
{
    partial class MyUIPrintSetting
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
            this.cbPrinterList = new System.Windows.Forms.ComboBox();
            this.rdHorizon = new System.Windows.Forms.RadioButton();
            this.rdVertical = new System.Windows.Forms.RadioButton();
            this.tbMgTop = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPaper = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbMgLeft = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMgRight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMgBottom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUseDefaultPrinter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPrinterList
            // 
            this.cbPrinterList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrinterList.FormattingEnabled = true;
            this.cbPrinterList.Location = new System.Drawing.Point(6, 20);
            this.cbPrinterList.Name = "cbPrinterList";
            this.cbPrinterList.Size = new System.Drawing.Size(298, 20);
            this.cbPrinterList.TabIndex = 1;
            this.cbPrinterList.SelectedIndexChanged += new System.EventHandler(this.cbPrinterList_SelectedIndexChanged);
            // 
            // rdHorizon
            // 
            this.rdHorizon.AutoSize = true;
            this.rdHorizon.Location = new System.Drawing.Point(81, 21);
            this.rdHorizon.Name = "rdHorizon";
            this.rdHorizon.Size = new System.Drawing.Size(65, 16);
            this.rdHorizon.TabIndex = 3;
            this.rdHorizon.TabStop = true;
            this.rdHorizon.Text = "横向(H)";
            this.rdHorizon.UseVisualStyleBackColor = true;
            // 
            // rdVertical
            // 
            this.rdVertical.AutoSize = true;
            this.rdVertical.Location = new System.Drawing.Point(10, 21);
            this.rdVertical.Name = "rdVertical";
            this.rdVertical.Size = new System.Drawing.Size(65, 16);
            this.rdVertical.TabIndex = 3;
            this.rdVertical.TabStop = true;
            this.rdVertical.Text = "纵向(V)";
            this.rdVertical.UseVisualStyleBackColor = true;
            // 
            // tbMgTop
            // 
            this.tbMgTop.Location = new System.Drawing.Point(196, 26);
            this.tbMgTop.Name = "tbMgTop";
            this.tbMgTop.Size = new System.Drawing.Size(34, 21);
            this.tbMgTop.TabIndex = 7;
            this.tbMgTop.Text = "0";
            this.tbMgTop.Leave += new System.EventHandler(this.tbMgTop_Leave);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(187, 215);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(66, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(259, 215);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(66, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "上：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPrinterList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 55);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "打印机";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPaper);
            this.groupBox2.Controls.Add(this.rdHorizon);
            this.groupBox2.Controls.Add(this.rdVertical);
            this.groupBox2.Location = new System.Drawing.Point(12, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 48);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "纸张";
            // 
            // cbPaper
            // 
            this.cbPaper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaper.FormattingEnabled = true;
            this.cbPaper.Location = new System.Drawing.Point(175, 17);
            this.cbPaper.Name = "cbPaper";
            this.cbPaper.Size = new System.Drawing.Size(129, 20);
            this.cbPaper.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbMgLeft);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbMgRight);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbMgBottom);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tbMgTop);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 60);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "打印边距(in)";
            // 
            // tbMgLeft
            // 
            this.tbMgLeft.Location = new System.Drawing.Point(36, 26);
            this.tbMgLeft.Name = "tbMgLeft";
            this.tbMgLeft.Size = new System.Drawing.Size(34, 21);
            this.tbMgLeft.TabIndex = 5;
            this.tbMgLeft.Text = "0";
            this.tbMgLeft.Leave += new System.EventHandler(this.tbMgLeft_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "左：";
            // 
            // tbMgRight
            // 
            this.tbMgRight.Location = new System.Drawing.Point(115, 26);
            this.tbMgRight.Name = "tbMgRight";
            this.tbMgRight.Size = new System.Drawing.Size(34, 21);
            this.tbMgRight.TabIndex = 6;
            this.tbMgRight.Text = "0";
            this.tbMgRight.Leave += new System.EventHandler(this.tbMgRight_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "右：";
            // 
            // tbMgBottom
            // 
            this.tbMgBottom.Location = new System.Drawing.Point(267, 25);
            this.tbMgBottom.Name = "tbMgBottom";
            this.tbMgBottom.Size = new System.Drawing.Size(34, 21);
            this.tbMgBottom.TabIndex = 8;
            this.tbMgBottom.Text = "0";
            this.tbMgBottom.Leave += new System.EventHandler(this.tbMgBottom_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "下：";
            // 
            // btnUseDefaultPrinter
            // 
            this.btnUseDefaultPrinter.Location = new System.Drawing.Point(12, 215);
            this.btnUseDefaultPrinter.Name = "btnUseDefaultPrinter";
            this.btnUseDefaultPrinter.Size = new System.Drawing.Size(95, 23);
            this.btnUseDefaultPrinter.TabIndex = 11;
            this.btnUseDefaultPrinter.Text = "使用默认打印机";
            this.btnUseDefaultPrinter.UseVisualStyleBackColor = true;
            this.btnUseDefaultPrinter.Click += new System.EventHandler(this.btnUseDefaultPrinter_Click);
            // 
            // MyUIPrintSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 252);
            this.Controls.Add(this.btnUseDefaultPrinter);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyUIPrintSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "打印设置";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPrinterList;
        private System.Windows.Forms.RadioButton rdHorizon;
        private System.Windows.Forms.RadioButton rdVertical;
        private System.Windows.Forms.TextBox tbMgTop;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUseDefaultPrinter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbMgLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMgRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMgBottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPaper;
    }
}

