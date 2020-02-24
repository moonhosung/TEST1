using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEST1.Function;

namespace TEST1
{
    public partial class MainForm : Form
    {

        private static MainForm theInstance = null;

        private Form1_1 form1_1 = Form1_1.CreateInstance();
        private Form1_2 form1_2 = Form1_2.CreateInstance();
        private Form1_3 form1_3 = Form1_3.CreateInstance();

        public static LoginDlg LoginPopup = LoginDlg.CreateInstance();
        public static OpacityForm opacityForm = OpacityForm.CreateInstance();
        public static Message_Popup Message_popup = Message_Popup.CreateInstance();
        public static List<bool> Line_1 =  new List<bool>();
        public static List<bool> Line_2 = new List<bool>();
        public static List<bool> Line_3 = new List<bool>();
        public static List<bool> Line_4 = new List<bool>();
        public static List<bool> Line_5 = new List<bool>();
        public static List<bool> Line_6 = new List<bool>();
        public static MovePosition position = new MovePosition();
        public static List<MovePosition> movePositions = new List<MovePosition>();

        public static MainForm CreateInstance()
        {
            if (theInstance == null)
            {
                theInstance = new MainForm();
            }
            return theInstance;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BTN_MAIN_EXIT.UseVisualStyleBackColor = false;
            this.TLP_CENTER.Controls.Add(form1_1);

            BTN_LOGIN.SetType(true);
            BTN_RIGHT1.SetType(true);
            BTN_RIGHT2.SetType(true);
            BTN_RIGHT3.SetType(true);
            BTN_RIGHT4.SetType(true);
            BTN_RIGHT5.SetType(true);
            BTN_BOTTOM_MENU1.SetType(true);
            BTN_BOTTOM_MENU2.SetType(true);
            BTN_BOTTOM_MENU3.SetType(true);
            BTN_BOTTOM_MENU4.SetType(true);
            BTN_BOTTOM_MENU5.SetType(true);

            BTN_LOGIN.SetText("LOGIN");
            BTN_RIGHT1.SetText("Menu 1");
            BTN_RIGHT2.SetText("Menu 2");
            BTN_RIGHT3.SetText("Menu 3");
            BTN_RIGHT4.SetText("Menu 4");
            BTN_RIGHT5.SetText("Menu 5");

            BTN_BOTTOM_MENU1.SetText("Bottom 1");
            BTN_BOTTOM_MENU2.SetText("Bottom 2");
            BTN_BOTTOM_MENU3.SetText("Bottom 3");
            BTN_BOTTOM_MENU4.SetText("Bottom 4");
            BTN_BOTTOM_MENU5.SetText("Bottom 5");

            MovePosition temp = new MovePosition();
            temp.position = Position.LINE1_START;
            temp.X = 110;
            temp.Y = 400;
            movePositions.Add(temp);
            temp.position = Position.LINE1_END;
            temp.X = 110;
            temp.Y = 100;
            movePositions.Add(temp);
            temp.position = Position.LINE1_END2;
            temp.X = 110;
            temp.Y = 400;
            movePositions.Add(temp);
            position = GetMovePosition(Position.STOP);
        }

        private void button1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_MAIN_EXIT_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process[] mProcess = System.Diagnostics.Process.GetProcessesByName(Application.ProductName);
            foreach (System.Diagnostics.Process p in mProcess)
                p.Kill();
        }
        

        private void BTN_MAIN_EXIT_MouseEnter(object sender, EventArgs e)
        {
            BTN_MAIN_EXIT.ForeColor = Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            BTN_MAIN_EXIT.BackgroundImage = global::TEST1.Properties.Resources.common_ic_grey_down;
        }

        private void BTN_MAIN_EXIT_MouseLeave(object sender, EventArgs e)
        {
            BTN_MAIN_EXIT.ForeColor = Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            BTN_MAIN_EXIT.BackgroundImage = global::TEST1.Properties.Resources.common_ic_grey;
        }

        private void BTN_RIGHT1_ButtonClick(object sender, EventArgs e)
        {
            ResetButton();
            BTN_RIGHT1.SetCheck(true);
            TLP_CENTER.Controls.RemoveAt(1);
            TLP_CENTER.Controls.Add(form1_1);
        }

        private void BTN_RIGHT2_ButtonClick(object sender, EventArgs e)
        {
            ResetButton();
            BTN_RIGHT2.SetCheck(true);
            TLP_CENTER.Controls.RemoveAt(1);
            TLP_CENTER.Controls.Add(form1_2);
        }

        public void ResetButton()
        {
            BTN_RIGHT1.SetCheck(false);
            BTN_RIGHT2.SetCheck(false);
            BTN_RIGHT3.SetCheck(false);
            BTN_RIGHT4.SetCheck(false);
            BTN_RIGHT5.SetCheck(false);
        }

        private void BTN_RIGHT3_ButtonClick(object sender, EventArgs e)
        {

            ResetButton();
            BTN_RIGHT3.SetCheck(true);
            TLP_CENTER.Controls.RemoveAt(1);
            TLP_CENTER.Controls.Add(form1_3);
        }

        private MovePosition GetMovePosition(Position position)
        {
            MovePosition Result = new MovePosition();
            for (int i = 0; i < MainForm.movePositions.Count; i++)
            {
                if (MainForm.movePositions[i].position == position)
                {
                    Result = MainForm.movePositions[i];
                }
            }
            return Result;
        }  

        private void BTN_LOGIN_ButtonClick(object sender, EventArgs e)
        {
            MainForm.opacityForm.Start = true;
            MainForm.opacityForm.ShowPopup();

            LoginPopup.DesktopLocation = new Point(1920 / 2 - (LoginPopup.Width / 2), 1080 / 2 - (LoginPopup.Height / 2));
            LoginPopup.StartPosition = FormStartPosition.Manual;
            LoginPopup.ShowDialog();
        }
    }
}
