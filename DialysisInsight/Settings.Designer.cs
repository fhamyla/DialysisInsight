namespace DialysisInsight
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            minmax = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ProfileManagement = new Label();
            manage = new Label();
            NotificationPreferences = new Label();
            notifcontrol = new Label();
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
            guna2Panel1.Controls.Add(notifcontrol);
            guna2Panel1.Controls.Add(NotificationPreferences);
            guna2Panel1.Controls.Add(manage);
            guna2Panel1.Controls.Add(ProfileManagement);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Location = new Point(-5, -7);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(892, 564);
            guna2Panel1.TabIndex = 5;
            // 
            // ProfileManagement
            // 
            ProfileManagement.AutoSize = true;
            ProfileManagement.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProfileManagement.Location = new Point(17, 16);
            ProfileManagement.Name = "ProfileManagement";
            ProfileManagement.Size = new Size(208, 34);
            ProfileManagement.TabIndex = 0;
            ProfileManagement.Text = "Profile Management";
            // 
            // manage
            // 
            manage.AutoSize = true;
            manage.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manage.ForeColor = Color.FromArgb(64, 64, 64);
            manage.Location = new Point(17, 50);
            manage.Name = "manage";
            manage.Size = new Size(345, 23);
            manage.TabIndex = 1;
            manage.Text = "Manage your personal information and preferences.";
            // 
            // NotificationPreferences
            // 
            NotificationPreferences.AutoSize = true;
            NotificationPreferences.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NotificationPreferences.Location = new Point(17, 274);
            NotificationPreferences.Name = "NotificationPreferences";
            NotificationPreferences.Size = new Size(242, 34);
            NotificationPreferences.TabIndex = 2;
            NotificationPreferences.Text = "Notification Preferences";
            // 
            // notifcontrol
            // 
            notifcontrol.AutoSize = true;
            notifcontrol.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            notifcontrol.ForeColor = Color.FromArgb(64, 64, 64);
            notifcontrol.Location = new Point(17, 308);
            notifcontrol.Name = "notifcontrol";
            notifcontrol.Size = new Size(293, 23);
            notifcontrol.TabIndex = 3;
            notifcontrol.Text = "Control how you receive updates and alerts.";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 553);
            ControlBox = false;
            Controls.Add(minmax);
            Controls.Add(guna2Panel1);
            Name = "Settings";
            ShowIcon = false;
            ShowInTaskbar = false;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button minmax;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label ProfileManagement;
        private Label notifcontrol;
        private Label NotificationPreferences;
        private Label manage;
    }
}