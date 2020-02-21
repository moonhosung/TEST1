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
    public partial class GridView_Job_MTBI : UserControl
    {

        private List<Info> infolist = null;

        private bool[] IO_Status = null;
        public event EventHandler ButtonClick;

        public GridView_Job_MTBI()
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
            CreateData();
        }
        
        public class Info
        {
            public string Title1 { get; set; }
            public string Info1 { get; set; }
            public string Title2 { get; set; }
            public string Info2 { get; set; }
        }
        
        const int RowCount = 4;
        public void CreateData()
        {
            infolist = new List<Info>();
            
            infolist.Add(new Info()
            {
                Title1 = "MTBI",
                Info1 = "",
                Title2 = "Idel Time",
                Info2 = ""
            });

            infolist.Add(new Info()
            {
                Title1 = "Alarm Time",
                Info1 = "",
                Title2 = "Run TIme",
                Info2 = ""
            });

            infolist.Add(new Info()
            {
                Title1 = "Stop Time",
                Info1 = "",
                Title2 = "REF Time",
                Info2 = ""
            });

            this.bindingSource1.DataSource = infolist;
        }
        
        public void SetMTBI(string str)
        {
            gridView1.SetRowCellValue(0, gridView1.Columns[1], str);
            infolist[0].Info1 = str;
        }
        public void SetAlarmTime(string str)
        {
            gridView1.SetRowCellValue(1, gridView1.Columns[1], str);
            infolist[1].Info1 = str;
        }
        public void SetIdelTime(string str)
        {
            gridView1.SetRowCellValue(0, gridView1.Columns[3], str);
            infolist[0].Info2 = str;
        }
        public void SetRunTIme(string str)
        {
            gridView1.SetRowCellValue(1, gridView1.Columns[3], str);
            infolist[1].Info2 = str;
        }
        public void SetStopTIme(string str)
        {
            gridView1.SetRowCellValue(2, gridView1.Columns[1], str);
            infolist[2].Info1 = str;
        }
        public void SetREFTIme(string str)
        {
            gridView1.SetRowCellValue(2, gridView1.Columns[3], str);
            infolist[2].Info2 = str;
        }
        public void SetIO_Status(bool[] IO_List)
        {
            IO_Status = IO_List;
        }
        public void SetCaption(string str)
        {
            gridColumn2.Caption = str;
        }
        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            //  int row = e.RowHandle;
            //  if (row>=IO_Status.Count())
            //  {
            //      return;
            //  }
            //  if(e.Column.FieldName == "Input")
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
