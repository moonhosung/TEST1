using System;
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
    public partial class GridView_Output : UserControl
    {

        private List<Info> infolist = null;
        private bool[] Output_Status = new bool[64];

        public event EventHandler ButtonClick;

        public GridView_Output()
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
        }
        
        public class Info
        {
            public int Num { get; set; }
            public string Output_Status { get; set; }
            public int Output { get; set; }
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
                    Output_Status = data[i - 1],
                    Output = 0
                });
            }
            this.bindingSource1.DataSource = infolist;

            for(int i=0;i< Output_Status.Count();i++)
            {
                Output_Status[i] = false;
            }
        }
        
        public void SetData(int row, string enable)
        {
            object Check = gridView1.GetRowCellValue(row, "In");
            gridView1.SetRowCellValue(row, gridView1.Columns[1], enable);
        }

        public void SetIO_Status(bool[] IO_List)
        {
            Output_Status = IO_List;
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

            int OutSizeX = 78;
            int OutSizeY = 33;

            int row = e.RowHandle;

            if (row < Output_Status.Count())
            {
                if (e.Column.FieldName == "Output_Status")
                {
                    if (Output_Status[row])
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
                    if (Output_Status[row])
                    {
                        e.Appearance.ForeColor = Color.FromArgb(0, 119, 255);
                    }
                    else
                    {
                        e.Appearance.ForeColor = Color.FromArgb(51, 51, 51);
                    }
                }

                if (e.Column.FieldName == "Output")
                {
                    Pen p = new Pen(SystemColors.HotTrack, 2);
                    int cellValue = (int)(e.CellValue);
                    SolidBrush br = new SolidBrush(Color.FromArgb(255, Color.White));
                    Rectangle temp = new Rectangle(e.Bounds.X + 40, e.Bounds.Y + 6, OutSizeX, OutSizeY);
                    if (Output_Status[row])
                    {
                        e.Cache.DrawImage(global::User_Control.Properties.Resources.common_bt_toggle_02_on, temp);
                    }
                    else
                    {
                        e.Cache.DrawImage(global::User_Control.Properties.Resources.common_bt_toggle_02_off, temp);
                    }
                }
            }
        }
        public int GetRowData()
        {
            int row = gridView1.GetSelectedRows()[0];
            return row;
        }
        public bool GetCheckData()
        {

            int row = gridView1.GetSelectedRows()[0];

            return Output_Status[row];
        }

        private void gridControl1_MouseClick(object sender, MouseEventArgs e)
        {

            //int row = gridView1.GetSelectedRows()[0];
            
            //if (Output_Status[row])
            //{
            //    gridView1.SetRowCellValue(row, gridView1.Columns[2], 0);
            //    Output_Status[row] = false;
            //}
            //else
            //{
            //    gridView1.SetRowCellValue(row, gridView1.Columns[2], 1);
            //    Output_Status[row] = true;
            //}
            
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }
    }
}
