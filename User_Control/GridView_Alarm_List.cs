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
    public partial class GridView_Alarm_List : UserControl
    {
        private List<Info> infolist = new List<Info>();

        public event EventHandler ButtonClick;

        public GridView_Alarm_List()
        {
            InitializeComponent();

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
            this.bindingSource1.DataSource = infolist;
        }
        
        public class Info
        {
            public string Date { get; set; }
            public string Code { get; set; }
            public bool IsWarning { get; set; }
        }
        
        const int RowCount = 4;
        public void CreateData(string date,string code,bool Iswarning)
        {
            string ALID = code.Substring(0, 4);
            string ALTX = code.Substring(4, code.Length-4);
            infolist.Add(new Info()
            {
                Date = date,
                Code = ALID + " - " + ALTX,
                IsWarning = Iswarning
            });
            gridView1.Invalidate();
            gridView1.RefreshData();
        }
        public void SetData(int row, string enable)
        {
            object Check = gridView1.GetRowCellValue(row, "In");
            gridView1.SetRowCellValue(row, gridView1.Columns[1], enable);
        }
        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            Color warning = Color.Red;
            Color on = Color.LawnGreen;
            Color off = Color.Gray;
            int markWidth = 25;
            e.Appearance.Options.UseTextOptions = true;
            e.DefaultDraw();

            int SizeX = 36;
            int SizeY = 36;

            if (e.Column.FieldName == "IsWarning")
            {
                Pen p = new Pen(SystemColors.HotTrack, 2);
                bool cellValue = (bool)(e.CellValue);
                SolidBrush br = new SolidBrush(Color.FromArgb(255, Color.White));
                Rectangle temp = new Rectangle(e.Bounds.X + (e.Bounds.Width - SizeX)/2, e.Bounds.Y + (e.Bounds.Height- SizeY) /2, SizeX, SizeY);

                if (cellValue)
                {
                    e.Cache.DrawImage(global::User_Control.Properties.Resources.alarms_alarms_ic_warning_02, temp);
                }
                else
                {
                    e.Cache.DrawImage(global::User_Control.Properties.Resources.alarms_alarms_ic_alarm_02, temp);
                }
                //new SolidBrush(Color.FromArgb(255, Color.Black))

                //e.Appearance.BackColor = Color.FromArgb(244, 249, 255);
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
            object Check = gridView1.GetRowCellValue(row, "Out");
            return (bool)Check;
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
    }
}
