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
            this.PB_AGV1 = new System.Windows.Forms.PictureBox();
            this.PB_FARM = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PB_AGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_FARM)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1001, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 50);
            this.button1.TabIndex = 0;
            this.button1.ButtonClick += new System.EventHandler(this.button1_ButtonClick);
            // 
            // PB_AGV1
            // 
            this.PB_AGV1.BackgroundImage = global::TEST1.Properties.Resources.AGV;
            this.PB_AGV1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_AGV1.Location = new System.Drawing.Point(47, 517);
            this.PB_AGV1.Name = "PB_AGV1";
            this.PB_AGV1.Size = new System.Drawing.Size(39, 44);
            this.PB_AGV1.TabIndex = 2;
            this.PB_AGV1.TabStop = false;
            // 
            // PB_FARM
            // 
            this.PB_FARM.BackgroundImage = global::TEST1.Properties.Resources.farm;
            this.PB_FARM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_FARM.Location = new System.Drawing.Point(31, 21);
            this.PB_FARM.Name = "PB_FARM";
            this.PB_FARM.Size = new System.Drawing.Size(924, 559);
            this.PB_FARM.TabIndex = 1;
            this.PB_FARM.TabStop = false;
            this.PB_FARM.Paint += new System.Windows.Forms.PaintEventHandler(this.PB_FARM_Paint);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label1.Location = new System.Drawing.Point(994, 21);
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
            // Form1_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PB_AGV1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.PB_FARM);
            this.Controls.Add(this.button1);
            this.Name = "Form1_1";
            this.Size = new System.Drawing.Size(1190, 703);
            this.Load += new System.EventHandler(this.Form1_1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.PB_AGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_FARM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Control.Button button1;
        private System.Windows.Forms.PictureBox PB_FARM;
        private System.Windows.Forms.PictureBox PB_AGV1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Timer timer1;
    }
}
