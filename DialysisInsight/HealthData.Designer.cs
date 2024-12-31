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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            minmax = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            Weight = new Guna.UI2.WinForms.Guna2TextBox();
            HeartRate = new Guna.UI2.WinForms.Guna2TextBox();
            BloodSugarLevel = new Guna.UI2.WinForms.Guna2TextBox();
            BloodPressure = new Guna.UI2.WinForms.Guna2TextBox();
            SessionComplete = new Guna.UI2.WinForms.Guna2TextBox();
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
            guna2Panel1.Controls.Add(SessionComplete);
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
            // Weight
            // 
            Weight.BorderColor = Color.FromArgb(64, 64, 64);
            Weight.BorderRadius = 10;
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
            Weight.Location = new Point(34, 72);
            Weight.Margin = new Padding(4, 5, 4, 5);
            Weight.Name = "Weight";
            Weight.PasswordChar = '\0';
            Weight.PlaceholderText = "Enter Weight in Kg";
            Weight.SelectedText = "";
            Weight.ShadowDecoration.CustomizableEdges = customizableEdges12;
            Weight.Size = new Size(229, 72);
            Weight.TabIndex = 0;
            // 
            // HeartRate
            // 
            HeartRate.BorderColor = Color.FromArgb(64, 64, 64);
            HeartRate.BorderRadius = 10;
            HeartRate.CustomizableEdges = customizableEdges9;
            HeartRate.DefaultText = "";
            HeartRate.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            HeartRate.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            HeartRate.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            HeartRate.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            HeartRate.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            HeartRate.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HeartRate.ForeColor = Color.FromArgb(64, 64, 64);
            HeartRate.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            HeartRate.Location = new Point(330, 72);
            HeartRate.Margin = new Padding(4, 5, 4, 5);
            HeartRate.Name = "HeartRate";
            HeartRate.PasswordChar = '\0';
            HeartRate.PlaceholderText = "Enter Heart Rate";
            HeartRate.SelectedText = "";
            HeartRate.ShadowDecoration.CustomizableEdges = customizableEdges10;
            HeartRate.Size = new Size(229, 72);
            HeartRate.TabIndex = 1;
            // 
            // BloodSugarLevel
            // 
            BloodSugarLevel.BorderColor = Color.FromArgb(64, 64, 64);
            BloodSugarLevel.BorderRadius = 10;
            BloodSugarLevel.CustomizableEdges = customizableEdges7;
            BloodSugarLevel.DefaultText = "";
            BloodSugarLevel.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            BloodSugarLevel.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            BloodSugarLevel.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            BloodSugarLevel.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            BloodSugarLevel.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            BloodSugarLevel.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BloodSugarLevel.ForeColor = Color.FromArgb(64, 64, 64);
            BloodSugarLevel.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            BloodSugarLevel.Location = new Point(625, 72);
            BloodSugarLevel.Margin = new Padding(4, 5, 4, 5);
            BloodSugarLevel.Name = "BloodSugarLevel";
            BloodSugarLevel.PasswordChar = '\0';
            BloodSugarLevel.PlaceholderText = "Enter Sugar Level";
            BloodSugarLevel.SelectedText = "";
            BloodSugarLevel.ShadowDecoration.CustomizableEdges = customizableEdges8;
            BloodSugarLevel.Size = new Size(229, 72);
            BloodSugarLevel.TabIndex = 2;
            // 
            // BloodPressure
            // 
            BloodPressure.BorderColor = Color.FromArgb(64, 64, 64);
            BloodPressure.BorderRadius = 10;
            BloodPressure.CustomizableEdges = customizableEdges5;
            BloodPressure.DefaultText = "";
            BloodPressure.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            BloodPressure.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            BloodPressure.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            BloodPressure.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            BloodPressure.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            BloodPressure.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BloodPressure.ForeColor = Color.FromArgb(64, 64, 64);
            BloodPressure.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            BloodPressure.Location = new Point(163, 251);
            BloodPressure.Margin = new Padding(4, 5, 4, 5);
            BloodPressure.Name = "BloodPressure";
            BloodPressure.PasswordChar = '\0';
            BloodPressure.PlaceholderText = "Enter Blood Pressure";
            BloodPressure.SelectedText = "";
            BloodPressure.ShadowDecoration.CustomizableEdges = customizableEdges6;
            BloodPressure.Size = new Size(229, 72);
            BloodPressure.TabIndex = 3;
            // 
            // SessionComplete
            // 
            SessionComplete.BorderColor = Color.FromArgb(64, 64, 64);
            SessionComplete.BorderRadius = 10;
            SessionComplete.CustomizableEdges = customizableEdges3;
            SessionComplete.DefaultText = "";
            SessionComplete.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            SessionComplete.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            SessionComplete.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            SessionComplete.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            SessionComplete.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            SessionComplete.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SessionComplete.ForeColor = Color.FromArgb(64, 64, 64);
            SessionComplete.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            SessionComplete.Location = new Point(485, 251);
            SessionComplete.Margin = new Padding(4, 5, 4, 5);
            SessionComplete.Name = "SessionComplete";
            SessionComplete.PasswordChar = '\0';
            SessionComplete.PlaceholderText = "Enter Session Complete";
            SessionComplete.SelectedText = "";
            SessionComplete.ShadowDecoration.CustomizableEdges = customizableEdges4;
            SessionComplete.Size = new Size(229, 72);
            SessionComplete.TabIndex = 4;
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
        private Guna.UI2.WinForms.Guna2TextBox Weight;
        private Guna.UI2.WinForms.Guna2TextBox SessionComplete;
        private Guna.UI2.WinForms.Guna2TextBox BloodPressure;
        private Guna.UI2.WinForms.Guna2TextBox BloodSugarLevel;
        private Guna.UI2.WinForms.Guna2TextBox HeartRate;
    }
}