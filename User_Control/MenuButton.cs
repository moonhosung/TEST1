using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace User_Control
{
    public partial class MenuButton : UserControl
    {

        public event EventHandler ButtonClick;
        int loca = 96;
        int width = 30;
        int color = 50;
        bool Select = false;
        public MenuButton()
        {
            InitializeComponent();
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            //color = 50;
            //loca = 96;
            //width = 30;
            //this.panel.Location = new System.Drawing.Point(loca, 64);
            //this.panel.Size = new System.Drawing.Size(width, 2);
            //this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(color)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            if (!Select)
            {
                timer1.Enabled = true;
                timer1.Start();
            }
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            if (!Select)
            {
                color = 50;
                loca = 96;
                width = 30;
                this.panel.Location = new System.Drawing.Point(loca, 64);
                this.panel.Size = new System.Drawing.Size(width, 2);
                this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(color)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));

                timer1.Enabled = false;
                timer1.Stop();
            }
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (width < 100)
             {
                width+=2;
                loca--;
                this.panel.Location = new System.Drawing.Point(loca, 64);
                this.panel.Size = new System.Drawing.Size(width, 2);
                //Thread.Sleep(5);
                if(color < 200)
                {
                    color += 5;
                    this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(color)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
                }
            }
            else 
            {

                timer1.Enabled = false;
                timer1.Stop();
                // width = 30;
                // loca = 96;
                //this.separatorControl2.Location = new System.Drawing.Point(loca, 53);
                //this.separatorControl2.Size = new System.Drawing.Size(width, 20);
                //Thread.Sleep(5);
            }

        }
        public void SetText(string text)
        {
            label.Text = text;
        }

        private void MenuButton_Load(object sender, EventArgs e)
        {

        }

        public void SetSelect(bool select)
        {
            Select = select;
            if(!Select)
            {
                color = 50;
                loca = 96;
                width = 30;
                this.panel.Location = new System.Drawing.Point(loca, 64);
                this.panel.Size = new System.Drawing.Size(width, 2);
                this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(color)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));

                timer1.Enabled = false;
                timer1.Stop();

            }
            else
            {
                timer1.Enabled = true;
                timer1.Start();
            }
        }

        private void label_Click(object sender, EventArgs e)
        {
            Select = true;
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }
    }
}
