using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Control
{
    public partial class CheckEdit : UserControl
    {

        public event EventHandler ButtonClick;

        bool OnOff = false;
        public CheckEdit()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (OnOff)
            {
                pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.common_bt_checkbox_n;
                OnOff = false;
            }
            else
            {
                pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.common_bt_checkbox_s;
                OnOff = true;
            }

            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (!OnOff)
            {
                pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.common_bt_checkbox_o;
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (OnOff)
            {
                pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.common_bt_checkbox_s;
            }
            else
            {
                pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.common_bt_checkbox_n;
            }
        }
        
        public bool GetOnOff()
        {
            return OnOff;
        }
        public void SetOnOff(bool Onoff)
        {
            OnOff = Onoff;
            if (OnOff)
            {
                pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.common_bt_checkbox_s;
                
            }
            else
            {
                pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.common_bt_checkbox_n;
                
            }
        }
    }
}
