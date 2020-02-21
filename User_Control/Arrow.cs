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
    public partial class Arrow : UserControl
    {

        public event EventHandler ButtonDown;
        public event EventHandler ButtonUp;
        int Rotation = 0;
        public Arrow()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (Rotation == 90)
            {
                this.pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.Arrow2_o;
            }
            else if (Rotation == 180)
            {
                this.pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.Arrow3_o;
            }
            else if (Rotation == 270)
            {
                this.pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.Arrow4_o;
            }
            else
            {
                this.pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.Arrow_o;
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (Rotation == 90)
            {
                this.pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.Arrow2_n;
            }
            else if (Rotation == 180)
            {
                this.pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.Arrow3_n;
            }
            else if (Rotation == 270)
            {
                this.pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.Arrow4_n;
            }
            else
            {
                this.pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.Arrow_n;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (Rotation == 90)
            {
                this.pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.Arrow2_p;
            }
            else if (Rotation == 180)
            {
                this.pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.Arrow3_p;
            }
            else if (Rotation == 270)
            {
                this.pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.Arrow4_p;
            }
            else
            {
                this.pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.Arrow_p;
            }

            if (this.ButtonDown != null)
                this.ButtonDown(this, e);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (Rotation == 90)
            {
                this.pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.Arrow2_n;
            }
            else if (Rotation == 180)
            {
                this.pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.Arrow3_n;
            }
            else if (Rotation == 270)
            {
                this.pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.Arrow4_n;
            }
            else
            {
                this.pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.Arrow_n;
            }

            if (this.ButtonUp != null)
                this.ButtonUp(this, e);
        }

        public void SetRotation(int rotation)
        {
            Rotation = rotation;
            if(Rotation==90)
            {
                this.pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.Arrow2_n;
            }
            else if (Rotation == 180)
            {
                this.pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.Arrow3_n;
            }
            else if (Rotation == 270)
            {
                this.pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.Arrow4_n;
            }
            else
            {
                this.pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.Arrow_n;
            }
        }
    }
}
