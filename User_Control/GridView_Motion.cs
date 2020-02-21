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
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;

namespace User_Control
{
    public partial class GridView_Motion : UserControl
    {

        private List<Info> infolist = null;



        public GridView_Motion()
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
            CreateData();

        }
        
        public class Info
        {
            public bool Check { get; set; }
            public string CheckText { get; set; }
            public int CMD_POS { get; set; }
            public int ACT_POS { get; set; }
            public int VEL { get; set; }
            public int SVON { get; set; }
            public int BUSY { get; set; }
            public int CLR { get; set; }
            public int ALM { get; set; }
            public int INP { get; set; }
            public int PEL { get; set; }
            public int ORG { get; set; }
            public int NEL { get; set; }
        }
        
        const int RowCount = 4;
        void CreateData()
        {
            infolist = new List<Info>();
          
            infolist.Add(new Info()
            {
                Check = true,
                CheckText = "Front Turn",
                CMD_POS = 0,
                ACT_POS = 123,
                VEL = 123,
                SVON = 1,
                BUSY = 0,
                CLR = 1,
                ALM = 3,
                INP = 0,
                PEL = 0,
                ORG = 1,
                NEL = 0
            });

            infolist.Add(new Info()
            {
                Check = false,
                CheckText = "Front Stopper",
                CMD_POS =   38,
                ACT_POS = 90,
                VEL = 32323,
                SVON = 0,
                BUSY = 1,
                CLR = 0,
                ALM = 0,
                INP = 1,
                PEL = 2,
                ORG = 1,
                NEL = 0
            });

            infolist.Add(new Info()
            {
                Check = false,
                CheckText = "Front Rack",
                CMD_POS = 9,
                ACT_POS = 18,
                VEL = 32,
                SVON = 0,
                BUSY = 0,
                CLR = 0,
                ALM = 2,
                INP = 0,
                PEL = 0,
                ORG = 1,
                NEL = 0
            });

            infolist.Add(new Info()
            {
                Check = false,
                CheckText = "Rear Turn",
                CMD_POS = 145,
                ACT_POS = 552,
                VEL = 123,
                SVON = 1,
                BUSY = 0,
                CLR = 0,
                ALM = 2,
                INP = 1,
                PEL = 0,
                ORG = 1,
                NEL = 2
            });

            infolist.Add(new Info()
            {
                Check = false,
                CheckText = "Rear Turn",
                CMD_POS = 145,
                ACT_POS = 552,
                VEL = 123,
                SVON = 1,
                BUSY = 0,
                CLR = 0,
                ALM = 2,
                INP = 1,
                PEL = 0,
                ORG = 1,
                NEL = 2
            });

            infolist.Add(new Info()
            {
                Check = false,
                CheckText = "Rear Turn",
                CMD_POS = 145,
                ACT_POS = 552,
                VEL = 123,
                SVON = 1,
                BUSY = 0,
                CLR = 0,
                ALM = 2,
                INP = 1,
                PEL = 0,
                ORG = 1,
                NEL = 2
            });
            this.bindingSource1.DataSource = infolist;
            
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
        }
        

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            Color warning = Color.Red;
            Color on = Color.LawnGreen;
            Color off = Color.Gray;
            int markWidth = 25;
            e.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            e.Appearance.Options.UseTextOptions = true;
            e.DefaultDraw();
            if (e.Column.FieldName=="CheckText")
            {
                e.Appearance.TextOptions.HAlignment = HorzAlignment.Near;
                //e.Appearance.BackColor = Color.FromArgb(244, 249, 255);
            }
            if (e.Column.FieldName == "SVON" || e.Column.FieldName == "BUSY" || e.Column.FieldName == "CLR" || e.Column.FieldName == "ALM"
                || e.Column.FieldName == "INP" || e.Column.FieldName == "PEL" || e.Column.FieldName == "ORG" || e.Column.FieldName == "NEL"
                )
            {
                Rectangle temp = new Rectangle(e.Bounds.X + 20, e.Bounds.Y + 12, 18, 12);

                e.Appearance.ForeColor = Color.Transparent;
                Color color;
                int cellValue = Convert.ToInt32(e.CellValue);
                if (cellValue == 2)
                {
                    e.Cache.DrawImage(global::User_Control.Properties.Resources.maint_conv_icon_statuslight_red, temp);
                }
                else if (cellValue == 1)
                {
                    e.Cache.DrawImage(global::User_Control.Properties.Resources.maint_conv_icon_statuslight_green, temp);
                }
                else
                {
                    e.Cache.DrawImage(global::User_Control.Properties.Resources.maint_conv_icon_statuslight_grey, temp);
                }
                
            }
        }
        
        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void gridView1_MouseUp(object sender, MouseEventArgs e)
        {
            for(int i=0;i<infolist.Count();i++)
            {
                gridView1.SetRowCellValue(i, gridView1.Columns[0], false);
            }
            
            object str, check;
            str = gridView1.GetFocusedRowCellValue("CheckText");
            check = gridView1.GetFocusedRowCellValue("Check");
            if (str.ToString() == "X_Axis")
            {
               gridView1.SetRowCellValue(0, gridView1.Columns[0], true);
            }
            if (str.ToString() == "Y_Axis")
            {
               gridView1.SetRowCellValue(1, gridView1.Columns[0], true);
            }
            if (str.ToString() == "Z_Axis")
            {
                gridView1.SetRowCellValue(2, gridView1.Columns[0], true);
            }
             if (str.ToString() == "Turn_Axis")
            {
                gridView1.SetRowCellValue(3, gridView1.Columns[0], true);
            }
            if (str.ToString() == "ToolChange")
            {
                gridView1.SetRowCellValue(4, gridView1.Columns[0], true);
            }
            if (str.ToString() == "Work_Width")
            {
                gridView1.SetRowCellValue(5, gridView1.Columns[0], true);
            }
            if (str.ToString() == "Out_Width")
            {
                gridView1.SetRowCellValue(6, gridView1.Columns[0], true);
            }
            if (str.ToString() == "UV_Axis")
            {
                gridView1.SetRowCellValue(7, gridView1.Columns[0], true);
            }
            if (str.ToString() == "UV_Z_Axis")
            {
                gridView1.SetRowCellValue(8, gridView1.Columns[0], true);
            }
        }

        public void SetAxisInfo(int Axis, string title,int cmdpos, int actpos, int vel, int svon, int busy,
                              int clr, int alm, int inp, int pel, int org, int nel)
        {
            infolist[Axis].CheckText = title;
            infolist[Axis].CMD_POS = cmdpos;
            infolist[Axis].ACT_POS = actpos;
            infolist[Axis].VEL = vel;
            infolist[Axis].SVON = svon;
            infolist[Axis].BUSY = busy;
            infolist[Axis].CLR = clr;
            infolist[Axis].ALM = alm;
            infolist[Axis].INP = inp;
            infolist[Axis].PEL = pel;
            infolist[Axis].ORG = org;
            infolist[Axis].NEL = nel;
            gridView1.Invalidate();
            gridView1.RefreshData();
        }

        public int GetRowData()
        {
            int row = gridView1.GetSelectedRows()[0];
            return row;
        }
    }
}
