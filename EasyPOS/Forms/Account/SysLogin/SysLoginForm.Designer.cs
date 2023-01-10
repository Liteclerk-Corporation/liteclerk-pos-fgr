namespace EasyPOS.Forms.Account.SysLogin
{
    partial class SysLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysLoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerLoginDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonSystemDate = new System.Windows.Forms.RadioButton();
            this.radioButtonLoginDate = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelSupport = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonChangeLoginDate = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxUserCardNumber = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 62);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EasyPOS.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(62, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(79)))), ((int)(((byte)(28)))));
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(79)))), ((int)(((byte)(28)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(52)))), ((int)(((byte)(18)))));
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(52)))), ((int)(((byte)(18)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(481, 6);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(88, 40);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(126)))), ((int)(((byte)(181)))));
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(126)))), ((int)(((byte)(181)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(388, 6);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(88, 40);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.TabStop = false;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxUsername.Location = new System.Drawing.Point(186, 65);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(286, 34);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUsername_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(74, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Username:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxPassword.Location = new System.Drawing.Point(186, 108);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '•';
            this.textBoxPassword.Size = new System.Drawing.Size(286, 34);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(80, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "Password:";
            // 
            // dateTimePickerLoginDate
            // 
            this.dateTimePickerLoginDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerLoginDate.CalendarFont = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePickerLoginDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePickerLoginDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerLoginDate.Location = new System.Drawing.Point(151, 45);
            this.dateTimePickerLoginDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerLoginDate.Name = "dateTimePickerLoginDate";
            this.dateTimePickerLoginDate.Size = new System.Drawing.Size(306, 34);
            this.dateTimePickerLoginDate.TabIndex = 5;
            this.dateTimePickerLoginDate.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(148, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Login Date";
            // 
            // radioButtonSystemDate
            // 
            this.radioButtonSystemDate.AutoSize = true;
            this.radioButtonSystemDate.Checked = true;
            this.radioButtonSystemDate.Location = new System.Drawing.Point(12, 11);
            this.radioButtonSystemDate.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonSystemDate.Name = "radioButtonSystemDate";
            this.radioButtonSystemDate.Size = new System.Drawing.Size(126, 27);
            this.radioButtonSystemDate.TabIndex = 3;
            this.radioButtonSystemDate.TabStop = true;
            this.radioButtonSystemDate.Text = "System Date";
            this.radioButtonSystemDate.UseVisualStyleBackColor = true;
            this.radioButtonSystemDate.CheckedChanged += new System.EventHandler(this.radioButtonSystemDate_CheckedChanged);
            // 
            // radioButtonLoginDate
            // 
            this.radioButtonLoginDate.AutoSize = true;
            this.radioButtonLoginDate.Location = new System.Drawing.Point(14, 49);
            this.radioButtonLoginDate.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonLoginDate.Name = "radioButtonLoginDate";
            this.radioButtonLoginDate.Size = new System.Drawing.Size(114, 27);
            this.radioButtonLoginDate.TabIndex = 4;
            this.radioButtonLoginDate.Text = "Login Date";
            this.radioButtonLoginDate.UseVisualStyleBackColor = true;
            this.radioButtonLoginDate.CheckedChanged += new System.EventHandler(this.radioButtonLoginDate_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.labelVersion);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.labelSupport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 331);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 58);
            this.panel2.TabIndex = 11;
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(84, 10);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(221, 20);
            this.labelVersion.TabIndex = 9;
            this.labelVersion.Text = "Easy POS Version: 1.20200518";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EasyPOS.Properties.Resources.liteclerklogoimg;
            this.pictureBox2.Location = new System.Drawing.Point(12, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // labelSupport
            // 
            this.labelSupport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSupport.AutoSize = true;
            this.labelSupport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelSupport.ForeColor = System.Drawing.Color.White;
            this.labelSupport.Location = new System.Drawing.Point(84, 30);
            this.labelSupport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSupport.Name = "labelSupport";
            this.labelSupport.Size = new System.Drawing.Size(334, 20);
            this.labelSupport.TabIndex = 10;
            this.labelSupport.Text = "Support: Liteclerk Corporation (032) 234 0787";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonChangeLoginDate);
            this.panel3.Controls.Add(this.radioButtonSystemDate);
            this.panel3.Controls.Add(this.dateTimePickerLoginDate);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.radioButtonLoginDate);
            this.panel3.Location = new System.Drawing.Point(0, 52);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(579, 94);
            this.panel3.TabIndex = 22;
            // 
            // buttonChangeLoginDate
            // 
            this.buttonChangeLoginDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChangeLoginDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonChangeLoginDate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonChangeLoginDate.FlatAppearance.BorderSize = 0;
            this.buttonChangeLoginDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(126)))), ((int)(((byte)(181)))));
            this.buttonChangeLoginDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(126)))), ((int)(((byte)(181)))));
            this.buttonChangeLoginDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeLoginDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeLoginDate.ForeColor = System.Drawing.Color.White;
            this.buttonChangeLoginDate.Location = new System.Drawing.Point(464, 45);
            this.buttonChangeLoginDate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChangeLoginDate.Name = "buttonChangeLoginDate";
            this.buttonChangeLoginDate.Size = new System.Drawing.Size(105, 36);
            this.buttonChangeLoginDate.TabIndex = 9;
            this.buttonChangeLoginDate.TabStop = false;
            this.buttonChangeLoginDate.Text = "Change";
            this.buttonChangeLoginDate.UseVisualStyleBackColor = false;
            this.buttonChangeLoginDate.Click += new System.EventHandler(this.buttonChangeLoginDate_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.textBoxUserCardNumber);
            this.panel4.Controls.Add(this.textBoxUsername);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.textBoxPassword);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(0, 139);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(579, 195);
            this.panel4.TabIndex = 12;
            // 
            // textBoxUserCardNumber
            // 
            this.textBoxUserCardNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUserCardNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxUserCardNumber.Location = new System.Drawing.Point(0, 15);
            this.textBoxUserCardNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserCardNumber.Name = "textBoxUserCardNumber";
            this.textBoxUserCardNumber.PasswordChar = '•';
            this.textBoxUserCardNumber.Size = new System.Drawing.Size(578, 34);
            this.textBoxUserCardNumber.TabIndex = 0;
            this.textBoxUserCardNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxUserCardNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUserCardNumber_KeyDown);
            // 
            // SysLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(579, 389);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.Name = "SysLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SysLoginForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonSystemDate;
        private System.Windows.Forms.RadioButton radioButtonLoginDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelSupport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxUserCardNumber;
        private System.Windows.Forms.Button buttonChangeLoginDate;
        public System.Windows.Forms.DateTimePicker dateTimePickerLoginDate;
    }
}