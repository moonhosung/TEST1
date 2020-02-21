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
    public partial class CheckButton : UserControl
    {
        public CheckButton()
        {
            InitializeComponent();
        }

        public void SetText(string str)
        {
            label1.Text = str;
        }

        public void SetTextSize(int Size)
        {
            label1.Font = new System.Drawing.Font("Roboto", Size);
            label1.Top -= (Size-9);
        }

        public void SetEnable(bool Enable)
        {
            if(Enable)
            {
                label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(246)))));
                label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
                pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.common_img_light_on;
            }
            else
            {
                label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
                label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
                pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.common_img_light_off;
            }
        }

        private void CheckButton_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.common_img_light_off;
        }
    }
}
