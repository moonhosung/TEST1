namespace TEST1
{
    partial class SetupForm
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.CHK_KEYPAD_USE = new User_Control.CheckEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ipControl2 = new User_Control.IpControl();
            this.label5 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ipControl1 = new User_Control.IpControl();
            this.label46 = new System.Windows.Forms.Label();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.pictureBox2.Location = new System.Drawing.Point(32, 56);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 3);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(24, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 42);
            this.label2.TabIndex = 25;
            this.label2.Text = "Setup";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.AppearancePage.Header.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabControl1.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControl1.Location = new System.Drawing.Point(32, 79);
            this.xtraTabControl1.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.xtraTabControl1.LookAndFeel.SkinName = "DevExpress Style";
            this.xtraTabControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1404, 600);
            this.xtraTabControl1.TabIndex = 221;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.label6);
            this.xtraTabPage1.Controls.Add(this.CHK_KEYPAD_USE);
            this.xtraTabPage1.Controls.Add(this.textEdit2);
            this.xtraTabPage1.Controls.Add(this.label3);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.ipControl2);
            this.xtraTabPage1.Controls.Add(this.label5);
            this.xtraTabPage1.Controls.Add(this.textEdit1);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Controls.Add(this.label15);
            this.xtraTabPage1.Controls.Add(this.ipControl1);
            this.xtraTabPage1.Controls.Add(this.label46);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1398, 555);
            this.xtraTabPage1.Text = "Communication";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label6.Location = new System.Drawing.Point(1235, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 34);
            this.label6.TabIndex = 333;
            this.label6.Text = "KeyPad Use";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CHK_KEYPAD_USE
            // 
            this.CHK_KEYPAD_USE.Location = new System.Drawing.Point(1203, 24);
            this.CHK_KEYPAD_USE.Margin = new System.Windows.Forms.Padding(0);
            this.CHK_KEYPAD_USE.Name = "CHK_KEYPAD_USE";
            this.CHK_KEYPAD_USE.Size = new System.Drawing.Size(24, 24);
            this.CHK_KEYPAD_USE.TabIndex = 332;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(732, 169);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 14F);
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Properties.Mask.EditMask = "####";
            this.textEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit2.Size = new System.Drawing.Size(79, 32);
            this.textEdit2.TabIndex = 331;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(493, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 22);
            this.label3.TabIndex = 330;
            this.label3.Text = "Port";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label4.Location = new System.Drawing.Point(494, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 22);
            this.label4.TabIndex = 329;
            this.label4.Text = "IP ";
            // 
            // ipControl2
            // 
            this.ipControl2.Location = new System.Drawing.Point(563, 113);
            this.ipControl2.Name = "ipControl2";
            this.ipControl2.Size = new System.Drawing.Size(264, 51);
            this.ipControl2.TabIndex = 328;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label5.Location = new System.Drawing.Point(472, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 34);
            this.label5.TabIndex = 327;
            this.label5.Text = "Robot 1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(290, 169);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 14F);
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Mask.EditMask = "####";
            this.textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit1.Size = new System.Drawing.Size(79, 32);
            this.textEdit1.TabIndex = 326;
            this.textEdit1.Click += new System.EventHandler(this.textEdit1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(50, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 325;
            this.label1.Text = "Port";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label15.Location = new System.Drawing.Point(51, 126);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 22);
            this.label15.TabIndex = 324;
            this.label15.Text = "IP ";
            // 
            // ipControl1
            // 
            this.ipControl1.Location = new System.Drawing.Point(120, 113);
            this.ipControl1.Name = "ipControl1";
            this.ipControl1.Size = new System.Drawing.Size(264, 47);
            this.ipControl1.TabIndex = 254;
            this.ipControl1.Click1 += new System.EventHandler(this.ipControl1_Click1);
            this.ipControl1.Click2 += new System.EventHandler(this.ipControl1_Click2);
            this.ipControl1.Click3 += new System.EventHandler(this.ipControl1_Click3);
            this.ipControl1.Click4 += new System.EventHandler(this.ipControl1_Click4);
            // 
            // label46
            // 
            this.label46.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label46.Location = new System.Drawing.Point(29, 57);
            this.label46.Margin = new System.Windows.Forms.Padding(0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(134, 34);
            this.label46.TabIndex = 253;
            this.label46.Text = "DataBase";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1398, 555);
            this.xtraTabPage2.Text = "Setup 2";
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Name = "SetupForm";
            this.Size = new System.Drawing.Size(1486, 706);
            this.Load += new System.EventHandler(this.SetupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private User_Control.IpControl ipControl1;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private User_Control.IpControl ipControl2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private User_Control.CheckEdit CHK_KEYPAD_USE;
    }
}
