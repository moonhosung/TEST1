using TEST1.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

using System.Reflection;

namespace TEST1
{
    public partial class LoginDlg : Form
    {
        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        private const int SW_SHOWNORMAL = 1;
        private const int SW_SHOWMINIMIZED = 2;
        private const int SW_SHOWMAXIMIZED = 3;
        

        private static LoginDlg theInstance = null;
        public static LoginDlg CreateInstance()
        {
            if (theInstance == null)
            {
                theInstance = new LoginDlg();
            }
            return theInstance;
        }

        public LoginDlg()
        {
            InitializeComponent();

            BTN_LOGIN_OK.SetText("LOG-IN");
            BTN_LOGIN_OK.SetType(true);
            BTN_LOGIN_OK.SetFontSize(12);
            BTN_LOGIN_OK.SetCheck(true);
          //  if (Login.User_Authority == "Supervisor")
            {
                CB_SUPERVISOR.SetOnOff(true);
            }
          //  else
            {
                CB_MAINTENANCE.SetOnOff(true);
            }
        }

        private void BTN_LOGIN_OK_ButtonClick(object sender, EventArgs e)
        {

            string PW = "", temp = "";
           // temp = Login.User_Authority;

            if (CB_MAINTENANCE.GetOnOff())
            {
               // PW = Login.LoadLoginInfo(CLogin.UserAuthority.Maintenance);
               // Login.User_Authority = "Maintenance";
            }
            else if (CB_SUPERVISOR.GetOnOff())
            {
              //  PW = Login.LoadLoginInfo(CLogin.UserAuthority.Supervisor);
              //  Login.User_Authority = "Supervisor";
            }
            else
            {
              //  Login.User_Authority = "Operator";
            }

            this.Visible = false;

            Thread.Sleep(50);

            // 윈도우 타이틀명으로 핸들을 찾는다
            IntPtr hWnd = FindWindow(null, "Form1");

            if (!hWnd.Equals(IntPtr.Zero))
            {
                // 윈도우가 최소화 되어 있다면 활성화 시킨다
                ShowWindowAsync(hWnd, SW_SHOWNORMAL);

                // 윈도우에 포커스를 줘서 최상위로 만든다
                SetForegroundWindow(hWnd);
            }
            
            if (TB_PASSWORD.Text != PW)
            {
               // Anything.InsertLog("Process", "[Login] failed - Password is wrong");
                MainForm.Message_popup.ShowPopup("Password is wrong", false);
                //TopMost = true;
                //TopLevel = true;
                //Login.User_Authority = temp;
            }
            else
            {

                //Anything.InsertLog("Process", "[Login] " + Login.User_Authority + " Logged In");
                MainForm.Message_popup.ShowPopup("logged in", false);
                //TopMost = true;
                //TopLevel = true;
                //MainForm.User_Change = true;
                // MainForm.opacityForm.ClosePopup();
            }
            this.Close();
            //Job job = Job.CreateInstance();
            // job.Job_Enter(null, null);
        }


        private void LoginDlg_Load(object sender, EventArgs e)
        {
            TopMost = true;
            TopLevel = true;
        }

        private void LoginDlg_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Silver), label2.Left - 1, label2.Top - 1, label2.Width + 2, label2.Height + 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  Job job = Job.CreateInstance();
            //  job.Job_Enter(null, null);

            MainForm.opacityForm.ClosePopup();
            this.Close();
        }

        private void CB_SUPERVISOR_ButtonClick(object sender, EventArgs e)
        {

            CB_MAINTENANCE.SetOnOff(false);
        }

        private void CB_MAINTENANCE_ButtonClick(object sender, EventArgs e)
        {

            CB_SUPERVISOR.SetOnOff(false);
        }


    }
}
