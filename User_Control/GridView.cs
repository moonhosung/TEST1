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

namespace User_Control
{
    public partial class GridView : UserControl
    {
        private List<Info> sourceList;

        public event EventHandler ButtonClick;

        public event EventHandler FocusedRowChanged;
        public GridView()
        {
            InitializeComponent();
            this.sourceList = new List<Info>();
            this.gridControl1.DataSource = this.sourceList;

            gridControl1.ForceInitialize();
            gridView1.PopulateColumns();
            gridView1.Columns[0].Width = 5;
            gridView1.Columns[0].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns[0].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns[0].AppearanceCell.Font = new System.Drawing.Font("roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            


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
            

        }
        public void SetData(string str)
        {

            Info sampleInfo = new Info();
            
            sampleInfo.Name = str;

            this.sourceList.Add(sampleInfo);

            this.gridControl1.DataSource = this.sourceList;
            gridControl1.RefreshDataSource();
        }

        public void Remove()
        {
            int row=  gridView1.GetSelectedRows()[0];
            gridView1.DeleteRow(row);
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

        public string GetFocusText()
        {
            object str = gridView1.GetFocusedRowCellValue("Name");
            return str.ToString();
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        public void Clear()
        {
            int row = gridView1.RowCount;
            for (int i=0;i< row;i++)
            {
                gridView1.DeleteRow(0);
            }
        }

        public class Info
        { 
            public string Name { get; set; }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (this.FocusedRowChanged != null)
                this.FocusedRowChanged(this, e);
        }
    }
}
