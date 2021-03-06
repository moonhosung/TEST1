﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;

namespace User_Control
{
    public partial class GridView_Input : UserControl
    {

        private List<Info> infolist = null;

        private bool[] IO_Status = null;
        public event EventHandler ButtonClick;
        private int UV_Ready = 99;
        public GridView_Input()
        {
            InitializeComponent();
            //  gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
            DevExpress.XtraEditors.VScrollBar vScrollBar = gridControl1.Controls.OfType<DevExpress.XtraEditors.VScrollBar>().FirstOrDefault();
            if (vScrollBar != null)
            {
                vScrollBar.LookAndFeel.UseDefaultLookAndFeel = false;
                vScrollBar.LookAndFeel.UseWindowsXPTheme = false;
                vScrollBar.LookAndFeel.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.DevExpress);
                GridViewInfo viewInfo = gridView1.GetViewInfo() as GridViewInfo;
            }
            //CreateData();
        }
        
        public class Info
        {
            public int Num { get; set; }
            public string Input { get; set; }
        }
        
        const int RowCount = 4;
        public void CreateData(List<string> data)
        {
            infolist = new List<Info>();
            
            //repositoryItemCheckEdit1.PictureChecked = global::User_Control.Properties.Resources.common_img_light_on;
           for(int i=1;i<data.Count+1; i++)
            {
                infolist.Add(new Info()
                {
                    Num = i,
                    Input = data[i-1]
                });
            }
            this.bindingSource1.DataSource = infolist;
        }
        
        public void SetData(int row, string enable)
        {
            object Check = gridView1.GetRowCellValue(row, "In");
            gridView1.SetRowCellValue(row, gridView1.Columns[1], enable);
        }

        public void SetIO_Status(bool[] IO_List,int UV_Ready_Num)
        {

            IO_Status = IO_List;
            UV_Ready = UV_Ready_Num;
            gridView1.Invalidate();
        }
        public void SetCaption(string str)
        {
            gridColumn2.Caption = str;
        }
        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            //Color warning = Color.Red;
            //Color on = Color.LawnGreen;
            //Color off = Color.Gray;
            //int markWidth = 25;
            //e.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            //e.Appearance.Options.UseTextOptions = true;
            //e.DefaultDraw();

            //int OutSizeX = 115;
            //int OutSizeY = 40;

            //int InSizeX = 113;
            //int InSizeY = 35;

            //if (e.Column.FieldName=="In")
            //{

            //    Pen p = new Pen(SystemColors.HotTrack, 2);
            //    string cellValue = (string)(e.CellValue);
            //    Rectangle temp = new Rectangle(e.Bounds.X + 5, e.Bounds.Y + 5, InSizeX, InSizeY);
            //    Rectangle temp2 = new Rectangle(e.Bounds.X + (InSizeX) + 15, e.Bounds.Y + 5, InSizeX, InSizeY);
            //    Rectangle temp3 = new Rectangle(e.Bounds.X + (InSizeX*2) + 25, e.Bounds.Y + 5, InSizeX, InSizeY);
            //    int row = e.RowHandle;
            //    object Title = gridView1.GetRowCellValue(row, "Title");
            //    if(cellValue.Length>=1)
            //    { 
            //       if (cellValue.Substring(0,1)=="1")
            //       {
            //           e.Cache.DrawImage(global::User_Control.Properties.Resources.common_img_light_on, temp);
            //           if(row<7)
            //           {
            //               e.Cache.DrawString("On", new Font("roboto", 12F), new SolidBrush(Color.FromArgb(255, Color.Black)), e.Bounds.X + 27, e.Bounds.Y + 13);
            //           }
            //            if (row == 7)
            //            {
            //                e.Cache.DrawString("All On", new Font("roboto", 12F), new SolidBrush(Color.FromArgb(255, Color.Black)), e.Bounds.X + 27, e.Bounds.Y + 13);
            //            }
            //            if (row==8)
            //            {
            //                e.Cache.DrawString("Ready", new Font("roboto", 12F), new SolidBrush(Color.FromArgb(255, Color.Black)), e.Bounds.X + 27, e.Bounds.Y + 13);
            //            }
            //            if (row == 9)
            //            {
            //                e.Cache.DrawString("Error", new Font("roboto", 12F), new SolidBrush(Color.FromArgb(255, Color.Black)), e.Bounds.X + 27, e.Bounds.Y + 13);
            //            }
            //        }
            //       if (cellValue.Substring(0, 1) == "0")
            //       {
            //           e.Cache.DrawImage(global::User_Control.Properties.Resources.common_img_light_off, temp);
            //           if (row < 7)
            //           {
            //               e.Cache.DrawString("Off", new Font("roboto", 12F), new SolidBrush(Color.FromArgb(255, Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152))))))), e.Bounds.X + 25, e.Bounds.Y + 13);
            //           }
            //            if (row == 7)
            //            {
            //                e.Cache.DrawString("All Off", new Font("roboto", 12F), new SolidBrush(Color.FromArgb(255, Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152))))))), e.Bounds.X + 27, e.Bounds.Y + 13);
            //            }
            //            if (row == 8)
            //            {
            //                e.Cache.DrawString("Ready", new Font("roboto", 12F), new SolidBrush(Color.FromArgb(255, Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152))))))), e.Bounds.X + 27, e.Bounds.Y + 13);
            //            }
            //            if (row == 9)
            //            {
            //                e.Cache.DrawString("Error", new Font("roboto", 12F), new SolidBrush(Color.FromArgb(255, Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152))))))), e.Bounds.X + 27, e.Bounds.Y + 13);
            //            }
            //        }
            //    }
            //    if (cellValue.Length >= 2)
            //    {
            //        if (cellValue.Substring(1, 1) == "1")
            //        {
            //            e.Cache.DrawImage(global::User_Control.Properties.Resources.common_img_light_on, temp2);
            //            if (row == 8)
            //            {
            //                e.Cache.DrawString("Busy", new Font("roboto", 12F), new SolidBrush(Color.FromArgb(255, Color.Black)), temp2.X + 20, e.Bounds.Y + 13);
            //            }
            //            if (row == 9)
            //            {
            //                e.Cache.DrawString("Temp", new Font("roboto", 12F), new SolidBrush(Color.FromArgb(255, Color.Black)), temp2.X + 20, e.Bounds.Y + 13);
            //            }
            //        }
            //        if (cellValue.Substring(1, 1) == "0")
            //        {
            //            e.Cache.DrawImage(global::User_Control.Properties.Resources.common_img_light_off, temp2);
            //            if (row == 8)
            //            {
            //                e.Cache.DrawString("Busy", new Font("roboto", 12F), new SolidBrush(Color.FromArgb(255, Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152))))))), temp2.X + 20, e.Bounds.Y + 13);
            //            }
            //            if (row == 9)
            //            {
            //                e.Cache.DrawString("Temp", new Font("roboto", 12F), new SolidBrush(Color.FromArgb(255, Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152))))))), temp2.X + 20, e.Bounds.Y + 13);
            //            }
            //        }
            //    }
            //    if (cellValue.Length >= 3)
            //    {
            //        if (cellValue.Substring(2, 1) == "1")
            //        {
            //            e.Cache.DrawImage(global::User_Control.Properties.Resources.common_img_light_on, temp3);
            //            if (row == 9)
            //            {
            //                e.Cache.DrawString("OCP", new Font("roboto", 12F), new SolidBrush(Color.FromArgb(255, Color.Black)), temp3.X + 20, e.Bounds.Y + 13);
            //            }
            //        }
            //        if (cellValue.Substring(2, 1) == "0")
            //        {
            //            e.Cache.DrawImage(global::User_Control.Properties.Resources.common_img_light_off, temp3);
            //            if (row == 9)
            //            {
            //                e.Cache.DrawString("OCP", new Font("roboto", 12F), new SolidBrush(Color.FromArgb(255, Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152))))))), temp3.X + 20, e.Bounds.Y + 13);
            //            }
            //        }
            //    }
            //new SolidBrush(Color.FromArgb(255, Color.Black))

            //e.Appearance.BackColor = Color.FromArgb(244, 249, 255);

            // }
            //if (e.Column.FieldName == "Out")
            //{
            //    Pen p = new Pen(SystemColors.HotTrack, 2);
            //    bool cellValue = (bool)(e.CellValue);
            //    int row = e.RowHandle;
            //    SolidBrush br = new SolidBrush(Color.FromArgb(255, Color.White));
            //    Rectangle temp = new Rectangle(e.Bounds.X + (e.Bounds.Width / 2) - (OutSizeX / 2), e.Bounds.Y + 5, OutSizeX, OutSizeY);
            //    if (row < 8)
            //    {
            //        if (cellValue)
            //        {
            //            e.Cache.DrawImage(global::User_Control.Properties.Resources.common_bt_toggle_01_on, temp);
            //            e.Cache.DrawString("On", new Font("roboto", 12F), new SolidBrush(Color.FromArgb(255, Color.White)), e.Bounds.X + 50, e.Bounds.Y + 13);
            //        }
            //        else
            //        {
            //            e.Cache.DrawImage(global::User_Control.Properties.Resources.common_bt_toggle_01_off, temp);
            //            e.Cache.DrawString("Off", new Font("roboto", 12F), new SolidBrush(Color.FromArgb(255, Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(255))))))), e.Bounds.X + 105, e.Bounds.Y + 13);
            //        } 
            //    }
            //    else
            //    {
            //        e.Cache.FillRectangle(br, temp);
            //    }
            //    //new SolidBrush(Color.FromArgb(255, Color.Black))

              int row = e.RowHandle;
              if (row>=IO_Status.Count())
              {
                  return;
              }
              if(e.Column.FieldName == "Input")
              { 
                if(row == UV_Ready || row == UV_Ready+1 || row == UV_Ready+2 || row == UV_Ready+3 || row == UV_Ready+4)
                {

                    if (!IO_Status[row])
                    {
                        e.Appearance.BackColor = Color.FromArgb(223, 240, 255);
                        e.Appearance.ForeColor = Color.FromArgb(0, 119, 255);
                    }
                    else
                    {
                        e.Appearance.BackColor = Color.White;
                        e.Appearance.ForeColor = Color.FromArgb(51, 51, 51);
                    }
                }
                else
                {

                    if (IO_Status[row])
                    {
                        e.Appearance.BackColor = Color.FromArgb(223, 240, 255);
                        e.Appearance.ForeColor = Color.FromArgb(0, 119, 255);
                    }
                    else
                    {
                        e.Appearance.BackColor = Color.White;
                        e.Appearance.ForeColor = Color.FromArgb(51, 51, 51);
                    }
                }
              }
            else
            {
                if (row == UV_Ready || row == UV_Ready + 1 || row == UV_Ready + 2 || row == UV_Ready + 3 || row == UV_Ready + 4)
                {
                    if (!IO_Status[row])
                    {
                        e.Appearance.ForeColor = Color.FromArgb(0, 119, 255);
                    }
                    else
                    {
                        e.Appearance.ForeColor = Color.FromArgb(51, 51, 51);
                    }
                }
                else
                {
                    if (IO_Status[row])
                    {
                        e.Appearance.ForeColor = Color.FromArgb(0, 119, 255);
                    }
                    else
                    {
                        e.Appearance.ForeColor = Color.FromArgb(51, 51, 51);
                    }
                }
            }
            //}
        }
        public int GetRowData()
        {
            int row = gridView1.GetSelectedRows()[0];
            return row;
        }
        public bool GetCheckData()
        {
            int row = gridView1.GetSelectedRows()[0];
            object Check = gridView1.GetRowCellValue(row, "Out");
            return (bool)Check;
        }

     
    }
}
