namespace DialysisInsight
{
    partial class HealthData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HealthData));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            minmax = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            DialysisSessionsCompleted = new Guna.UI2.WinForms.Guna2TextBox();
            BloodPressure = new Guna.UI2.WinForms.Guna2TextBox();
            BloodSugarLevel = new Guna.UI2.WinForms.Guna2TextBox();
            HeartRate = new Guna.UI2.WinForms.Guna2TextBox();
            Weight = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // minmax
            // 
            minmax.BackColor = Color.Transparent;
            minmax.BorderRadius = 10;
            minmax.CustomizableEdges = customizableEdges1;
            minmax.DisabledState.BorderColor = Color.DarkGray;
            minmax.DisabledState.CustomBorderColor = Color.DarkGray;
            minmax.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            minmax.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            minmax.FillColor = Color.Transparent;
            minmax.Font = new Font("Segoe UI", 9F);
            minmax.ForeColor = Color.White;
            minmax.Image = (Image)resources.GetObject("minmax.Image");
            minmax.ImageSize = new Size(15, 15);
            minmax.Location = new Point(864, 3);
            minmax.Name = "minmax";
            minmax.PressedColor = Color.Transparent;
            minmax.ShadowDecoration.CustomizableEdges = customizableEdges2;
            minmax.Size = new Size(15, 19);
            minmax.TabIndex = 4;
            minmax.Click += minmax_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(DialysisSessionsCompleted);
            guna2Panel1.Controls.Add(BloodPressure);
            guna2Panel1.Controls.Add(BloodSugarLevel);
            guna2Panel1.Controls.Add(HeartRate);
            guna2Panel1.Controls.Add(Weight);
            guna2Panel1.CustomizableEdges = customizableEdges13;
            guna2Panel1.Location = new Point(-6, -7);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2Panel1.Size = new Size(894, 567);
            guna2Panel1.TabIndex = 5;
            // 
            // DialysisSessionsCompleted
            // 
            DialysisSessionsCompleted.CustomizableEdges = customizableEdges3;
            DialysisSessionsCompleted.DefaultText = "";
            DialysisSessionsCompleted.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            DialysisSessionsCompleted.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            DialysisSessionsCompleted.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            DialysisSessionsCompleted.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            DialysisSessionsCompleted.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            DialysisSessionsCompleted.Font = new Font("Segoe UI", 9F);
            DialysisSessionsCompleted.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            DialysisSessionsCompleted.Location = new Point(626, 452);
            DialysisSessionsCompleted.Name = "DialysisSessionsCompleted";
            DialysisSessionsCompleted.PasswordChar = '\0';
            DialysisSessionsCompleted.PlaceholderText = "";
            DialysisSessionsCompleted.SelectedText = "";
            DialysisSessionsCompleted.ShadowDecoration.CustomizableEdges = customizableEdges4;
            DialysisSessionsCompleted.Size = new Size(200, 36);
            DialysisSessionsCompleted.TabIndex = 4;
            // 
            // BloodPressure
            // 
            BloodPressure.CustomizableEdges = customizableEdges5;
            BloodPressure.DefaultText = "";
            BloodPressure.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            BloodPressure.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            BloodPressure.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            BloodPressure.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            BloodPressure.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            BloodPressure.Font = new Font("Segoe UI", 9F);
            BloodPressure.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            BloodPressure.Location = new Point(494, 339);
            BloodPressure.Name = "BloodPressure";
            BloodPressure.PasswordChar = '\0';
            BloodPressure.PlaceholderText = "";
            BloodPressure.SelectedText = "";
            BloodPressure.ShadowDecoration.CustomizableEdges = customizableEdges6;
            BloodPressure.Size = new Size(200, 36);
            BloodPressure.TabIndex = 3;
            // 
            // BloodSugarLevel
            // 
            BloodSugarLevel.CustomizableEdges = customizableEdges7;
            BloodSugarLevel.DefaultText = "";
            BloodSugarLevel.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            BloodSugarLevel.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            BloodSugarLevel.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            BloodSugarLevel.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            BloodSugarLevel.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            BloodSugarLevel.Font = new Font("Segoe UI", 9F);
            BloodSugarLevel.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            BloodSugarLevel.Location = new Point(513, 203);
            BloodSugarLevel.Name = "BloodSugarLevel";
            BloodSugarLevel.PasswordChar = '\0';
            BloodSugarLevel.PlaceholderText = "";
            BloodSugarLevel.SelectedText = "";
            BloodSugarLevel.ShadowDecoration.CustomizableEdges = customizableEdges8;
            BloodSugarLevel.Size = new Size(200, 36);
            BloodSugarLevel.TabIndex = 2;
            // 
            // HeartRate
            // 
            HeartRate.CustomizableEdges = customizableEdges9;
            HeartRate.DefaultText = "";
            HeartRate.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            HeartRate.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            HeartRate.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            HeartRate.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            HeartRate.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            HeartRate.Font = new Font("Segoe UI", 9F);
            HeartRate.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            HeartRate.Location = new Point(332, 108);
            HeartRate.Name = "HeartRate";
            HeartRate.PasswordChar = '\0';
            HeartRate.PlaceholderText = "";
            HeartRate.SelectedText = "";
            HeartRate.ShadowDecoration.CustomizableEdges = customizableEdges10;
            HeartRate.Size = new Size(200, 36);
            HeartRate.TabIndex = 1;
            // 
            // Weight
            // 
            Weight.BorderColor = Color.FromArgb(64, 64, 64);
            Weight.CustomizableEdges = customizableEdges11;
            Weight.DefaultText = "";
            Weight.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Weight.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Weight.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Weight.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Weight.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Weight.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Weight.ForeColor = Color.FromArgb(64, 64, 64);
            Weight.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Weight.Location = new Point(54, 152);
            Weight.Margin = new Padding(4, 5, 4, 5);
            Weight.Name = "Weight";
            Weight.PasswordChar = '\0';
            Weight.PlaceholderText = "Enter Weight in Kg";
            Weight.SelectedText = "";
            Weight.ShadowDecoration.CustomizableEdges = customizableEdges12;
            Weight.Size = new Size(229, 72);
            Weight.TabIndex = 0;
            // 
            // HealthData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 553);
            ControlBox = false;
            Controls.Add(minmax);
            Controls.Add(guna2Panel1);
            Name = "HealthData";
            ShowIcon = false;
            ShowInTaskbar = false;
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button minmax;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox DialysisSessionsCompleted;
        private Guna.UI2.WinForms.Guna2TextBox BloodPressure;
        private Guna.UI2.WinForms.Guna2TextBox BloodSugarLevel;
        private Guna.UI2.WinForms.Guna2TextBox HeartRate;
        private Guna.UI2.WinForms.Guna2TextBox Weight;
    }
}