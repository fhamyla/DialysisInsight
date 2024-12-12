namespace DialysisInsight
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbdays = new Label();
            red = new Panel();
            orange = new Panel();
            green = new Panel();
            red.SuspendLayout();
            orange.SuspendLayout();
            SuspendLayout();
            // 
            // lbdays
            // 
            lbdays.AutoSize = true;
            lbdays.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbdays.Location = new Point(12, 11);
            lbdays.Name = "lbdays";
            lbdays.Size = new Size(54, 26);
            lbdays.TabIndex = 0;
            lbdays.Text = "label1";
            // 
            // red
            // 
            red.Controls.Add(orange);
            red.Location = new Point(0, 51);
            red.Name = "red";
            red.Size = new Size(121, 49);
            red.TabIndex = 1;
            // 
            // orange
            // 
            orange.Controls.Add(green);
            orange.Location = new Point(0, 18);
            orange.Name = "orange";
            orange.Size = new Size(121, 28);
            orange.TabIndex = 2;
            // 
            // green
            // 
            green.Location = new Point(0, 16);
            green.Name = "green";
            green.Size = new Size(121, 15);
            green.TabIndex = 3;
            // 
            // UserControlDays
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(red);
            Controls.Add(lbdays);
            Name = "UserControlDays";
            Size = new Size(121, 100);
            red.ResumeLayout(false);
            orange.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbdays;
        private Panel red;
        private Panel orange;
        private Panel green;
    }
}
