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
    public partial class EditBox : UserControl
    {
        public EditBox()
        {
            InitializeComponent();
        }
        public void SetReadOnly()
        {
            textEdit1.ReadOnly = true;
        }

    }
}
