namespace User_Control
{
    partial class Button
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
            this.SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // SimpleButton
            // 
            this.SimpleButton.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.SimpleButton.AllowFocus = false;
            this.SimpleButton.Appearance.BackColor = System.Drawing.Color.White;
            this.SimpleButton.Appearance.BackColor2 = System.Drawing.Color.White;
            this.SimpleButton.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.SimpleButton.Appearance.Font = new System.Drawing.Font("Roboto", 16F);
            this.SimpleButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.SimpleButton.Appearance.Options.UseBackColor = true;
            this.SimpleButton.Appearance.Options.UseBorderColor = true;
            this.SimpleButton.Appearance.Options.UseFont = true;
            this.SimpleButton.Appearance.Options.UseForeColor = true;
            this.SimpleButton.Appearance.Options.UseImage = true;
            this.SimpleButton.Appearance.Options.UseTextOptions = true;
            this.SimpleButton.AppearanceDisabled.BorderColor = System.Drawing.Color.Black;
            this.SimpleButton.AppearanceDisabled.Options.UseBorderColor = true;
            this.SimpleButton.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.SimpleButton.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.SimpleButton.AppearanceHovered.Options.UseBackColor = true;
            this.SimpleButton.AppearanceHovered.Options.UseForeColor = true;
            this.SimpleButton.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.SimpleButton.AppearancePressed.Options.UseBackColor = true;
            this.SimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SimpleButton.Location = new System.Drawing.Point(0, 0);
            this.SimpleButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SimpleButton.LookAndFeel.SkinName = "Office 2016 Black";
            this.SimpleButton.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.SimpleButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.SimpleButton.Name = "SimpleButton";
            this.SimpleButton.ShowToolTips = false;
            this.SimpleButton.Size = new System.Drawing.Size(160, 50);
            this.SimpleButton.TabIndex = 7;
            this.SimpleButton.Text = "Button";
            this.SimpleButton.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.SimpleButton);
            this.Name = "Button";
            this.Size = new System.Drawing.Size(160, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton SimpleButton;
    }
}
