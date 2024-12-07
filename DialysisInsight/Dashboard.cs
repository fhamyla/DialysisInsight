using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Guna.UI2.WinForms;

namespace DialysisInsight
{
    public partial class Dashboard : Form
    {
        private Size formOriginalSize;
        private Dictionary<Guna2CustomGradientPanel, Rectangle> panelRectangles = new Dictionary<Guna2CustomGradientPanel, Rectangle>();
        private Dictionary<Label, Rectangle> labelRectangles = new Dictionary<Label, Rectangle>();
        private Dictionary<PictureBox, Rectangle> pictureBoxRectangles = new Dictionary<PictureBox, Rectangle>();
        private Dictionary<Guna2TextBox, Rectangle> textBoxRectangles = new Dictionary<Guna2TextBox, Rectangle>();
        private Dictionary<Guna2Button, Rectangle> gunabuttonRectangles = new Dictionary<Guna2Button, Rectangle>();
        public Dashboard()
        {
            InitializeComponent();
            AddIcons();
            AddHoverEffects();
            InitializeResizing();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void calender_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.Show();
            this.Hide();
        }

        private void addhealthdata_Click(object sender, EventArgs e)
        {
            HealthData healthData = new HealthData();
            healthData.Show();
            this.Hide();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Hide();
        }

        private void AddIcons()
        {
            int iconSize = 58;

            logout.Image = IconChar.SignOutAlt.ToBitmap(IconFont.Auto, iconSize, Color.White, iconSize, FlipOrientation.Normal);
            logout.ImageAlign = (HorizontalAlignment)ContentAlignment.MiddleCenter;
            logout.TextAlign = (HorizontalAlignment)TextImageRelation.ImageBeforeText;

            calender.Image = IconChar.CalendarAlt.ToBitmap(IconFont.Auto, iconSize, Color.White, 0, FlipOrientation.Normal);
            calender.ImageAlign = (HorizontalAlignment)ContentAlignment.MiddleLeft;
            calender.TextAlign = (HorizontalAlignment)TextImageRelation.ImageBeforeText;

            addhealthdata.Image = IconChar.PlusCircle.ToBitmap(IconFont.Auto, iconSize, Color.White, 0, FlipOrientation.Normal);
            addhealthdata.ImageAlign = (HorizontalAlignment)ContentAlignment.MiddleLeft;

            settings.Image = IconChar.Cogs.ToBitmap(IconFont.Auto, iconSize, Color.White, 0, FlipOrientation.Normal);
            settings.ImageAlign = (HorizontalAlignment)ContentAlignment.MiddleLeft;
            settings.TextAlign = (HorizontalAlignment)TextImageRelation.ImageBeforeText;
        }

        private void AddHoverEffects()
        {
            int iconSize = 58;
            logout.MouseEnter += (sender, e) =>
            {
                logout.Image = IconChar.SignOutAlt.ToBitmap(IconFont.Auto, iconSize, Color.Black, 0, FlipOrientation.Normal);
            };
            logout.MouseLeave += (sender, e) =>
            {
                logout.Image = IconChar.SignOutAlt.ToBitmap(IconFont.Auto, iconSize, Color.White, 0, FlipOrientation.Normal);
            };

            calender.MouseEnter += (sender, e) =>
            {
                calender.Image = IconChar.CalendarAlt.ToBitmap(IconFont.Auto, iconSize, Color.Green, 0, FlipOrientation.Normal);
            };
            calender.MouseLeave += (sender, e) =>
            {
                calender.Image = IconChar.CalendarAlt.ToBitmap(IconFont.Auto, iconSize, Color.White, 0, FlipOrientation.Normal);
            };

            addhealthdata.MouseEnter += (sender, e) =>
            {
                addhealthdata.Image = IconChar.PlusCircle.ToBitmap(IconFont.Auto, iconSize, Color.Red, 0, FlipOrientation.Normal);
            };
            addhealthdata.MouseLeave += (sender, e) =>
            {
                addhealthdata.Image = IconChar.PlusCircle.ToBitmap(IconFont.Auto, iconSize, Color.White, 0, FlipOrientation.Normal);
            };

            settings.MouseEnter += (sender, e) =>
            {
                settings.Image = IconChar.Cogs.ToBitmap(IconFont.Auto, iconSize, Color.Purple, 0, FlipOrientation.Normal);
            };
            settings.MouseLeave += (sender, e) =>
            {
                settings.Image = IconChar.Cogs.ToBitmap(IconFont.Auto, iconSize, Color.White, 0, FlipOrientation.Normal);
            };
        }

        private void user_Click(object sender, EventArgs e)
        {

        }

        private void minmax_Click(object sender, EventArgs e)
        {
            // Check if the form is currently in the normal state (not maximized)
            if (this.WindowState == FormWindowState.Normal)
            {
                // Maximize the form
                this.WindowState = FormWindowState.Maximized;

                // Maximize the panel along with the form (adjust the panel size as per the form)
                guna2Panel1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
            }
            else
            {
                // Restore the form to its original state
                this.WindowState = FormWindowState.Normal;

                // Restore the panel to its original size
                guna2Panel1.Size = new Size(886, 548); // Replace with the panel's original size
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            // You can add custom painting logic here if needed, for now it’s empty.
        }

        private void InitializeResizing()
        {
            // Store the original form size when the form is initialized
            guna2Panel1.Dock = DockStyle.Fill;

            foreach (Control control in this.Controls)
            {
                if (control is Label || control is Guna2Button)
                {
                    control.Anchor = AnchorStyles.Top | AnchorStyles.Left;  // Example: Top-left anchored
                }
            }

            // Loop through all the controls in the panels and store their original positions and sizes
            foreach (Guna2CustomGradientPanel panel in guna2Panel1.Controls.OfType<Guna2CustomGradientPanel>())
            {
                panelRectangles.Add(panel, new Rectangle(panel.Location, panel.Size));
            }
            foreach (Label label in guna2Panel1.Controls.OfType<Label>())
            {
                labelRectangles.Add(label, new Rectangle(label.Location, label.Size));
            }
            foreach (PictureBox pictureBox in guna2Panel1.Controls.OfType<PictureBox>())
            {
                pictureBoxRectangles.Add(pictureBox, new Rectangle(pictureBox.Location, pictureBox.Size));
            }
            foreach (Guna2TextBox textBox in guna2Panel1.Controls.OfType<Guna2TextBox>())
            {
                textBoxRectangles.Add(textBox, new Rectangle(textBox.Location, textBox.Size));
            }
            foreach (Guna2Button button in guna2Panel1.Controls.OfType<Guna2Button>())
            {
                gunabuttonRectangles.Add(button, new Rectangle(button.Location, button.Size));
            }
        }

        private void dashboard_Resize(object sender, EventArgs e)
        {
            // Resize controls dynamically based on the new form size
            foreach (var kvp in panelRectangles)
            {
                ResizeControl(kvp.Key, kvp.Value);
            }
            foreach (var kvp in labelRectangles)
            {
                ResizeControl(kvp.Key, kvp.Value);
            }
            foreach (var kvp in pictureBoxRectangles)
            {
                ResizeControl(kvp.Key, kvp.Value);
            }
            foreach (var kvp in textBoxRectangles)
            {
                ResizeControl(kvp.Key, kvp.Value);
            }
            foreach (var kvp in gunabuttonRectangles)
            {
                ResizeControl(kvp.Key, kvp.Value);
            }
        }

        private void ResizeControl(Control c, Rectangle r)
        {
            // Calculate the scaling ratio based on the current form size
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);

            // Apply the scaling ratio to the control's position and size
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);
            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            // Update the control's location and size
            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            // Initialize the resizing setup when the form loads
            InitializeResizing();
        }

        private void DateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }

        private void notify_Click(object sender, EventArgs e)
        {

        }

        private void weight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void heartrate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sugarlevel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void healthpressure_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dialysisinsight_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}