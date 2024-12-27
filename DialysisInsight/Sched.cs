using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DialysisInsight.Calendar;
using static System.Net.Mime.MediaTypeNames;

namespace DialysisInsight
{
    public partial class Sched : Form
    {
        private Size formOriginalSize;
        private Rectangle recminmax;
        private Rectangle recpanel1;
        private Rectangle reclabel1;
        private Rectangle reccontainer;
        private Rectangle recprevious;
        private Rectangle recprev;

        private Calendar calendarInstance;
        private DateTime selectedDate;

        public Sched(Calendar calendar, DateTime date)
        {
            calendarInstance = calendar ?? throw new ArgumentNullException(nameof(calendar));
            selectedDate = date;

            InitializeComponent();

            this.Resize += Dashboard_Resiz;
            formOriginalSize = this.Size;
            recminmax = new Rectangle(minmax.Location, minmax.Size);
            recpanel1 = new Rectangle(guna2Panel1.Location, guna2Panel1.Size);
            reclabel1 = new Rectangle(Title.Location, Title.Size);
            reccontainer = new Rectangle(Body.Location, Body.Size);
            recprevious = new Rectangle(guna2Button1.Location, guna2Button1.Size);
            recprevious = new Rectangle(guna2Button1.Location, guna2Button1.Size);
            recprev = new Rectangle(guna2Button2.Location, guna2Button2.Size);
        }

        private void Dashboard_Resiz(object? sender, EventArgs e)
        {
            resize_Control(minmax, recminmax);
            resize_Control(guna2Panel1, recpanel1);
            resize_Control(Title, reclabel1);
            resize_Control(Body, reccontainer);
            resize_Control(guna2Button1, recprevious);
            resize_Control(guna2Button2, recprev);
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

        private void Title_TextChanged(object sender, EventArgs e)
        {

        }

        private void Body_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string note = Body.Text.Trim();
            if (!string.IsNullOrEmpty(note))
            {
                calendarInstance.AddNoteForDate(selectedDate, note);
            }
            calendarInstance.Show();
            this.Hide();
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

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            calendarInstance.AddNoteForDate(selectedDate, string.Empty);
            calendarInstance.Show();
            this.Hide();
        }
    }
}