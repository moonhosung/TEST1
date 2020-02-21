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
    public partial class ToggleButton : UserControl
    {
        public event EventHandler ButtonClick;
        bool OnOff = false;
        public ToggleButton()
        {
            InitializeComponent();
        }

        private void PB_MAINT_ICON_MouseClick(object sender, MouseEventArgs e)
        {
            if (OnOff)
            {
                label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
                label1.Left = 52;
                PB_MAINT_ICON.BackgroundImage = global::User_Control.Properties.Resources.common_bt_toggle_01_off;
                OnOff = false;
            }
            else
            {
                label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
                label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                label1.Left = 9;
                PB_MAINT_ICON.BackgroundImage = global::User_Control.Properties.Resources.common_bt_toggle_01_on;
                OnOff = true;
            }
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            if (OnOff)
            {
                label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
                label1.Left = 52;
                PB_MAINT_ICON.BackgroundImage = global::User_Control.Properties.Resources.common_bt_toggle_01_off;
                OnOff = false;
            }
            else
            {
                label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
                label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                label1.Left = 9;
                PB_MAINT_ICON.BackgroundImage = global::User_Control.Properties.Resources.common_bt_toggle_01_on;
                OnOff = true;
            }
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        public bool GetOnOff()
        {
            return OnOff;
        }

        public void SetText(string str)
        {
            label1.Text = str;
        }
        public void SetTextSize(int Size)
        {
            label1.Font = new System.Drawing.Font("Roboto", Size);
            if(Size==10)
            {
                label1.Top += 1;
            }
            else if (Size==9)
            {
                label1.Top += 2;
            }
        }

        private void ToggleButton_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            label1.Left = 52;
            PB_MAINT_ICON.BackgroundImage = global::User_Control.Properties.Resources.common_bt_toggle_01_off;
        }

        public void SetOnOff(bool onoff)
        {
            if (!onoff)
            {
                label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
                label1.Left = 52;
                PB_MAINT_ICON.BackgroundImage = global::User_Control.Properties.Resources.common_bt_toggle_01_off;
                OnOff = false;
            }
            else
            {
                label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
                label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                label1.Left = 9;
                PB_MAINT_ICON.BackgroundImage = global::User_Control.Properties.Resources.common_bt_toggle_01_on;
                OnOff = true;
            }
        }
    }

}
