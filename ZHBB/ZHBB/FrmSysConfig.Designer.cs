namespace ZHBB
{
    partial class FrmSysConfig
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_submit = new System.Windows.Forms.Button();
            this.cb_person = new System.Windows.Forms.CheckBox();
            this.cb_sensor = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(128, 60);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(139, 23);
            this.btn_submit.TabIndex = 1;
            this.btn_submit.Text = "提交";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // cb_person
            // 
            this.cb_person.AutoSize = true;
            this.cb_person.Location = new System.Drawing.Point(128, 25);
            this.cb_person.Name = "cb_person";
            this.cb_person.Size = new System.Drawing.Size(72, 16);
            this.cb_person.TabIndex = 2;
            this.cb_person.Text = "手动录入";
            this.cb_person.UseVisualStyleBackColor = true;
            this.cb_person.Click += new System.EventHandler(this.cb_person_Click);
            // 
            // cb_sensor
            // 
            this.cb_sensor.AutoSize = true;
            this.cb_sensor.Location = new System.Drawing.Point(206, 25);
            this.cb_sensor.Name = "cb_sensor";
            this.cb_sensor.Size = new System.Drawing.Size(72, 16);
            this.cb_sensor.TabIndex = 3;
            this.cb_sensor.Text = "自动读取";
            this.cb_sensor.UseVisualStyleBackColor = true;
            this.cb_sensor.Click += new System.EventHandler(this.cb_sensor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "重量输入方式：";
            // 
            // FrmSysConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 105);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_sensor);
            this.Controls.Add(this.cb_person);
            this.Controls.Add(this.btn_submit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSysConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "FrmIsSensorEdit";
            this.Text = "系统配置";
            this.Load += new System.EventHandler(this.FrmPriceEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.CheckBox cb_person;
        private System.Windows.Forms.CheckBox cb_sensor;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDoc;
    }
}