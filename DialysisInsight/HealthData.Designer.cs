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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            minmax = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
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
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Location = new Point(-6, -7);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(894, 567);
            guna2Panel1.TabIndex = 5;
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
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button minmax;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}