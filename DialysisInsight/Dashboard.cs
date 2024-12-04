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
            AddIcons(); // Call the method after the form is initialized
            AddHoverEffects();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void calender_Click(object sender, EventArgs e)
        {

        }

        private void addhealthdata_Click(object sender, EventArgs e)
        {

        }

        private void settings_Click(object sender, EventArgs e)
        {

        }

        private void AddIcons()
        {
            // Convert FontAwesome icon to Bitmap and assign it to the button
            logout.Image = IconChar.SignOutAlt.ToBitmap(IconFont.Auto, 52, Color.White, 0, FlipOrientation.Normal);  // Logout icon
            logout.ImageAlign = (HorizontalAlignment)ContentAlignment.MiddleLeft;  // Align icon to the left

            calender.Image = IconChar.CalendarAlt.ToBitmap(IconFont.Auto, 52, Color.White, 0, FlipOrientation.Normal);  // Calendar icon
            calender.ImageAlign = (HorizontalAlignment)ContentAlignment.MiddleLeft;  // Align icon to the left

            addhealthdata.Image = IconChar.PlusCircle.ToBitmap(IconFont.Auto, 52, Color.White, 0, FlipOrientation.Normal);  // Add health data icon
            addhealthdata.ImageAlign = (HorizontalAlignment)ContentAlignment.MiddleLeft;  // Align icon to the left

            settings.Image = IconChar.Cogs.ToBitmap(IconFont.Auto, 52, Color.White, 0, FlipOrientation.Normal);  // Settings icon
            settings.ImageAlign = (HorizontalAlignment)ContentAlignment.MiddleLeft;  // Align icon to the left
        }

        private void AddHoverEffects()
        {
            // Hover effect for logout button
            logout.MouseEnter += (sender, e) =>
            {
                logout.Image = IconChar.SignOutAlt.ToBitmap(IconFont.Auto, 52, Color.Black, 0, FlipOrientation.Normal);  // Change icon color on hover
            };
            logout.MouseLeave += (sender, e) =>
            {
                logout.Image = IconChar.SignOutAlt.ToBitmap(IconFont.Auto, 52, Color.White, 0, FlipOrientation.Normal);  // Revert icon color
            };

            // Hover effect for calendar button
            calender.MouseEnter += (sender, e) =>
            {
                calender.Image = IconChar.CalendarAlt.ToBitmap(IconFont.Auto, 52, Color.Green, 0, FlipOrientation.Normal);  // Change icon color on hover
            };
            calender.MouseLeave += (sender, e) =>
            {
                calender.Image = IconChar.CalendarAlt.ToBitmap(IconFont.Auto, 52, Color.White, 0, FlipOrientation.Normal);  // Revert icon color
            };

            // Hover effect for add health data button
            addhealthdata.MouseEnter += (sender, e) =>
            {
                addhealthdata.Image = IconChar.PlusCircle.ToBitmap(IconFont.Auto, 52, Color.Red, 0, FlipOrientation.Normal);  // Change icon color on hover
            };
            addhealthdata.MouseLeave += (sender, e) =>
            {
                addhealthdata.Image = IconChar.PlusCircle.ToBitmap(IconFont.Auto, 52, Color.White, 0, FlipOrientation.Normal);  // Revert icon color
            };

            // Hover effect for settings button
            settings.MouseEnter += (sender, e) =>
            {
                settings.Image = IconChar.Cogs.ToBitmap(IconFont.Auto, 52, Color.Purple, 0, FlipOrientation.Normal);  // Change icon color on hover
            };
            settings.MouseLeave += (sender, e) =>
            {
                settings.Image = IconChar.Cogs.ToBitmap(IconFont.Auto, 52, Color.White, 0, FlipOrientation.Normal);  // Revert icon color
            };
        }
    }
}