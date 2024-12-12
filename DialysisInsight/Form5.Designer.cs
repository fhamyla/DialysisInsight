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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            minmax = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            gotodashboard = new PictureBox();
            next = new PictureBox();
            lbMonth = new Label();
            saturday = new Label();
            friday = new Label();
            thursday = new Label();
            wednesday = new Label();
            tuesday = new Label();
            monday = new Label();
            previous = new PictureBox();
            sunday = new Label();
            daycontainer = new FlowLayoutPanel();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gotodashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)next).BeginInit();
            ((System.ComponentModel.ISupportInitialize)previous).BeginInit();
            SuspendLayout();
            // 
            // minmax
            // 
            minmax.BackColor = Color.Transparent;
            minmax.BorderRadius = 10;
            minmax.CustomizableEdges = customizableEdges5;
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
            minmax.ShadowDecoration.CustomizableEdges = customizableEdges6;
            minmax.Size = new Size(15, 19);
            minmax.TabIndex = 3;
            minmax.Click += minmax_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(daycontainer);
            guna2Panel1.Controls.Add(gotodashboard);
            guna2Panel1.Controls.Add(next);
            guna2Panel1.Controls.Add(lbMonth);
            guna2Panel1.Controls.Add(saturday);
            guna2Panel1.Controls.Add(friday);
            guna2Panel1.Controls.Add(thursday);
            guna2Panel1.Controls.Add(wednesday);
            guna2Panel1.Controls.Add(tuesday);
            guna2Panel1.Controls.Add(monday);
            guna2Panel1.Controls.Add(previous);
            guna2Panel1.Controls.Add(sunday);
            guna2Panel1.CustomizableEdges = customizableEdges7;
            guna2Panel1.Location = new Point(-7, -7);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel1.Size = new Size(897, 725);
            guna2Panel1.TabIndex = 1;
            guna2Panel1.Paint += guna2Panel1_Paint;
            // 
            // gotodashboard
            // 
            gotodashboard.Image = (Image)resources.GetObject("gotodashboard.Image");
            gotodashboard.Location = new Point(801, 16);
            gotodashboard.Name = "gotodashboard";
            gotodashboard.Size = new Size(41, 41);
            gotodashboard.SizeMode = PictureBoxSizeMode.StretchImage;
            gotodashboard.TabIndex = 11;
            gotodashboard.TabStop = false;
            gotodashboard.Click += gotodashboard_Click;
            // 
            // next
            // 
            next.Image = (Image)resources.GetObject("next.Image");
            next.Location = new Point(310, 16);
            next.Name = "next";
            next.Size = new Size(41, 41);
            next.SizeMode = PictureBoxSizeMode.StretchImage;
            next.TabIndex = 10;
            next.TabStop = false;
            next.Click += next_Click;
            // 
            // lbMonth
            // 
            lbMonth.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMonth.Location = new Point(19, 16);
            lbMonth.Name = "lbMonth";
            lbMonth.Size = new Size(238, 26);
            lbMonth.TabIndex = 8;
            lbMonth.Text = "MONTH";
            lbMonth.Click += lbMonth_Click;
            // 
            // saturday
            // 
            saturday.AutoSize = true;
            saturday.Font = new Font("Poppins", 11.25F);
            saturday.Location = new Point(777, 65);
            saturday.Name = "saturday";
            saturday.Size = new Size(80, 26);
            saturday.TabIndex = 7;
            saturday.Text = "Saturday";
            saturday.Click += saturday_Click;
            // 
            // friday
            // 
            friday.AutoSize = true;
            friday.Font = new Font("Poppins", 11.25F);
            friday.Location = new Point(665, 65);
            friday.Name = "friday";
            friday.Size = new Size(58, 26);
            friday.TabIndex = 6;
            friday.Text = "Friday";
            friday.Click += friday_Click;
            // 
            // thursday
            // 
            thursday.AutoSize = true;
            thursday.Font = new Font("Poppins", 11.25F);
            thursday.Location = new Point(530, 65);
            thursday.Name = "thursday";
            thursday.Size = new Size(82, 26);
            thursday.TabIndex = 5;
            thursday.Text = "Thursday";
            thursday.Click += thursday_Click;
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
            wednesday.Click += wednesday_Click;
            // 
            // tuesday
            // 
            tuesday.AutoSize = true;
            tuesday.Font = new Font("Poppins", 11.25F);
            tuesday.Location = new Point(290, 65);
            tuesday.Name = "tuesday";
            tuesday.Size = new Size(75, 26);
            tuesday.TabIndex = 3;
            tuesday.Text = "Tuesday";
            tuesday.Click += tuesday_Click;
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
            monday.Click += monday_Click;
            // 
            // previous
            // 
            previous.Image = (Image)resources.GetObject("previous.Image");
            previous.Location = new Point(263, 16);
            previous.Name = "previous";
            previous.Size = new Size(41, 41);
            previous.SizeMode = PictureBoxSizeMode.StretchImage;
            previous.TabIndex = 9;
            previous.TabStop = false;
            previous.Click += previous_Click;
            // 
            // sunday
            // 
            sunday.AutoSize = true;
            sunday.Font = new Font("Poppins", 11.25F);
            sunday.ForeColor = Color.Maroon;
            sunday.Location = new Point(50, 65);
            sunday.Name = "sunday";
            sunday.Size = new Size(69, 26);
            sunday.TabIndex = 1;
            sunday.Text = "Sunday";
            sunday.Click += label1_Click;
            // 
            // daycontainer
            // 
            daycontainer.Location = new Point(19, 103);
            daycontainer.Name = "daycontainer";
            daycontainer.Size = new Size(867, 616);
            daycontainer.TabIndex = 12;
            // 
            // Calendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 715);
            ControlBox = false;
            Controls.Add(minmax);
            Controls.Add(guna2Panel1);
            Name = "Calendar";
            ShowIcon = false;
            ShowInTaskbar = false;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gotodashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)next).EndInit();
            ((System.ComponentModel.ISupportInitialize)previous).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button minmax;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label sunday;
        private Label saturday;
        private Label friday;
        private Label thursday;
        private Label wednesday;
        private Label tuesday;
        private Label monday;
        private Label lbMonth;
        private PictureBox next;
        private PictureBox previous;
        private PictureBox gotodashboard;
        private FlowLayoutPanel daycontainer;
    }
}