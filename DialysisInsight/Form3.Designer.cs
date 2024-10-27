namespace DialysisInsight
{
    partial class CreateAccount
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            showpassword = new Guna.UI2.WinForms.Guna2CheckBox();
            exit = new Guna.UI2.WinForms.Guna2ImageButton();
            guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            password = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            email = new Guna.UI2.WinForms.Guna2TextBox();
            confirmpassword = new Guna.UI2.WinForms.Guna2TextBox();
            confirm = new Guna.UI2.WinForms.Guna2HtmlLabel();
            login = new FontAwesome.Sharp.IconButton();
            create = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // showpassword
            // 
            showpassword.AutoSize = true;
            showpassword.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            showpassword.CheckedState.BorderRadius = 0;
            showpassword.CheckedState.BorderThickness = 0;
            showpassword.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            showpassword.Location = new Point(55, 330);
            showpassword.Name = "showpassword";
            showpassword.Size = new Size(108, 19);
            showpassword.TabIndex = 24;
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
            exit.HoverState.ImageSize = new Size(64, 64);
            exit.Image = Properties.Resources.cross;
            exit.ImageOffset = new Point(0, 0);
            exit.ImageRotate = 0F;
            exit.ImageSize = new Size(30, 30);
            exit.Location = new Point(26, 11);
            exit.Name = "exit";
            exit.PressedState.ImageSize = new Size(64, 64);
            exit.ShadowDecoration.CustomizableEdges = customizableEdges1;
            exit.Size = new Size(40, 34);
            exit.TabIndex = 23;
            exit.Click += exit_Click;
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel5.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel5.Location = new Point(126, 454);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(141, 16);
            guna2HtmlLabel5.TabIndex = 21;
            guna2HtmlLabel5.Text = "Already have an account?";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.Gray;
            guna2HtmlLabel1.Location = new Point(186, 432);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(14, 16);
            guna2HtmlLabel1.TabIndex = 20;
            guna2HtmlLabel1.Text = "or";
            // 
            // password
            // 
            password.BorderRadius = 15;
            password.CustomizableEdges = customizableEdges2;
            password.DefaultText = "";
            password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            password.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            password.Font = new Font("Segoe UI", 9F);
            password.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            password.Location = new Point(55, 220);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "Enter your password";
            password.SelectedText = "";
            password.ShadowDecoration.CustomizableEdges = customizableEdges3;
            password.Size = new Size(278, 36);
            password.TabIndex = 16;
            password.TextChanged += password_TextChanged;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Bell MT", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.Location = new Point(55, 56);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(239, 42);
            guna2HtmlLabel2.TabIndex = 14;
            guna2HtmlLabel2.Text = "Create Account";
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel4.Location = new Point(55, 194);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(62, 20);
            guna2HtmlLabel4.TabIndex = 18;
            guna2HtmlLabel4.Text = "Password";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel3.Location = new Point(55, 126);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(37, 20);
            guna2HtmlLabel3.TabIndex = 17;
            guna2HtmlLabel3.Text = "Email";
            // 
            // email
            // 
            email.BorderRadius = 15;
            email.CustomizableEdges = customizableEdges4;
            email.DefaultText = "";
            email.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            email.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            email.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            email.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            email.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            email.Font = new Font("Segoe UI", 9F);
            email.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            email.Location = new Point(55, 152);
            email.Name = "email";
            email.PasswordChar = '\0';
            email.PlaceholderText = "Enter your email address";
            email.SelectedText = "";
            email.ShadowDecoration.CustomizableEdges = customizableEdges5;
            email.Size = new Size(278, 36);
            email.TabIndex = 15;
            email.TextChanged += email_TextChanged;
            // 
            // confirmpassword
            // 
            confirmpassword.BorderRadius = 15;
            confirmpassword.CustomizableEdges = customizableEdges6;
            confirmpassword.DefaultText = "";
            confirmpassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            confirmpassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            confirmpassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            confirmpassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            confirmpassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            confirmpassword.Font = new Font("Segoe UI", 9F);
            confirmpassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            confirmpassword.Location = new Point(55, 288);
            confirmpassword.Name = "confirmpassword";
            confirmpassword.PasswordChar = '*';
            confirmpassword.PlaceholderText = "Enter your password";
            confirmpassword.SelectedText = "";
            confirmpassword.ShadowDecoration.CustomizableEdges = customizableEdges7;
            confirmpassword.Size = new Size(278, 36);
            confirmpassword.TabIndex = 25;
            confirmpassword.TextChanged += confirmpassword_TextChanged;
            // 
            // confirm
            // 
            confirm.BackColor = Color.Transparent;
            confirm.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirm.Location = new Point(55, 262);
            confirm.Name = "confirm";
            confirm.Size = new Size(115, 20);
            confirm.TabIndex = 26;
            confirm.Text = "Confirm Password";
            // 
            // login
            // 
            login.BackColor = Color.White;
            login.FlatStyle = FlatStyle.Flat;
            login.ForeColor = Color.Black;
            login.IconChar = FontAwesome.Sharp.IconChar.None;
            login.IconColor = Color.White;
            login.IconFont = FontAwesome.Sharp.IconFont.Auto;
            login.Location = new Point(50, 476);
            login.Name = "login";
            login.Size = new Size(283, 45);
            login.TabIndex = 28;
            login.Text = "Login";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // create
            // 
            create.BackColor = Color.Black;
            create.FlatStyle = FlatStyle.Flat;
            create.ForeColor = Color.White;
            create.IconChar = FontAwesome.Sharp.IconChar.None;
            create.IconColor = Color.Black;
            create.IconFont = FontAwesome.Sharp.IconFont.Auto;
            create.Location = new Point(50, 381);
            create.Name = "create";
            create.Size = new Size(283, 45);
            create.TabIndex = 27;
            create.Text = "Create account";
            create.UseVisualStyleBackColor = false;
            create.Click += create_Click;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(383, 541);
            ControlBox = false;
            Controls.Add(login);
            Controls.Add(create);
            Controls.Add(confirmpassword);
            Controls.Add(confirm);
            Controls.Add(showpassword);
            Controls.Add(exit);
            Controls.Add(guna2HtmlLabel5);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(password);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel4);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(email);
            Name = "CreateAccount";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CheckBox showpassword;
        private Guna.UI2.WinForms.Guna2ImageButton exit;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox password;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox email;
        private Guna.UI2.WinForms.Guna2TextBox confirmpassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel confirm;
        private FontAwesome.Sharp.IconButton login;
        private FontAwesome.Sharp.IconButton create;
    }
}