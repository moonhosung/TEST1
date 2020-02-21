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
    public partial class Form1_3 : UserControl
    {
        private static Form1_3 theInstance = null;
        public static Form1_3 CreateInstance()
        {
            if (theInstance == null)
            {
                theInstance = new Form1_3();
            }
            return theInstance;
        }

        public Form1_3()
        {
            InitializeComponent();
        }

        private void Form1_3_Load(object sender, EventArgs e)
        {
            button1.SetText("Form1_3");
        }
    }
}
