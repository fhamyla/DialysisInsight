using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialysisInsight
{
    public partial class HealthData : Form
    {
        private Size formOriginalSize;
        private Rectangle recminmax;
        private Rectangle recpanel1;
        private Rectangle reckilo;
        private Rectangle reckilobox;
        private Rectangle recbpm;
        private Rectangle recbpmbox;
        private Rectangle recmg;
        private Rectangle recmgbox;
        private Rectangle recmm;
        private Rectangle recmm1;
        private Rectangle recmm2;
        private Rectangle recsessions;
        private Rectangle recsessions1;
        private Rectangle recsessions2;
        private Rectangle recsave;
        private Rectangle recback;
        public HealthData()
        {
            InitializeComponent();
            this.Resize += Dashboard_Resiz;
            formOriginalSize = this.Size;
            recminmax = new Rectangle(minmax.Location, minmax.Size);
            recpanel1 = new Rectangle(guna2Panel1.Location, guna2Panel1.Size);
            reckilo = new Rectangle(guna2HtmlLabel1.Location, guna2HtmlLabel1.Size);
            reckilobox = new Rectangle(Weight.Location, Weight.Size);
            recbpm = new Rectangle(guna2HtmlLabel2.Location, guna2HtmlLabel2.Size);
            recbpmbox = new Rectangle(HeartRate.Location, HeartRate.Size);
            recmg = new Rectangle(guna2HtmlLabel3.Location, guna2HtmlLabel3.Size);
            recmgbox = new Rectangle(BloodSugarLevel.Location, BloodSugarLevel.Size);
            recmm = new Rectangle(guna2HtmlLabel4.Location, guna2HtmlLabel4.Size);
            recmm1 = new Rectangle(SYS.Location, SYS.Size);
            recmm2 = new Rectangle(DIA.Location, DIA.Size);
            recsessions = new Rectangle(guna2HtmlLabel5.Location, guna2HtmlLabel5.Size);
            recsessions1 = new Rectangle(SessionComplete.Location, SessionComplete.Size);
            recsessions2 = new Rectangle(CompleteSession.Location, CompleteSession.Size);
            recsave = new Rectangle(save.Location, save.Size);
            recback = new Rectangle(back.Location, back.Size);
        }

        private void Dashboard_Resiz(object? sender, EventArgs e)
        {
            resize_Control(minmax, recminmax);
            resize_Control(guna2Panel1, recpanel1);
            resize_Control(guna2HtmlLabel1, reckilo);
            resize_Control(Weight, reckilobox);
            resize_Control(guna2HtmlLabel2, recbpm);
            resize_Control(HeartRate, recbpmbox);
            resize_Control(guna2HtmlLabel3, recmg);
            resize_Control(BloodSugarLevel, recmgbox);
            resize_Control(guna2HtmlLabel4, recmm);
            resize_Control(SYS, recmm1);
            resize_Control(DIA, recmm2);
            resize_Control(guna2HtmlLabel5, recsessions);
            resize_Control(SessionComplete, recsessions1);
            resize_Control(CompleteSession, recsessions2);
            resize_Control(save, recsave);
            resize_Control(back, recback);
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

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Weight_TextChanged(object sender, EventArgs e)
        {

        }

        private void HeartRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void BloodSugarLevel_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void SYS_TextChanged(object sender, EventArgs e)
        {

        }

        private void DIA_TextChanged(object sender, EventArgs e)
        {

        }

        private void SessionComplete_TextChanged(object sender, EventArgs e)
        {

        }

        private void CompleteSession_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {

        }
    }
}
