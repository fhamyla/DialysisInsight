namespace DialysisInsight
{
    partial class Sched
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            Body = new Guna.UI2.WinForms.Guna2TextBox();
            Title = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(guna2Button1);
            guna2Panel1.Controls.Add(Body);
            guna2Panel1.Controls.Add(Title);
            guna2Panel1.CustomizableEdges = customizableEdges7;
            guna2Panel1.Location = new Point(-9, -9);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel1.Size = new Size(379, 316);
            guna2Panel1.TabIndex = 0;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderColor = Color.Transparent;
            guna2Button1.BorderRadius = 5;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.FromArgb(64, 64, 64);
            guna2Button1.HoverState.FillColor = Color.FromArgb(64, 64, 64);
            guna2Button1.HoverState.ForeColor = Color.White;
            guna2Button1.Location = new Point(112, 251);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = Color.FromArgb(64, 0, 0);
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(180, 47);
            guna2Button1.TabIndex = 2;
            guna2Button1.Text = "Save";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // Body
            // 
            Body.BorderColor = Color.FromArgb(64, 64, 64);
            Body.BorderRadius = 5;
            Body.CustomizableEdges = customizableEdges3;
            Body.DefaultText = "";
            Body.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Body.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Body.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Body.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Body.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Body.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Body.ForeColor = Color.Gray;
            Body.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Body.Location = new Point(30, 86);
            Body.Margin = new Padding(5, 9, 5, 9);
            Body.Name = "Body";
            Body.PasswordChar = '\0';
            Body.PlaceholderForeColor = Color.Gray;
            Body.PlaceholderText = "Body";
            Body.SelectedText = "";
            Body.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Body.Size = new Size(331, 153);
            Body.TabIndex = 1;
            Body.TextAlign = HorizontalAlignment.Center;
            Body.TextChanged += Body_TextChanged;
            // 
            // Title
            // 
            Title.BorderColor = Color.FromArgb(64, 64, 64);
            Title.BorderRadius = 5;
            Title.CustomizableEdges = customizableEdges5;
            Title.DefaultText = "";
            Title.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Title.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Title.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Title.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Title.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Title.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.Gray;
            Title.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Title.Location = new Point(30, 16);
            Title.Margin = new Padding(4, 6, 4, 6);
            Title.Name = "Title";
            Title.PasswordChar = '\0';
            Title.PlaceholderForeColor = Color.Gray;
            Title.PlaceholderText = "Title";
            Title.SelectedText = "";
            Title.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Title.Size = new Size(331, 55);
            Title.TabIndex = 0;
            Title.TextAlign = HorizontalAlignment.Center;
            Title.TextChanged += Title_TextChanged;
            // 
            // Sched
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(365, 301);
            ControlBox = false;
            Controls.Add(guna2Panel1);
            Name = "Sched";
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox Title;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox Body;
    }
}