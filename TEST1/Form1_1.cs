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
    public partial class Form1_1 : UserControl
    {

        int LineSizeX = 30;
        int LineSizeY = 330;
        int LineGap = 80;

        int CursorX, CursorY;

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
            SolidBrush br = new SolidBrush(Color.FromArgb(100, Color.Blue));
            SolidBrush br2 = new SolidBrush(Color.FromArgb(180, Color.Red));
            if(MainForm.position.position != Position.STOP)
            {
                e.Graphics.FillRectangle(br, new Rectangle(40, 10, LineSizeX, LineSizeY));
                e.Graphics.FillRectangle(br, new Rectangle(40 + LineGap, 10, LineSizeX, LineSizeY));
            }

            if(MainForm.In)
            {
                e.Graphics.FillRectangle(br, new Rectangle(100, 100, 100, 100));
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
            if (CursorX > 100 && CursorX < 200)
            {
                if (CursorY > 100 && CursorY < 200)
                {
                    MainForm.Message_popup.ShowPopup("Form Open1", false);
                }
            }
        }

        private void PB_FARM_MouseMove(object sender, MouseEventArgs e)
        {

            CursorX = e.Location.X;
            CursorY = e.Location.Y;

            if (CursorX > 100 && CursorX < 200)
            {
                if (CursorY > 100 && CursorY < 200)
                {
                    MainForm.In = true;
                }
                else
                {
                    MainForm.In = false;
                }
            }
            else
            {
                MainForm.In = false;
            }
               

            PB_FARM.Invalidate();
        }
    }
}
