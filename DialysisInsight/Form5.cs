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
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        private Dictionary<DateTime, string> notedDays;

        public Calendar()
        {
            InitializeComponent();

            notedDays = new Dictionary<DateTime, string>();

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

        public static class SharedData
        {
            public static HashSet<DateTime> NotedDays { get; } = new HashSet<DateTime>();
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
            daycontainer.ColumnStyles.Clear();
            daycontainer.RowStyles.Clear();

            daycontainer.ColumnCount = 7;
            daycontainer.RowCount = 6;

            for (int col = 0; col < daycontainer.ColumnCount; col++)
            {
                daycontainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / daycontainer.ColumnCount));
            }

            for (int row = 0; row < daycontainer.RowCount; row++)
            {
                daycontainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / daycontainer.RowCount));
            }

            lbMonth.Text = currentMonth.ToString("MMMM yyyy");

            DateTime firstDayOfMonth = new DateTime(currentMonth.Year, currentMonth.Month, 1);
            int daysInMonth = DateTime.DaysInMonth(currentMonth.Year, currentMonth.Month);

            int startDay = (int)firstDayOfMonth.DayOfWeek;

            for (int i = 0; i < startDay; i++)
            {
                var blankLabel = new Label
                {
                    Dock = DockStyle.Fill,
                    BackColor = Color.Transparent
                };
                daycontainer.Controls.Add(blankLabel);
            }

            for (int day = 1; day <= daysInMonth; day++)
            {
                int currentDay = day;

                var currentDate = new DateTime(currentMonth.Year, currentMonth.Month, day);

                var dayButton = new Guna2Button
                {
                    Text = day.ToString(),
                    Dock = DockStyle.Fill,
                    BorderRadius = 10,
                    BorderThickness = 1,
                    Margin = new Padding(2),
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    FillColor = notedDays.ContainsKey(currentDate)
                    ? Color.FromArgb(197, 211, 191)
                    : Color.White,
                    ForeColor = Color.Black,
                    Tag = currentDate
                };

                if (day == DateTime.Now.Day && currentMonth.Month == DateTime.Now.Month && currentMonth.Year == DateTime.Now.Year)
                {
                    dayButton.FillColor = Color.FromArgb(217, 210, 233);
                    dayButton.Tag = "current";
                }

                dayButton.MouseEnter += (s, e) =>
                {
                    if (dayButton.Tag?.ToString() != "current")
                    {
                        dayButton.FillColor = Color.FromArgb(255, 242, 204);
                    }
                };

                dayButton.MouseLeave += (s, e) =>
                {
                    if (dayButton.Tag?.ToString() == "current")
                    {
                        dayButton.FillColor = Color.FromArgb(217, 210, 233);
                    }
                    else if (!notedDays.ContainsKey(currentDate))
                    {
                        dayButton.FillColor = Color.White;
                    }
                    else
                    {
                        dayButton.FillColor = Color.FromArgb(197, 211, 191);
                    }
                };

                dayButton.Click += (s, e) => DayButton_Click(currentDate);

                daycontainer.Controls.Add(dayButton);
            }

            int totalCells = daycontainer.RowCount * daycontainer.ColumnCount;
            int filledCells = daycontainer.Controls.Count;

            for (int i = filledCells; i < totalCells; i++)
            {
                var blankLabel = new Label
                {
                    Dock = DockStyle.Fill,
                    BackColor = Color.Transparent
                };
                daycontainer.Controls.Add(blankLabel);
            }
        }

        private void DayButton_Click(DateTime selectedDate)
        {
            if (notedDays.ContainsKey(selectedDate))
            {
                string note = notedDays[selectedDate];
                MessageBox.Show($"Note for {selectedDate.ToShortDateString()}:\n{note}", "View Note");

                var result = MessageBox.Show("Do you want to delete this note?", "Delete Note", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    notedDays.Remove(selectedDate);
                    DisplayCurrentMonth();
                }
            }
            else
            {
                Sched sched = new Sched(this, selectedDate);
                sched.Show();
                this.Hide();
            }
        }

        public void AddNoteForDate(DateTime date, string note)
        {
            notedDays[date] = note;
            DisplayCurrentMonth(); // Refresh the calendar
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