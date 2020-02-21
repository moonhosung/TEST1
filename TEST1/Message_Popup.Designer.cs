namespace TEST1
{
    partial class Message_Popup
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LB_MESSAGE_TITLE = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTN_MESSAGE_POPUP_NO = new User_Control.Button();
            this.BTN_MESSAGE_POPUP_YES = new User_Control.Button();
            this.LB_MESSAGE_CONTENTS = new System.Windows.Forms.Label();
            this.BTN_MESSAGE_POPUP_OK = new User_Control.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(559, 329);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.LB_MESSAGE_TITLE);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 50);
            this.panel1.TabIndex = 0;
            // 
            // LB_MESSAGE_TITLE
            // 
            this.LB_MESSAGE_TITLE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_MESSAGE_TITLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MESSAGE_TITLE.ForeColor = System.Drawing.Color.White;
            this.LB_MESSAGE_TITLE.Location = new System.Drawing.Point(0, 11);
            this.LB_MESSAGE_TITLE.Margin = new System.Windows.Forms.Padding(0);
            this.LB_MESSAGE_TITLE.Name = "LB_MESSAGE_TITLE";
            this.LB_MESSAGE_TITLE.Size = new System.Drawing.Size(559, 29);
            this.LB_MESSAGE_TITLE.TabIndex = 10;
            this.LB_MESSAGE_TITLE.Text = "Message";
            this.LB_MESSAGE_TITLE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.BTN_MESSAGE_POPUP_NO);
            this.panel2.Controls.Add(this.BTN_MESSAGE_POPUP_YES);
            this.panel2.Controls.Add(this.LB_MESSAGE_CONTENTS);
            this.panel2.Controls.Add(this.BTN_MESSAGE_POPUP_OK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 279);
            this.panel2.TabIndex = 1;
            // 
            // BTN_MESSAGE_POPUP_NO
            // 
            this.BTN_MESSAGE_POPUP_NO.Location = new System.Drawing.Point(315, 231);
            this.BTN_MESSAGE_POPUP_NO.Name = "BTN_MESSAGE_POPUP_NO";
            this.BTN_MESSAGE_POPUP_NO.Size = new System.Drawing.Size(167, 36);
            this.BTN_MESSAGE_POPUP_NO.TabIndex = 38;
            this.BTN_MESSAGE_POPUP_NO.Visible = false;
            this.BTN_MESSAGE_POPUP_NO.ButtonClick += new System.EventHandler(this.BTN_MESSAGE_POPUP_NO_ButtonClick);
            // 
            // BTN_MESSAGE_POPUP_YES
            // 
            this.BTN_MESSAGE_POPUP_YES.Location = new System.Drawing.Point(77, 231);
            this.BTN_MESSAGE_POPUP_YES.Name = "BTN_MESSAGE_POPUP_YES";
            this.BTN_MESSAGE_POPUP_YES.Size = new System.Drawing.Size(167, 36);
            this.BTN_MESSAGE_POPUP_YES.TabIndex = 37;
            this.BTN_MESSAGE_POPUP_YES.Visible = false;
            this.BTN_MESSAGE_POPUP_YES.ButtonClick += new System.EventHandler(this.BTN_MESSAGE_POPUP_YES_ButtonClick);
            // 
            // LB_MESSAGE_CONTENTS
            // 
            this.LB_MESSAGE_CONTENTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.LB_MESSAGE_CONTENTS.Location = new System.Drawing.Point(62, 32);
            this.LB_MESSAGE_CONTENTS.Name = "LB_MESSAGE_CONTENTS";
            this.LB_MESSAGE_CONTENTS.Size = new System.Drawing.Size(431, 167);
            this.LB_MESSAGE_CONTENTS.TabIndex = 36;
            this.LB_MESSAGE_CONTENTS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_MESSAGE_POPUP_OK
            // 
            this.BTN_MESSAGE_POPUP_OK.Location = new System.Drawing.Point(196, 231);
            this.BTN_MESSAGE_POPUP_OK.Name = "BTN_MESSAGE_POPUP_OK";
            this.BTN_MESSAGE_POPUP_OK.Size = new System.Drawing.Size(167, 36);
            this.BTN_MESSAGE_POPUP_OK.TabIndex = 35;
            this.BTN_MESSAGE_POPUP_OK.Visible = false;
            this.BTN_MESSAGE_POPUP_OK.ButtonClick += new System.EventHandler(this.BTN_MESSAGE_POPUP_ButtonClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // Message_Popup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(559, 329);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Message_Popup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Message_Popup";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private User_Control.Button BTN_MESSAGE_POPUP_OK;
        private System.Windows.Forms.Label LB_MESSAGE_TITLE;
        private System.Windows.Forms.Label LB_MESSAGE_CONTENTS;
        private User_Control.Button BTN_MESSAGE_POPUP_NO;
        private User_Control.Button BTN_MESSAGE_POPUP_YES;
    }
}