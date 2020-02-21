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
            button1.SetText("Form1_2");
        }
    }
}
