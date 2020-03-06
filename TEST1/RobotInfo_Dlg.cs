using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST1
{
    public partial class RobotInfo_Dlg : Form
    {
        private static RobotInfo_Dlg _Instance = null;
        public static RobotInfo_Dlg CreateInstance()
        {
            if (_Instance == null)
            {
                _Instance = new RobotInfo_Dlg();
            }
            return _Instance;
        }
        public RobotInfo_Dlg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.opacityForm.ClosePopup();
            this.Close();
        }
    }
}
