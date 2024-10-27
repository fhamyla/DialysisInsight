namespace DialysisInsight
{
    partial class Otp
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
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.BackgroundImage = Properties.Resources.otp;
            iconPictureBox1.BackgroundImageLayout = ImageLayout.None;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 129;
            iconPictureBox1.Location = new Point(128, 31);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(129, 132);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.Black;
            guna2HtmlLabel1.Location = new Point(89, 199);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(204, 27);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Please check your email";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel2.Location = new Point(134, 232);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(123, 22);
            guna2HtmlLabel2.TabIndex = 2;
            guna2HtmlLabel2.Text = "We've sent a code";
            // 
            // TextBox1
            // 
            TextBox1.BorderColor = Color.Black;
            TextBox1.BorderRadius = 5;
            TextBox1.CustomizableEdges = customizableEdges1;
            TextBox1.DefaultText = "";
            TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox1.Font = new Font("Segoe UI", 9F);
            TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox1.Location = new Point(12, 303);
            TextBox1.Name = "TextBox1";
            TextBox1.PasswordChar = '\0';
            TextBox1.PlaceholderText = "";
            TextBox1.SelectedText = "";
            TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            TextBox1.Size = new Size(75, 63);
            TextBox1.TabIndex = 3;
            // 
            // Otp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(362, 541);
            ControlBox = false;
            Controls.Add(TextBox1);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(iconPictureBox1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Otp";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox TextBox1;
    }
}