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
    public partial class LogForm : UserControl
    {
        private static LogForm theInstance = null;

        public static LogForm CreateInstance()
        {
            if (theInstance == null)
            {
                theInstance = new LogForm();
            }
            return theInstance;
        }

        public LogForm()
        {
            InitializeComponent();
        }

        private void LogForm_Load(object sender, EventArgs e)
        {
            dateEdit1.SetDate(DateTime.Now);
            dateEdit2.SetMinDate(dateEdit1.GetDate());
            dateEdit1.SetMaxDate(); 
            dateEdit2.SetMaxDate();
            TodayLog();
        }

        public void Maint_Conv_Click(int cmd)
        {

        }

        private void dateEdit1_Closed(object sender, EventArgs e)
        {
            dateEdit2.SetMinDate(dateEdit1.GetDate());
            Reload();
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

        private void LogForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Silver), gridView_Log1.Left - 1, gridView_Log1.Top - 1, gridView_Log1.Width + 2, gridView_Log1.Height + 2);
        }

        private void dateEdit2_Closed(object sender, EventArgs e)
        {
            Reload();
        }

        private void Reload()
        {
            // DataInsertLog("Process", "Test");
            // AddLogMessage("Test", 1);
            DateTime temp, temp2, temp3;
            gridView_Log1.Clear();
            temp = dateEdit1.GetDate();
            temp2 = dateEdit2.GetDate();
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
                    temp3 = new DateTime(Year, Month, Day);

                    if (temp3.Date >= temp.Date && temp3.Date <= temp2.Date)
                    {
                        // if (tt2[0][j] == CB_LOGCASE.GetSelectedItem())
                        {
                            //if (tt2[2][j].Contains(TB_SEARCH.Text))
                            {
                                // if (tt2[3][j] == CB_LOG_USER.GetSelectedItem())
                                {
                                    //uiInvoke.SetTextListControl(theInstance.listBox_ProcessLog, "Date=[" + tt2[1][j] + "] Test");
                                    gridView_Log1.AddItem(tt2[1][j], tt2[3][j], tt2[0][j], tt2[2][j]);
                                }
                            }
                        }
                    }
                }
            }
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

        private void LogForm_Enter(object sender, EventArgs e)
        {
          
        }
    }
}
