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
            foreach (Control control in daycontainer.Controls)
            {
                if (control is Guna2Button dayButton)
                {
                    dayButton.Width = daycontainer.Width / 7 - 5;
                    dayButton.Height = daycontainer.Height / 6 - 5;
                }
            }
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
            currentMonth = DateTime.Now;
            DisplayCurrentMonth();
        }

        private void DisplayCurrentMonth()
        {
            daycontainer.Controls.Clear();
            lbMonth.Text = currentMonth.ToString("MMMM yyyy");

            // Get the first day of the month
            DateTime firstDay = new DateTime(currentMonth.Year, currentMonth.Month, 1);
            int daysInMonth = DateTime.DaysInMonth(currentMonth.Year, currentMonth.Month);
            int startDay = (int)firstDay.DayOfWeek;

            for (int i = 0; i < startDay; i++)
            {
                var blankLabel = new Label
                {
                    Width = 50,
                    Height = 50,
                    BackColor = Color.Transparent
                };
                daycontainer.Controls.Add(blankLabel);
            }

            for (int day = 1; day <= daysInMonth; day++)
            {
                int currentDay = day;
                var dayButton = new Guna2Button
                {
                    Text = day.ToString(),
                    Width = daycontainer.Width / 7 - 5,
                    Height = daycontainer.Height / 6 - 5,
                    BorderRadius = 10,
                    BorderThickness = 1,
                    Margin = new Padding(2),
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    FillColor = Color.White,
                    ForeColor = Color.Black
                };

                // Highlight the current date
                if (day == DateTime.Now.Day && currentMonth.Month == DateTime.Now.Month && currentMonth.Year == DateTime.Now.Year)
                {
                    dayButton.FillColor = Color.FromArgb(217, 210, 233);
                    dayButton.Tag = "current";
                }
                else
                {
                    dayButton.Tag = "normal";
                }

                dayButton.MouseEnter += (s, e) =>
                {
                    if (dayButton.Tag.ToString() != "current")
                    {
                        dayButton.FillColor = Color.FromArgb(255, 242, 204);
                    }
                };

                dayButton.MouseLeave += (s, e) =>
                {
                    if (dayButton.Tag.ToString() == "current")
                    {
                        dayButton.FillColor = Color.FromArgb(217, 210, 233);
                    }
                    else
                    {
                        dayButton.FillColor = Color.White;
                    }
                };
                dayButton.Click += (s, e) => DayButton_Click(currentDay);
                daycontainer.Controls.Add(dayButton);
            }
        }

        private void DayButton_Click(int day)
        {
            MessageBox.Show($"You selected {currentMonth:MMMM} {day}, {currentMonth.Year}", "Day Selected");
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
