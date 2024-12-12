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

namespace DialysisInsight
{
    public partial class Calendar : Form
    {
        int month, year;
        private Size formOriginalSize;
        private Rectangle recminmax;
        private Rectangle recpanel1;
        public Calendar()
        {
            InitializeComponent();
            this.Resize += Dashboard_Resiz;
            formOriginalSize = this.Size;
            recminmax = new Rectangle(minmax.Location, minmax.Size);
            recpanel1 = new Rectangle(guna2Panel1.Location, guna2Panel1.Size);
        }

        private void Dashboard_Resiz(object? sender, EventArgs e)
        {
            resize_Control(minmax, recminmax);
            resize_Control(guna2Panel1, recpanel1);
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

        private void Calendar_Load(object sender, EventArgs e)
        {
            displaDays();
        }

        private void displaDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbMonth.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < daysoftheweek; i++)
            {
                ucDays ucBlank = new ucDays();
                daycontainer.Controls.Add(ucBlank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                DateTime currentDate = new DateTime(year, month, i);
                ucdays.setDate(currentDate.ToString("MM/dd/yyyy"));
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void gotodashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void previous_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month--;

            if (month < 1)
            {
                month = 12;
                year--;
            }

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbMonth.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < daysoftheweek; i++)
            {
                ucDays ucBlank = new ucDays();
                daycontainer.Controls.Add(ucBlank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                DateTime currentDate = new DateTime(year, month, i);
                ucdays.setDate(currentDate.ToString("MM/dd/yyyy"));
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month++;

            if (month > 12)
            {
                month = 1;
                year++;
            }

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbMonth.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < daysoftheweek; i++)
            {
                ucDays ucBlank = new ucDays();
                daycontainer.Controls.Add(ucBlank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                DateTime currentDate = new DateTime(year, month, i);
                ucdays.setDate(currentDate.ToString("MM/dd/yyyy"));
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
