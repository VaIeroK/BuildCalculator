namespace BuildCalculator.Forms
{
    partial class AuthorizeForm
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
            this.RegisterGroupBox = new System.Windows.Forms.GroupBox();
            this.RegisterRewritePasswordLabel = new System.Windows.Forms.Label();
            this.RegisterRewritePasswordTextBox = new System.Windows.Forms.TextBox();
            this.RegisterShowPasswordLabel = new System.Windows.Forms.CheckBox();
            this.RegisterLoginLabel = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.RegisterLoginTextBox = new System.Windows.Forms.TextBox();
            this.AuthorizeLink = new System.Windows.Forms.LinkLabel();
            this.RegisterPasswordLabel = new System.Windows.Forms.Label();
            this.RegisterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginGroupBox = new System.Windows.Forms.GroupBox();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.AuthorizeButton = new System.Windows.Forms.Button();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.RegisterLink = new System.Windows.Forms.LinkLabel();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.EnterLoginLabel = new System.Windows.Forms.Label();
            this.EnterPasswordLabel = new System.Windows.Forms.Label();
            this.EnterLoginTimer = new System.Windows.Forms.Timer(this.components);
            this.EnterPasswordTimer = new System.Windows.Forms.Timer(this.components);
            this.EnterRegisterPasswordLabel = new System.Windows.Forms.Label();
            this.EnterRegisterLoginLabel = new System.Windows.Forms.Label();
            this.EnterRegisterRewritePasswordLabel = new System.Windows.Forms.Label();
            this.EnterRegisterLoginTimer = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.EnterRegisterPasswordTimer = new System.Windows.Forms.Timer(this.components);
            this.EnterRegisterRewritePasswordTimer = new System.Windows.Forms.Timer(this.components);
            this.EnterRegisterNameLabel = new System.Windows.Forms.Label();
            this.RegisterNameLabel = new System.Windows.Forms.Label();
            this.RegisterNameTextBox = new System.Windows.Forms.TextBox();
            this.EnterRegisterLastNameLabel = new System.Windows.Forms.Label();
            this.RegisterLastNameLabel = new System.Windows.Forms.Label();
            this.RegisterLastNameTextBox = new System.Windows.Forms.TextBox();
            this.EnterRegisterNameTimer = new System.Windows.Forms.Timer(this.components);
            this.EnterRegisterLastNameTimer = new System.Windows.Forms.Timer(this.components);
            this.BadPasswordsTimer = new System.Windows.Forms.Timer(this.components);
            this.RegisterGroupBox.SuspendLayout();
            this.LoginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterGroupBox
            // 
            this.RegisterGroupBox.Controls.Add(this.EnterRegisterLastNameLabel);
            this.RegisterGroupBox.Controls.Add(this.RegisterLastNameLabel);
            this.RegisterGroupBox.Controls.Add(this.RegisterLastNameTextBox);
            this.RegisterGroupBox.Controls.Add(this.EnterRegisterNameLabel);
            this.RegisterGroupBox.Controls.Add(this.RegisterNameLabel);
            this.RegisterGroupBox.Controls.Add(this.RegisterNameTextBox);
            this.RegisterGroupBox.Controls.Add(this.EnterRegisterRewritePasswordLabel);
            this.RegisterGroupBox.Controls.Add(this.EnterRegisterPasswordLabel);
            this.RegisterGroupBox.Controls.Add(this.RegisterRewritePasswordLabel);
            this.RegisterGroupBox.Controls.Add(this.EnterRegisterLoginLabel);
            this.RegisterGroupBox.Controls.Add(this.RegisterRewritePasswordTextBox);
            this.RegisterGroupBox.Controls.Add(this.RegisterShowPasswordLabel);
            this.RegisterGroupBox.Controls.Add(this.RegisterLoginLabel);
            this.RegisterGroupBox.Controls.Add(this.RegisterButton);
            this.RegisterGroupBox.Controls.Add(this.RegisterLoginTextBox);
            this.RegisterGroupBox.Controls.Add(this.AuthorizeLink);
            this.RegisterGroupBox.Controls.Add(this.RegisterPasswordLabel);
            this.RegisterGroupBox.Controls.Add(this.RegisterPasswordTextBox);
            this.RegisterGroupBox.Location = new System.Drawing.Point(552, 66);
            this.RegisterGroupBox.Name = "RegisterGroupBox";
            this.RegisterGroupBox.Size = new System.Drawing.Size(383, 233);
            this.RegisterGroupBox.TabIndex = 8;
            this.RegisterGroupBox.TabStop = false;
            // 
            // RegisterRewritePasswordLabel
            // 
            this.RegisterRewritePasswordLabel.AutoSize = true;
            this.RegisterRewritePasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterRewritePasswordLabel.Location = new System.Drawing.Point(6, 127);
            this.RegisterRewritePasswordLabel.Name = "RegisterRewritePasswordLabel";
            this.RegisterRewritePasswordLabel.Size = new System.Drawing.Size(132, 16);
            this.RegisterRewritePasswordLabel.TabIndex = 8;
            this.RegisterRewritePasswordLabel.Text = "Повторите пароль:";
            // 
            // RegisterRewritePasswordTextBox
            // 
            this.RegisterRewritePasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterRewritePasswordTextBox.Location = new System.Drawing.Point(144, 125);
            this.RegisterRewritePasswordTextBox.Name = "RegisterRewritePasswordTextBox";
            this.RegisterRewritePasswordTextBox.Size = new System.Drawing.Size(231, 22);
            this.RegisterRewritePasswordTextBox.TabIndex = 9;
            this.RegisterRewritePasswordTextBox.UseSystemPasswordChar = true;
            // 
            // RegisterShowPasswordLabel
            // 
            this.RegisterShowPasswordLabel.AutoSize = true;
            this.RegisterShowPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterShowPasswordLabel.Location = new System.Drawing.Point(5, 153);
            this.RegisterShowPasswordLabel.Name = "RegisterShowPasswordLabel";
            this.RegisterShowPasswordLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RegisterShowPasswordLabel.Size = new System.Drawing.Size(154, 20);
            this.RegisterShowPasswordLabel.TabIndex = 7;
            this.RegisterShowPasswordLabel.Text = "     Показать пароль";
            this.RegisterShowPasswordLabel.UseVisualStyleBackColor = true;
            this.RegisterShowPasswordLabel.CheckedChanged += new System.EventHandler(this.RegisterShowPasswordLabel_CheckedChanged);
            // 
            // RegisterLoginLabel
            // 
            this.RegisterLoginLabel.AutoSize = true;
            this.RegisterLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterLoginLabel.Location = new System.Drawing.Point(6, 16);
            this.RegisterLoginLabel.Name = "RegisterLoginLabel";
            this.RegisterLoginLabel.Size = new System.Drawing.Size(49, 16);
            this.RegisterLoginLabel.TabIndex = 0;
            this.RegisterLoginLabel.Text = "Логин:";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterButton.Location = new System.Drawing.Point(9, 187);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(366, 36);
            this.RegisterButton.TabIndex = 6;
            this.RegisterButton.Text = "Зарегистрироваться";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegisterLoginTextBox
            // 
            this.RegisterLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterLoginTextBox.Location = new System.Drawing.Point(144, 13);
            this.RegisterLoginTextBox.Name = "RegisterLoginTextBox";
            this.RegisterLoginTextBox.Size = new System.Drawing.Size(231, 22);
            this.RegisterLoginTextBox.TabIndex = 1;
            // 
            // AuthorizeLink
            // 
            this.AuthorizeLink.AutoSize = true;
            this.AuthorizeLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorizeLink.Location = new System.Drawing.Point(328, 168);
            this.AuthorizeLink.Name = "AuthorizeLink";
            this.AuthorizeLink.Size = new System.Drawing.Size(47, 16);
            this.AuthorizeLink.TabIndex = 5;
            this.AuthorizeLink.TabStop = true;
            this.AuthorizeLink.Text = "Войти";
            this.AuthorizeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AuthorizeLink_LinkClicked);
            // 
            // RegisterPasswordLabel
            // 
            this.RegisterPasswordLabel.AutoSize = true;
            this.RegisterPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterPasswordLabel.Location = new System.Drawing.Point(6, 100);
            this.RegisterPasswordLabel.Name = "RegisterPasswordLabel";
            this.RegisterPasswordLabel.Size = new System.Drawing.Size(59, 16);
            this.RegisterPasswordLabel.TabIndex = 2;
            this.RegisterPasswordLabel.Text = "Пароль:";
            // 
            // RegisterPasswordTextBox
            // 
            this.RegisterPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterPasswordTextBox.Location = new System.Drawing.Point(144, 97);
            this.RegisterPasswordTextBox.Name = "RegisterPasswordTextBox";
            this.RegisterPasswordTextBox.Size = new System.Drawing.Size(231, 22);
            this.RegisterPasswordTextBox.TabIndex = 3;
            this.RegisterPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginGroupBox
            // 
            this.LoginGroupBox.Controls.Add(this.EnterPasswordLabel);
            this.LoginGroupBox.Controls.Add(this.EnterLoginLabel);
            this.LoginGroupBox.Controls.Add(this.ShowPasswordCheckBox);
            this.LoginGroupBox.Controls.Add(this.LoginLabel);
            this.LoginGroupBox.Controls.Add(this.AuthorizeButton);
            this.LoginGroupBox.Controls.Add(this.LoginTextBox);
            this.LoginGroupBox.Controls.Add(this.RegisterLink);
            this.LoginGroupBox.Controls.Add(this.PasswordLabel);
            this.LoginGroupBox.Controls.Add(this.PasswordTextBox);
            this.LoginGroupBox.Location = new System.Drawing.Point(48, 66);
            this.LoginGroupBox.Name = "LoginGroupBox";
            this.LoginGroupBox.Size = new System.Drawing.Size(383, 171);
            this.LoginGroupBox.TabIndex = 9;
            this.LoginGroupBox.TabStop = false;
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(5, 70);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(154, 20);
            this.ShowPasswordCheckBox.TabIndex = 7;
            this.ShowPasswordCheckBox.Text = "     Показать пароль";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(6, 16);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(49, 16);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Логин:";
            // 
            // AuthorizeButton
            // 
            this.AuthorizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorizeButton.Location = new System.Drawing.Point(9, 126);
            this.AuthorizeButton.Name = "AuthorizeButton";
            this.AuthorizeButton.Size = new System.Drawing.Size(366, 36);
            this.AuthorizeButton.TabIndex = 6;
            this.AuthorizeButton.Text = "Войти";
            this.AuthorizeButton.UseVisualStyleBackColor = true;
            this.AuthorizeButton.Click += new System.EventHandler(this.AuthorizeButton_Click);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextBox.Location = new System.Drawing.Point(144, 13);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(231, 22);
            this.LoginTextBox.TabIndex = 1;
            // 
            // RegisterLink
            // 
            this.RegisterLink.AutoSize = true;
            this.RegisterLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterLink.Location = new System.Drawing.Point(232, 107);
            this.RegisterLink.Name = "RegisterLink";
            this.RegisterLink.Size = new System.Drawing.Size(144, 16);
            this.RegisterLink.TabIndex = 5;
            this.RegisterLink.TabStop = true;
            this.RegisterLink.Text = "Зарегистрироваться";
            this.RegisterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLink_LinkClicked);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(6, 43);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(59, 16);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Пароль:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.Location = new System.Drawing.Point(144, 40);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(231, 22);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // EnterLoginLabel
            // 
            this.EnterLoginLabel.AutoSize = true;
            this.EnterLoginLabel.BackColor = System.Drawing.SystemColors.Control;
            this.EnterLoginLabel.ForeColor = System.Drawing.Color.Red;
            this.EnterLoginLabel.Location = new System.Drawing.Point(147, 17);
            this.EnterLoginLabel.Name = "EnterLoginLabel";
            this.EnterLoginLabel.Size = new System.Drawing.Size(93, 13);
            this.EnterLoginLabel.TabIndex = 8;
            this.EnterLoginLabel.Text = "Заполните логин";
            this.EnterLoginLabel.Visible = false;
            // 
            // EnterPasswordLabel
            // 
            this.EnterPasswordLabel.AutoSize = true;
            this.EnterPasswordLabel.BackColor = System.Drawing.SystemColors.Control;
            this.EnterPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.EnterPasswordLabel.Location = new System.Drawing.Point(147, 45);
            this.EnterPasswordLabel.Name = "EnterPasswordLabel";
            this.EnterPasswordLabel.Size = new System.Drawing.Size(100, 13);
            this.EnterPasswordLabel.TabIndex = 9;
            this.EnterPasswordLabel.Text = "Заполните пароль";
            this.EnterPasswordLabel.Visible = false;
            // 
            // EnterLoginTimer
            // 
            this.EnterLoginTimer.Interval = 2000;
            this.EnterLoginTimer.Tick += new System.EventHandler(this.EnterLoginTimer_Tick);
            // 
            // EnterPasswordTimer
            // 
            this.EnterPasswordTimer.Interval = 2000;
            this.EnterPasswordTimer.Tick += new System.EventHandler(this.EnterPasswordTimer_Tick);
            // 
            // EnterRegisterPasswordLabel
            // 
            this.EnterRegisterPasswordLabel.AutoSize = true;
            this.EnterRegisterPasswordLabel.BackColor = System.Drawing.SystemColors.Control;
            this.EnterRegisterPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.EnterRegisterPasswordLabel.Location = new System.Drawing.Point(148, 102);
            this.EnterRegisterPasswordLabel.Name = "EnterRegisterPasswordLabel";
            this.EnterRegisterPasswordLabel.Size = new System.Drawing.Size(100, 13);
            this.EnterRegisterPasswordLabel.TabIndex = 11;
            this.EnterRegisterPasswordLabel.Text = "Заполните пароль";
            this.EnterRegisterPasswordLabel.Visible = false;
            // 
            // EnterRegisterLoginLabel
            // 
            this.EnterRegisterLoginLabel.AutoSize = true;
            this.EnterRegisterLoginLabel.BackColor = System.Drawing.SystemColors.Control;
            this.EnterRegisterLoginLabel.ForeColor = System.Drawing.Color.Red;
            this.EnterRegisterLoginLabel.Location = new System.Drawing.Point(147, 17);
            this.EnterRegisterLoginLabel.Name = "EnterRegisterLoginLabel";
            this.EnterRegisterLoginLabel.Size = new System.Drawing.Size(93, 13);
            this.EnterRegisterLoginLabel.TabIndex = 10;
            this.EnterRegisterLoginLabel.Text = "Заполните логин";
            this.EnterRegisterLoginLabel.Visible = false;
            // 
            // EnterRegisterRewritePasswordLabel
            // 
            this.EnterRegisterRewritePasswordLabel.AutoSize = true;
            this.EnterRegisterRewritePasswordLabel.BackColor = System.Drawing.SystemColors.Control;
            this.EnterRegisterRewritePasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.EnterRegisterRewritePasswordLabel.Location = new System.Drawing.Point(147, 130);
            this.EnterRegisterRewritePasswordLabel.Name = "EnterRegisterRewritePasswordLabel";
            this.EnterRegisterRewritePasswordLabel.Size = new System.Drawing.Size(100, 13);
            this.EnterRegisterRewritePasswordLabel.TabIndex = 12;
            this.EnterRegisterRewritePasswordLabel.Text = "Повторите пароль";
            this.EnterRegisterRewritePasswordLabel.Visible = false;
            // 
            // EnterRegisterLoginTimer
            // 
            this.EnterRegisterLoginTimer.Interval = 2000;
            this.EnterRegisterLoginTimer.Tick += new System.EventHandler(this.EnterRegisterLoginTimer_Tick);
            // 
            // EnterRegisterPasswordTimer
            // 
            this.EnterRegisterPasswordTimer.Interval = 2000;
            this.EnterRegisterPasswordTimer.Tick += new System.EventHandler(this.EnterRegisterPasswordTimer_Tick);
            // 
            // EnterRegisterRewritePasswordTimer
            // 
            this.EnterRegisterRewritePasswordTimer.Interval = 2000;
            this.EnterRegisterRewritePasswordTimer.Tick += new System.EventHandler(this.EnterRegisterRewritePasswordTimer_Tick);
            // 
            // EnterRegisterNameLabel
            // 
            this.EnterRegisterNameLabel.AutoSize = true;
            this.EnterRegisterNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.EnterRegisterNameLabel.ForeColor = System.Drawing.Color.Red;
            this.EnterRegisterNameLabel.Location = new System.Drawing.Point(147, 45);
            this.EnterRegisterNameLabel.Name = "EnterRegisterNameLabel";
            this.EnterRegisterNameLabel.Size = new System.Drawing.Size(84, 13);
            this.EnterRegisterNameLabel.TabIndex = 15;
            this.EnterRegisterNameLabel.Text = "Заполните имя";
            this.EnterRegisterNameLabel.Visible = false;
            // 
            // RegisterNameLabel
            // 
            this.RegisterNameLabel.AutoSize = true;
            this.RegisterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterNameLabel.Location = new System.Drawing.Point(6, 44);
            this.RegisterNameLabel.Name = "RegisterNameLabel";
            this.RegisterNameLabel.Size = new System.Drawing.Size(36, 16);
            this.RegisterNameLabel.TabIndex = 13;
            this.RegisterNameLabel.Text = "Имя:";
            // 
            // RegisterNameTextBox
            // 
            this.RegisterNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterNameTextBox.Location = new System.Drawing.Point(144, 41);
            this.RegisterNameTextBox.Name = "RegisterNameTextBox";
            this.RegisterNameTextBox.Size = new System.Drawing.Size(231, 22);
            this.RegisterNameTextBox.TabIndex = 14;
            // 
            // EnterRegisterLastNameLabel
            // 
            this.EnterRegisterLastNameLabel.AutoSize = true;
            this.EnterRegisterLastNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.EnterRegisterLastNameLabel.ForeColor = System.Drawing.Color.Red;
            this.EnterRegisterLastNameLabel.Location = new System.Drawing.Point(147, 73);
            this.EnterRegisterLastNameLabel.Name = "EnterRegisterLastNameLabel";
            this.EnterRegisterLastNameLabel.Size = new System.Drawing.Size(112, 13);
            this.EnterRegisterLastNameLabel.TabIndex = 18;
            this.EnterRegisterLastNameLabel.Text = "Заполните фамилию";
            this.EnterRegisterLastNameLabel.Visible = false;
            // 
            // RegisterLastNameLabel
            // 
            this.RegisterLastNameLabel.AutoSize = true;
            this.RegisterLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterLastNameLabel.Location = new System.Drawing.Point(5, 72);
            this.RegisterLastNameLabel.Name = "RegisterLastNameLabel";
            this.RegisterLastNameLabel.Size = new System.Drawing.Size(69, 16);
            this.RegisterLastNameLabel.TabIndex = 16;
            this.RegisterLastNameLabel.Text = "Фамилия:";
            // 
            // RegisterLastNameTextBox
            // 
            this.RegisterLastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterLastNameTextBox.Location = new System.Drawing.Point(144, 69);
            this.RegisterLastNameTextBox.Name = "RegisterLastNameTextBox";
            this.RegisterLastNameTextBox.Size = new System.Drawing.Size(231, 22);
            this.RegisterLastNameTextBox.TabIndex = 17;
            // 
            // EnterRegisterNameTimer
            // 
            this.EnterRegisterNameTimer.Interval = 2000;
            this.EnterRegisterNameTimer.Tick += new System.EventHandler(this.EnterRegisterNameTimer_Tick);
            // 
            // EnterRegisterLastNameTimer
            // 
            this.EnterRegisterLastNameTimer.Interval = 2000;
            this.EnterRegisterLastNameTimer.Tick += new System.EventHandler(this.EnterRegisterLastNameTimer_Tick);
            // 
            // BadPasswordsTimer
            // 
            this.BadPasswordsTimer.Interval = 2000;
            this.BadPasswordsTimer.Tick += new System.EventHandler(this.BadPasswordsTimer_Tick);
            // 
            // AuthorizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 568);
            this.Controls.Add(this.LoginGroupBox);
            this.Controls.Add(this.RegisterGroupBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthorizeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Авторизация";
            this.RegisterGroupBox.ResumeLayout(false);
            this.RegisterGroupBox.PerformLayout();
            this.LoginGroupBox.ResumeLayout(false);
            this.LoginGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox RegisterGroupBox;
        private System.Windows.Forms.CheckBox RegisterShowPasswordLabel;
        private System.Windows.Forms.Label RegisterLoginLabel;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox RegisterLoginTextBox;
        private System.Windows.Forms.LinkLabel AuthorizeLink;
        private System.Windows.Forms.Label RegisterPasswordLabel;
        private System.Windows.Forms.TextBox RegisterPasswordTextBox;
        private System.Windows.Forms.Label RegisterRewritePasswordLabel;
        private System.Windows.Forms.TextBox RegisterRewritePasswordTextBox;
        private System.Windows.Forms.GroupBox LoginGroupBox;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button AuthorizeButton;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.LinkLabel RegisterLink;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label EnterLoginLabel;
        private System.Windows.Forms.Label EnterPasswordLabel;
        private System.Windows.Forms.Timer EnterLoginTimer;
        private System.Windows.Forms.Timer EnterPasswordTimer;
        private System.Windows.Forms.Label EnterRegisterPasswordLabel;
        private System.Windows.Forms.Label EnterRegisterLoginLabel;
        private System.Windows.Forms.Label EnterRegisterRewritePasswordLabel;
        private System.Windows.Forms.Timer EnterRegisterLoginTimer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer EnterRegisterPasswordTimer;
        private System.Windows.Forms.Timer EnterRegisterRewritePasswordTimer;
        private System.Windows.Forms.Label EnterRegisterLastNameLabel;
        private System.Windows.Forms.Label RegisterLastNameLabel;
        private System.Windows.Forms.TextBox RegisterLastNameTextBox;
        private System.Windows.Forms.Label EnterRegisterNameLabel;
        private System.Windows.Forms.Label RegisterNameLabel;
        private System.Windows.Forms.TextBox RegisterNameTextBox;
        private System.Windows.Forms.Timer EnterRegisterNameTimer;
        private System.Windows.Forms.Timer EnterRegisterLastNameTimer;
        private System.Windows.Forms.Timer BadPasswordsTimer;
    }
}