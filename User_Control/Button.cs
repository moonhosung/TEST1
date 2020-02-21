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
    public partial class Button : UserControl
    {
        public event EventHandler ButtonClick;
        private bool IsCheck = false;
        private bool Normal = false;
        public Button()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
            if (Normal)
            {
                return;
            }
            if(!IsCheck)
            { 
            this.SimpleButton.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
                this.SimpleButton.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));

                this.SimpleButton.Appearance.ForeColor = System.Drawing.Color.White;
                IsCheck = true;
            }
            else
            {
                this.SimpleButton.Appearance.BackColor = System.Drawing.Color.White;
                this.SimpleButton.Appearance.BackColor2 = System.Drawing.Color.White;

                this.SimpleButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
                IsCheck = false;
            }
        }
        public void SetFontSize(int size)
        {
            this.SimpleButton.Appearance.Font = new System.Drawing.Font("Roboto", size);
        }
        public void SetText(string str)
        {
            SimpleButton.Text = str;
        }
        public void SetType(bool Type)
        {
            Normal = Type;
        }
        public bool GetCheck()
        {
            return IsCheck;
        }
        public void SetCheck(bool check=true)
        {
            if(!check)
            {
                this.SimpleButton.Appearance.BackColor = System.Drawing.Color.White;
                this.SimpleButton.Appearance.BackColor2 = System.Drawing.Color.White;

                this.SimpleButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
                return;
            }
            this.SimpleButton.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.SimpleButton.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));

            this.SimpleButton.Appearance.ForeColor = System.Drawing.Color.White;
            IsCheck = true;
        }
    }
}
