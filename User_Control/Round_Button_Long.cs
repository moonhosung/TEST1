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
    public partial class Round_Button_Long : UserControl
    {
        public event EventHandler ButtonClick;
        private bool IsCheck = false;
        public Round_Button_Long()
        {
            InitializeComponent();

            label1.ForeColor = Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            label1.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.maint_eqp_img_3light_grey;
            pictureBox2.BackgroundImage = global::User_Control.Properties.Resources.maint_eqp_icon_check_off;
            pictureBox2.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
        }

        public void SetText(string str)
        {
            label1.Text = str;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //if (IsCheck)
            //{
            //    label1.ForeColor = Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            //    label1.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            //    pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.maint_eqp_img_3light_grey;
            //    pictureBox2.BackgroundImage = global::User_Control.Properties.Resources.maint_eqp_icon_check_off;
            //    pictureBox2.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));

            //    IsCheck = false;
            //}
            //else
            //{
            //    label1.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            //    pictureBox2.BackgroundImage = global::User_Control.Properties.Resources.maint_eqp_icon_check_on;
            //    switch (label1.Text)
            //    {
            //        case "Red":


            //            label1.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(18)))), ((int)(((byte)(54)))));
            //            pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.maint_eqp_img_3light_red;
            //            pictureBox2.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(18)))), ((int)(((byte)(54)))));
            //            break;

            //        case "Blue":

            //            label1.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            //            pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.maint_eqp_img_3light_blue;
            //            pictureBox2.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            //            break;

            //        case "Yellow":

            //            label1.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(0)))));
            //            pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.maint_eqp_img_3light_yellow;
            //            pictureBox2.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(0)))));
            //            break;
            //        case "Green":

            //            label1.BackColor = Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(219)))), ((int)(((byte)(2)))));
            //            pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.maint_eqp_img_3light_green;
            //            pictureBox2.BackColor = Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(219)))), ((int)(((byte)(2)))));
            //            break;
            //    }
            //    IsCheck = true;
            //}

            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {

            //if (IsCheck)
            //{
            //    label1.ForeColor = Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            //    label1.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            //    pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.maint_eqp_img_3light_grey;
            //    pictureBox2.BackgroundImage = global::User_Control.Properties.Resources.maint_eqp_icon_check_off;
            //    pictureBox2.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));

            //    IsCheck = false;
            //}
            //else
            //{
            //    label1.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            //    pictureBox2.BackgroundImage = global::User_Control.Properties.Resources.maint_eqp_icon_check_on;
            //    switch (label1.Text)
            //    {
            //        case "Red":

                        
            //            label1.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(18)))), ((int)(((byte)(54)))));
            //            pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.maint_eqp_img_3light_red;
            //            pictureBox2.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(18)))), ((int)(((byte)(54)))));
            //            break;

            //        case "Blue":

            //            label1.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            //            pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.maint_eqp_img_3light_blue;
            //            pictureBox2.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            //            break;

            //        case "Yellow":

            //            label1.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(0)))));
            //            pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.maint_eqp_img_3light_yellow;
            //            pictureBox2.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(0)))));
            //            break;
            //        case "Green":

            //            label1.BackColor = Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(219)))), ((int)(((byte)(2)))));
            //            pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.maint_eqp_img_3light_green;
            //            pictureBox2.BackColor = Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(219)))), ((int)(((byte)(2)))));
            //            break;
            //    }
            //    IsCheck = true;
            //}

            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }
        public void SetCheck(bool Chek)
        {
            if(IsCheck!= Chek)
            { 
                if (!Chek)
                {
                    label1.ForeColor = Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
                    label1.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
                    pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.maint_eqp_img_3light_grey;
                    pictureBox2.BackgroundImage = global::User_Control.Properties.Resources.maint_eqp_icon_check_off;
                    pictureBox2.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));

                    IsCheck = false;
                }
                else
                {
                    label1.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                    pictureBox2.BackgroundImage = global::User_Control.Properties.Resources.maint_eqp_icon_check_on;
                    switch (label1.Text)
                    {
                        case "Red":
                            label1.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(18)))), ((int)(((byte)(54)))));
                            pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.maint_eqp_img_3light_red;
                            pictureBox2.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(18)))), ((int)(((byte)(54)))));
                            break;

                        case "Blue":
                            label1.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
                            pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.maint_eqp_img_3light_blue;
                            pictureBox2.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
                            break;

                        case "Yellow":
                            label1.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(0)))));
                            pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.maint_eqp_img_3light_yellow;
                            pictureBox2.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(0)))));
                            break;
                        case "Green":
                            label1.BackColor = Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(219)))), ((int)(((byte)(2)))));
                            pictureBox1.BackgroundImage = global::User_Control.Properties.Resources.maint_eqp_img_3light_green;
                            pictureBox2.BackColor = Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(219)))), ((int)(((byte)(2)))));
                            break;
                    }
                    IsCheck = true;
                }
            }
        }
        public bool GetCheck()
        {
            return IsCheck;
        }
    }
}
