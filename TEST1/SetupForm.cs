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

        private void textEdit1_Click(object sender, EventArgs e)
        {
            Keypad_Load(textEdit1);
        }

        public void Keypad_Load(DevExpress.XtraEditors.TextEdit edit)
        {
            if (CHK_KEYPAD_USE.GetOnOff())
            {
                MainForm.opacityForm.Start = true;
                MainForm.opacityForm.ShowPopup();
                MainForm.keypad_Dlg.SetEdit(edit);
                //MainForm.keypad_Dlg.DesktopLocation = new Point(1920 / 2 - (MainForm.keypad_Dlg.Width / 2), 1080 / 2 - (MainForm.keypad_Dlg.Height / 2));
                MainForm.keypad_Dlg.DesktopLocation = new Point(Control.MousePosition.X, Control.MousePosition.Y+30);
                MainForm.keypad_Dlg.StartPosition = FormStartPosition.Manual;
                MainForm.keypad_Dlg.ShowDialog();
            }
        }

        private void ipControl1_Click1(object sender, EventArgs e)
        {
            Keypad_Load(ipControl1.edit);
        }

        private void ipControl1_Click2(object sender, EventArgs e)
        {
            Keypad_Load(ipControl1.edit);
        }

        private void ipControl1_Click3(object sender, EventArgs e)
        {
            Keypad_Load(ipControl1.edit);
        }

        private void ipControl1_Click4(object sender, EventArgs e)
        {
            Keypad_Load(ipControl1.edit);
        }
    }
}
