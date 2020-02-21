namespace User_Control
{
    partial class ComboBox
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
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxEdit1.Location = new System.Drawing.Point(0, 0);
            this.comboBoxEdit1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.AllowFocused = false;
            this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit1.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 16F);
            this.comboBoxEdit1.Properties.AppearanceDropDown.Options.UseFont = true;
            this.comboBoxEdit1.Properties.AutoHeight = false;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.ContextButtonOptions.ShowToolTips = false;
            this.comboBoxEdit1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.comboBoxEdit1.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.comboBoxEdit1.Properties.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.HotTrack;
            this.comboBoxEdit1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit1.Properties.UseReadOnlyAppearance = false;
            this.comboBoxEdit1.Size = new System.Drawing.Size(192, 32);
            this.comboBoxEdit1.TabIndex = 0;
            this.comboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged_1);
            // 
            // ComboBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.comboBoxEdit1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ComboBox";
            this.Size = new System.Drawing.Size(192, 32);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
    }
}
