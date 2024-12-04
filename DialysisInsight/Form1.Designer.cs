namespace DialysisInsight
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            password = new Guna.UI2.WinForms.Guna2TextBox();
            email = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            showpassword = new Guna.UI2.WinForms.Guna2CheckBox();
            exit = new Guna.UI2.WinForms.Guna2ImageButton();
            createaccount = new FontAwesome.Sharp.IconButton();
            guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            login = new FontAwesome.Sharp.IconButton();
            forgotpassword = new LinkLabel();
            guna2CustomGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel4.Location = new Point(48, 206);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(62, 20);
            guna2HtmlLabel4.TabIndex = 6;
            guna2HtmlLabel4.Text = "Password";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel3.Location = new Point(48, 118);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(37, 20);
            guna2HtmlLabel3.TabIndex = 5;
            guna2HtmlLabel3.Text = "Email";
            // 
            // password
            // 
            password.BorderRadius = 15;
            password.CustomizableEdges = customizableEdges1;
            password.DefaultText = "";
            password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            password.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            password.Font = new Font("Segoe UI", 9F);
            password.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            password.Location = new Point(48, 232);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "Enter your password";
            password.SelectedText = "";
            password.ShadowDecoration.CustomizableEdges = customizableEdges2;
            password.Size = new Size(283, 36);
            password.TabIndex = 4;
            password.TextChanged += password_TextChanged;
            // 
            // email
            // 
            email.BorderRadius = 15;
            email.CustomizableEdges = customizableEdges3;
            email.DefaultText = "";
            email.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            email.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            email.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            email.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            email.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            email.Font = new Font("Segoe UI", 9F);
            email.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            email.Location = new Point(48, 144);
            email.Name = "email";
            email.PasswordChar = '\0';
            email.PlaceholderText = "Enter your email address";
            email.SelectedText = "";
            email.ShadowDecoration.CustomizableEdges = customizableEdges4;
            email.Size = new Size(283, 36);
            email.TabIndex = 3;
            email.TextChanged += email_TextChanged;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Bell MT", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.Location = new Point(48, 48);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(159, 42);
            guna2HtmlLabel2.TabIndex = 2;
            guna2HtmlLabel2.Text = "Welcome!";
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.BorderColor = Color.Transparent;
            guna2CustomGradientPanel1.Controls.Add(showpassword);
            guna2CustomGradientPanel1.Controls.Add(exit);
            guna2CustomGradientPanel1.Controls.Add(createaccount);
            guna2CustomGradientPanel1.Controls.Add(guna2HtmlLabel5);
            guna2CustomGradientPanel1.Controls.Add(guna2HtmlLabel1);
            guna2CustomGradientPanel1.Controls.Add(login);
            guna2CustomGradientPanel1.Controls.Add(forgotpassword);
            guna2CustomGradientPanel1.Controls.Add(password);
            guna2CustomGradientPanel1.Controls.Add(guna2HtmlLabel2);
            guna2CustomGradientPanel1.Controls.Add(guna2HtmlLabel4);
            guna2CustomGradientPanel1.Controls.Add(guna2HtmlLabel3);
            guna2CustomGradientPanel1.Controls.Add(email);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges6;
            guna2CustomGradientPanel1.Location = new Point(-7, -6);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges7;
            guna2CustomGradientPanel1.Size = new Size(378, 557);
            guna2CustomGradientPanel1.TabIndex = 7;
            // 
            // showpassword
            // 
            showpassword.AutoSize = true;
            showpassword.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            showpassword.CheckedState.BorderRadius = 0;
            showpassword.CheckedState.BorderThickness = 0;
            showpassword.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            showpassword.Location = new Point(48, 274);
            showpassword.Name = "showpassword";
            showpassword.Size = new Size(108, 19);
            showpassword.TabIndex = 13;
            showpassword.Text = "Show Password";
            showpassword.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            showpassword.UncheckedState.BorderRadius = 0;
            showpassword.UncheckedState.BorderThickness = 0;
            showpassword.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            showpassword.CheckedChanged += showpassword_CheckedChanged;
            // 
            // exit
            // 
            exit.BackgroundImageLayout = ImageLayout.None;
            exit.CheckedState.ImageSize = new Size(64, 64);
            exit.ImageOffset = new Point(0, 0);
            exit.ImageRotate = 0F;
            exit.ImageSize = new Size(30, 30);
            exit.Location = new Point(19, 3);
            exit.Name = "exit";
            exit.PressedState.ImageSize = new Size(64, 64);
            exit.ShadowDecoration.CustomizableEdges = customizableEdges5;
            exit.Size = new Size(40, 34);
            exit.TabIndex = 12;
            exit.Click += exit_Click;
            // 
            // createaccount
            // 
            createaccount.BackColor = Color.White;
            createaccount.FlatStyle = FlatStyle.Flat;
            createaccount.ForeColor = Color.Black;
            createaccount.IconChar = FontAwesome.Sharp.IconChar.None;
            createaccount.IconColor = Color.White;
            createaccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            createaccount.Location = new Point(48, 477);
            createaccount.Name = "createaccount";
            createaccount.Size = new Size(283, 45);
            createaccount.TabIndex = 11;
            createaccount.Text = "Create account";
            createaccount.UseVisualStyleBackColor = false;
            createaccount.Click += createaccount_Click;
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel5.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel5.Location = new Point(119, 446);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(129, 16);
            guna2HtmlLabel5.TabIndex = 10;
            guna2HtmlLabel5.Text = "Don't have an account?";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.Gray;
            guna2HtmlLabel1.Location = new Point(179, 386);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(14, 16);
            guna2HtmlLabel1.TabIndex = 9;
            guna2HtmlLabel1.Text = "or";
            // 
            // login
            // 
            login.BackColor = Color.Black;
            login.FlatStyle = FlatStyle.Flat;
            login.ForeColor = Color.White;
            login.IconChar = FontAwesome.Sharp.IconChar.None;
            login.IconColor = Color.Black;
            login.IconFont = FontAwesome.Sharp.IconFont.Auto;
            login.Location = new Point(48, 335);
            login.Name = "login";
            login.Size = new Size(283, 45);
            login.TabIndex = 8;
            login.Text = "Login";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // forgotpassword
            // 
            forgotpassword.AutoSize = true;
            forgotpassword.LinkColor = Color.Black;
            forgotpassword.Location = new Point(204, 296);
            forgotpassword.Name = "forgotpassword";
            forgotpassword.Size = new Size(127, 15);
            forgotpassword.TabIndex = 7;
            forgotpassword.TabStop = true;
            forgotpassword.Text = "Forgot your password?";
            forgotpassword.LinkClicked += forgotpassword_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(368, 541);
            ControlBox = false;
            Controls.Add(guna2CustomGradientPanel1);
            Name = "Form1";
            ShowIcon = false;
            ShowInTaskbar = false;
            Load += Form1_Load;
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox password;
        private Guna.UI2.WinForms.Guna2TextBox email;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private LinkLabel forgotpassword;
        private FontAwesome.Sharp.IconButton login;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private FontAwesome.Sharp.IconButton createaccount;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ImageButton exit;
        private Guna.UI2.WinForms.Guna2CheckBox showpassword;
    }
}
