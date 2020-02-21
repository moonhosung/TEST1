﻿namespace User_Control
{
    partial class ToggleButton
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
            this.label1 = new System.Windows.Forms.Label();
            this.PB_MAINT_ICON = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MAINT_ICON)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label1_MouseClick);
            // 
            // PB_MAINT_ICON
            // 
            this.PB_MAINT_ICON.BackColor = System.Drawing.Color.Transparent;
            this.PB_MAINT_ICON.BackgroundImage = global::User_Control.Properties.Resources.common_bt_toggle_01_on;
            this.PB_MAINT_ICON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PB_MAINT_ICON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_MAINT_ICON.Location = new System.Drawing.Point(0, 0);
            this.PB_MAINT_ICON.Name = "PB_MAINT_ICON";
            this.PB_MAINT_ICON.Size = new System.Drawing.Size(118, 38);
            this.PB_MAINT_ICON.TabIndex = 13;
            this.PB_MAINT_ICON.TabStop = false;
            this.PB_MAINT_ICON.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PB_MAINT_ICON_MouseClick);
            // 
            // ToggleButton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PB_MAINT_ICON);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ToggleButton";
            this.Size = new System.Drawing.Size(118, 38);
            this.Load += new System.EventHandler(this.ToggleButton_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_MAINT_ICON)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_MAINT_ICON;
        private System.Windows.Forms.Label label1;
    }
}
