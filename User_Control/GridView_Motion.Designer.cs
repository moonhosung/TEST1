﻿using System.Drawing;

namespace User_Control
{
    partial class GridView_Motion
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridView_Motion));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colclnBool = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CMD_POS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACT_POS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SVON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BUSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CLR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ALM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.INP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ORG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource1;
            resources.ApplyResources(this.gridControl1, "gridControl1");
            this.gridControl1.LookAndFeel.SkinName = "Office 2010 Black";
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2});
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(User_Control.GridView_Motion.Info);
            // 
            // gridView1
            // 
            this.gridView1.ActiveFilterEnabled = false;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Transparent;
            this.gridView1.Appearance.HeaderPanel.Font = ((System.Drawing.Font)(resources.GetObject("gridView1.Appearance.HeaderPanel.Font")));
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.Transparent;
            this.gridView1.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.Transparent;
            this.gridView1.Appearance.Row.Font = ((System.Drawing.Font)(resources.GetObject("gridView1.Appearance.Row.Font")));
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.Transparent;
            this.gridView1.Appearance.RowSeparator.BorderColor = System.Drawing.Color.Transparent;
            this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView1.Appearance.RowSeparator.Options.UseBorderColor = true;
            this.gridView1.Appearance.VertLine.BackColor = System.Drawing.Color.Transparent;
            this.gridView1.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.ColumnPanelRowHeight = 40;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colclnBool,
            this.ColumnText,
            this.CMD_POS,
            this.ACT_POS,
            this.VEL,
            this.SVON,
            this.BUSY,
            this.CLR,
            this.ALM,
            this.INP,
            this.PEL,
            this.ORG,
            this.NEL});
            this.gridView1.DetailHeight = 323;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupRowHeight = 40;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("gridView1.GroupSummary"))), resources.GetString("gridView1.GroupSummary1"), ((DevExpress.XtraGrid.Columns.GridColumn)(resources.GetObject("gridView1.GroupSummary2"))), resources.GetString("gridView1.GroupSummary3")),
            new DevExpress.XtraGrid.GridGroupSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("gridView1.GroupSummary4"))), resources.GetString("gridView1.GroupSummary5"), ((DevExpress.XtraGrid.Columns.GridColumn)(resources.GetObject("gridView1.GroupSummary6"))), resources.GetString("gridView1.GroupSummary7"))});
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.gridView1.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsCustomization.AllowColumnResizing = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView1.OptionsCustomization.AllowSort = false;
            this.gridView1.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView1.OptionsHint.ShowColumnHeaderHints = false;
            this.gridView1.OptionsLayout.Columns.AddNewColumns = false;
            this.gridView1.OptionsLayout.Columns.RemoveOldColumns = false;
            this.gridView1.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.gridView1.OptionsPrint.PrintFixedColumnsOnEveryPage = true;
            this.gridView1.OptionsPrint.PrintFooter = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.BestFitMaxRowCount = 20;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Standard;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.PaintStyleName = "Web";
            this.gridView1.RowHeight = 40;
            this.gridView1.ViewCaptionHeight = 40;
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseDown);
            this.gridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseUp);
            // 
            // colclnBool
            // 
            this.colclnBool.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.colclnBool.AppearanceCell.Options.UseBackColor = true;
            this.colclnBool.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.colclnBool, "colclnBool");
            this.colclnBool.FieldName = "Check";
            this.colclnBool.MinWidth = 23;
            this.colclnBool.Name = "colclnBool";
            this.colclnBool.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colclnBool.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colclnBool.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            // 
            // ColumnText
            // 
            this.ColumnText.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ColumnText.AppearanceCell.Options.UseBackColor = true;
            this.ColumnText.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnText.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.ColumnText, "ColumnText");
            this.ColumnText.FieldName = "CheckText";
            this.ColumnText.MinWidth = 23;
            this.ColumnText.Name = "ColumnText";
            this.ColumnText.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            // 
            // CMD_POS
            // 
            this.CMD_POS.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CMD_POS.AppearanceCell.Options.UseTextOptions = true;
            this.CMD_POS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.CMD_POS, "CMD_POS");
            this.CMD_POS.FieldName = "CMD_POS";
            this.CMD_POS.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value;
            this.CMD_POS.MinWidth = 23;
            this.CMD_POS.Name = "CMD_POS";
            // 
            // ACT_POS
            // 
            this.ACT_POS.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ACT_POS.AppearanceCell.Options.UseTextOptions = true;
            this.ACT_POS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.ACT_POS, "ACT_POS");
            this.ACT_POS.FieldName = "ACT_POS";
            this.ACT_POS.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value;
            this.ACT_POS.MinWidth = 23;
            this.ACT_POS.Name = "ACT_POS";
            // 
            // VEL
            // 
            this.VEL.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.VEL.AppearanceCell.Options.UseTextOptions = true;
            this.VEL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.VEL, "VEL");
            this.VEL.FieldName = "VEL";
            this.VEL.Name = "VEL";
            // 
            // SVON
            // 
            this.SVON.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SVON.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("SVON.AppearanceCell.Font")));
            this.SVON.AppearanceCell.Options.UseFont = true;
            resources.ApplyResources(this.SVON, "SVON");
            this.SVON.FieldName = "SVON";
            this.SVON.Name = "SVON";
            // 
            // BUSY
            // 
            this.BUSY.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BUSY.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("BUSY.AppearanceCell.Font")));
            this.BUSY.AppearanceCell.Options.UseFont = true;
            resources.ApplyResources(this.BUSY, "BUSY");
            this.BUSY.FieldName = "BUSY";
            this.BUSY.Name = "BUSY";
            // 
            // CLR
            // 
            this.CLR.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CLR.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("CLR.AppearanceCell.Font")));
            this.CLR.AppearanceCell.Options.UseFont = true;
            resources.ApplyResources(this.CLR, "CLR");
            this.CLR.FieldName = "CLR";
            this.CLR.Name = "CLR";
            // 
            // ALM
            // 
            this.ALM.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ALM.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("ALM.AppearanceCell.Font")));
            this.ALM.AppearanceCell.Options.UseFont = true;
            resources.ApplyResources(this.ALM, "ALM");
            this.ALM.FieldName = "ALM";
            this.ALM.Name = "ALM";
            // 
            // INP
            // 
            this.INP.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.INP.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("INP.AppearanceCell.Font")));
            this.INP.AppearanceCell.Options.UseFont = true;
            resources.ApplyResources(this.INP, "INP");
            this.INP.FieldName = "INP";
            this.INP.Name = "INP";
            // 
            // PEL
            // 
            this.PEL.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PEL.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("PEL.AppearanceCell.Font")));
            this.PEL.AppearanceCell.Options.UseFont = true;
            resources.ApplyResources(this.PEL, "PEL");
            this.PEL.FieldName = "PEL";
            this.PEL.Name = "PEL";
            // 
            // ORG
            // 
            this.ORG.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ORG.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("ORG.AppearanceCell.Font")));
            this.ORG.AppearanceCell.Options.UseFont = true;
            resources.ApplyResources(this.ORG, "ORG");
            this.ORG.FieldName = "ORG";
            this.ORG.Name = "ORG";
            // 
            // NEL
            // 
            this.NEL.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NEL.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("NEL.AppearanceCell.Font")));
            this.NEL.AppearanceCell.Options.UseFont = true;
            resources.ApplyResources(this.NEL, "NEL");
            this.NEL.FieldName = "NEL";
            this.NEL.Name = "NEL";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.repositoryItemCheckEdit1.LookAndFeel.SkinMaskColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            this.repositoryItemCheckEdit1.LookAndFeel.SkinName = "Metropolis Dark";
            this.repositoryItemCheckEdit1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // repositoryItemCheckEdit2
            // 
            resources.ApplyResources(this.repositoryItemCheckEdit2, "repositoryItemCheckEdit2");
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // GridView_Motion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gridControl1);
            this.Name = "GridView_Motion";
            resources.ApplyResources(this, "$this");
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnText;
        private DevExpress.XtraGrid.Columns.GridColumn CMD_POS;
        private DevExpress.XtraGrid.Columns.GridColumn ACT_POS;
        private DevExpress.XtraGrid.Columns.GridColumn colclnBool;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn VEL;
        private DevExpress.XtraGrid.Columns.GridColumn SVON;
        private DevExpress.XtraGrid.Columns.GridColumn BUSY;
        private DevExpress.XtraGrid.Columns.GridColumn CLR;
        private DevExpress.XtraGrid.Columns.GridColumn ALM;
        private DevExpress.XtraGrid.Columns.GridColumn INP;
        private DevExpress.XtraGrid.Columns.GridColumn PEL;
        private DevExpress.XtraGrid.Columns.GridColumn ORG;
        private DevExpress.XtraGrid.Columns.GridColumn NEL;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
    }
}
