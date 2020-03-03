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
    public partial class SetupForm : UserControl
    {
        private static SetupForm theInstance = null;
        public static SetupForm CreateInstance()
        {
            if (theInstance == null)
            {
                theInstance = new SetupForm();
            }
            return theInstance;
        }

        public SetupForm()
        {
            InitializeComponent();
        }

        private void SetupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
