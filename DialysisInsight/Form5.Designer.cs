namespace DialysisInsight
{
    partial class Calendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            minmax = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            pictureBox2 = new PictureBox();
            month = new Label();
            saturday = new Label();
            friday = new Label();
            thursday = new Label();
            wednesday = new Label();
            tuesday = new Label();
            monday = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            minmax.TabIndex = 3;
            minmax.Click += minmax_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(pictureBox2);
            guna2Panel1.Controls.Add(month);
            guna2Panel1.Controls.Add(saturday);
            guna2Panel1.Controls.Add(friday);
            guna2Panel1.Controls.Add(thursday);
            guna2Panel1.Controls.Add(wednesday);
            guna2Panel1.Controls.Add(tuesday);
            guna2Panel1.Controls.Add(monday);
            guna2Panel1.Controls.Add(pictureBox1);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(flowLayoutPanel1);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Location = new Point(-7, -7);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(897, 566);
            guna2Panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(223, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // month
            // 
            month.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            month.Location = new Point(19, 16);
            month.Name = "month";
            month.Size = new Size(151, 26);
            month.TabIndex = 8;
            month.Text = "MONTH";
            // 
            // saturday
            // 
            saturday.AutoSize = true;
            saturday.Font = new Font("Poppins", 11.25F);
            saturday.Location = new Point(781, 65);
            saturday.Name = "saturday";
            saturday.Size = new Size(80, 26);
            saturday.TabIndex = 7;
            saturday.Text = "Saturday";
            // 
            // friday
            // 
            friday.AutoSize = true;
            friday.Font = new Font("Poppins", 11.25F);
            friday.Location = new Point(672, 65);
            friday.Name = "friday";
            friday.Size = new Size(58, 26);
            friday.TabIndex = 6;
            friday.Text = "Friday";
            // 
            // thursday
            // 
            thursday.AutoSize = true;
            thursday.Font = new Font("Poppins", 11.25F);
            thursday.Location = new Point(534, 65);
            thursday.Name = "thursday";
            thursday.Size = new Size(82, 26);
            thursday.TabIndex = 5;
            thursday.Text = "Thursday";
            // 
            // wednesday
            // 
            wednesday.AutoSize = true;
            wednesday.Font = new Font("Poppins", 11.25F);
            wednesday.Location = new Point(398, 65);
            wednesday.Name = "wednesday";
            wednesday.Size = new Size(101, 26);
            wednesday.TabIndex = 4;
            wednesday.Text = "Wednesday";
            // 
            // tuesday
            // 
            tuesday.AutoSize = true;
            tuesday.Font = new Font("Poppins", 11.25F);
            tuesday.Location = new Point(293, 65);
            tuesday.Name = "tuesday";
            tuesday.Size = new Size(75, 26);
            tuesday.TabIndex = 3;
            tuesday.Text = "Tuesday";
            // 
            // monday
            // 
            monday.AutoSize = true;
            monday.Font = new Font("Poppins", 11.25F);
            monday.Location = new Point(170, 65);
            monday.Name = "monday";
            monday.Size = new Size(73, 26);
            monday.TabIndex = 2;
            monday.Text = "Monday";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(176, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 11.25F);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(50, 65);
            label1.Name = "label1";
            label1.Size = new Size(69, 26);
            label1.TabIndex = 1;
            label1.Text = "Sunday";
            label1.Click += label1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(19, 103);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(867, 445);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // Calendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 553);
            ControlBox = false;
            Controls.Add(minmax);
            Controls.Add(guna2Panel1);
            Name = "Calendar";
            ShowIcon = false;
            ShowInTaskbar = false;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button minmax;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label saturday;
        private Label friday;
        private Label thursday;
        private Label wednesday;
        private Label tuesday;
        private Label monday;
        private Label month;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}