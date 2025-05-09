﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
        private Rectangle recResetDataButton;
        private Rectangle recedit;
        private Rectangle receditt;
        private Rectangle recedittt;
        private Rectangle receditttt;
        private Rectangle recedittttt;
        private Rectangle receditttttt;
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
            recResetDataButton = new Rectangle(ResetDataButton.Location, ResetDataButton.Size);
            recedit = new Rectangle(editkilo.Location, editkilo.Size);
            receditt = new Rectangle(editbpm.Location, editbpm.Size);
            recedittt = new Rectangle(editmg.Location, editmg.Size);
            receditttt = new Rectangle(editmmhg.Location, editmmhg.Size);
            recedittttt = new Rectangle(editsessions.Location, editsessions.Size);
            receditttttt = new Rectangle(editttttt.Location, editttttt.Size);

            if (Properties.Settings.Default.isHealthDataSaved)
            {
                Weight.Text = Properties.Settings.Default.Weight;
                HeartRate.Text = Properties.Settings.Default.HeartRate;
                BloodSugarLevel.Text = Properties.Settings.Default.BloodSugarLevel;
                SYS.Text = Properties.Settings.Default.SYS;
                DIA.Text = Properties.Settings.Default.DIA;
                SessionComplete.Text = Properties.Settings.Default.SessionComplete;
                CompleteSession.Text = Properties.Settings.Default.CompleteSession;

                DisableInputs();
            }
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
            resize_Control(ResetDataButton, recResetDataButton);
            resize_Control(editkilo, recedit);
            resize_Control(editbpm, receditt);
            resize_Control(editmg, recedittt);
            resize_Control(editmmhg, receditttt);
            resize_Control(editsessions, recedittttt);
            resize_Control(editttttt, receditttttt);
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
            string input = Weight.Text;
            double result;

            if (Regex.IsMatch(input, @"^\d+\.$") || Regex.IsMatch(input, @"^\d*\.\d*\.$") || Regex.IsMatch(input, @"^\.\d*\.\d*$"))
            {
                Weight.BackColor = Color.Red;
                return;
            }

            if (double.TryParse(input, out result))
            {
                Weight.BackColor = Color.White;
            }
            else
            {
                Weight.Text = "";
                Weight.BackColor = Color.Red;
            }
            ValidateForm();
        }

        private void HeartRate_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void BloodSugarLevel_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void SYS_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void DIA_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void SessionComplete_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(SessionComplete.Text, out int sessionCompleteValue) &&
                int.TryParse(CompleteSession.Text, out int completeSessionValue))
            {
                if (sessionCompleteValue > completeSessionValue)
                {
                    MessageBox.Show("The number entered must be less than or equal to the value in 'CompleteSession'.",
                                    "Validation Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    SessionComplete.Text = "";
                }
            }
            ValidateForm();
        }

        private void CompleteSession_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(SessionComplete.Text, out int sessionCompleteValue) &&
                int.TryParse(CompleteSession.Text, out int completeSessionValue))
            {
                if (sessionCompleteValue > completeSessionValue)
                {
                    MessageBox.Show("The value in 'SessionComplete' must be less than or equal to the value entered here.",
                                    "Validation Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    SessionComplete.Text = "";
                }
            }
            ValidateForm();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Close();
        }

        private bool isHealthDataSaved = false;
        private bool kilosave = false;
        private bool bpmsave = false;
        private bool mgsave = false;
        private bool mmsave = false;
        private bool sessionsave = false;
        private bool completesave = false;

        private void save_Click(object sender, EventArgs e)
        {
            string input = Weight.Text;

            if (string.IsNullOrEmpty(input) || Regex.IsMatch(input, @"^\d+\.$") || Regex.IsMatch(input, @"^\d*\.\d*\.$") || Regex.IsMatch(input, @"^\.\d*\.\d*$"))
            {
                MessageBox.Show("Please enter a valid weight.");
                return;
            }

            double result;
            if (double.TryParse(input, out result))
            {

            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a numeric value.");
            }

            if (isHealthDataSaved)
            {
                MessageBox.Show("Data has already been saved and cannot be modified.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(Weight.Text) ||
                string.IsNullOrWhiteSpace(HeartRate.Text) ||
                string.IsNullOrWhiteSpace(BloodSugarLevel.Text) ||
                string.IsNullOrWhiteSpace(SYS.Text) ||
                string.IsNullOrWhiteSpace(DIA.Text) ||
                string.IsNullOrWhiteSpace(SessionComplete.Text) ||
                string.IsNullOrWhiteSpace(CompleteSession.Text))
            {
                MessageBox.Show("Please fill in all required fields before saving.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Properties.Settings.Default.Weight = Weight.Text;
            Properties.Settings.Default.HeartRate = HeartRate.Text;
            Properties.Settings.Default.BloodSugarLevel = BloodSugarLevel.Text;
            Properties.Settings.Default.SYS = SYS.Text;
            Properties.Settings.Default.DIA = DIA.Text;
            Properties.Settings.Default.SessionComplete = SessionComplete.Text;
            Properties.Settings.Default.CompleteSession = CompleteSession.Text;
            Properties.Settings.Default.isHealthDataSaved = true;

            kilosave = true;
            bpmsave = true;
            mgsave = true;
            mmsave = true;
            sessionsave = true;
            completesave = true;

            if (kilosave)
            {
                Console.WriteLine("Kilo data is saved.");
            }
            if (bpmsave)
            {
                Console.WriteLine("MMHg data is saved.");
            }
            if (mgsave)
            {
                Console.WriteLine("Kilo data is saved.");
            }
            if (mmsave)
            {
                Console.WriteLine("MMHg data is saved.");
            }

            if (sessionsave)
            {
                Console.WriteLine("Kilo data is saved.");
            }
            if (completesave)
            {
                Console.WriteLine("MMHg data is saved.");
            }

            Properties.Settings.Default.Save();

            DisableInputs();

            MessageBox.Show("Data saved successfully and is now locked!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void DisableInputs()
        {
            Weight.Enabled = false;
            HeartRate.Enabled = false;
            BloodSugarLevel.Enabled = false;
            SYS.Enabled = false;
            DIA.Enabled = false;
            SessionComplete.Enabled = false;
            CompleteSession.Enabled = false;
        }

        private void ValidateForm()
        {
            save.Enabled = !string.IsNullOrWhiteSpace(Weight.Text) &&
                   !string.IsNullOrWhiteSpace(HeartRate.Text) &&
                   !string.IsNullOrWhiteSpace(BloodSugarLevel.Text) &&
                   !string.IsNullOrWhiteSpace(SYS.Text) &&
                   !string.IsNullOrWhiteSpace(DIA.Text) &&
                   !string.IsNullOrWhiteSpace(SessionComplete.Text) &&
                   !string.IsNullOrWhiteSpace(CompleteSession.Text) &&
                   !string.IsNullOrWhiteSpace(SessionComplete.Text) &&
                   !string.IsNullOrWhiteSpace(CompleteSession.Text);
        }

        private void ResetDataButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset the data?",
                                                  "Reset Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Properties.Settings.Default.Weight = string.Empty;
                Properties.Settings.Default.HeartRate = string.Empty;
                Properties.Settings.Default.BloodSugarLevel = string.Empty;
                Properties.Settings.Default.SYS = string.Empty;
                Properties.Settings.Default.DIA = string.Empty;
                Properties.Settings.Default.SessionComplete = string.Empty;
                Properties.Settings.Default.CompleteSession = string.Empty;
                Properties.Settings.Default.isHealthDataSaved = false;

                Properties.Settings.Default.Save();

                ClearFormFields();

                EnableControls();

                MessageBox.Show("Data has been reset successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearFormFields()
        {
            Weight.Clear();
            HeartRate.Clear();
            BloodSugarLevel.Clear();
            SYS.Clear();
            DIA.Clear();
            SessionComplete.Clear();
            CompleteSession.Clear();
        }

        private void EnableControls()
        {
            Weight.Enabled = true;
            HeartRate.Enabled = true;
            BloodSugarLevel.Enabled = true;
            SYS.Enabled = true;
            DIA.Enabled = true;
            SessionComplete.Enabled = true;
            CompleteSession.Enabled = true;
        }

        private void KiloClearFormFields()
        {
            Weight.Clear();
        }

        private void KiloEnableControls()
        {
            Weight.Enabled = true;
        }

        private void BpmClearFormFields()
        {
            HeartRate.Clear();
        }

        private void BpmEnableControls()
        {
            HeartRate.Enabled = true;
        }

        private void MgClearFormFields()
        {
            BloodSugarLevel.Clear();
        }

        private void MgEnableControls()
        {
            BloodSugarLevel.Enabled = true;
        }

        private void MmClearFormFields()
        {
            SYS.Clear();
            DIA.Clear();
        }

        private void MmEnableControls()
        {
            SYS.Enabled = true;
            DIA.Enabled = true;
        }

        private void SeClearFormFields()
        {
            SessionComplete.Clear();
        }

        private void SeEnableControls()
        {
            SessionComplete.Enabled = true;
        }

        private void CoClearFormFields()
        {
            CompleteSession.Clear();
        }

        private void CoEnableControls()
        {
            CompleteSession.Enabled = true;
        }

        private void editkilo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to edit the data?",
                                                  "Edit Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Properties.Settings.Default.Weight = string.Empty;
                Properties.Settings.Default.kilosave = false;

                Properties.Settings.Default.Save();

                KiloClearFormFields();

                KiloEnableControls();

                MessageBox.Show("Data has been edit successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editbpm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to edit the data?",
                                                  "Edit Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Properties.Settings.Default.HeartRate = string.Empty;
                Properties.Settings.Default.bpmsave = false;

                Properties.Settings.Default.Save();

                BpmClearFormFields();

                BpmEnableControls();

                MessageBox.Show("Data has been edit successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editmg_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to edit the data?",
                                                  "Edit Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Properties.Settings.Default.BloodSugarLevel = string.Empty;
                Properties.Settings.Default.mgsave = false;

                Properties.Settings.Default.Save();

                MgClearFormFields();

                MgEnableControls();

                MessageBox.Show("Data has been edit successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editmmhg_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to edit the data?",
                                                  "Edit Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Properties.Settings.Default.SYS = string.Empty;
                Properties.Settings.Default.DIA = string.Empty;
                Properties.Settings.Default.mmsave = false;

                Properties.Settings.Default.Save();

                MmClearFormFields();

                MmEnableControls();

                MessageBox.Show("Data has been edit successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editsessions_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to edit the data?",
                                                  "Edit Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Properties.Settings.Default.SessionComplete = string.Empty;
                Properties.Settings.Default.sessionssave = false;

                Properties.Settings.Default.Save();

                SeClearFormFields();

                SeEnableControls();

                MessageBox.Show("Data has been edit successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Weight_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void HeartRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BloodSugarLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SYS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DIA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SessionComplete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CompleteSession_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void editttttt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to edit the data?",
                                                  "Edit Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Properties.Settings.Default.CompleteSession = string.Empty;
                Properties.Settings.Default.completesave = false;

                Properties.Settings.Default.Save();

                CoClearFormFields();

                CoEnableControls();

                MessageBox.Show("Data has been edit successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
