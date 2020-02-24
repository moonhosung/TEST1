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

using DevExpress.XtraCharts;
using DevExpress.Utils;

namespace TEST1
{
    public partial class Form1_1 : UserControl
    {
        
        int CursorX, CursorY;
        double StartX = 52;
        double StartY = 58;
        double LocationSizeX = 37;
        double LocationSizeY = 36;
        int LineGap = 80;
        int LocationCountY = 9;
        int LocationCountX = 6;

        DoughnutSeriesView doughnutSeriesView1 = new DoughnutSeriesView();

        private static Form1_1 theInstance = null;
        public static Form1_1 CreateInstance()
        {
            if (theInstance == null)
            {
                theInstance = new Form1_1();
            }
            return theInstance;
        }

        public Form1_1()
        {
            InitializeComponent();
        }

        private void Form1_1_Load(object sender, EventArgs e)
        {
            button1.SetText("Start");

            for (int i = 0; i < LocationCountY; i++)
            {
                MainForm.Line_1.Add(false);
                MainForm.Line_2.Add(false);
                MainForm.Line_3.Add(false);
                MainForm.Line_4.Add(false);
                MainForm.Line_5.Add(false);
                MainForm.Line_6.Add(false);
            }
           // StartX -= PB_FARM.Location.X;
            //StartY -= PB_FARM.Location.Y;

            BTN_GROWTH.SetText("생육");
            BTN_HARVEST.SetText("수확");
            BTN_PEST.SetText("방제");
            BTN_GROWTH.SetCheck(true);
            BTN_GROWTH.SetType(true);
            BTN_HARVEST.SetType(true);
            BTN_PEST.SetType(true);
        }


        private void Form1_1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Silver), PB_FARM.Left - 1, PB_FARM.Top - 1, PB_FARM.Width + 2, PB_FARM.Height + 2);
        }

        private void button1_ButtonClick(object sender, EventArgs e)
        {
            if(button1.GetCheck())
            {
                MainForm.position = GetMovePosition(Position.STOP);
            }
            else
            {
                MainForm.position = GetMovePosition(Position.LINE1_START);
            }
        }

        private void AGVMoveUP()
        {
            PB_AGV1.Top += 1; 
        }

        private void AGVMoveDOWN()
        {
            PB_AGV1.Top -= 1;
        }

        private void AGVMoveLEFT()
        {
            PB_AGV1.Left -= 1;
        }

        private void AGVMoveRIGHT()
        {
            PB_AGV1.Left += 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(MainForm.position.position != Position.STOP)
             CheckPosition(MainForm.position);
        }

        private void CheckPosition(MovePosition position)
        {
           if (PB_AGV1.Left < position.X)
           {
               AGVMoveRIGHT();
           }
           else if (PB_AGV1.Left > position.X)
           {
               AGVMoveLEFT();
           }
           else
           {
               if (PB_AGV1.Top < position.Y)
               {
                   AGVMoveUP();
               }
               else if (PB_AGV1.Top > position.Y)
               {
                   AGVMoveDOWN();
               }
               else
               {
                   if(MainForm.position.position == Position.LINE1_START)
                   {
                       MainForm.position = GetMovePosition(Position.LINE1_END);
                   }
                   else if (MainForm.position.position == Position.LINE1_END)
                   {
                       MainForm.position = GetMovePosition(Position.LINE1_END2);
                   }

                }
           }
        }
        private MovePosition GetMovePosition(Position position)
        {
            MovePosition Result = new MovePosition();
            for(int i=0;i< MainForm.movePositions.Count;i++)
            {
                if(MainForm.movePositions[i].position == position)
                {
                    Result= MainForm.movePositions[i];
                }
            }
            return Result;
        }

        private void PB_FARM_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush br = new SolidBrush(Color.FromArgb(100, Color.FromArgb(200,20,40)));
            SolidBrush br2 = new SolidBrush(Color.FromArgb(180, Color.Red));
            if(MainForm.position.position != Position.STOP)
            {
                //e.Graphics.FillRectangle(br, new Rectangle(40, 10, LineSizeX, LineSizeY));
               // e.Graphics.FillRectangle(br, new Rectangle(40 + LineGap, 10, LineSizeX, LineSizeY));
            }

            for (int i = 0; i < LocationCountY; i++)
            {
                for (int j = 0; j < LocationCountX; j++)
                {
                    e.Graphics.DrawImage(global::TEST1.Properties.Resources.tomato, (int)StartX, (int)(StartY + (i * LocationSizeY)), (int)LocationSizeX, (int)LocationSizeY);
                    e.Graphics.DrawImage(global::TEST1.Properties.Resources.tomato, (int)StartX + (int)LocationSizeX - 1, (int)(StartY + (i * LocationSizeY)), (int)LocationSizeX, (int)LocationSizeY);
                    if (MainForm.Line_1[i])
                    {
                        e.Graphics.FillRectangle(br, new Rectangle((int)StartX, (int)(StartY + (i * LocationSizeY)), (int)LocationSizeX, (int)LocationSizeY));
                    }
                    if (MainForm.Line_2[i])
                    {
                        e.Graphics.FillRectangle(br, new Rectangle((int)StartX + (int)LocationSizeX - 1, (int)(StartY + (i * LocationSizeY)), (int)LocationSizeX, (int)LocationSizeY));
                    }
                }
            }
            //for(int i=0;i<10;i++)
            //{
            //    e.Graphics.FillEllipse(br2, 10, 10 + (i * 30), 30, 30);
            //    e.Graphics.FillEllipse(br2, 40, 10+(i*30), 30, 30);
            //    e.Graphics.FillEllipse(br2, 120, 10 + (i * 30), 30, 30);
            //    e.Graphics.FillEllipse(br2, 150, 10 + (i * 30), 30, 30);
            //}

        }

        private void PB_FARM_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LocationCountY; i++)
            {
                if (MainForm.Line_1[i])
                {
                    MainForm.Message_popup.ShowPopup("Form Open1_"+(i+1).ToString(), false);
                }
                if (MainForm.Line_2[i])
                {
                    MainForm.Message_popup.ShowPopup("Form Open2_" + (i + 1).ToString(), false);
                }
            }
        }

        private void PB_FARM_MouseMove(object sender, MouseEventArgs e)
        {

            CursorX = e.Location.X;
            CursorY = e.Location.Y;

            for(int i=0;i< LocationCountY; i++)
            {
                if (CursorX > StartX && CursorX < StartX+LocationSizeX)
                {
                    if (CursorY > StartY+(i*LocationSizeY) && CursorY < StartY + ((i+1) * LocationSizeY))
                    {
                        if (!MainForm.Line_1[i])
                        {
                            SetProgress(10*(i+1));
                            MainForm.Line_1[i] = true;
                        }

                    }
                    else
                    {
                        MainForm.Line_1[i] = false;
                    }
                }
                else
                {
                    MainForm.Line_1[i] = false;
                }
            }

            for (int i = 0; i < LocationCountY; i++)
            {
                if (CursorX > StartX + (LocationSizeX) && CursorX < StartX + (LocationSizeX*2))
                {
                    if (CursorY > StartY + (i * LocationSizeY) && CursorY < StartY + ((i + 1) * LocationSizeY))
                    {
                        if (!MainForm.Line_2[i])
                        {
                            SetProgress(10 * (i + 1));
                            MainForm.Line_2[i] = true;
                        }

                    }
                    else
                    {
                        MainForm.Line_2[i] = false;
                    }
                }
                else
                {
                    MainForm.Line_2[i] = false;
                }
            }


            PB_FARM.Invalidate();
        }

        private void BTN_GROWTH_ButtonClick(object sender, EventArgs e)
        {
            ResetButton();
            BTN_GROWTH.SetCheck(true);
        }

        private void BTN_PEST_ButtonClick(object sender, EventArgs e)
        {
            ResetButton();
            BTN_PEST.SetCheck(true);
        }

        private void BTN_HARVEST_ButtonClick(object sender, EventArgs e)
        {
            ResetButton();
            BTN_HARVEST.SetCheck(true);
        }

        public void ResetButton()
        {
            BTN_HARVEST.SetCheck(false);
            BTN_PEST.SetCheck(false);
            BTN_GROWTH.SetCheck(false);
        }

        public void SetProgress(int Percent)
        {
            CHART_GROWTH.Series.Clear();
            // Create a doughnut series. 
            Series series1 = new Series("Doughnut Series 1", ViewType.Doughnut);
            SeriesPoint seriesPoint = new SeriesPoint(6D, new object[] { ((object)(Percent)) }, 0);
            seriesPoint.ColorSerializable = "#C81428";
            seriesPoint.Argument = "1";
            SeriesPoint seriesPoint2 = new SeriesPoint(6D, new object[] { ((object)(100 - Percent)) }, 0);
            seriesPoint2.ColorSerializable = "#C8C8C8";
            seriesPoint2.Argument = "2";

            // Populate the series with points. 
            series1.Points.Add(seriesPoint);
            series1.Points.Add(seriesPoint2);
            series1.LabelsVisibility = DefaultBoolean.False;
            doughnutSeriesView1.Rotation = 270;
            doughnutSeriesView1.HoleRadiusPercent = 80;
            doughnutSeriesView1.TotalLabel.Visible = true;
            doughnutSeriesView1.TotalLabel.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            //doughnutSeriesView1.TotalLabel.TextPattern = "23%";
            doughnutSeriesView1.SweepDirection = PieSweepDirection.Clockwise;

            series1.View = doughnutSeriesView1;

            // Add the series to the chart. 
            CHART_GROWTH.Series.Add(series1);
            doughnutSeriesView1.TotalLabel.TextPattern = Percent.ToString() + "%";
            doughnutSeriesView1.TotalLabel.Font = new System.Drawing.Font("roboto", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doughnutSeriesView1.TotalLabel.TextColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));

        }
    }
}
