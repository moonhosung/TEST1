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
    public partial class GridView_Alarm : UserControl
    {

        private List<Info> infolist = new List<Info>();

        private bool[] IO_Status = null;
        public event EventHandler ButtonClick;  

        public GridView_Alarm()
        {
            InitializeComponent();
            //  gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            DevExpress.XtraEditors.VScrollBar vScrollBar = gridControl1.Controls.OfType<DevExpress.XtraEditors.VScrollBar>().FirstOrDefault();
            if (vScrollBar != null)
            {
                vScrollBar.LookAndFeel.UseDefaultLookAndFeel = false;
                vScrollBar.LookAndFeel.UseWindowsXPTheme = false;
                vScrollBar.LookAndFeel.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.DevExpress);
                GridViewInfo viewInfo = gridView1.GetViewInfo() as GridViewInfo;
            }
            //CreateData();
            this.bindingSource1.DataSource = infolist;
        }
        
        public class Info
        {
            public int ALID { get; set; }
            public string Alarm { get; set; }
        }
        
        const int RowCount = 4;
        public void CreateData(int ID, string data)
        {
            
            
            //repositoryItemCheckEdit1.PictureChecked = global::User_Control.Properties.Resources.common_img_light_on;
         
            infolist.Add(new Info()
            {
                ALID = ID,
                Alarm = data
            });
            gridView1.Invalidate();
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
              int row = e.RowHandle;
             
            //  if(e.Column.FieldName == "Alarm")
            //  { 
            //     if(IO_Status[row])
            //     {
            //        e.Appearance.BackColor = Color.FromArgb(223, 240, 255);
            //        e.Appearance.ForeColor = Color.FromArgb(0, 119, 255);
            //     }
            //     else
            //     {
            //         e.Appearance.BackColor = Color.White;
            //         e.Appearance.ForeColor = Color.FromArgb(51, 51, 51);
            //     }
            //  }
            //else
            //{
            //    if (IO_Status[row])
            //    {
            //        e.Appearance.ForeColor = Color.FromArgb(0, 119, 255);
            //    }
            //    else
            //    {
            //        e.Appearance.ForeColor = Color.FromArgb(51, 51, 51);
            //    }
            //}
            //}
        }
        public int GetRowData()
        {
            if (infolist.Count == 0)
                return 0;
            int row = gridView1.GetSelectedRows()[0];
            object Check = gridView1.GetRowCellValue(row, "ALID");
            return (int)Check;
        }
        public void Remove()
        {
            int row = gridView1.GetSelectedRows()[0];
            infolist.RemoveAt(row);
            gridView1.DeleteRow(row);
            gridView1.RefreshData();
        }

        public bool GetCheckData()
        {
            int row = gridView1.GetSelectedRows()[0];
            object Check = gridView1.GetRowCellValue(row, "Out");
            return (bool)Check;
        }
        

        private void gridView1_MouseUp(object sender, MouseEventArgs e)
        {

            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }
    }
}
