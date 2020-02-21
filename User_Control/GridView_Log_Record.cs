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
    public partial class GridView_Log_Record : UserControl
    {
        public event EventHandler ButtonClick;
        private List<Info> sourceList;
        private DataTable listTable = null;
        List<Info> infolist = new List<Info>();


        public GridView_Log_Record()
        {
            InitializeComponent();
            // this.sourceList = new List<Info>();
            // this.gridControl1.DataSource = this.sourceList;

            // gridControl1.ForceInitialize();
            //gridView1.PopulateColumns();
            // gridView1.Columns[0].Caption = " ";
            //gridView1.Columns[0].Width = 200;
            //gridView1.Columns[0].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            //gridView1.Columns[0].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            //gridView1.Columns[1].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            //gridView1.Columns[1].AppearanceHeader.Font = new System.Drawing.Font("roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //gridView1.Columns[0].AppearanceCell.Font = new System.Drawing.Font("roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //gridView1.Columns[1].AppearanceCell.Font = new System.Drawing.Font("roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
                //vScrollBar.Location = new Point(vScrollBar.Location.X, vScrollBar.Location.Y - viewInfo.ViewRects.ColumnPanel.Height);
                //vScrollBar.Height += viewInfo.ViewRects.ColumnPanel.Height;
                //  vScrollBar.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            }

            //  gridView1.AddNewRow();
            //
            //   Info sampleInfo = new Info();
            //   sampleInfo.HeaderCheck = true;
            //   sampleInfo.CheckText = "Front Turn";
            //   sampleInfo.CMD_POS = "1";
            //   sampleInfo.ACT_POS = "1";
            //   sampleInfo.VEL = "1";
            //   sampleInfo.SVON = 1;
            //   sampleInfo.BUSY = 1;
            //   sampleInfo.CLR = 2;
            //   sampleInfo.ALM = 1;
            //   sampleInfo.INP = 1;
            //   sampleInfo.PEL = 1;
            //   sampleInfo.ORG = 1;
            //   sampleInfo.NEL = 1;         
            //  this.sourceList.Add(sampleInfo);
            //
            //  gridControl1.RefreshDataSource();

            //this.listTable = GetSampleList();
            //this.gridControl1.DataSource = this.listTable; 

            //CheckEdit checkEdit = new CheckEdit();
            // checkEdit.Text = "Front Turn"; 
            // checkEdit.Width = 19;
            // checkEdit.Height = 19;
            //gridView1.GridControl.Controls.Add(checkEdit);
        }
        
        public class Info
        {
            public string Date { get; set; }
            public int Shift_1 { get; set; }
            public int Shift_2 { get; set; }
            public int Shift_3 { get; set; }
            public int Total { get; set; }
        }
        
        const int RowCount = 4;

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
        }


        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
         
        }
        
        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void gridView1_MouseUp(object sender, MouseEventArgs e)
        {

            if (this.ButtonClick != null)
                this.ButtonClick(this, e);

            //for (int i=0;i< gridView1.RowCount;i++)
            //{
            //    gridView1.SetRowCellValue(i, gridView1.Columns[1], false);
            //}
            
            //int row = gridView1.GetSelectedRows()[0];
            //gridView1.SetRowCellValue(row, gridView1.Columns[1], true);
        }
        
        public void AddItem(string name)
        {
            
            infolist.Add(new Info()
            {
                Date = "ds",
                Shift_1 = 123,
                Shift_2 = 234,
                Shift_3 = 12,
                Total = 123
            });

            this.bindingSource1.DataSource = infolist;
            gridView1.RefreshData();
        }

        //public bool DeleteItem()
        //{
        //    int row = -1;
        //    for (int i = 0; i < infolist.Count; i++)
        //    {
        //        if (infolist[i].Select)
        //        {
        //            row = i;
        //        }
        //    }
        //    if(row==-1)
        //    {
        //        return false;
        //    }
        //    infolist.RemoveAt(row);

        //    this.bindingSource1.DataSource = infolist;
        //    gridView1.RefreshData();
        //    return true;
        //}
        //public bool ModifyItem(string name)
        //{

        //    int row=-1;
        //    for (int i = 0; i < infolist.Count; i++)
        //    {
        //        if (infolist[i].Select)
        //        {
        //            row = i;
        //        }
        //    }
        //    if (row == -1)
        //    {
        //        return false;
        //    }
        //    infolist[row].Name = name;

        //    this.bindingSource1.DataSource = infolist;
        //    gridView1.RefreshData();
        //    return true;
        //}
        //public bool CheckName(string name)
        //{
        //    bool res = false;
        //    for (int i = 0; i < infolist.Count; i++)
        //    {
        //        if(infolist[i].Name == name)
        //        {
        //            res = true;
        //        }
        //    }
        //    return res;
        //}

        //public bool Check()
        //{
        //    int row = -1;
        //    for (int i = 0; i < infolist.Count; i++)
        //    {
        //        if (infolist[i].Select)
        //        {
        //            row = i;
        //        }
        //    }
        //    if (row == -1)
        //    {
        //        return false;
        //    }

        //    return true;
        //}

        //public void SetCheck(string name)
        //{
        //    for (int i = 0; i < infolist.Count; i++)
        //    {
        //        if (infolist[i].Name == name)
        //        {
        //            gridView1.SetRowCellValue(i, gridView1.Columns[1], true);
        //        }
        //    }
        //}
    }
}
