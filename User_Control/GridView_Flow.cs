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
    public partial class GridView_Flow : UserControl
    {

        private List<Info> infolist = new List<Info>();

        private bool[] IO_Status = null;
        public event EventHandler ButtonClick;

        public GridView_Flow()
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
            public string Date { get; set; }
            public string User { get; set; }
            public string FlowRate { get; set; }
            public string Period { get; set; }
        }
        
        //public void SetData(int row, string enable)
        //{
        //    object Check = gridView1.GetRowCellValue(row, "In");
        //    gridView1.SetRowCellValue(row, gridView1.Columns[1], enable);
        //}
        public void AddItem(string date, string user, string flowrate, string period)
        {

            infolist.Add(new Info()
            {
                Date = date,
                User = user,
                FlowRate = flowrate,
                Period = period
            });

            this.bindingSource1.DataSource = infolist;
            gridView1.RefreshData();
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            //  int row = e.RowHandle;
            //  if (row>=IO_Status.Count())
            //  {
            //      return;
            //  }
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
            ////}
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
