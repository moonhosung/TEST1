namespace User_Control
{
    partial class RoundButton_Short
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
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.CausesValidation = false;
            this.toggleSwitch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleSwitch1.EditValue = true;
            this.toggleSwitch1.Location = new System.Drawing.Point(0, 0);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.AllowFocused = false;
            this.toggleSwitch1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.toggleSwitch1.Properties.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.toggleSwitch1.Properties.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.toggleSwitch1.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitch1.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.toggleSwitch1.Properties.Appearance.Options.UseBackColor = true;
            this.toggleSwitch1.Properties.Appearance.Options.UseBorderColor = true;
            this.toggleSwitch1.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch1.Properties.Appearance.Options.UseForeColor = true;
            this.toggleSwitch1.Properties.Appearance.Options.UseImage = true;
            this.toggleSwitch1.Properties.Appearance.Options.UseTextOptions = true;
            this.toggleSwitch1.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.toggleSwitch1.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.toggleSwitch1.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.toggleSwitch1.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.toggleSwitch1.Properties.AutoWidth = true;
            this.toggleSwitch1.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText;
            this.toggleSwitch1.Properties.GlyphVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.toggleSwitch1.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.Transparent;
            this.toggleSwitch1.Properties.LookAndFeel.SkinName = "Office 2019 Colorful";
            this.toggleSwitch1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.toggleSwitch1.Properties.NullText = "66";
            this.toggleSwitch1.Properties.OffText = "44";
            this.toggleSwitch1.Properties.OnText = "55";
            this.toggleSwitch1.Size = new System.Drawing.Size(127, 32);
            this.toggleSwitch1.TabIndex = 1;
            this.toggleSwitch1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.toggleSwitch1_MouseClick);
            // 
            // RoundButton_Short
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.toggleSwitch1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "RoundButton_Short";
            this.Size = new System.Drawing.Size(127, 32);
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
    }
}
