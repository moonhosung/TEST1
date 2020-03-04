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
    public partial class IpControl : UserControl
    {
        public IpControl()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if(textEdit1.Text == "")
            {
                return;
            }
            if(Int32.Parse(textEdit1.Text)>255)
            {
                textEdit1.Text = 255.ToString();
            }
            if(textEdit1.Text.Length>=3)
            {
                textEdit2.Focus();
            }
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
            if (textEdit2.Text == "")
            {
                return;
            }
            if (Int32.Parse(textEdit2.Text) > 255)
            {
                textEdit2.Text = 255.ToString();
            }
            if (textEdit2.Text.Length >= 3)
            {
                textEdit3.Focus();
            }
        }

        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {
            if (textEdit4.Text == "")
            {
                return;
            }
            if (Int32.Parse(textEdit4.Text) > 255)
            {
                textEdit4.Text = 255.ToString();
            }
        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {
            if (textEdit3.Text == "")
            {
                return;
            }
            if (Int32.Parse(textEdit3.Text) > 255)
            {
                textEdit3.Text = 255.ToString();
            }
            if (textEdit3.Text.Length >= 3)
            {
                textEdit4.Focus();
            }
        }

        private void textEdit2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Back) && (textEdit2.Text == "" || textEdit2.Text == "0"))
            {
                textEdit1.Focus();
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Tab) || e.KeyChar == '.')
            {
                textEdit3.Focus();
            }
        }

        private void textEdit3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Back) && (textEdit3.Text == "" || textEdit3.Text == "0"))
            {
                textEdit2.Focus();
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Tab) || e.KeyChar == '.')
            {
                textEdit4.Focus();
            }
        }

        private void textEdit4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Back) && (textEdit4.Text == "" || textEdit4.Text == "0"))
            {
                textEdit3.Focus();
            }
        }

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Tab) || e.KeyChar == '.')
            {
                textEdit2.Focus();
            }
        }
    }
}
