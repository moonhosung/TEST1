namespace User_Control
{
    partial class DateEdit
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
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = new System.DateTime(2020, 2, 28, 0, 0, 0, 0);
            this.dateEdit1.Location = new System.Drawing.Point(0, 0);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
            this.dateEdit1.Properties.AllowFocused = false;
            this.dateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.dateEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.dateEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.dateEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.dateEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)});
            this.dateEdit1.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit1.Properties.CalendarTimeProperties.AllowFocused = false;
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.dateEdit1.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.dateEdit1.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.dateEdit1.Properties.LookAndFeel.SkinName = "DevExpress Style";
            this.dateEdit1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dateEdit1.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.dateEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEdit1.Properties.TimeEditWidth = 12;
            this.dateEdit1.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit1.Size = new System.Drawing.Size(250, 36);
            this.dateEdit1.TabIndex = 77;
            this.dateEdit1.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.dateEdit1_Closed);
            this.dateEdit1.Click += new System.EventHandler(this.dateEdit1_Click);
            // 
            // DateEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateEdit1);
            this.Name = "DateEdit";
            this.Size = new System.Drawing.Size(252, 36);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dateEdit1;
    }
}
