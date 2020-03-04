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
using System.Runtime.InteropServices;
using System.IO;

namespace TEST1
{
    public partial class Main : UserControl
    {

        Series[] series = new Series[3];
        int CursorX, CursorY;
        double StartX = 52;
        double StartY = 58;
        double LocationSizeX = 37;
        double LocationSizeY = 36;
        int LineGap = 50;
        int LocationCountY = 9;
        int LocationCountX = 6;
        int PestLineCount = 5;
        Random r = new Random();
        int r1, r2;
        public Bitmap img;

        DoughnutSeriesView doughnutSeriesView1 = new DoughnutSeriesView();

        private static Main theInstance = null;
        public static Main CreateInstance()
        {
            if (theInstance == null)
            {
                theInstance = new Main();
            }
            return theInstance;
        }

        public Main()
        {
            InitializeComponent();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect
                                                     , int nTopRect
                                                     , int nRightRect
                                                     , int nBottomRect
                                                     , int nWidthEllipse
                                                     , int nHeightEllipse);

        private void Main_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < LocationCountY; i++)
            {
                MainForm.Line_1.Add(false);
                MainForm.Line_2.Add(false);
                MainForm.Line_3.Add(false);
                MainForm.Line_4.Add(false);
                MainForm.Line_5.Add(false);
                MainForm.Line_6.Add(false);
            }
            for (int i = 0; i < PestLineCount; i++)
            {
                MainForm.PestLines.Add(false);
            }
                // StartX -= PB_FARM.Location.X;
                //StartY -= PB_FARM.Location.Y;

            BTN_GROWTH.SetText("Growth");
            BTN_HARVEST.SetText("Harvest");
            BTN_PEST.SetText("Pest");
            BTN_GROWTH.SetCheck(true);
            BTN_GROWTH.SetType(true);
            BTN_HARVEST.SetType(true);
            BTN_PEST.SetType(true);
            MainForm.Mode = SelectMode.GROWTH;
            r1 = r.Next(0, 100);
            r2 = r.Next(0, 100);

            ChartInit();

            //SetProgress(0);

            //for (int k = 0; k < 4; k++)
            //{
            //    ChartUpdate(k, 0, 0);
            //}
            CB_HARVEST_LINE1.InsertItem("Line 1");
            CB_HARVEST_LINE1.InsertItem("Line 2");
            CB_HARVEST_LINE1.InsertItem("Line 3");
            CB_HARVEST_LINE1.InsertItem("Line 4");

            CB_HARVEST_LINE2.InsertItem("Line 1");
            CB_HARVEST_LINE2.InsertItem("Line 2");
            CB_HARVEST_LINE2.InsertItem("Line 3");
            CB_HARVEST_LINE2.InsertItem("Line 4");

            CB_HARVEST_LINE1.SetSelectedIndex(0);
            CB_HARVEST_LINE2.SetSelectedIndex(0);

            CB_PEST_LINE1.InsertItem("Line 1");
            CB_PEST_LINE1.InsertItem("Line 2");
            CB_PEST_LINE1.InsertItem("Line 3");
            CB_PEST_LINE1.InsertItem("Line 4");

            CB_PEST_LINE2.InsertItem("Line 1");
            CB_PEST_LINE2.InsertItem("Line 2");
            CB_PEST_LINE2.InsertItem("Line 3");
            CB_PEST_LINE2.InsertItem("Line 4");

            CB_PEST_LINE1.SetSelectedIndex(0);
            CB_PEST_LINE2.SetSelectedIndex(0);

            PN_GROWTH_INFO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            PN_HARVEST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            PN_PEST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            PN_GROWTH_INFO.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PN_GROWTH_INFO.Width, PN_GROWTH_INFO.Height, 30, 30));
            PN_HARVEST.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PN_HARVEST.Width, PN_HARVEST.Height, 30, 30));
            PN_PEST.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PN_PEST.Width, PN_PEST.Height, 30, 30));

            BTN_GROWTH_CHECK.SetText("Growth Info Check");
            BTN_GROWTH_CHECK.SetType(true);

            CB_HARVEST_LINE1.Enabled = false;
            CB_HARVEST_LINE2.Enabled = false;

            // 생육정보 취득 방법 초기화
            CB_GROWTH_TYPE.InsertItem("Sample");
            CB_GROWTH_TYPE.InsertItem("All");
            CB_GROWTH_TYPE.SetSelectedIndex(0);
            //for (int i = 0; i < LocationCountY; i++)
            //{
            //    MainForm.Line_1[i] = false;
            //    MainForm.Line_2[i] = false;
            //    MainForm.Line_3[i] = false;
            //    MainForm.Line_4[i] = false;
            //}
            //int R = r.Next(0, 9);
            //MainForm.Line_1[R] = true;
            //R = r.Next(0, 9);
            //MainForm.Line_2[R] = true;
            //R = r.Next(0, 9);
            //MainForm.Line_3[R] = true;
            //R = r.Next(0, 9);
            //MainForm.Line_4[R] = true;
            //PB_FARM.Invalidate();

            SetProgress(10);

            for (int k = 0; k < 4; k++)
            {
                ChartUpdate(k, r.Next(0, 5), r.Next(0, 5));
            }
            LB_GROWTH.Text = "Line 1_1 Growth Information";

            string strExePath = Directory.GetCurrentDirectory(); //실행 Directory.
            string strFilePath;
            
            strFilePath = strExePath + "\\Image\\" + "1" + ".JPG";
            Image temp = Image.FromFile(strFilePath);
            img = temp as Bitmap;
            PB_GROWTH.BackgroundImage = temp;

            BTN_HARVEST_START.SetText("Harvest Start");
            //BTN_HARVEST_START.SetType(true);
            BTN_HARVEST_START.Enabled = false;

            BTN_PEST_START.SetText("Pest Start");
            //BTN_HARVEST_START.SetType(true);
            BTN_PEST_START.Enabled = false;
        }


        public void InitPosition()
        {
            MovePosition temp = new MovePosition();

            temp.position = Position.LINE1_START;
            temp.X = (int)StartX + ((int)LineGap/2) + ((int)LocationSizeX * 2);
            temp.Y = (int)StartY + (int)LocationSizeY*9;
            temp.X += PB_FARM.Location.X;
            temp.Y += PB_FARM.Location.Y;
            temp.X -= PB_AGV1.Size.Width / 2;
           // temp.Y -= PB_AGV1.Size.Height / 2;
            MainForm.movePositions.Add(temp);
            
            temp.position = Position.LINE1_END;
            temp.X = (int)StartX + ((int)LineGap/2) + ((int)LocationSizeX * 2);
            temp.Y = (int)StartY;
            temp.X += PB_FARM.Location.X;
            temp.Y += PB_FARM.Location.Y;
            temp.X -= PB_AGV1.Size.Width / 2;
            //temp.Y -= PB_AGV1.Size.Height / 2;
            MainForm.movePositions.Add(temp);
            
            temp.position = Position.LINE1_END2;
            temp.X =(int)StartX + ((int)LineGap/2) + ((int)LocationSizeX * 2);
            temp.Y = (int)StartY + (int)LocationSizeY * 9;
            temp.X += PB_FARM.Location.X;
            temp.Y += PB_FARM.Location.Y;
            temp.X -= PB_AGV1.Size.Width / 2;
            //temp.Y -= PB_AGV1.Size.Height / 2;
            MainForm.movePositions.Add(temp);
            MainForm.position = GetMovePosition(Position.STOP);
        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Silver), PB_FARM.Left - 1, PB_FARM.Top - 1, PB_FARM.Width + 2, PB_FARM.Height + 2);
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
            SolidBrush br = new SolidBrush(Color.FromArgb(100, Color.FromArgb(200, 20, 40)));
            SolidBrush br2 = new SolidBrush(Color.FromArgb(100, Color.BlueViolet));
            SolidBrush br3 = new SolidBrush(Color.FromArgb(100, Color.Green));

            if (MainForm.position.position != Position.STOP)
            {
                //e.Graphics.FillRectangle(br, new Rectangle(40, 10, LineSizeX, LineSizeY));
                // e.Graphics.FillRectangle(br, new Rectangle(40 + LineGap, 10, LineSizeX, LineSizeY));
            }
            for (int j = 0; j < LocationCountX; j++)
            {
                for (int i = 0; i < LocationCountY; i++)
                {
                    if (r1 > 60)
                    {
                        e.Graphics.DrawImage(global::TEST1.Properties.Resources.green_tomato, (int)StartX + ((int)LineGap * j) + ((int)LocationSizeX * 2 * j), (int)(StartY + (i * LocationSizeY)), (int)LocationSizeX, (int)LocationSizeY);
                    }
                    else if (r1 > 30)
                    {
                        e.Graphics.DrawImage(global::TEST1.Properties.Resources.yellow_tomato, (int)StartX + ((int)LineGap * j) + ((int)LocationSizeX * 2 * j), (int)(StartY + (i * LocationSizeY)), (int)LocationSizeX, (int)LocationSizeY);
                    }
                    else
                    {
                        e.Graphics.DrawImage(global::TEST1.Properties.Resources.tomato, (int)StartX + ((int)LineGap * j) + ((int)LocationSizeX * 2 * j), (int)(StartY + (i * LocationSizeY)), (int)LocationSizeX, (int)LocationSizeY);
                    }
                    if (r2 > 60)
                    {
                        e.Graphics.DrawImage(global::TEST1.Properties.Resources.green_tomato, (int)StartX + ((int)LineGap * j) + ((int)LocationSizeX*2) * j + (int)LocationSizeX, (int)(StartY + (i * LocationSizeY)), (int)LocationSizeX, (int)LocationSizeY);
                    }
                    else if (r2 > 30)
                    {
                        e.Graphics.DrawImage(global::TEST1.Properties.Resources.yellow_tomato, (int)StartX + ((int)LineGap * j) + ((int)LocationSizeX * 2) * j + (int)LocationSizeX, (int)(StartY + (i * LocationSizeY)), (int)LocationSizeX, (int)LocationSizeY);
                    }
                    else
                    {
                        e.Graphics.DrawImage(global::TEST1.Properties.Resources.tomato, (int)StartX + ((int)LineGap * j) + ((int)LocationSizeX * 2) * j + (int)LocationSizeX, (int)(StartY + (i * LocationSizeY)), (int)LocationSizeX, (int)LocationSizeY);
                    }
                }
            }

            if (MainForm.Mode == SelectMode.HARVEST)
            {
                if (Int32.Parse(CB_HARVEST_LINE1.GetSelectedItem().Substring(5,1)) == 1)
                {
                    e.Graphics.FillRectangle(br2, new Rectangle((int)StartX, (int)StartY, (int)LocationSizeX, (int)(LocationCountY * LocationSizeY)));
                }
                if (Int32.Parse(CB_HARVEST_LINE1.GetSelectedItem().Substring(5, 1)) <= 2 && Int32.Parse(CB_HARVEST_LINE2.GetSelectedItem().Substring(5, 1)) >= 2)
                {
                    e.Graphics.FillRectangle(br2, new Rectangle((int)StartX + (int)LocationSizeX, (int)StartY, (int)LocationSizeX, (int)(LocationCountY * LocationSizeY)));
                }
                if (Int32.Parse(CB_HARVEST_LINE1.GetSelectedItem().Substring(5, 1)) <= 3 && Int32.Parse(CB_HARVEST_LINE2.GetSelectedItem().Substring(5, 1)) >= 3)
                {
                    e.Graphics.FillRectangle(br2, new Rectangle((int)StartX + ((int)LineGap) + ((int)LocationSizeX * 2), (int)StartY, (int)LocationSizeX, (int)(LocationCountY * LocationSizeY)));
                }
                if (Int32.Parse(CB_HARVEST_LINE1.GetSelectedItem().Substring(5, 1)) <= 4 && Int32.Parse(CB_HARVEST_LINE2.GetSelectedItem().Substring(5, 1)) >= 4)
                {
                    e.Graphics.FillRectangle(br2, new Rectangle((int)StartX + ((int)LineGap) + ((int)LocationSizeX * 2) + (int)LocationSizeX, (int)StartY, (int)LocationSizeX, (int)(LocationCountY * LocationSizeY)));
                }
            }


            if (MainForm.Mode == SelectMode.GROWTH)
            {
                for (int j = 0; j < LocationCountX; j++)
                {
                    for (int i = 0; i < LocationCountY; i++)
                    {
                        if (MainForm.Line_1[i] && j == 0)
                        {
                            e.Graphics.FillRectangle(br, new Rectangle((int)StartX + ((int)LineGap * j) + ((int)LocationSizeX * 2 * j), (int)(StartY + (i * LocationSizeY)), (int)LocationSizeX, (int)LocationSizeY));
                        }
                        if (MainForm.Line_2[i] && j == 0)
                        {
                            e.Graphics.FillRectangle(br, new Rectangle((int)StartX + ((int)LineGap * j) + ((int)LocationSizeX * 2 * j) + (int)LocationSizeX, (int)(StartY + (i * LocationSizeY)), (int)LocationSizeX, (int)LocationSizeY));
                        }
                        if (MainForm.Line_3[i] && j == 1)
                        {
                            e.Graphics.FillRectangle(br, new Rectangle((int)StartX + ((int)LineGap * j) + ((int)LocationSizeX * 2 * j), (int)(StartY + (i * LocationSizeY)), (int)LocationSizeX, (int)LocationSizeY));
                        }
                        if (MainForm.Line_4[i] && j == 1)
                        {
                            e.Graphics.FillRectangle(br, new Rectangle((int)StartX + ((int)LineGap * j) + ((int)LocationSizeX * 2 * j) + (int)LocationSizeX, (int)(StartY + (i * LocationSizeY)), (int)LocationSizeX, (int)LocationSizeY));
                        }

                        if(MainForm.Growth_Check[j,i])
                        {
                            if(j%2==0)
                            {
                                e.Graphics.FillRectangle(br3, new Rectangle((int)StartX + ((int)LineGap * (j/2)) + ((int)LocationSizeX * 2 * (j / 2)), (int)(StartY + (i * LocationSizeY)), (int)LocationSizeX, (int)LocationSizeY));
                            }
                            else
                            {
                                e.Graphics.FillRectangle(br3, new Rectangle((int)StartX + ((int)LineGap * (j / 2)) + ((int)LocationSizeX * 2 * (j / 2)) + (int)LocationSizeX, (int)(StartY + (i * LocationSizeY)), (int)LocationSizeX, (int)LocationSizeY));
                            }

                        }
                    }
                }
            }

            if (MainForm.Mode == SelectMode.PEST)
            {
                for (int i = 0; i < PestLineCount; i++)
                {
                    if (MainForm.PestLines[i])
                    {
                        e.Graphics.FillRectangle(br, new Rectangle((int)StartX + ((int)LineGap * i) + ((int)LocationSizeX * 2 * i) + (int)LocationSizeX*2, (int)StartY, (int)LineGap/*+( (int)LocationSizeX * 2)*/, (int)(LocationCountY * LocationSizeY)));
                       
                    }
                }
            }
        }

        private void PB_FARM_Click(object sender, EventArgs e)
        {
            string strExePath = Directory.GetCurrentDirectory(); //실행 Directory.
            string strFilePath;

            if (MainForm.Mode == SelectMode.GROWTH)
            {
                for (int i = 0; i < LocationCountY; i++)
                {
                    if (MainForm.Line_1[i])
                    {
                        SetProgress(10 * (i + 1));

                        for (int k = 0; k < 4; k++)
                        {
                            ChartUpdate(k, r.Next(0, 5), r.Next(0, 5));
                        }
                        LB_GROWTH.Text = "Line 1_" + (i + 1).ToString() + " Growth Information";

                        strFilePath = strExePath + "\\Image\\" + "1" + ".JPG";
                        Image temp = Image.FromFile(strFilePath);
                        img = temp as Bitmap;
                        PB_GROWTH.BackgroundImage = temp;
                        //MainForm.Message_popup.ShowPopup("Form Open1_" + (i + 1).ToString(), false);
                    }
                    if (MainForm.Line_2[i])
                    {
                        SetProgress(10 * (i + 1));

                        for (int k = 0; k < 4; k++)
                        {
                            ChartUpdate(k, r.Next(0, 5), r.Next(0, 5));
                        }

                        strFilePath = strExePath + "\\Image\\" + "2" + ".JPG";
                        Image temp = Image.FromFile(strFilePath);
                        img = temp as Bitmap;
                        PB_GROWTH.BackgroundImage = temp;
                        LB_GROWTH.Text = "Line 2_" + (i + 1).ToString() + " Growth Information";
                        //MainForm.Message_popup.ShowPopup("Form Open2_" + (i + 1).ToString(), false);
                    }


                    if (MainForm.Line_3[i])
                    {
                        SetProgress(10 * (i + 1));

                        for (int k = 0; k < 4; k++)
                        {
                            ChartUpdate(k, r.Next(0, 5), r.Next(0, 5));
                        }


                        strFilePath = strExePath + "\\Image\\" + "3" + ".JPG";
                        Image temp = Image.FromFile(strFilePath);
                        img = temp as Bitmap;
                        PB_GROWTH.BackgroundImage = temp;
                        LB_GROWTH.Text = "Line 3_" + (i + 1).ToString() + " Growth Information";
                        //MainForm.Message_popup.ShowPopup("Form Open3_" + (i + 1).ToString(), false);
                    }
                    if (MainForm.Line_4[i])
                    {
                        SetProgress(10 * (i + 1));

                        for (int k = 0; k < 4; k++)
                        {
                            ChartUpdate(k, r.Next(0, 5), r.Next(0, 5));
                        }
                        strFilePath = strExePath + "\\Image\\" + "1" + ".JPG";
                        Image temp = Image.FromFile(strFilePath);
                        img = temp as Bitmap;
                        PB_GROWTH.BackgroundImage = temp;
                        
                        LB_GROWTH.Text = "Line 4_" + (i + 1).ToString() + " Growth Information";
                        //MainForm.Message_popup.ShowPopup("Form Open4_" + (i + 1).ToString(), false);
                    }
                }
            }
            if (MainForm.Mode == SelectMode.PEST)
            {
                for(int i=0;i<MainForm.PestLines.Count;i++)
                {
                    if (MainForm.PestLines[i])
                        MainForm.Message_popup.ShowPopup("Pest Popup_"+i+1, false);
                }
            }
        }

        private void PB_FARM_MouseMove(object sender, MouseEventArgs e)
        {

            CursorX = e.Location.X;
            CursorY = e.Location.Y;

            if (MainForm.position.position != Position.STOP)
            {
                return;
            }

            if (MainForm.Mode == SelectMode.GROWTH)
            {
                for (int i = 0; i < LocationCountY; i++)
                {
                    for (int j = 0; j < LocationCountX; j++)
                    {

                        if (CursorX > (int)StartX + ((int)LineGap * j) +((int)LocationSizeX*2*j) && CursorX < (int)StartX + ((int)LineGap * j) + (int)LocationSizeX + ((int)LocationSizeX * 2 * j))
                        {
                            if (CursorY > StartY + (i * LocationSizeY) && CursorY < StartY + ((i + 1) * LocationSizeY))
                            {
                                if (!MainForm.Line_1[i] && j == 0)
                                {
                                    MainForm.Line_2[i] = false;
                                    MainForm.Line_1[i] = true;
                                    MainForm.Line_3[i] = false;
                                    MainForm.Line_4[i] = false;
                                }
                                else if (!MainForm.Line_3[i] && j == 1)
                                {
                                    MainForm.Line_2[i] = false;
                                    MainForm.Line_3[i] = true;
                                    MainForm.Line_1[i] = false;
                                    MainForm.Line_4[i] = false;
                                }
                            }
                            else
                            {
                                MainForm.Line_1[i] = false;
                                MainForm.Line_2[i] = false;
                                MainForm.Line_3[i] = false;
                                MainForm.Line_4[i] = false;
                            }
                        }

                        if (CursorX > (int)StartX + ((int)LineGap * j) + ((int)LocationSizeX * 2 * j) + (int)LocationSizeX && CursorX < (int)StartX + ((int)LineGap * j) + ((int)LocationSizeX * 2 * j) + ((int)LocationSizeX * 2))
                        {
                            if (CursorY > StartY + (i * LocationSizeY) && CursorY < StartY + ((i + 1) * LocationSizeY))
                            {
                                if (!MainForm.Line_2[i] && j == 0)
                                {
                                    MainForm.Line_2[i] = true;
                                    MainForm.Line_1[i] = false;
                                    MainForm.Line_3[i] = false;
                                    MainForm.Line_4[i] = false;
                                }
                                else if (!MainForm.Line_4[i] && j == 1)
                                {
                                  
                                    MainForm.Line_2[i] = false;
                                    MainForm.Line_3[i] = false;
                                    MainForm.Line_1[i] = false;
                                    MainForm.Line_4[i] = true;
                                }
                            }
                            else
                            {
                                MainForm.Line_1[i] = false;
                                MainForm.Line_2[i] = false;
                                MainForm.Line_3[i] = false;
                                MainForm.Line_4[i] = false;
                            }
                        }
                    }
                }
            }


            if (MainForm.Mode == SelectMode.PEST)
            { 
                for (int i = 0; i < PestLineCount; i++)
                {
                    if (CursorX > (int)StartX + ((int)LineGap * i) + ((int)LocationSizeX * 2 * i) + (int)LocationSizeX && CursorX < (int)StartX + ((int)LineGap * (i+1)) + ((int)LocationSizeX * 2 * (i+1)) + (int)LocationSizeX)
                    {
                        if (CursorY > StartY && CursorY < StartY + (LocationCountY * LocationSizeY))
                        {
                            MainForm.PestLines[i] = true;
                        }
                        else
                        {
                            MainForm.PestLines[i] = false;
                        }
                    }
                    else
                    {
                        MainForm.PestLines[i] = false;
                    }
                }
            }


            PB_FARM.Invalidate();
        }

        private void BTN_GROWTH_ButtonClick(object sender, EventArgs e)
        {
            ResetButton();
            BTN_GROWTH.SetCheck(true);

            MainForm.Mode = SelectMode.GROWTH;

            PB_FARM.Invalidate();
            CB_HARVEST_LINE1.Enabled = false;
            CB_HARVEST_LINE2.Enabled = false;
            CB_GROWTH_TYPE.Enabled = true;
            BTN_GROWTH_CHECK.Enabled = true;
            CB_PEST_LINE1.Enabled = false;
            CB_PEST_LINE2.Enabled = false;

            BTN_PEST_START.Enabled = false;
            BTN_HARVEST_START.Enabled = false;
            PN_GROWTH_INFO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            PN_HARVEST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            PN_PEST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
        }

        private void BTN_PEST_ButtonClick(object sender, EventArgs e)
        {
            ResetButton();
            BTN_PEST.SetCheck(true);

            MainForm.Mode = SelectMode.PEST;

            PB_FARM.Invalidate();
            CB_HARVEST_LINE1.Enabled = false;
            CB_HARVEST_LINE2.Enabled = false;
            CB_GROWTH_TYPE.Enabled = false;
            BTN_GROWTH_CHECK.Enabled = false;
            CB_PEST_LINE1.Enabled = true;
            CB_PEST_LINE2.Enabled = true;

            BTN_HARVEST_START.Enabled = false;
            BTN_PEST_START.Enabled = true;
            PN_GROWTH_INFO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            PN_HARVEST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            PN_PEST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
        }

        private void BTN_HARVEST_ButtonClick(object sender, EventArgs e)
        {
            ResetButton();
            BTN_HARVEST.SetCheck(true);

            MainForm.Mode = SelectMode.HARVEST;

            PB_FARM.Invalidate();
            CB_HARVEST_LINE1.Enabled = true;
            CB_HARVEST_LINE2.Enabled = true;

            CB_PEST_LINE1.Enabled = false;
            CB_PEST_LINE2.Enabled = false;
            CB_GROWTH_TYPE.Enabled = false;
            BTN_PEST_START.Enabled = false;

            BTN_HARVEST_START.Enabled = true;
            BTN_GROWTH_CHECK.Enabled = false;
            PN_GROWTH_INFO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            PN_HARVEST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            PN_PEST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
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
            seriesPoint2.ColorSerializable = "#FFCCCC";
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

            CHART_GROWTH.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.RightOutside;
            CHART_GROWTH.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            series1.View = doughnutSeriesView1;

            // Add the series to the chart. 
            CHART_GROWTH.Series.Add(series1);
            doughnutSeriesView1.TotalLabel.TextPattern = Percent.ToString() + "%";
            doughnutSeriesView1.TotalLabel.Font = new System.Drawing.Font("roboto", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doughnutSeriesView1.TotalLabel.TextColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));

        }

        private void CB_GROWTH_LINE_ButtonClick(object sender, EventArgs e)
        {
            CB_HARVEST_LINE2.ClearItem();
            int num = CB_HARVEST_LINE1.GetSelectedIndex();
            if(num==0)
            {
                CB_HARVEST_LINE2.InsertItem("Line 1");
                CB_HARVEST_LINE2.InsertItem("Line 2");
                CB_HARVEST_LINE2.InsertItem("Line 3");
                CB_HARVEST_LINE2.InsertItem("Line 4");
            }
            if (num == 1)
            {
                CB_HARVEST_LINE2.InsertItem("Line 2");
                CB_HARVEST_LINE2.InsertItem("Line 3");
                CB_HARVEST_LINE2.InsertItem("Line 4");
            }
            if (num == 2)
            {
                CB_HARVEST_LINE2.InsertItem("Line 3");
                CB_HARVEST_LINE2.InsertItem("Line 4");
            }
            if (num == 3)
            {
                CB_HARVEST_LINE2.InsertItem("Line 4");
            }

            CB_HARVEST_LINE2.SetSelectedIndex(0);
            PB_FARM.Invalidate();
        }

        private void BTN_GROWTH_CHECK_ButtonClick(object sender, EventArgs e)
        {
            MainForm.Message_popup.ShowPopup("Do you want to start acquiring growth information?", "Growth information", false);
            if (MainForm.Message_popup.YesNo)
            {
                // 정보취득 시작
            }
        }

        private void CB_HARVEST_LINE2_ButtonClick(object sender, EventArgs e)
        {

            PB_FARM.Invalidate();
        }

        private void CB_GROWTH_TYPE_ButtonClick(object sender, EventArgs e)
        {
            if (CB_GROWTH_TYPE.GetSelectedItem() == "Sample")
            {
                for (int i = 0; i < LocationCountY; i++)
                {
                    for (int j = 0; j < LocationCountX; j++)
                    {
                        MainForm.Growth_Check[j, i] = false;
                    }
                }
                int temp = r.Next(0, 9);
                MainForm.Growth_Check[0, temp] = true;

                temp = r.Next(0, 9);
                MainForm.Growth_Check[1, temp] = true;
                temp = r.Next(0, 9);
                MainForm.Growth_Check[2, temp] = true;
                temp = r.Next(0, 9);
                MainForm.Growth_Check[3, temp] = true;
            }
            else
            {
                for (int i = 0; i < LocationCountY; i++)
                {
                    for (int j = 0; j < LocationCountX-2; j++)
                    {
                        MainForm.Growth_Check[j, i] = true;
                    }
                }
            }
            PB_FARM.Invalidate();
        }

        private void PN_GROWTH_INFO_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.PaleVioletRed, 4), PB_GROWTH.Left - 2, PB_GROWTH.Top - 2, PB_GROWTH.Width + 4, PB_GROWTH.Height + 4);
        }

        private void BTN_HARVEST_START_ButtonClick(object sender, EventArgs e)
        {
            if(BTN_HARVEST_START.GetCheck())
            {
                BTN_HARVEST_START.SetCheck(true);
                MainForm.position = GetMovePosition(Position.STOP);
            }
            else
            {
                BTN_HARVEST_START.SetCheck(false);
                MainForm.position = GetMovePosition(Position.LINE1_START);
            }
        }

        private void BTN_PEST_START_ButtonClick(object sender, EventArgs e)
        {
            if (BTN_PEST_START.GetCheck())
            {
                BTN_PEST_START.SetCheck(true);
                MainForm.position = GetMovePosition(Position.STOP);
            }
            else
            {
                BTN_PEST_START.SetCheck(false);
                MainForm.position = GetMovePosition(Position.LINE1_START);
            }
        }

        private void ChartInit()
        {
            CHART_GROWTH2.Series.Clear();
            series[0] = new Series("Data1", ViewType.Line);
            series[1] = new Series("Data2", ViewType.Line);
            series[2] = new Series("Data3", ViewType.Line);
            //ChartControl에 Series 추가            
            CHART_GROWTH2.Series.Add(series[0]);
            CHART_GROWTH2.Series.Add(series[1]);
            CHART_GROWTH2.Series.Add(series[2]);
            CHART_GROWTH2.CrosshairEnabled = DefaultBoolean.False;

            XYDiagram diagram = (XYDiagram)CHART_GROWTH2.Diagram;
            diagram.AxisY.WholeRange.MaxValue = 2000;    // y축 최대값     
            diagram.AxisY.WholeRange.MinValue = 0;   // y축 최소값     
            diagram.AxisY.WholeRange.Auto = true;      // y축 범위 자동변경 설정  
            diagram.AxisX.WholeRange.SideMarginsValue = 0;
            diagram.AxisX.WholeRange.MaxValue = 3;    // x축 최대값     
            diagram.AxisX.WholeRange.MinValue = 0;   // x축 최소값     
            ConstantLine zeroLine = new ConstantLine();
            zeroLine.Color = Color.LightYellow;
            zeroLine.AxisValue = 0;
            zeroLine.ShowInLegend = false;
            diagram.AxisY.ConstantLines.Add(zeroLine);  // y값 0인 x축 생성     
            diagram.EnableAxisXScrolling = true;   //스크롤과 줌은 절대       
            diagram.EnableAxisXZooming = true; //true로 하지않도록 한다. 

        }


        private void ChartUpdate(int para1, int para2, int para3)
        {
            if (series[0].Points.Count > 3) // x축은 10개까지만 값을 출력하게 한다.    
            {
                series[0].Points.RemoveAt(0);
                series[1].Points.RemoveAt(0);
                series[2].Points.RemoveAt(0);
            }
            
            // DataInsertLog("Process", "Test");
            // AddLogMessage("Test", 1);
            DateTime Today = DateTime.Now;
            CUIInvoke uiInvoke = CUIInvoke.CreateInstance();
            int OK = 0, NG = 0;
            string[] tt = { "date", "user", "OK", "NG" };
            List<string>[] tt2;
            //tt2 = com.DBSelect("work", tt);
            //int Year, Month, Day, hour, min;
            //// for (int i = 0; i < tt2.Count(); i++)
            //{
            //    for (int j = 0; j < tt2[0].Count(); j++)
            //    {
            //        Year = Int32.Parse(tt2[0][j].Substring(0, 4));
            //        Month = Int32.Parse(tt2[0][j].Substring(5, 2));
            //        Day = Int32.Parse(tt2[0][j].Substring(8, 2));
            //        hour = Int32.Parse(tt2[0][j].Substring(11, 2));
            //        min = Int32.Parse(tt2[0][j].Substring(14, 2));
            //        if (Day == Today.Day
            //            && Month == Today.Month
            //            && Year == Today.Year
            //            )
            //        {
            //            if (hour == Hour)
            //            {
            //                OK += Int32.Parse(tt2[2][j]);
            //                NG += Int32.Parse(tt2[3][j]);
            //            }
            //        }
            //    }
            //}
            //series[0].Points.Clear();
            //series[1].Points.Clear();
            //series[2].Points.Clear();

            series[0].Points.Add(new SeriesPoint(para1, para2));
            series[1].Points.Add(new SeriesPoint(para1, para3));
            series[2].Points.Add(new SeriesPoint(para1, para2 + para3));
        }
    }
}
