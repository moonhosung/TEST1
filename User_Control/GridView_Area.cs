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
using System.IO;

namespace User_Control
{
    public partial class GridView_Area : UserControl
    {
        public event EventHandler ButtonClick;
        private List<Info> sourceList;
        private DataTable listTable = null;
        List<Info> infolist;


        public GridView_Area()
        {
            InitializeComponent();
        
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
            public string Dispenser { get; set; }
            public double Start_X { get; set; }
            public double Start_Y { get; set; }
            public double End_X { get; set; }
            public double End_Y { get; set; }
            public string Work_Direction { get; set; }
            public string Pattern_Angle { get; set; }
            public double Z_Pos { get; set; }
        }
        
        const int RowCount = 4;
        
        
        private void gridView1_MouseUp(object sender, MouseEventArgs e)
        {

            //if (this.ButtonClick != null)
            //    this.ButtonClick(this, e);

            //for (int i=0;i< gridView1.RowCount;i++)
            //{
            //    gridView1.SetRowCellValue(i, gridView1.Columns[1], false);
            //}
            
            //int row = gridView1.GetSelectedRows()[0];
            //gridView1.SetRowCellValue(row, gridView1.Columns[1], true);
        }

        public void AddItem(string Dispenser,double StartX, double StartY, double EndX, double EndY, string Work_Direction, string Pattern_Angle,double Z_pos)
        {
            int count=1;
            if (infolist != null)
            {
                if (infolist.Count > 0)
                {
                    count = infolist[infolist.Count - 1].Num + 1;
                }
            }
            else
            {
                infolist = new List<Info>();
            }
            infolist.Add(new Info()
            {
                Num = count,
                Dispenser = Dispenser,
                Start_X = StartX,
                Start_Y = StartY,
                End_X = EndX,
                End_Y = EndY,
                Work_Direction = Work_Direction,
                Pattern_Angle = Pattern_Angle,
                Z_Pos = Z_pos
            });

            this.bindingSource1.DataSource = infolist;
            gridView1.RefreshData();
        }

        public void Clear()
        {
            int row = 0;
            if (infolist != null)
            {
                row = infolist.Count;
                infolist.Clear();
            }
            else
            {
                return;
            }
            for (int i = 0; i < row; i++)
            {
                gridView1.DeleteRow(0);
            }

            gridView1.RefreshData();
        }

        public void Remove()
        {
            int row = gridView1.GetSelectedRows()[0];
            gridView1.DeleteRow(row);
            gridView1.RefreshData();
        }
        public int GetFocusIndex()
        {
            return gridView1.GetSelectedRows()[0];
        }

        public void SetFocusIndex(int index)
        {
            gridView1.FocusedRowHandle = index;
        }

        public int GetCount()
        {
            return gridView1.RowCount;
        }
    }
}
