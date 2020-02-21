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
    public partial class TabControl : UserControl
    {
        public TabControl()
        {
            InitializeComponent();
        }

        public void SetTabTitle(int Index,string Title)
        {
            switch (Index)
            {
                case 1:
                    this.xtraTabPage1.Text = Title;
                    break;
                case 2:
                    this.xtraTabPage2.Text = Title;
                    break;
            }
        }
    }
}
