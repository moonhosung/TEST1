namespace TEST1
{
    partial class LoginDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_PASSWORD = new System.Windows.Forms.TextBox();
            this.LB_LOGIN_TITLE = new System.Windows.Forms.Label();
            this.BTN_LOGIN_OK = new User_Control.Button();
            this.LB_Maintenance = new System.Windows.Forms.Label();
            this.CB_MAINTENANCE = new User_Control.CheckEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_SUPERVISOR = new User_Control.CheckEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkEdit1 = new User_Control.CheckEdit();
            this.checkEdit2 = new User_Control.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_PASSWORD
            // 
            this.TB_PASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_PASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TB_PASSWORD.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TB_PASSWORD.Location = new System.Drawing.Point(107, 327);
            this.TB_PASSWORD.Name = "TB_PASSWORD";
            this.TB_PASSWORD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_PASSWORD.Size = new System.Drawing.Size(395, 25);
            this.TB_PASSWORD.TabIndex = 34;
            this.TB_PASSWORD.UseSystemPasswordChar = true;
            // 
            // LB_LOGIN_TITLE
            // 
            this.LB_LOGIN_TITLE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.LB_LOGIN_TITLE.Dock = System.Windows.Forms.DockStyle.Top;
            this.LB_LOGIN_TITLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_LOGIN_TITLE.ForeColor = System.Drawing.Color.White;
            this.LB_LOGIN_TITLE.Location = new System.Drawing.Point(0, 0);
            this.LB_LOGIN_TITLE.Margin = new System.Windows.Forms.Padding(0);
            this.LB_LOGIN_TITLE.Name = "LB_LOGIN_TITLE";
            this.LB_LOGIN_TITLE.Size = new System.Drawing.Size(582, 50);
            this.LB_LOGIN_TITLE.TabIndex = 41;
            this.LB_LOGIN_TITLE.Text = "Login";
            this.LB_LOGIN_TITLE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_LOGIN_OK
            // 
            this.BTN_LOGIN_OK.Location = new System.Drawing.Point(80, 370);
            this.BTN_LOGIN_OK.Name = "BTN_LOGIN_OK";
            this.BTN_LOGIN_OK.Size = new System.Drawing.Size(422, 36);
            this.BTN_LOGIN_OK.TabIndex = 60;
            this.BTN_LOGIN_OK.ButtonClick += new System.EventHandler(this.BTN_LOGIN_OK_ButtonClick);
            // 
            // LB_Maintenance
            // 
            this.LB_Maintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LB_Maintenance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.LB_Maintenance.Location = new System.Drawing.Point(135, 280);
            this.LB_Maintenance.Margin = new System.Windows.Forms.Padding(0);
            this.LB_Maintenance.Name = "LB_Maintenance";
            this.LB_Maintenance.Size = new System.Drawing.Size(128, 27);
            this.LB_Maintenance.TabIndex = 63;
            this.LB_Maintenance.Text = "Maintenance";
            this.LB_Maintenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CB_MAINTENANCE
            // 
            this.CB_MAINTENANCE.Location = new System.Drawing.Point(92, 440);
            this.CB_MAINTENANCE.Margin = new System.Windows.Forms.Padding(0);
            this.CB_MAINTENANCE.Name = "CB_MAINTENANCE";
            this.CB_MAINTENANCE.Size = new System.Drawing.Size(24, 38);
            this.CB_MAINTENANCE.TabIndex = 62;
            this.CB_MAINTENANCE.ButtonClick += new System.EventHandler(this.CB_MAINTENANCE_ButtonClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(389, 280);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 27);
            this.label1.TabIndex = 65;
            this.label1.Text = "Supervisor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CB_SUPERVISOR
            // 
            this.CB_SUPERVISOR.Location = new System.Drawing.Point(347, 440);
            this.CB_SUPERVISOR.Margin = new System.Windows.Forms.Padding(0);
            this.CB_SUPERVISOR.Name = "CB_SUPERVISOR";
            this.CB_SUPERVISOR.Size = new System.Drawing.Size(24, 38);
            this.CB_SUPERVISOR.TabIndex = 64;
            this.CB_SUPERVISOR.ButtonClick += new System.EventHandler(this.CB_SUPERVISOR_ButtonClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(80, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 30);
            this.label2.TabIndex = 69;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(85, 330);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 18);
            this.pictureBox2.TabIndex = 68;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TEST1.Properties.Resources.popup_login_ic_character;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(196, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 190);
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.button1.BackgroundImage = global::TEST1.Properties.Resources.popup_ic_x;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(541, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 35);
            this.button1.TabIndex = 66;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(340, 283);
            this.checkEdit1.Margin = new System.Windows.Forms.Padding(0);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Size = new System.Drawing.Size(24, 24);
            this.checkEdit1.TabIndex = 70;
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(80, 283);
            this.checkEdit2.Margin = new System.Windows.Forms.Padding(0);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Size = new System.Drawing.Size(24, 24);
            this.checkEdit2.TabIndex = 71;
            // 
            // LoginDlg
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 425);
            this.ControlBox = false;
            this.Controls.Add(this.checkEdit2);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_SUPERVISOR);
            this.Controls.Add(this.LB_Maintenance);
            this.Controls.Add(this.CB_MAINTENANCE);
            this.Controls.Add(this.BTN_LOGIN_OK);
            this.Controls.Add(this.LB_LOGIN_TITLE);
            this.Controls.Add(this.TB_PASSWORD);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginDlg";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoginDlg_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginDlg_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TB_PASSWORD;
        private System.Windows.Forms.Label LB_LOGIN_TITLE;
        private User_Control.Button BTN_LOGIN_OK;
        private System.Windows.Forms.Label LB_Maintenance;
        private User_Control.CheckEdit CB_MAINTENANCE;
        private System.Windows.Forms.Label label1;
        private User_Control.CheckEdit CB_SUPERVISOR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private User_Control.CheckEdit checkEdit1;
        private User_Control.CheckEdit checkEdit2;
    }
}
