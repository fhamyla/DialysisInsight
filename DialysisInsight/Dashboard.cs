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
        private Rectangle recuser;
        private Rectangle recminmax;
        private Rectangle recpanel1;
        private Rectangle recdatetime;
        private Rectangle recsearch;
        private Rectangle recnotify;
        private Rectangle recweight;
        private Rectangle recheart;
        private Rectangle recsugar;
        private Rectangle rechealth;
        private Rectangle recdialysis;
        private Rectangle recpanel2;
        private Rectangle reclabel1;
        private Rectangle reclabel2;
        private Rectangle reclabel3;
        private Rectangle reclabel4;
        private Rectangle reclabel5;
        public Dashboard()
        {
            InitializeComponent();
            LoadDataFromSettings();
            AddIcons();
            AddHoverEffects();
            this.Resize += Dashboard_Resiz;
            formOriginalSize = this.Size;
            recuser = new Rectangle(user.Location, user.Size);
            recminmax = new Rectangle(minmax.Location, minmax.Size);
            recpanel1 = new Rectangle(guna2Panel1.Location, guna2Panel1.Size);
            recdatetime = new Rectangle(DateTime.Location, DateTime.Size);
            recsearch = new Rectangle(search.Location, search.Size);
            recnotify = new Rectangle(notify.Location, notify.Size);
            recweight = new Rectangle(weight.Location, weight.Size);
            recheart = new Rectangle(heartrate.Location, heartrate.Size);
            recsugar = new Rectangle(sugarlevel.Location, sugarlevel.Size);
            rechealth = new Rectangle(healthpressure.Location, healthpressure.Size);
            recdialysis = new Rectangle(dialysisinsight.Location, dialysisinsight.Size);
            recpanel2 = new Rectangle(guna2Panel2.Location, guna2Panel2.Size);
            reclabel1 = new Rectangle(weightlabel.Location, weightlabel.Size);
            reclabel2 = new Rectangle(heartratelabel.Location, heartratelabel.Size);
            reclabel3 = new Rectangle(bloodsugarlevellabel.Location, bloodsugarlevellabel.Size);
            reclabel4 = new Rectangle(bloodpressurelabel.Location, bloodpressurelabel.Size);
            reclabel5 = new Rectangle(dailysissessionlabel.Location, dailysissessionlabel.Size);
        }

        private void LoadDataFromSettings()
        {
            if (Properties.Settings.Default.isHealthDataSaved)
            {
                if (double.TryParse(Properties.Settings.Default.Weight, out double weight))
                {
                    weightlabel.Text = $" {weight}";
                    if (weight < 18.5)
                        weightlabel.BackColor = Color.Yellow;
                    else if (weight >= 18.5 && weight <= 24.9)
                        weightlabel.BackColor = Color.Green;
                    else
                        weightlabel.BackColor = Color.Red;
                }
                else
                {
                    weightlabel.Text = "Invalid";
                    weightlabel.BackColor = Color.White;
                }

                if (int.TryParse(Properties.Settings.Default.HeartRate, out int heartRate))
                {
                    heartratelabel.Text = $" {heartRate}";
                    if (heartRate < 60 || heartRate > 100)
                        heartratelabel.BackColor = Color.Red;
                    else
                        heartratelabel.BackColor = Color.Green;
                }
                else
                {
                    heartratelabel.Text = "Invalid";
                    heartratelabel.BackColor = Color.White;
                }

                if (int.TryParse(Properties.Settings.Default.BloodSugarLevel, out int bloodSugar))
                {
                    bloodsugarlevellabel.Text = $" {bloodSugar}";
                    if (bloodSugar < 100 || bloodSugar > 125)
                        bloodsugarlevellabel.BackColor = Color.Red;
                    else
                        bloodsugarlevellabel.BackColor = Color.Green;
                }
                else
                {
                    bloodsugarlevellabel.Text = "Invalid";
                    bloodsugarlevellabel.BackColor = Color.White;
                }

                if (int.TryParse(Properties.Settings.Default.SYS, out int sys) &&
                    int.TryParse(Properties.Settings.Default.DIA, out int dia))
                {
                    bloodpressurelabel.Text = $" {sys}/{dia}";
                    if (sys < 120 && dia < 80)
                    {
                        bloodpressurelabel.BackColor = Color.Green;
                    }
                    else if (sys >= 120 && sys <= 129 && dia < 80)
                    {
                        bloodpressurelabel.BackColor = Color.Yellow;
                    }
                    else
                    {
                        bloodpressurelabel.BackColor = Color.Red;
                    }
                }
                else
                {
                    bloodpressurelabel.Text = "Invalid";
                    bloodpressurelabel.BackColor = Color.White;
                }

                if (int.TryParse(Properties.Settings.Default.SessionComplete, out int completed) &&
                    int.TryParse(Properties.Settings.Default.CompleteSession, out int total))
                {
                    dailysissessionlabel.Text = $" {completed}/{total}";
                    if (completed < total)
                        dailysissessionlabel.BackColor = Color.Red;
                    else
                        dailysissessionlabel.BackColor = Color.Green;
                }
                else
                {
                    dailysissessionlabel.Text = "Invalid";
                    dailysissessionlabel.BackColor = Color.White;
                }
            }
            else
            {
                weightlabel.Text = "Not Available";
                heartratelabel.Text = "Not Available";
                bloodsugarlevellabel.Text = "Not Available";
                bloodpressurelabel.Text = "Not Available";
                dailysissessionlabel.Text = "Not Available";

                weightlabel.BackColor = Color.White;
                heartratelabel.BackColor = Color.White;
                bloodsugarlevellabel.BackColor = Color.White;
                bloodpressurelabel.BackColor = Color.White;
                dailysissessionlabel.BackColor = Color.White;
            }
        }

        private void Dashboard_Resiz(object? sender, EventArgs e)
        {
            resize_Control(user, recuser);
            resize_Control(minmax, recminmax);
            resize_Control(guna2Panel1, recpanel1);
            resize_Control(DateTime, recdatetime);
            resize_Control(search, recsearch);
            resize_Control(notify, recnotify);
            resize_Control(weight, recweight);
            resize_Control(heartrate, recheart);
            resize_Control(sugarlevel, recsugar);
            resize_Control(healthpressure, rechealth);
            resize_Control(dialysisinsight, recdialysis);
            resize_Control(guna2Panel2, recpanel2);
            resize_Control(weightlabel, reclabel1);
            resize_Control(heartratelabel, reclabel2);
            resize_Control(bloodsugarlevellabel, reclabel3);
            resize_Control(bloodpressurelabel, reclabel4);
            resize_Control(dailysissessionlabel, reclabel5);
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
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void guna2Panel1_Paint(object sender, EventArgs e)
        {

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

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void weightlabel_Click(object sender, EventArgs e)
        {

        }

        private void heartratelabel_Click(object sender, EventArgs e)
        {

        }

        private void bloodsugarlevellabel_Click(object sender, EventArgs e)
        {

        }

        private void bloodpressurelabel_Click(object sender, EventArgs e)
        {

        }

        private void dailysissessionlabel_Click(object sender, EventArgs e)
        {

        }
    }
}