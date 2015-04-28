using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Drawing.Printing;
using System.IO.Ports;
namespace ZHBB
{
    public partial class FrmSysConfig : Form
    {

        public int IsSensor = 1;

        public SerialPort comm = new SerialPort();

        public FrmSysConfig()
        {
            InitializeComponent();
        }

        private void FrmPriceEdit_Load(object sender, EventArgs e)
        {
            // IsSensor
            string sensor = Util.GetDbConfig("IsSensor");
            if (sensor == "1")
            {
                this.SwitchIsSensorCheckbox(1);
            }
            else
            {
                this.SwitchIsSensorCheckbox(0);
            }
            if (AppData.uroleid < 1)
            {
                this.cb_person.Enabled = false;
                this.cb_sensor.Enabled = false;
            }
        }





        public void SwitchIsSensorCheckbox(int which)
        {
            if (which == 0)
            {
                this.cb_person.Checked = true;
                this.cb_sensor.Checked = false;
                this.IsSensor = 0;
            }
            else
            {
                this.cb_person.Checked = false;
                this.cb_sensor.Checked = true;
                this.IsSensor = 1;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            bool result = Util.SetDbConfig("IsSensor", this.IsSensor.ToString());
            if (result)
            {
                MessageBox.Show("提交成功");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("操作失败");
            }
        }


        private void cb_person_Click(object sender, EventArgs e)
        {
            this.SwitchIsSensorCheckbox(0);

        }

        private void cb_sensor_Click(object sender, EventArgs e)
        {
            this.SwitchIsSensorCheckbox(1);
        }

    }
}
