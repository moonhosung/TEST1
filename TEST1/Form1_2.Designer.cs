namespace TEST1
{
    partial class Form1_2
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
            DevExpress.XtraCharts.XYDiagram xyDiagram3 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series7 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint31 = new DevExpress.XtraCharts.SeriesPoint(0D, new object[] {
            ((object)(10D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint32 = new DevExpress.XtraCharts.SeriesPoint(1D, new object[] {
            ((object)(20D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint33 = new DevExpress.XtraCharts.SeriesPoint(2D, new object[] {
            ((object)(15D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint34 = new DevExpress.XtraCharts.SeriesPoint(3D, new object[] {
            ((object)(10D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint35 = new DevExpress.XtraCharts.SeriesPoint(4D, new object[] {
            ((object)(20D))});
            DevExpress.XtraCharts.StackedLineSeriesView stackedLineSeriesView7 = new DevExpress.XtraCharts.StackedLineSeriesView();
            DevExpress.XtraCharts.Series series8 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint36 = new DevExpress.XtraCharts.SeriesPoint(0D, new object[] {
            ((object)(15D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint37 = new DevExpress.XtraCharts.SeriesPoint(1D, new object[] {
            ((object)(20D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint38 = new DevExpress.XtraCharts.SeriesPoint(2D, new object[] {
            ((object)(12D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint39 = new DevExpress.XtraCharts.SeriesPoint(3D, new object[] {
            ((object)(15D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint40 = new DevExpress.XtraCharts.SeriesPoint(4D, new object[] {
            ((object)(14D))});
            DevExpress.XtraCharts.StackedLineSeriesView stackedLineSeriesView8 = new DevExpress.XtraCharts.StackedLineSeriesView();
            DevExpress.XtraCharts.Series series9 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint41 = new DevExpress.XtraCharts.SeriesPoint(0D, new object[] {
            ((object)(12D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint42 = new DevExpress.XtraCharts.SeriesPoint(1D, new object[] {
            ((object)(13D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint43 = new DevExpress.XtraCharts.SeriesPoint(2D, new object[] {
            ((object)(14D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint44 = new DevExpress.XtraCharts.SeriesPoint(3D, new object[] {
            ((object)(15D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint45 = new DevExpress.XtraCharts.SeriesPoint(4D, new object[] {
            ((object)(16D))});
            DevExpress.XtraCharts.StackedLineSeriesView stackedLineSeriesView9 = new DevExpress.XtraCharts.StackedLineSeriesView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateEdit2 = new User_Control.DateEdit();
            this.dateEdit1 = new User_Control.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedLineSeriesView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedLineSeriesView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedLineSeriesView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.BackColor = System.Drawing.Color.Transparent;
            this.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram3.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram3.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram3;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(640, 157);
            this.chartControl1.Name = "chartControl1";
            series7.Name = "Series 1";
            series7.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint31,
            seriesPoint32,
            seriesPoint33,
            seriesPoint34,
            seriesPoint35});
            series7.View = stackedLineSeriesView7;
            series8.Name = "Series 2";
            series8.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint36,
            seriesPoint37,
            seriesPoint38,
            seriesPoint39,
            seriesPoint40});
            series8.View = stackedLineSeriesView8;
            series9.Name = "Series 3";
            series9.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint41,
            seriesPoint42,
            seriesPoint43,
            seriesPoint44,
            seriesPoint45});
            series9.View = stackedLineSeriesView9;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series7,
        series8,
        series9};
            this.chartControl1.Size = new System.Drawing.Size(659, 470);
            this.chartControl1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(24, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 42);
            this.label2.TabIndex = 23;
            this.label2.Text = "Log";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.pictureBox2.Location = new System.Drawing.Point(32, 55);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 3);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TEST1.Properties.Resources.common_ic_wave;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(299, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 32);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // dateEdit2
            // 
            this.dateEdit2.Location = new System.Drawing.Point(356, 73);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Size = new System.Drawing.Size(253, 36);
            this.dateEdit2.TabIndex = 25;
            this.dateEdit2.Mouseclick += new System.EventHandler(this.dateEdit2_Mouseclick);
            this.dateEdit2.Load += new System.EventHandler(this.dateEdit2_Load);
            // 
            // dateEdit1
            // 
            this.dateEdit1.Location = new System.Drawing.Point(32, 73);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Size = new System.Drawing.Size(253, 36);
            this.dateEdit1.TabIndex = 24;
            this.dateEdit1.Mouseclick += new System.EventHandler(this.dateEdit1_Mouseclick);
            this.dateEdit1.Closed += new System.EventHandler(this.dateEdit1_Closed);
            // 
            // Form1_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateEdit2);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.chartControl1);
            this.Name = "Form1_2";
            this.Size = new System.Drawing.Size(1609, 883);
            this.Load += new System.EventHandler(this.Form1_2_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedLineSeriesView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedLineSeriesView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedLineSeriesView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private User_Control.DateEdit dateEdit1;
        private User_Control.DateEdit dateEdit2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
