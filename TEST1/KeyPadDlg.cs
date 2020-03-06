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
    public partial class KeyPadDlg : Form
    {
        private DevExpress.XtraEditors.TextEdit edit;
        private int MinLimit = 0;
        private int MaxLimit = 9999;
        private static KeyPadDlg _Instance = null;
        public static KeyPadDlg CreateInstance()
        {
            if (_Instance == null)
            {
                _Instance = new KeyPadDlg();
            }
            return _Instance;
        }

        public KeyPadDlg()
        {
            InitializeComponent();
        }

        public void SetEdit(DevExpress.XtraEditors.TextEdit textEdit)
        {
            edit = textEdit;
        }

        public void SetMin(int num)
        {
            MinLimit = num;
        }

        public void SetMax(int num)
        {
            MaxLimit = num;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            edit.Text = "";
            MainForm.opacityForm.ClosePopup();
            this.Close();
        }

        private void BTN_KEY_1_ButtonClick(object sender, EventArgs e)
        {
            edit.Text += "1";
        }

        private void BTN_KEY_2_ButtonClick(object sender, EventArgs e)
        {
            edit.Text += "2";
        }

        private void BTN_KEY_3_ButtonClick(object sender, EventArgs e)
        {
            edit.Text += "3";
        }

        private void BTN_KEY_4_ButtonClick(object sender, EventArgs e)
        {
            edit.Text += "4";
        }

        private void BTN_KEY_5_ButtonClick(object sender, EventArgs e)
        {
            edit.Text += "5";
        }

        private void BTN_KEY_6_ButtonClick(object sender, EventArgs e)
        {
            edit.Text += "6";
        }

        private void BTN_KEY_7_ButtonClick(object sender, EventArgs e)
        {
            edit.Text += "7";
        }

        private void BTN_KEY_8_ButtonClick(object sender, EventArgs e)
        {
            edit.Text += "8";
        }

        private void BTN_KEY_9_ButtonClick(object sender, EventArgs e)
        {
            edit.Text += "9";
        }

        private void BTN_KEY_MINUS_ButtonClick(object sender, EventArgs e)
        {
            int num = Int32.Parse(edit.Text);
            if(num>0)
            {
                edit.Text = (num-1).ToString();
            }
            
        }

        private void BTN_KEY_PLUS_ButtonClick(object sender, EventArgs e)
        {
            int num = Int32.Parse(edit.Text);
            if (num < 9999)
            {
                edit.Text = (num + 1).ToString();
            }
        }

        private void BTN_KEY_ENTER_ButtonClick(object sender, EventArgs e)
        {

            MainForm.opacityForm.ClosePopup();
            this.Close();
        }

        private void BTN_KEY_0_ButtonClick(object sender, EventArgs e)
        {

            edit.Text += "0";
        }

        private void BTN_KEY_DOT_ButtonClick(object sender, EventArgs e)
        {
        }

        private void KeyPadDlg_Load(object sender, EventArgs e)
        {
            BTN_KEY_0.SetText("0");
            BTN_KEY_1.SetText("1");
            BTN_KEY_2.SetText("2");
            BTN_KEY_3.SetText("3");
            BTN_KEY_4.SetText("4");
            BTN_KEY_5.SetText("5");
            BTN_KEY_6.SetText("6");
            BTN_KEY_7.SetText("7");
            BTN_KEY_8.SetText("8");
            BTN_KEY_9.SetText("9");
            BTN_KEY_MINUS.SetText("-");
            BTN_KEY_PLUS.SetText("+");
            BTN_KEY_CLEAR.SetText("C");
            BTN_KEY_BACK.SetText("←");
            BTN_KEY_ENTER.SetText("E\nN\nT\nE\nR");

            BTN_KEY_0.SetType(true);
            BTN_KEY_1.SetType(true);
            BTN_KEY_2.SetType(true);
            BTN_KEY_3.SetType(true);
            BTN_KEY_4.SetType(true);
            BTN_KEY_5.SetType(true);
            BTN_KEY_6.SetType(true);
            BTN_KEY_7.SetType(true);
            BTN_KEY_8.SetType(true);
            BTN_KEY_9.SetType(true);
            BTN_KEY_MINUS.SetType(true);
            BTN_KEY_BACK.SetType(true);
            BTN_KEY_CLEAR.SetType(true);
            BTN_KEY_PLUS.SetType(true);
            BTN_KEY_ENTER.SetType(true);
        }

        private void BTN_KEY_BACK_ButtonClick(object sender, EventArgs e)
        {
            if(edit.Text.Length!=0)
            {
                edit.Text = edit.Text.Substring(0, edit.Text.Length - 1);
            }
        }

        private void BTN_KEY_CLEAR_ButtonClick(object sender, EventArgs e)
        {
            edit.Text = "";
        }
    }
}
