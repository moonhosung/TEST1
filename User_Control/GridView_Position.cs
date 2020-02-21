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
    public partial class GridView_Position : UserControl
    {

        private List<Info> infolist = null;

        private bool[] IO_Status = null;
        public event EventHandler ButtonClick;

        public GridView_Position()
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

            infolist = new List<Info>();
            // CreateData();
        }
        
        public class Info
        {
            public string Position { get; set; }
        }
        
        const int RowCount = 4;
        public void CreateData(List<string> datalist)
        {
            infolist = new List<Info>();
              
            for(int i=0;i< datalist.Count();i++)
            {
                infolist.Add(new Info()
                {
                    Position = datalist[i]
                });
            }

            this.bindingSource1.DataSource = infolist;
        }
        
        public void SetData(int row, string enable)
        {
            object Check = gridView1.GetRowCellValue(row, "In");
            gridView1.SetRowCellValue(row, gridView1.Columns[1], enable);
        }

        public int GetRowData()
        {
            int row = gridView1.GetSelectedRows()[0];
            return row;
        }
        public string GetData()
        {
            int row = gridView1.GetSelectedRows()[0];
            object data = gridView1.GetRowCellValue(row, "Position");
            return (string)data;
        }

        public void AddItem(string text)
        {

            infolist.Add(new Info()
            {
                Position = text,
            });

            this.bindingSource1.DataSource = infolist;
            gridView1.RefreshData();
        }

        public void DeleteItem()
        {
            int row = gridView1.GetSelectedRows()[0];

            infolist.RemoveAt(row);
        }

        private void gridView1_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {

            int row = gridView1.GetSelectedRows()[0];

            //if (e.Column.FieldName == "Alarm")
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

        private void gridView1_Click(object sender, EventArgs e)
        {

            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }
    }
}
