using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace DialysisInsight
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;

                foreach (Control control in this.Controls)
                {
                    control.Dock = DockStyle.Fill;
                }
            }
            else
            {
                this.WindowState = FormWindowState.Normal;

                // Reset the Dock property if necessary
                foreach (Control control in this.Controls)
                {
                    control.Dock = DockStyle.None;
                }
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void calendar_Click(object sender, EventArgs e)
        {

        }

        private void addhealthdata_Click(object sender, EventArgs e)
        {

        }

        private void settings_Click(object sender, EventArgs e)
        {

        }

        private void BloodPressure_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DialysisSessionsCompleted_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Weight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HeartRate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BloodSugarLevel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }

        private void notification_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}