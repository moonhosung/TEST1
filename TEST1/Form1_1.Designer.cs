
using System.Runtime.InteropServices;

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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CHART_GROWTH = new DevExpress.XtraCharts.ChartControl();
            this.LB_GROWTH = new System.Windows.Forms.Label();
            this.CHART_GROWTH2 = new DevExpress.XtraCharts.ChartControl();
            this.LB_HARVEST = new System.Windows.Forms.Label();
            this.PN_GROWTH_INFO = new System.Windows.Forms.Panel();
            this.CB_GROWTH_TYPE = new User_Control.ComboBox();
            this.BTN_GROWTH_CHECK = new User_Control.Button();
            this.PN_GROWTH_LINE = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CB_HARVEST_LINE2 = new User_Control.ComboBox();
            this.CB_HARVEST_LINE1 = new User_Control.ComboBox();
            this.PB_AGV1 = new System.Windows.Forms.PictureBox();
            this.PB_FARM = new System.Windows.Forms.PictureBox();
            this.BTN_HARVEST = new User_Control.Button();
            this.BTN_PEST = new User_Control.Button();
            this.BTN_GROWTH = new User_Control.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CHART_GROWTH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHART_GROWTH2)).BeginInit();
            this.PN_GROWTH_INFO.SuspendLayout();
            this.PN_GROWTH_LINE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_AGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_FARM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CHART_GROWTH
            // 
            this.CHART_GROWTH.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.CHART_GROWTH.BackColor = System.Drawing.Color.Transparent;
            this.CHART_GROWTH.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.CHART_GROWTH.Legend.Name = "Default Legend";
            this.CHART_GROWTH.Location = new System.Drawing.Point(13, 157);
            this.CHART_GROWTH.Name = "CHART_GROWTH";
            this.CHART_GROWTH.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.CHART_GROWTH.Size = new System.Drawing.Size(594, 280);
            this.CHART_GROWTH.TabIndex = 5;
            // 
            // LB_GROWTH
            // 
            this.LB_GROWTH.AutoSize = true;
            this.LB_GROWTH.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LB_GROWTH.Location = new System.Drawing.Point(26, 32);
            this.LB_GROWTH.Name = "LB_GROWTH";
            this.LB_GROWTH.Size = new System.Drawing.Size(243, 32);
            this.LB_GROWTH.TabIndex = 9;
            this.LB_GROWTH.Text = "Growth Information";
            // 
            // CHART_GROWTH2
            // 
            this.CHART_GROWTH2.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.CHART_GROWTH2.BackColor = System.Drawing.Color.Transparent;
            this.CHART_GROWTH2.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.CHART_GROWTH2.Legend.Name = "Default Legend";
            this.CHART_GROWTH2.Location = new System.Drawing.Point(12, 473);
            this.CHART_GROWTH2.Name = "CHART_GROWTH2";
            this.CHART_GROWTH2.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.CHART_GROWTH2.Size = new System.Drawing.Size(595, 256);
            this.CHART_GROWTH2.TabIndex = 14;
            // 
            // LB_HARVEST
            // 
            this.LB_HARVEST.AutoSize = true;
            this.LB_HARVEST.BackColor = System.Drawing.Color.Transparent;
            this.LB_HARVEST.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LB_HARVEST.Location = new System.Drawing.Point(25, 31);
            this.LB_HARVEST.Name = "LB_HARVEST";
            this.LB_HARVEST.Size = new System.Drawing.Size(101, 32);
            this.LB_HARVEST.TabIndex = 16;
            this.LB_HARVEST.Text = "Harvest";
            // 
            // PN_GROWTH_INFO
            // 
            this.PN_GROWTH_INFO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.PN_GROWTH_INFO.Controls.Add(this.CB_GROWTH_TYPE);
            this.PN_GROWTH_INFO.Controls.Add(this.BTN_GROWTH_CHECK);
            this.PN_GROWTH_INFO.Controls.Add(this.CHART_GROWTH2);
            this.PN_GROWTH_INFO.Controls.Add(this.CHART_GROWTH);
            this.PN_GROWTH_INFO.Controls.Add(this.LB_GROWTH);
            this.PN_GROWTH_INFO.Location = new System.Drawing.Point(974, 132);
            this.PN_GROWTH_INFO.Name = "PN_GROWTH_INFO";
            this.PN_GROWTH_INFO.Size = new System.Drawing.Size(613, 810);
            this.PN_GROWTH_INFO.TabIndex = 17;
            // 
            // CB_GROWTH_TYPE
            // 
            this.CB_GROWTH_TYPE.Location = new System.Drawing.Point(32, 92);
            this.CB_GROWTH_TYPE.Margin = new System.Windows.Forms.Padding(0);
            this.CB_GROWTH_TYPE.Name = "CB_GROWTH_TYPE";
            this.CB_GROWTH_TYPE.Size = new System.Drawing.Size(260, 35);
            this.CB_GROWTH_TYPE.TabIndex = 16;
            this.CB_GROWTH_TYPE.ButtonClick += new System.EventHandler(this.CB_GROWTH_TYPE_ButtonClick);
            // 
            // BTN_GROWTH_CHECK
            // 
            this.BTN_GROWTH_CHECK.Location = new System.Drawing.Point(317, 92);
            this.BTN_GROWTH_CHECK.Name = "BTN_GROWTH_CHECK";
            this.BTN_GROWTH_CHECK.Size = new System.Drawing.Size(260, 35);
            this.BTN_GROWTH_CHECK.TabIndex = 15;
            this.BTN_GROWTH_CHECK.ButtonClick += new System.EventHandler(this.BTN_GROWTH_CHECK_ButtonClick);
            // 
            // PN_GROWTH_LINE
            // 
            this.PN_GROWTH_LINE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.PN_GROWTH_LINE.Controls.Add(this.pictureBox1);
            this.PN_GROWTH_LINE.Controls.Add(this.CB_HARVEST_LINE2);
            this.PN_GROWTH_LINE.Controls.Add(this.LB_HARVEST);
            this.PN_GROWTH_LINE.Controls.Add(this.CB_HARVEST_LINE1);
            this.PN_GROWTH_LINE.Location = new System.Drawing.Point(31, 708);
            this.PN_GROWTH_LINE.Name = "PN_GROWTH_LINE";
            this.PN_GROWTH_LINE.Size = new System.Drawing.Size(924, 234);
            this.PN_GROWTH_LINE.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TEST1.Properties.Resources.common_ic_wave;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(216, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 32);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // CB_HARVEST_LINE2
            // 
            this.CB_HARVEST_LINE2.Location = new System.Drawing.Point(273, 90);
            this.CB_HARVEST_LINE2.Margin = new System.Windows.Forms.Padding(0);
            this.CB_HARVEST_LINE2.Name = "CB_HARVEST_LINE2";
            this.CB_HARVEST_LINE2.Size = new System.Drawing.Size(170, 32);
            this.CB_HARVEST_LINE2.TabIndex = 17;
            this.CB_HARVEST_LINE2.ButtonClick += new System.EventHandler(this.CB_HARVEST_LINE2_ButtonClick);
            // 
            // CB_HARVEST_LINE1
            // 
            this.CB_HARVEST_LINE1.Location = new System.Drawing.Point(26, 90);
            this.CB_HARVEST_LINE1.Margin = new System.Windows.Forms.Padding(0);
            this.CB_HARVEST_LINE1.Name = "CB_HARVEST_LINE1";
            this.CB_HARVEST_LINE1.Size = new System.Drawing.Size(170, 32);
            this.CB_HARVEST_LINE1.TabIndex = 15;
            this.CB_HARVEST_LINE1.ButtonClick += new System.EventHandler(this.CB_GROWTH_LINE_ButtonClick);
            // 
            // PB_AGV1
            // 
            this.PB_AGV1.BackgroundImage = global::TEST1.Properties.Resources.AGV;
            this.PB_AGV1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_AGV1.Location = new System.Drawing.Point(47, 628);
            this.PB_AGV1.Name = "PB_AGV1";
            this.PB_AGV1.Size = new System.Drawing.Size(39, 44);
            this.PB_AGV1.TabIndex = 2;
            this.PB_AGV1.TabStop = false;
            // 
            // PB_FARM
            // 
            this.PB_FARM.BackColor = System.Drawing.Color.Transparent;
            this.PB_FARM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_FARM.Location = new System.Drawing.Point(31, 132);
            this.PB_FARM.Name = "PB_FARM";
            this.PB_FARM.Size = new System.Drawing.Size(924, 559);
            this.PB_FARM.TabIndex = 1;
            this.PB_FARM.TabStop = false;
            this.PB_FARM.Click += new System.EventHandler(this.PB_FARM_Click);
            this.PB_FARM.Paint += new System.Windows.Forms.PaintEventHandler(this.PB_FARM_Paint);
            this.PB_FARM.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB_FARM_MouseMove);
            // 
            // BTN_HARVEST
            // 
            this.BTN_HARVEST.Location = new System.Drawing.Point(342, 75);
            this.BTN_HARVEST.Name = "BTN_HARVEST";
            this.BTN_HARVEST.Size = new System.Drawing.Size(126, 41);
            this.BTN_HARVEST.TabIndex = 12;
            this.BTN_HARVEST.ButtonClick += new System.EventHandler(this.BTN_HARVEST_ButtonClick);
            // 
            // BTN_PEST
            // 
            this.BTN_PEST.Location = new System.Drawing.Point(187, 75);
            this.BTN_PEST.Name = "BTN_PEST";
            this.BTN_PEST.Size = new System.Drawing.Size(126, 41);
            this.BTN_PEST.TabIndex = 11;
            this.BTN_PEST.ButtonClick += new System.EventHandler(this.BTN_PEST_ButtonClick);
            // 
            // BTN_GROWTH
            // 
            this.BTN_GROWTH.Location = new System.Drawing.Point(32, 75);
            this.BTN_GROWTH.Name = "BTN_GROWTH";
            this.BTN_GROWTH.Size = new System.Drawing.Size(126, 41);
            this.BTN_GROWTH.TabIndex = 10;
            this.BTN_GROWTH.ButtonClick += new System.EventHandler(this.BTN_GROWTH_ButtonClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.pictureBox2.Location = new System.Drawing.Point(32, 55);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 3);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(24, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 37);
            this.label2.TabIndex = 21;
            this.label2.Text = "Main";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PN_GROWTH_LINE);
            this.Controls.Add(this.PN_GROWTH_INFO);
            this.Controls.Add(this.BTN_HARVEST);
            this.Controls.Add(this.BTN_PEST);
            this.Controls.Add(this.BTN_GROWTH);
            this.Controls.Add(this.PB_AGV1);
            this.Controls.Add(this.PB_FARM);
            this.Name = "Form1_1";
            this.Size = new System.Drawing.Size(1609, 957);
            this.Load += new System.EventHandler(this.Form1_1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.CHART_GROWTH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHART_GROWTH2)).EndInit();
            this.PN_GROWTH_INFO.ResumeLayout(false);
            this.PN_GROWTH_INFO.PerformLayout();
            this.PN_GROWTH_LINE.ResumeLayout(false);
            this.PN_GROWTH_LINE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_AGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_FARM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PB_FARM;
        private System.Windows.Forms.PictureBox PB_AGV1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraCharts.ChartControl CHART_GROWTH;
        private System.Windows.Forms.Label LB_GROWTH;
        private User_Control.Button BTN_GROWTH;
        private User_Control.Button BTN_PEST;
        private User_Control.Button BTN_HARVEST;
        private DevExpress.XtraCharts.ChartControl CHART_GROWTH2;
        private User_Control.ComboBox CB_HARVEST_LINE1;
        private System.Windows.Forms.Label LB_HARVEST;
        private System.Windows.Forms.Panel PN_GROWTH_INFO;
        private System.Windows.Forms.Panel PN_GROWTH_LINE;
        private User_Control.Button BTN_GROWTH_CHECK;
        private User_Control.ComboBox CB_GROWTH_TYPE;
        private User_Control.ComboBox CB_HARVEST_LINE2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}
