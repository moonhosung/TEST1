namespace TEST1
{
    partial class MainForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.MAIN_TLP = new System.Windows.Forms.TableLayoutPanel();
            this.TLP_CENTER = new System.Windows.Forms.TableLayoutPanel();
            this.TLP_RIGHT = new System.Windows.Forms.TableLayoutPanel();
            this.TLP_MENU = new System.Windows.Forms.TableLayoutPanel();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.TLP_BOTTOM = new System.Windows.Forms.TableLayoutPanel();
            this.PN_TOP = new System.Windows.Forms.Panel();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_MAIN_EXIT = new System.Windows.Forms.Button();
            this.PB_LOGO = new System.Windows.Forms.PictureBox();
            this.BTN_RIGHT5 = new User_Control.Button();
            this.BTN_RIGHT4 = new User_Control.Button();
            this.BTN_RIGHT3 = new User_Control.Button();
            this.BTN_RIGHT2 = new User_Control.Button();
            this.BTN_RIGHT1 = new User_Control.Button();
            this.BTN_MENU1 = new User_Control.MenuButton();
            this.BTN_MENU2 = new User_Control.MenuButton();
            this.BTN_MENU3 = new User_Control.MenuButton();
            this.BTN_BOTTOM_MENU4 = new User_Control.Button();
            this.BTN_BOTTOM_MENU5 = new User_Control.Button();
            this.BTN_BOTTOM_MENU3 = new User_Control.Button();
            this.BTN_BOTTOM_MENU1 = new User_Control.Button();
            this.BTN_BOTTOM_MENU2 = new User_Control.Button();
            this.BTN_LOGIN = new User_Control.Button();
            this.MAIN_TLP.SuspendLayout();
            this.TLP_CENTER.SuspendLayout();
            this.TLP_RIGHT.SuspendLayout();
            this.TLP_MENU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            this.TLP_BOTTOM.SuspendLayout();
            this.PN_TOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_LOGO)).BeginInit();
            this.SuspendLayout();
            // 
            // MAIN_TLP
            // 
            this.MAIN_TLP.BackColor = System.Drawing.Color.White;
            this.MAIN_TLP.ColumnCount = 1;
            this.MAIN_TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MAIN_TLP.Controls.Add(this.TLP_CENTER, 0, 1);
            this.MAIN_TLP.Controls.Add(this.TLP_BOTTOM, 0, 2);
            this.MAIN_TLP.Controls.Add(this.PN_TOP, 0, 0);
            this.MAIN_TLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MAIN_TLP.Location = new System.Drawing.Point(0, 0);
            this.MAIN_TLP.Name = "MAIN_TLP";
            this.MAIN_TLP.RowCount = 3;
            this.MAIN_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.MAIN_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MAIN_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.MAIN_TLP.Size = new System.Drawing.Size(1920, 1080);
            this.MAIN_TLP.TabIndex = 0;
            // 
            // TLP_CENTER
            // 
            this.TLP_CENTER.BackColor = System.Drawing.Color.White;
            this.TLP_CENTER.ColumnCount = 4;
            this.TLP_CENTER.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_CENTER.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLP_CENTER.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.TLP_CENTER.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.TLP_CENTER.Controls.Add(this.TLP_RIGHT, 2, 0);
            this.TLP_CENTER.Controls.Add(this.TLP_MENU, 3, 0);
            this.TLP_CENTER.Controls.Add(this.separatorControl2, 1, 0);
            this.TLP_CENTER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_CENTER.Location = new System.Drawing.Point(0, 80);
            this.TLP_CENTER.Margin = new System.Windows.Forms.Padding(0);
            this.TLP_CENTER.Name = "TLP_CENTER";
            this.TLP_CENTER.RowCount = 1;
            this.TLP_CENTER.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_CENTER.Size = new System.Drawing.Size(1920, 999);
            this.TLP_CENTER.TabIndex = 1;
            this.TLP_CENTER.Paint += new System.Windows.Forms.PaintEventHandler(this.TLP_CENTER_Paint);
            // 
            // TLP_RIGHT
            // 
            this.TLP_RIGHT.ColumnCount = 1;
            this.TLP_RIGHT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_RIGHT.Controls.Add(this.BTN_RIGHT5, 0, 4);
            this.TLP_RIGHT.Controls.Add(this.BTN_RIGHT4, 0, 3);
            this.TLP_RIGHT.Controls.Add(this.BTN_RIGHT3, 0, 2);
            this.TLP_RIGHT.Controls.Add(this.BTN_RIGHT2, 0, 1);
            this.TLP_RIGHT.Controls.Add(this.BTN_RIGHT1, 0, 0);
            this.TLP_RIGHT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_RIGHT.Location = new System.Drawing.Point(1672, 3);
            this.TLP_RIGHT.Name = "TLP_RIGHT";
            this.TLP_RIGHT.RowCount = 6;
            this.TLP_RIGHT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TLP_RIGHT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TLP_RIGHT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TLP_RIGHT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TLP_RIGHT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TLP_RIGHT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TLP_RIGHT.Size = new System.Drawing.Size(1, 993);
            this.TLP_RIGHT.TabIndex = 0;
            // 
            // TLP_MENU
            // 
            this.TLP_MENU.ColumnCount = 1;
            this.TLP_MENU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_MENU.Controls.Add(this.BTN_MENU1, 0, 0);
            this.TLP_MENU.Controls.Add(this.BTN_MENU2, 0, 1);
            this.TLP_MENU.Controls.Add(this.BTN_MENU3, 0, 2);
            this.TLP_MENU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_MENU.Location = new System.Drawing.Point(1673, 3);
            this.TLP_MENU.Name = "TLP_MENU";
            this.TLP_MENU.RowCount = 8;
            this.TLP_MENU.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TLP_MENU.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TLP_MENU.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TLP_MENU.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TLP_MENU.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TLP_MENU.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TLP_MENU.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TLP_MENU.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TLP_MENU.Size = new System.Drawing.Size(244, 993);
            this.TLP_MENU.TabIndex = 1;
            // 
            // separatorControl2
            // 
            this.separatorControl2.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl2.Location = new System.Drawing.Point(1649, 0);
            this.separatorControl2.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.separatorControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.separatorControl2.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(20, 996);
            this.separatorControl2.TabIndex = 17;
            // 
            // TLP_BOTTOM
            // 
            this.TLP_BOTTOM.BackColor = System.Drawing.Color.White;
            this.TLP_BOTTOM.ColumnCount = 8;
            this.TLP_BOTTOM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TLP_BOTTOM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TLP_BOTTOM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TLP_BOTTOM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TLP_BOTTOM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TLP_BOTTOM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.TLP_BOTTOM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.TLP_BOTTOM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1060F));
            this.TLP_BOTTOM.Controls.Add(this.BTN_BOTTOM_MENU4, 0, 0);
            this.TLP_BOTTOM.Controls.Add(this.BTN_BOTTOM_MENU5, 0, 0);
            this.TLP_BOTTOM.Controls.Add(this.BTN_BOTTOM_MENU3, 0, 0);
            this.TLP_BOTTOM.Controls.Add(this.BTN_BOTTOM_MENU1, 0, 0);
            this.TLP_BOTTOM.Controls.Add(this.BTN_BOTTOM_MENU2, 0, 0);
            this.TLP_BOTTOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_BOTTOM.Location = new System.Drawing.Point(0, 1079);
            this.TLP_BOTTOM.Margin = new System.Windows.Forms.Padding(0);
            this.TLP_BOTTOM.Name = "TLP_BOTTOM";
            this.TLP_BOTTOM.RowCount = 1;
            this.TLP_BOTTOM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_BOTTOM.Size = new System.Drawing.Size(1920, 1);
            this.TLP_BOTTOM.TabIndex = 2;
            // 
            // PN_TOP
            // 
            this.PN_TOP.BackColor = System.Drawing.Color.White;
            this.PN_TOP.Controls.Add(this.separatorControl1);
            this.PN_TOP.Controls.Add(this.BTN_LOGIN);
            this.PN_TOP.Controls.Add(this.label1);
            this.PN_TOP.Controls.Add(this.BTN_MAIN_EXIT);
            this.PN_TOP.Controls.Add(this.PB_LOGO);
            this.PN_TOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PN_TOP.Location = new System.Drawing.Point(0, 0);
            this.PN_TOP.Margin = new System.Windows.Forms.Padding(0);
            this.PN_TOP.Name = "PN_TOP";
            this.PN_TOP.Size = new System.Drawing.Size(1920, 80);
            this.PN_TOP.TabIndex = 3;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(-3, 68);
            this.separatorControl1.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.separatorControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(1917, 18);
            this.separatorControl1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(147, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "SmartFarm System";
            // 
            // BTN_MAIN_EXIT
            // 
            this.BTN_MAIN_EXIT.BackColor = System.Drawing.Color.White;
            this.BTN_MAIN_EXIT.BackgroundImage = global::TEST1.Properties.Resources.common_ic_grey;
            this.BTN_MAIN_EXIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_MAIN_EXIT.CausesValidation = false;
            this.BTN_MAIN_EXIT.FlatAppearance.BorderSize = 0;
            this.BTN_MAIN_EXIT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTN_MAIN_EXIT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTN_MAIN_EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_MAIN_EXIT.Location = new System.Drawing.Point(1856, 16);
            this.BTN_MAIN_EXIT.Name = "BTN_MAIN_EXIT";
            this.BTN_MAIN_EXIT.Size = new System.Drawing.Size(45, 45);
            this.BTN_MAIN_EXIT.TabIndex = 7;
            this.BTN_MAIN_EXIT.UseMnemonic = false;
            this.BTN_MAIN_EXIT.UseVisualStyleBackColor = false;
            this.BTN_MAIN_EXIT.Click += new System.EventHandler(this.BTN_MAIN_EXIT_Click);
            this.BTN_MAIN_EXIT.MouseEnter += new System.EventHandler(this.BTN_MAIN_EXIT_MouseEnter);
            this.BTN_MAIN_EXIT.MouseLeave += new System.EventHandler(this.BTN_MAIN_EXIT_MouseLeave);
            // 
            // PB_LOGO
            // 
            this.PB_LOGO.BackgroundImage = global::TEST1.Properties.Resources.logo;
            this.PB_LOGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB_LOGO.Location = new System.Drawing.Point(11, 18);
            this.PB_LOGO.Name = "PB_LOGO";
            this.PB_LOGO.Size = new System.Drawing.Size(120, 42);
            this.PB_LOGO.TabIndex = 6;
            this.PB_LOGO.TabStop = false;
            // 
            // BTN_RIGHT5
            // 
            this.BTN_RIGHT5.Location = new System.Drawing.Point(3, 483);
            this.BTN_RIGHT5.Name = "BTN_RIGHT5";
            this.BTN_RIGHT5.Size = new System.Drawing.Size(1, 109);
            this.BTN_RIGHT5.TabIndex = 4;
            // 
            // BTN_RIGHT4
            // 
            this.BTN_RIGHT4.Location = new System.Drawing.Point(3, 363);
            this.BTN_RIGHT4.Name = "BTN_RIGHT4";
            this.BTN_RIGHT4.Size = new System.Drawing.Size(1, 109);
            this.BTN_RIGHT4.TabIndex = 3;
            // 
            // BTN_RIGHT3
            // 
            this.BTN_RIGHT3.Location = new System.Drawing.Point(3, 243);
            this.BTN_RIGHT3.Name = "BTN_RIGHT3";
            this.BTN_RIGHT3.Size = new System.Drawing.Size(1, 109);
            this.BTN_RIGHT3.TabIndex = 2;
            this.BTN_RIGHT3.ButtonClick += new System.EventHandler(this.BTN_RIGHT3_ButtonClick);
            // 
            // BTN_RIGHT2
            // 
            this.BTN_RIGHT2.Location = new System.Drawing.Point(3, 123);
            this.BTN_RIGHT2.Name = "BTN_RIGHT2";
            this.BTN_RIGHT2.Size = new System.Drawing.Size(1, 109);
            this.BTN_RIGHT2.TabIndex = 1;
            this.BTN_RIGHT2.ButtonClick += new System.EventHandler(this.BTN_RIGHT2_ButtonClick);
            // 
            // BTN_RIGHT1
            // 
            this.BTN_RIGHT1.Location = new System.Drawing.Point(3, 3);
            this.BTN_RIGHT1.Name = "BTN_RIGHT1";
            this.BTN_RIGHT1.Size = new System.Drawing.Size(1, 109);
            this.BTN_RIGHT1.TabIndex = 0;
            this.BTN_RIGHT1.ButtonClick += new System.EventHandler(this.BTN_RIGHT1_ButtonClick);
            // 
            // BTN_MENU1
            // 
            this.BTN_MENU1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_MENU1.Location = new System.Drawing.Point(3, 3);
            this.BTN_MENU1.Name = "BTN_MENU1";
            this.BTN_MENU1.Size = new System.Drawing.Size(238, 84);
            this.BTN_MENU1.TabIndex = 0;
            this.BTN_MENU1.ButtonClick += new System.EventHandler(this.BTN_MENU1_ButtonClick);
            // 
            // BTN_MENU2
            // 
            this.BTN_MENU2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_MENU2.Location = new System.Drawing.Point(3, 93);
            this.BTN_MENU2.Name = "BTN_MENU2";
            this.BTN_MENU2.Size = new System.Drawing.Size(238, 84);
            this.BTN_MENU2.TabIndex = 0;
            this.BTN_MENU2.ButtonClick += new System.EventHandler(this.BTN_MENU2_ButtonClick);
            // 
            // BTN_MENU3
            // 
            this.BTN_MENU3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_MENU3.Location = new System.Drawing.Point(3, 183);
            this.BTN_MENU3.Name = "BTN_MENU3";
            this.BTN_MENU3.Size = new System.Drawing.Size(238, 84);
            this.BTN_MENU3.TabIndex = 0;
            this.BTN_MENU3.ButtonClick += new System.EventHandler(this.BTN_MENU3_ButtonClick);
            // 
            // BTN_BOTTOM_MENU4
            // 
            this.BTN_BOTTOM_MENU4.Location = new System.Drawing.Point(363, 3);
            this.BTN_BOTTOM_MENU4.Name = "BTN_BOTTOM_MENU4";
            this.BTN_BOTTOM_MENU4.Size = new System.Drawing.Size(114, 1);
            this.BTN_BOTTOM_MENU4.TabIndex = 5;
            this.BTN_BOTTOM_MENU4.Visible = false;
            this.BTN_BOTTOM_MENU4.ButtonClick += new System.EventHandler(this.BTN_BOTTOM_MENU4_ButtonClick);
            // 
            // BTN_BOTTOM_MENU5
            // 
            this.BTN_BOTTOM_MENU5.Location = new System.Drawing.Point(483, 3);
            this.BTN_BOTTOM_MENU5.Name = "BTN_BOTTOM_MENU5";
            this.BTN_BOTTOM_MENU5.Size = new System.Drawing.Size(114, 1);
            this.BTN_BOTTOM_MENU5.TabIndex = 4;
            this.BTN_BOTTOM_MENU5.Visible = false;
            this.BTN_BOTTOM_MENU5.ButtonClick += new System.EventHandler(this.BTN_BOTTOM_MENU5_ButtonClick);
            // 
            // BTN_BOTTOM_MENU3
            // 
            this.BTN_BOTTOM_MENU3.Location = new System.Drawing.Point(243, 3);
            this.BTN_BOTTOM_MENU3.Name = "BTN_BOTTOM_MENU3";
            this.BTN_BOTTOM_MENU3.Size = new System.Drawing.Size(114, 1);
            this.BTN_BOTTOM_MENU3.TabIndex = 3;
            this.BTN_BOTTOM_MENU3.Visible = false;
            this.BTN_BOTTOM_MENU3.ButtonClick += new System.EventHandler(this.BTN_BOTTOM_MENU3_ButtonClick);
            // 
            // BTN_BOTTOM_MENU1
            // 
            this.BTN_BOTTOM_MENU1.Location = new System.Drawing.Point(3, 3);
            this.BTN_BOTTOM_MENU1.Name = "BTN_BOTTOM_MENU1";
            this.BTN_BOTTOM_MENU1.Size = new System.Drawing.Size(114, 1);
            this.BTN_BOTTOM_MENU1.TabIndex = 2;
            this.BTN_BOTTOM_MENU1.Visible = false;
            this.BTN_BOTTOM_MENU1.ButtonClick += new System.EventHandler(this.BTN_BOTTOM_MENU1_ButtonClick);
            // 
            // BTN_BOTTOM_MENU2
            // 
            this.BTN_BOTTOM_MENU2.Location = new System.Drawing.Point(123, 3);
            this.BTN_BOTTOM_MENU2.Name = "BTN_BOTTOM_MENU2";
            this.BTN_BOTTOM_MENU2.Size = new System.Drawing.Size(114, 1);
            this.BTN_BOTTOM_MENU2.TabIndex = 1;
            this.BTN_BOTTOM_MENU2.Visible = false;
            this.BTN_BOTTOM_MENU2.ButtonClick += new System.EventHandler(this.BTN_BOTTOM_MENU2_ButtonClick);
            // 
            // BTN_LOGIN
            // 
            this.BTN_LOGIN.Location = new System.Drawing.Point(1717, 18);
            this.BTN_LOGIN.Name = "BTN_LOGIN";
            this.BTN_LOGIN.Size = new System.Drawing.Size(109, 40);
            this.BTN_LOGIN.TabIndex = 9;
            this.BTN_LOGIN.ButtonClick += new System.EventHandler(this.BTN_LOGIN_ButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.MAIN_TLP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MAIN_TLP.ResumeLayout(false);
            this.TLP_CENTER.ResumeLayout(false);
            this.TLP_RIGHT.ResumeLayout(false);
            this.TLP_MENU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            this.TLP_BOTTOM.ResumeLayout(false);
            this.PN_TOP.ResumeLayout(false);
            this.PN_TOP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_LOGO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MAIN_TLP;
        private System.Windows.Forms.TableLayoutPanel TLP_CENTER;
        private System.Windows.Forms.TableLayoutPanel TLP_BOTTOM;
        private System.Windows.Forms.TableLayoutPanel TLP_RIGHT;
        private User_Control.Button BTN_RIGHT5;
        private User_Control.Button BTN_RIGHT4;
        private User_Control.Button BTN_RIGHT3;
        private User_Control.Button BTN_RIGHT2;
        private User_Control.Button BTN_RIGHT1;
        private System.Windows.Forms.Panel PN_TOP;
        private System.Windows.Forms.PictureBox PB_LOGO;
        private User_Control.Button BTN_BOTTOM_MENU4;
        private User_Control.Button BTN_BOTTOM_MENU5;
        private User_Control.Button BTN_BOTTOM_MENU3;
        private User_Control.Button BTN_BOTTOM_MENU1;
        private User_Control.Button BTN_BOTTOM_MENU2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private User_Control.Button BTN_LOGIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_MAIN_EXIT;
        private System.Windows.Forms.TableLayoutPanel TLP_MENU;
        private User_Control.MenuButton BTN_MENU3;
        private User_Control.MenuButton BTN_MENU2;
        private User_Control.MenuButton BTN_MENU1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
    }
}

