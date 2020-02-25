namespace TEST1
{
    partial class Form1_1
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
            this.button1 = new User_Control.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CHART_GROWTH = new DevExpress.XtraCharts.ChartControl();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_GROWTH = new User_Control.Button();
            this.BTN_PEST = new User_Control.Button();
            this.BTN_HARVEST = new User_Control.Button();
            this.PB_AGV1 = new System.Windows.Forms.PictureBox();
            this.PB_FARM = new System.Windows.Forms.PictureBox();
            this.CHART_GROWTH2 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.CHART_GROWTH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_AGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_FARM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHART_GROWTH2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 765);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 50);
            this.button1.TabIndex = 0;
            this.button1.ButtonClick += new System.EventHandler(this.button1_ButtonClick);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label1.Location = new System.Drawing.Point(40, 702);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(179, 40);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Pest Control";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CHART_GROWTH
            // 
            this.CHART_GROWTH.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.CHART_GROWTH.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.CHART_GROWTH.Legend.Name = "Default Legend";
            this.CHART_GROWTH.Location = new System.Drawing.Point(1024, 167);
            this.CHART_GROWTH.Name = "CHART_GROWTH";
            this.CHART_GROWTH.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.CHART_GROWTH.Size = new System.Drawing.Size(608, 280);
            this.CHART_GROWTH.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(1025, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 45);
            this.label2.TabIndex = 9;
            this.label2.Text = "Growth information";
            // 
            // BTN_GROWTH
            // 
            this.BTN_GROWTH.Location = new System.Drawing.Point(31, 31);
            this.BTN_GROWTH.Name = "BTN_GROWTH";
            this.BTN_GROWTH.Size = new System.Drawing.Size(126, 50);
            this.BTN_GROWTH.TabIndex = 10;
            this.BTN_GROWTH.ButtonClick += new System.EventHandler(this.BTN_GROWTH_ButtonClick);
            // 
            // BTN_PEST
            // 
            this.BTN_PEST.Location = new System.Drawing.Point(186, 31);
            this.BTN_PEST.Name = "BTN_PEST";
            this.BTN_PEST.Size = new System.Drawing.Size(126, 50);
            this.BTN_PEST.TabIndex = 11;
            this.BTN_PEST.ButtonClick += new System.EventHandler(this.BTN_PEST_ButtonClick);
            // 
            // BTN_HARVEST
            // 
            this.BTN_HARVEST.Location = new System.Drawing.Point(341, 31);
            this.BTN_HARVEST.Name = "BTN_HARVEST";
            this.BTN_HARVEST.Size = new System.Drawing.Size(126, 50);
            this.BTN_HARVEST.TabIndex = 12;
            this.BTN_HARVEST.ButtonClick += new System.EventHandler(this.BTN_HARVEST_ButtonClick);
            // 
            // PB_AGV1
            // 
            this.PB_AGV1.BackgroundImage = global::TEST1.Properties.Resources.AGV;
            this.PB_AGV1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_AGV1.Location = new System.Drawing.Point(47, 612);
            this.PB_AGV1.Name = "PB_AGV1";
            this.PB_AGV1.Size = new System.Drawing.Size(39, 44);
            this.PB_AGV1.TabIndex = 2;
            this.PB_AGV1.TabStop = false;
            // 
            // PB_FARM
            // 
            this.PB_FARM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_FARM.Location = new System.Drawing.Point(31, 116);
            this.PB_FARM.Name = "PB_FARM";
            this.PB_FARM.Size = new System.Drawing.Size(924, 559);
            this.PB_FARM.TabIndex = 1;
            this.PB_FARM.TabStop = false;
            this.PB_FARM.Click += new System.EventHandler(this.PB_FARM_Click);
            this.PB_FARM.Paint += new System.Windows.Forms.PaintEventHandler(this.PB_FARM_Paint);
            this.PB_FARM.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB_FARM_MouseMove);
            // 
            // CHART_GROWTH2
            // 
            this.CHART_GROWTH2.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.CHART_GROWTH2.Legend.Name = "Default Legend";
            this.CHART_GROWTH2.Location = new System.Drawing.Point(1024, 483);
            this.CHART_GROWTH2.Name = "CHART_GROWTH2";
            this.CHART_GROWTH2.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.CHART_GROWTH2.Size = new System.Drawing.Size(608, 320);
            this.CHART_GROWTH2.TabIndex = 14;
            // 
            // Form1_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.CHART_GROWTH2);
            this.Controls.Add(this.BTN_HARVEST);
            this.Controls.Add(this.BTN_PEST);
            this.Controls.Add(this.BTN_GROWTH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CHART_GROWTH);
            this.Controls.Add(this.PB_AGV1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.PB_FARM);
            this.Controls.Add(this.button1);
            this.Name = "Form1_1";
            this.Size = new System.Drawing.Size(1694, 922);
            this.Load += new System.EventHandler(this.Form1_1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.CHART_GROWTH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_AGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_FARM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHART_GROWTH2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Control.Button button1;
        private System.Windows.Forms.PictureBox PB_FARM;
        private System.Windows.Forms.PictureBox PB_AGV1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraCharts.ChartControl CHART_GROWTH;
        private System.Windows.Forms.Label label2;
        private User_Control.Button BTN_GROWTH;
        private User_Control.Button BTN_PEST;
        private User_Control.Button BTN_HARVEST;
        private DevExpress.XtraCharts.ChartControl CHART_GROWTH2;
    }
}
