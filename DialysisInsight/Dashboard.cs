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
        public Dashboard()
        {
            InitializeComponent();
            AddIcons();
            AddHoverEffects();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Rectangle resolutionRect = System.Windows.Forms.Screen.FromControl(this).Bounds;
            if (this.Width >= resolutionRect.Width || this.Height >= resolutionRect.Height)
            {
                this.WindowState = FormWindowState.Maximized;
            }
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

        private bool isMaximized = false; // Flag to track the state

        private void minmax_Click(object sender, EventArgs e)
        {
            if (isMaximized)
            {
                // Restore to original size
                this.WindowState = FormWindowState.Normal;
                this.Bounds = new Rectangle(100, 100, 800, 600); // Replace with your original size
                ScaleControls(guna2Panel1, 0.5f); // Adjust scale factor as needed
                isMaximized = false;
            }
            else
            {
                // Maximize the form
                this.WindowState = FormWindowState.Maximized;
                ScaleControls(guna2Panel1, 2.0f); // Adjust scale factor as needed
                isMaximized = true;
            }
        }

        /// <summary>
        /// Scales all controls within a panel by a given factor.
        /// </summary>
        /// <param name="panel">The panel containing the controls.</param>
        /// <param name="scaleFactor">The factor by which to scale the controls.</param>
        private void ScaleControls(Control panel, float scaleFactor)
        {
            foreach (Control control in panel.Controls)
            {
                control.Left = (int)(control.Left * scaleFactor);
                control.Top = (int)(control.Top * scaleFactor);
                control.Width = (int)(control.Width * scaleFactor);
                control.Height = (int)(control.Height * scaleFactor);
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            // You can add custom painting logic here if needed, for now it’s empty.
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