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
    public partial class GridView_Position_Axis : UserControl
    {

        List<Info> infolist = new List<Info>();

        public event EventHandler ButtonClick;

        public GridView_Position_Axis()
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
            public string axis { get; set; }
            public string encoder { get; set; }
            public string mm { get; set; }
        }
        
        const int RowCount = 4;
        public void AddItem(string axis, string encoder, string mm)
        {
            infolist.Add(new Info()
               {
                axis = axis,
                encoder = encoder,
                mm = mm
            });

            this.bindingSource1.DataSource = infolist;
            gridView1.RefreshData();
            //for(int i=1;i<data.Count+1; i++)
            // {
            //     infolist.Add(new Info()
            //     {
            //         Num = i,
            //         Output_Status = data[i - 1],
            //         Output = 0
            //     });
            // }
        }
        public void SetData(int index,string encoder, string mm)
        {                             
            infolist[index].encoder = encoder;
            infolist[index].mm = mm;

            gridView1.Invalidate();
            gridView1.RefreshData();
        }

        public void SetData(int row, string enable)
        {
            object Check = gridView1.GetRowCellValue(row, "In");
            gridView1.SetRowCellValue(row, gridView1.Columns[1], enable);
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

        }
        public int GetRowData()
        {
            int row = gridView1.GetSelectedRows()[0];
            return row;
        }
        public string GetData(int row)
        {
            object data = gridView1.GetRowCellValue(row, "encoder");
            return (string)data;
        }
        private void gridControl1_MouseClick(object sender, MouseEventArgs e)
        {
           
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        public void Clear()
        {
            int row = gridView1.RowCount;
            for (int i = 0; i < row; i++)
            {
                gridView1.DeleteRow(0);
            }

            infolist.Clear();
        }
    }
}
