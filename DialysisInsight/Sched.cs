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
using static System.Windows.Forms.DataFormats;

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
        private Rectangle recback;

        private Calendar calendarInstance;
        private DateTime selectedDate;
        private TextBox? noteTextBox;

        public Sched(Calendar calendar, DateTime date)
        {
            calendarInstance = calendar ?? throw new ArgumentNullException(nameof(calendar));
            selectedDate = date;

            InitializeComponent();
            InitializeNoteTextBox();

            this.Resize += Dashboard_Resiz;
            formOriginalSize = this.Size;
            recminmax = new Rectangle(minmax.Location, minmax.Size);
            recpanel1 = new Rectangle(guna2Panel1.Location, guna2Panel1.Size);
            reclabel1 = new Rectangle(Title.Location, Title.Size);
            reccontainer = new Rectangle(Body.Location, Body.Size);
            recprevious = new Rectangle(guna2Button1.Location, guna2Button1.Size);
            recprevious = new Rectangle(guna2Button1.Location, guna2Button1.Size);
            recprev = new Rectangle(guna2Button2.Location, guna2Button2.Size);
            recback= new Rectangle(Back.Location, Back.Size);
        }

        private Guna.UI2.WinForms.Guna2TextBox? titleTextBox;
        private Guna.UI2.WinForms.Guna2TextBox? bodyTextBox;

        private void ValidateNoteFields()
        {
            bool isInputValid = !string.IsNullOrWhiteSpace(titleTextBox?.Text) &&
                                !string.IsNullOrWhiteSpace(bodyTextBox?.Text);

            guna2Button1.Enabled = isInputValid;
            guna2Button2.Enabled = isInputValid;
        }

        public void SetNoteForDate(string note)
        {
            if (titleTextBox != null && bodyTextBox != null)
            {
                string[] parts = note.Split(new[] { ':' }, 2);
                titleTextBox.Text = parts.Length > 0 ? parts[0].Trim() : string.Empty;
                bodyTextBox.Text = parts.Length > 1 ? parts[1].Trim() : string.Empty;
            }
        }

        private void Dashboard_Resiz(object? sender, EventArgs e)
        {
            resize_Control(minmax, recminmax);
            resize_Control(guna2Panel1, recpanel1);
            resize_Control(Title, reclabel1);
            resize_Control(Body, reccontainer);
            resize_Control(guna2Button1, recprevious);
            resize_Control(guna2Button2, recprev);
            resize_Control(Back, recback);
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

        private void Title_TextChanged(object? sender, EventArgs e)
        {
            ValidateNoteFields();
        }

        private void Body_TextChanged(object? sender, EventArgs e)
        {
            ValidateNoteFields();
        }

        private void InitializeNoteTextBox()
        {
            titleTextBox = Title;
            bodyTextBox = Body;

            titleTextBox?.Clear();
            bodyTextBox?.Clear();

            if (titleTextBox != null)
                titleTextBox.TextChanged += Title_TextChanged;

            if (bodyTextBox != null)
                bodyTextBox.TextChanged += Body_TextChanged;

            ValidateNoteFields();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (titleTextBox == null || bodyTextBox == null)
            {
                MessageBox.Show("Title or Body text box is not initialized. Please check the configuration.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string title = titleTextBox?.Text.Trim() ?? string.Empty;
            string note = bodyTextBox?.Text.Trim() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(note))
            {
                MessageBox.Show("Title and Body cannot be empty. Please provide valid input.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            calendarInstance.AddNoteForDate(selectedDate, $"{title}: {note}");
            MessageBox.Show("Note saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            calendarInstance.Show();
            this.Close();
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
            if (titleTextBox == null || bodyTextBox == null)
            {
                MessageBox.Show("Title or Body text box is not initialized. Please check the configuration.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string title = titleTextBox?.Text.Trim() ?? string.Empty;
            string note = bodyTextBox?.Text.Trim() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Title cannot be empty. Please provide a valid title to delete.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to delete the note with title: \"{title}\"?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            bool deleted = calendarInstance.DeleteNoteForDate(selectedDate, title);

            if (deleted)
            {
                MessageBox.Show("Note deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Note not found. Please check the title and try again.",
                    "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            calendarInstance.Show();
            this.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            calendarInstance.Show();
            this.Close();
        }
    }
}