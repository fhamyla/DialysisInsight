using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using System.Xml.Linq;

namespace DialysisInsight
{
    public partial class Calendar : Form
    {
        private Size formOriginalSize;
        private Rectangle recminmax;
        private Rectangle recpanel1;
        private Rectangle reclabel1;
        private Rectangle reccontainer;
        private Rectangle recprevious;
        private Rectangle recnext;
        private Rectangle reclbMonth;
        private Rectangle recmonday;
        private Rectangle rectuesday;
        private Rectangle recwednesday;
        private Rectangle recthursday;
        private Rectangle recfriday;
        private Rectangle recsaturday;
        private Rectangle recdashboard;
        private DateTime currentMonth;
        public Calendar()
        {
            InitializeComponent();
            this.Load += Calendar_Load;
            previous.Click += previous_Click;
            next.Click += next_Click;
            this.Resize += Dashboard_Resiz;
            formOriginalSize = this.Size;
            recminmax = new Rectangle(minmax.Location, minmax.Size);
            recpanel1 = new Rectangle(guna2Panel1.Location, guna2Panel1.Size);
            reclabel1 = new Rectangle(sunday.Location, sunday.Size);
            reccontainer = new Rectangle(daycontainer.Location, daycontainer.Size);
            recprevious = new Rectangle(previous.Location, previous.Size);
            recnext = new Rectangle(next.Location, next.Size);
            reclbMonth = new Rectangle(lbMonth.Location, lbMonth.Size);
            recmonday = new Rectangle(monday.Location, monday.Size);
            rectuesday = new Rectangle(tuesday.Location, tuesday.Size);
            recwednesday = new Rectangle(wednesday.Location, wednesday.Size);
            recthursday = new Rectangle(thursday.Location, thursday.Size);
            recfriday = new Rectangle(friday.Location, friday.Size);
            recsaturday = new Rectangle(saturday.Location, saturday.Size);
            recdashboard = new Rectangle(gotodashboard.Location, gotodashboard.Size);
            reccontainer = new Rectangle(daycontainer.Location, daycontainer.Size);

            currentMonth = DateTime.Now;
        }

        private void Dashboard_Resiz(object? sender, EventArgs e)
        {
            resize_Control(minmax, recminmax);
            resize_Control(guna2Panel1, recpanel1);
            resize_Control(guna2Panel1, recpanel1);
            resize_Control(monday, reclabel1);
            resize_Control(daycontainer, reccontainer);
            resize_Control(previous, recprevious);
            resize_Control(next, recnext);
            resize_Control(lbMonth, reclbMonth);
            resize_Control(monday, recmonday);
            resize_Control(tuesday, rectuesday);
            resize_Control(wednesday, recwednesday);
            resize_Control(thursday, recthursday);
            resize_Control(friday, recfriday);
            resize_Control(saturday, recsaturday);
            resize_Control(gotodashboard, recdashboard);
            resize_Control(daycontainer, reccontainer);
        }

        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void minmax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Calendar_Load(object? sender, EventArgs e)
        {
            daycontainer = new TableLayoutPanel
            {
                Location = new Point(19, 103),
                Size = new Size(867, 616),
                Dock = DockStyle.None,
                ColumnCount = 7,          // 7 days per week
                RowCount = 6,
                AutoSize = false,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
            };

            for (int i = 0; i < daycontainer.ColumnCount; i++)
                daycontainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / daycontainer.ColumnCount));

            for (int i = 0; i < daycontainer.RowCount; i++)
                daycontainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / daycontainer.RowCount));

            // Add the TableLayoutPanel to the panel
            guna2Panel1.Controls.Add(daycontainer);

            // Set the month label
            lbMonth.Text = currentMonth.ToString("MMMM yyyy");

            // Fill the TableLayoutPanel with the correct days of the month
            FillCalendar(currentMonth);
        }

        private void FillCalendar(DateTime month)
        {
            // Clear existing controls in daycontainer
            daycontainer.Controls.Clear();

            // Get the first day of the month and the number of days in the month
            DateTime firstDayOfMonth = new DateTime(month.Year, month.Month, 1);
            int daysInMonth = DateTime.DaysInMonth(month.Year, month.Month);

            // Get the starting day of the week for the 1st of the month
            int startDay = (int)firstDayOfMonth.DayOfWeek; // Sunday = 0, Monday = 1, etc.

            // Add empty labels for days before the 1st day of the month
            for (int i = 0; i < startDay; i++)
            {
                daycontainer.Controls.Add(new Label()); // Empty label for padding
            }

            // Add buttons for each day of the month
            for (int day = 1; day <= daysInMonth; day++)
            {
                Button dayButton = new Button
                {
                    Text = day.ToString(),
                    Dock = DockStyle.None,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 12),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.LightGray // Optional: Add color to make it visually distinct
                };

                dayButton.Click += DayButton_Click;

                // Add the button to the appropriate cell in the TableLayoutPanel
                daycontainer.Controls.Add(dayButton);
            }
        }

        private void DayButton_Click(object? sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;
            if (clickedButton != null)
            {
                MessageBox.Show($"You clicked on day: {clickedButton.Text}");
            }
        }

        private void DisplayCurrentMonth()
        {
            daycontainer.Controls.Clear(); // Clear previous buttons
            var firstDay = new DateTime(currentMonth.Year, currentMonth.Month, 1);
            var daysInMonth = DateTime.DaysInMonth(currentMonth.Year, currentMonth.Month);

            int dayOfWeekOffset = (int)firstDay.DayOfWeek;

            for (int i = 0; i < dayOfWeekOffset; i++)
            {
                // Add empty placeholders for days of the previous month
                daycontainer.Controls.Add(new Label());
            }

            for (int day = 1; day <= daysInMonth; day++)
            {
                var dayButton = new Guna2Button
                {
                    Text = day.ToString(),
                    Dock = DockStyle.None,
                    BorderRadius = 10,
                    BorderThickness = 1,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    FillColor = Color.White,
                    ForeColor = Color.Black,
                    Margin = new Padding(2)
                };

                daycontainer.Controls.Add(dayButton); // Add the button to the container
            }
        }

        private void gotodashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void previous_Click(object? sender, EventArgs e)
        {
            currentMonth = currentMonth.AddMonths(-1);
            DisplayCurrentMonth();
        }

        private void next_Click(object? sender, EventArgs e)
        {
            currentMonth = currentMonth.AddMonths(1);
            DisplayCurrentMonth();
        }

        private void lbMonth_Click(object sender, EventArgs e)
        {
            
        }

        private void monday_Click(object sender, EventArgs e)
        {

        }

        private void tuesday_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void wednesday_Click(object sender, EventArgs e)
        {

        }

        private void thursday_Click(object sender, EventArgs e)
        {

        }

        private void friday_Click(object sender, EventArgs e)
        {

        }

        private void saturday_Click(object sender, EventArgs e)
        {

        }
    }
}
