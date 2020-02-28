using TEST1.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;
using System.Runtime.InteropServices;

namespace TEST1
{
    public partial class Message_Popup : Form
    {

        public bool YesNo = false;
        private bool InPopup = false;
        private static Message_Popup _Instance = null;
        public static Message_Popup CreateInstance()
        {
            if (_Instance == null)
            {
                _Instance = new Message_Popup();
            }
            return _Instance;
        }
        public Message_Popup()
        {
            InitializeComponent();

            // this.Visible = false;

            BTN_MESSAGE_POPUP_OK.SetText("OK");
            BTN_MESSAGE_POPUP_OK.SetType(true);


            BTN_MESSAGE_POPUP_YES.SetText("YES");
            BTN_MESSAGE_POPUP_YES.SetType(true);
            BTN_MESSAGE_POPUP_YES.SetCheck(true);
            BTN_MESSAGE_POPUP_NO.SetText("NO");
            BTN_MESSAGE_POPUP_NO.SetType(true);

            this.DesktopLocation = new Point(1920 / 2 - (this.Width / 2), 1080 / 2 - (this.Height / 2));
            this.StartPosition = FormStartPosition.Manual;

            this.TopMost = true;


        }
        // inPopup = 함수를 호출한 위치가 popup일 경우 true
        public void ShowPopup(string message, bool inPopup)
        {

            InPopup = inPopup;
            BTN_MESSAGE_POPUP_OK.Visible = true;
            BTN_MESSAGE_POPUP_YES.Visible = false;
            BTN_MESSAGE_POPUP_NO.Visible = false;

            CUIInvoke invoke = CUIInvoke.CreateInstance();
            MainForm.opacityForm.Start = true;

            MainForm.opacityForm.BackColor = Color.Black;
            //invoke.InvokeFormTop(Main.opacityForm);
            // invoke.InvokeFormShowDlg(Main.opacityForm, true,false);

            //Main.opacityForm.TopLevel = true;
            //Main.opacityForm.TopMost = true;
            MainForm.opacityForm.ShowPopup();
            invoke.InvokeLabel(LB_MESSAGE_CONTENTS,
                LB_MESSAGE_CONTENTS.ForeColor,
                LB_MESSAGE_CONTENTS.BackColor,
                message);
            invoke.InvokeFormShowDlg(MainForm.Message_popup, true, true);
        }

        public void ShowPopupInAlarm(string message)
        {

            InPopup = true;
            BTN_MESSAGE_POPUP_OK.Visible = true;
            BTN_MESSAGE_POPUP_YES.Visible = false;
            BTN_MESSAGE_POPUP_NO.Visible = false;

            CUIInvoke invoke = CUIInvoke.CreateInstance();
            invoke.InvokeLabel(LB_MESSAGE_CONTENTS,
                LB_MESSAGE_CONTENTS.ForeColor,
                LB_MESSAGE_CONTENTS.BackColor,
                message);
            invoke.InvokeFormShowDlg(MainForm.Message_popup, true, true);
        }
        // inPopup = 함수를 호출한 위치가 popup일 경우 true
        public void ShowPopup(string message, string title, bool inPopup)
        {
            BTN_MESSAGE_POPUP_OK.Visible = false;
            BTN_MESSAGE_POPUP_YES.Visible = true;
            BTN_MESSAGE_POPUP_NO.Visible = true;
            InPopup = inPopup;
            CUIInvoke invoke = CUIInvoke.CreateInstance();

            MainForm.opacityForm.BackColor = Color.Black;
            //Main.opacityForm.TopLevel = true;
            //Main.opacityForm.TopMost = true;
            MainForm.opacityForm.Start = true;
            //invoke.InvokeFormTop(Main.opacityForm);
            // invoke.InvokeFormShowDlg(Main.opacityForm, true, false);
            MainForm.opacityForm.ShowPopup();

            invoke.InvokeLabel(LB_MESSAGE_CONTENTS,
              LB_MESSAGE_CONTENTS.ForeColor,
              LB_MESSAGE_CONTENTS.BackColor,
              message);
            invoke.InvokeLabel(LB_MESSAGE_TITLE,
              LB_MESSAGE_TITLE.ForeColor,
              LB_MESSAGE_TITLE.BackColor,
              title);
            invoke.InvokeFormShowDlg(MainForm.Message_popup, true, true);
        }

        private void BTN_MESSAGE_POPUP_ButtonClick(object sender, EventArgs e)
        {
            this.Close();
            if (!InPopup)
            {
                MainForm.opacityForm.ClosePopup();
            }
            LB_MESSAGE_CONTENTS.Text = "";
            LB_MESSAGE_TITLE.Text = "Message";
        }

        private void BTN_MESSAGE_POPUP_YES_ButtonClick(object sender, EventArgs e)
        {
            YesNo = true;
            this.Close();
            if (!InPopup)
            {
                MainForm.opacityForm.ClosePopup();
            }
            LB_MESSAGE_CONTENTS.Text = "";
            LB_MESSAGE_TITLE.Text = "Message";
        }

        private void BTN_MESSAGE_POPUP_NO_ButtonClick(object sender, EventArgs e)
        {
            YesNo = false;
            this.Close();
            if (!InPopup)
            {
                MainForm.opacityForm.ClosePopup();
            }
            LB_MESSAGE_CONTENTS.Text = "";
            LB_MESSAGE_TITLE.Text = "Message";
        }

        public bool GetInPopup()
        {
            return InPopup;
        }

        private void Message_Popup_Load(object sender, EventArgs e)
        {
            
        }
    }
}
