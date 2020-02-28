using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST1
{
    public partial class Form1_2 : UserControl
    {
        private static Form1_2 theInstance = null;
        public static Form1_2 CreateInstance()
        {
            if (theInstance == null)
            {
                theInstance = new Form1_2();
            }
            return theInstance;
        }

        public Form1_2()
        {
            InitializeComponent();
        }

        private void Form1_2_Load(object sender, EventArgs e)
        {
            dateEdit2.SetDate(dateEdit1.GetDate());
            dateEdit1.SetMaxDate(); 
            dateEdit2.SetMaxDate();
        }

        private void dateEdit1_Closed(object sender, EventArgs e)
        {
            dateEdit2.SetDate(dateEdit1.GetDate());
        }

        private void dateEdit1_Mouseclick(object sender, EventArgs e)
        {
            
        }

        private void dateEdit2_Load(object sender, EventArgs e)
        {

        }

        private void dateEdit2_Mouseclick(object sender, EventArgs e)
        {

        }

        private void Form1_2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Silver), gridView_Log1.Left - 1, gridView_Log1.Top - 1, gridView_Log1.Width + 2, gridView_Log1.Height + 2);
        }

        private void dateEdit2_Closed(object sender, EventArgs e)
        {
            gridView_Log1.AddItem(DateTime.Now.ToString(), "user1","normal","test");
        }
    }
}
