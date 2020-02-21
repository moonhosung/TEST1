using TEST1.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TEST1
{
    public partial class LoginDlg : Form
    {
        
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

            if (TB_PASSWORD.Text != PW)
            {
               // Anything.InsertLog("Process", "[Login] failed - Password is wrong");
                MainForm.Message_popup.ShowPopup("Password is wrong", true);
                TopMost = true;
                TopLevel = true;
                //Login.User_Authority = temp;
            }
            else
            {

                //Anything.InsertLog("Process", "[Login] " + Login.User_Authority + " Logged In");
                MainForm.Message_popup.ShowPopup("logged in", true);
                TopMost = true;
                TopLevel = true;
                //MainForm.User_Change = true;
                MainForm.opacityForm.ClosePopup();
                this.Close();
            }
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
