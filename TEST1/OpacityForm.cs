using TEST1.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST1
{
    public partial class OpacityForm : Form
    {

        public ThreadStart mThreadStart = null;
        public Thread mThread = null;
        private static OpacityForm _Instance = null;
        public bool Start = false;
        public bool End = false;
        public bool alarm = false;
        bool On = false;
        public static OpacityForm CreateInstance()
        {
            if (_Instance == null)
            {
                _Instance = new OpacityForm();
            }
            return _Instance;
        }

        public OpacityForm()
        {
            InitializeComponent();

        }
        public void ClosePopup()
        {

            CUIInvoke invoke = CUIInvoke.CreateInstance();
            End = true;
        }
        public void thread()
        {
            CUIInvoke invoke = CUIInvoke.CreateInstance();
            while (On)
            {

                if (End)
                {
                    for (int i = 50; i > 1; i--)
                    {
                        double temp = (double)i / (double)100;
                        invoke.SetInvolkOpacity(this, temp);
                        Thread.Sleep(10);
                    }
                    End = false;
                    On = false;
                    invoke.SetInvolkHide(this);
                    return;
                }
                if (Start)
                {
                    for (int i = 1; i < 50; i++)
                    {
                        double temp = (double)i / (double)100;
                        invoke.SetInvolkOpacity(this, temp);
                        Thread.Sleep(10);
                    }
                    Start = false;
                }
                if (alarm)
                {
                    for (int i = 10; i < 60; i++)
                    {
                        double temp = (double)i / (double)100;
                        invoke.SetInvolkOpacity(this, temp);
                        Thread.Sleep(10);
                    }
                    for (int i = 60; i > 10; i--)
                    {
                        double temp = (double)i / (double)100;
                        invoke.SetInvolkOpacity(this, temp);
                        Thread.Sleep(10);
                    }
                    if (!alarm)
                    {
                        BackColor = Color.Black;
                        End = false;
                        On = false;
                        invoke.SetInvolkHide(this);
                        //Alarm alarm = Alarm.CreateInstance();
                       // alarm.IsOpen = false;
                    }
                }
            }
        }
        public void ShowPopup()
        {
            CUIInvoke invoke = CUIInvoke.CreateInstance();
            invoke.InvokeFormShowDlg(MainForm.opacityForm, true, false);
            // Show();
            On = true;
            mThreadStart = new ThreadStart(thread);
            mThread = new Thread(mThreadStart);
            mThread.Start();
        }
        private void OpacityForm_Load(object sender, EventArgs e)
        {
        }

        private void OpacityForm_Activated(object sender, EventArgs e)
        {
            if(!MainForm.Message_popup.GetInPopup())
            {
                MainForm.LoginPopup.Activate();
            }
            
        }
    }
}
