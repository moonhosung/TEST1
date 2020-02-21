namespace User_Control
{
    partial class Light_Button
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
            this.PB_MAINT_ICON = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MAINT_ICON)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_MAINT_ICON
            // 
            this.PB_MAINT_ICON.BackColor = System.Drawing.Color.Transparent;
            this.PB_MAINT_ICON.BackgroundImage = global::User_Control.Properties.Resources.maint_eqp_icon_btlight_on;
            this.PB_MAINT_ICON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB_MAINT_ICON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_MAINT_ICON.Location = new System.Drawing.Point(0, 0);
            this.PB_MAINT_ICON.Name = "PB_MAINT_ICON";
            this.PB_MAINT_ICON.Size = new System.Drawing.Size(30, 30);
            this.PB_MAINT_ICON.TabIndex = 13;
            this.PB_MAINT_ICON.TabStop = false;
            // 
            // Light_Button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.PB_MAINT_ICON);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Light_Button";
            this.Size = new System.Drawing.Size(30, 30);
            ((System.ComponentModel.ISupportInitialize)(this.PB_MAINT_ICON)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_MAINT_ICON;
    }
}
