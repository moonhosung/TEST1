using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEST1.Function;

namespace TEST1
{
    public partial class Form1_2 : UserControl
    {

        
        private static Form1_2 theInstance = null;
        public static Form1_2 CreateInstance()
        {
            if (theInstance == null)
            {
                theInstance = new Form1_2();
            }
            return theInstance;
        }

        public Form1_2()
        {
            InitializeComponent();
        }

        private void Form1_2_Load(object sender, EventArgs e)
        {
            dateEdit2.SetDate(dateEdit1.GetDate());
            dateEdit1.SetMaxDate(); 
            dateEdit2.SetMaxDate();
            TodayLog();
        }
        public void Maint_Conv_Click(int cmd)
        {
        }
            private void dateEdit1_Closed(object sender, EventArgs e)
        {
            dateEdit2.SetDate(dateEdit1.GetDate());
        }

        private void dateEdit1_Mouseclick(object sender, EventArgs e)
        {
            
        }

        private void dateEdit2_Load(object sender, EventArgs e)
        {

        }

        private void dateEdit2_Mouseclick(object sender, EventArgs e)
        {

        }

        private void Form1_2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Silver), gridView_Log1.Left - 1, gridView_Log1.Top - 1, gridView_Log1.Width + 2, gridView_Log1.Height + 2);
        }

        private void dateEdit2_Closed(object sender, EventArgs e)
        {
            gridView_Log1.AddItem(DateTime.Now.ToString(), "user1","normal","test");
        }

        private void button1_ButtonClick(object sender, EventArgs e)
        {
            CLog.InsertLog("Process", "[EXIT] Vision Camera Exit");
        }


        public void TodayLog()
        {
            //CLogin login = CLogin.CreateInstance();
            // DataInsertLog("Process", "Test");
            // AddLogMessage("Test", 1);
            DateTime Today = DateTime.Now;
            gridView_Log1.Clear();
            CUIInvoke uiInvoke = CUIInvoke.CreateInstance();

            Communication com = Communication.CreateInstance();
            string[] tt = { "LogCase", "DateTime", "LogText", "User" };
            List<string>[] tt2;
            tt2 = com.DBSelect("log", tt);
            int Year, Month, Day;
            if (tt2[0].Count() == 0)
            {
                return;
            }
            //for (int i = 0; i < tt2.Count(); i++)
            {
                for (int j = tt2[0].Count() - 1; j >= 0; j--)
                {
                    Year = Int32.Parse(tt2[1][j].Substring(0, 4));
                    Month = Int32.Parse(tt2[1][j].Substring(5, 2));
                    Day = Int32.Parse(tt2[1][j].Substring(8, 2));
                    if (Day == Today.Day
                        && Month == Today.Month
                        && Year == Today.Year
                        )
                    {
                        //uiInvoke.SetTextListControl(theInstance.listBox_ProcessLog, "Date=[" + tt2[1][j] + "] Test");
                        gridView_Log1.AddItem(tt2[1][j], tt2[3][j], tt2[0][j], tt2[2][j]);
                    }
                }
            }
        }

        private void Form1_2_Enter(object sender, EventArgs e)
        {
          
        }
    }
}
