using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialysisInsight
{
    public partial class Settings : Form
    {
        private Size formOriginalSize;
        private Rectangle recminmax;
        private Rectangle recpanel1;
        private Rectangle recfirstname;
        private Rectangle recmiddlename;
        private Rectangle reclastname;
        private Rectangle recdate;
        private Rectangle recmuni;
        private Rectangle recpro;
        private Rectangle recappo;
        private Rectangle recmed;
        private Rectangle reconeday;
        private Rectangle reconehour;
        private Rectangle recprof;
        private Rectangle recmanage;
        private Rectangle recback;
        private Rectangle recsave;
        private Rectangle recnotif;
        private Rectangle recnotifpre;
        public Settings()
        {
            InitializeComponent();
            this.Resize += Dashboard_Resiz;
            formOriginalSize = this.Size;
            recminmax = new Rectangle(minmax.Location, minmax.Size);
            recpanel1 = new Rectangle(guna2Panel1.Location, guna2Panel1.Size);
            recfirstname = new Rectangle(firstname.Location, firstname.Size);
            recmiddlename = new Rectangle(middlename.Location, middlename.Size);
            reclastname = new Rectangle(lastname.Location, lastname.Size);
            recdate = new Rectangle(datebirth.Location, datebirth.Size);
            recmuni = new Rectangle(conditions.Location, conditions.Size);
            recpro = new Rectangle(province.Location, province.Size);
            recappo = new Rectangle(AppointmentReminders.Location, AppointmentReminders.Size);
            recmed = new Rectangle(MedicationReminders.Location, MedicationReminders.Size);
            reconeday = new Rectangle(oneday.Location, oneday.Size);
            reconehour = new Rectangle(onehour.Location, onehour.Size);
            recprof = new Rectangle(ProfileManagement.Location, ProfileManagement.Size);
            recmanage = new Rectangle(manage.Location, manage.Size);
            recback = new Rectangle(back.Location, back.Size);
            recsave = new Rectangle(save.Location, save.Size);
            recnotif = new Rectangle(notifcontrol.Location, notifcontrol.Size);
            recnotifpre = new Rectangle(NotificationPreferences.Location, NotificationPreferences.Size);

            PopulateConditionsComboBox();
            PopulateProvinceComboBox();

            if (Properties.Settings.Default.isDataSaved)
            {
                // Load saved data
                firstname.Text = Properties.Settings.Default.firstname;
                lastname.Text = Properties.Settings.Default.lastname;
                datebirth.Value = DateTime.Parse(Properties.Settings.Default.datebirth);
                conditions.SelectedItem = Properties.Settings.Default.conditions;
                province.SelectedItem = Properties.Settings.Default.province;
                MedicationReminders.Checked = Properties.Settings.Default.MedicationReminders;
                oneday.Checked = Properties.Settings.Default.oneday;
                onehour.Checked = Properties.Settings.Default.onehour;

                // Disable inputs to prevent editing
                DisableInputs();
            }
        }

        private void Dashboard_Resiz(object? sender, EventArgs e)
        {
            resize_Control(minmax, recminmax);
            resize_Control(guna2Panel1, recpanel1);
            resize_Control(firstname, recfirstname);
            resize_Control(middlename, recmiddlename);
            resize_Control(lastname, reclastname);
            resize_Control(datebirth, recdate);
            resize_Control(conditions, recmuni);
            resize_Control(province, recpro);
            resize_Control(AppointmentReminders, recappo);
            resize_Control(MedicationReminders, recmed);
            resize_Control(oneday, reconeday);
            resize_Control(onehour, reconehour);
            resize_Control(ProfileManagement, recprof);
            resize_Control(manage, recmanage);
            resize_Control(back, recback);
            resize_Control(save, recsave);
            resize_Control(notifcontrol, recnotif);
            resize_Control(NotificationPreferences, recnotifpre);
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

        private void firstname_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void middlename_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void datebirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void edit_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void edit2_Click(object sender, EventArgs e)
        {

        }

        private void municipality_TextChanged(object sender, EventArgs e)
        {

        }

        private void province_TextChanged(object sender, EventArgs e)
        {

        }

        private void region_TextChanged(object sender, EventArgs e)
        {

        }

        private void AppointmentReminders_Click(object sender, EventArgs e)
        {

        }

        private void MedicationReminders_CheckedChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void oneday_CheckedChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void onehour_CheckedChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void ProfileManagement_Click(object sender, EventArgs e)
        {

        }

        private void manage_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private bool isDataSaved = false;

        private void save_Click(object sender, EventArgs e)
        {
            if (isDataSaved)
            {
                MessageBox.Show("Data has already been saved and cannot be modified.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(firstname.Text) ||
                string.IsNullOrWhiteSpace(lastname.Text) ||
                conditions.SelectedIndex == -1 ||
                province.SelectedIndex == -1 ||
                (datebirth.Value == default(DateTime)) ||
                !MedicationReminders.Checked ||
                (!oneday.Checked && !onehour.Checked))
            {
                MessageBox.Show("Please fill in all required fields before saving.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save data to application settings
            Properties.Settings.Default.firstname = firstname.Text;
            Properties.Settings.Default.lastname = lastname.Text;
            Properties.Settings.Default.datebirth = datebirth.Value.ToString("yyyy-MM-dd");
            Properties.Settings.Default.conditions = conditions.SelectedItem?.ToString() ?? string.Empty;
            Properties.Settings.Default.province = province.SelectedItem?.ToString() ?? string.Empty;
            Properties.Settings.Default.MedicationReminders = MedicationReminders.Checked;
            Properties.Settings.Default.oneday = oneday.Checked;
            Properties.Settings.Default.onehour = onehour.Checked;
            Properties.Settings.Default.isDataSaved = true; // Mark data as saved
            Properties.Settings.Default.Save(); // Save settings permanently

            // Disable inputs after saving
            DisableInputs();

            MessageBox.Show("Data saved successfully and is now locked!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            HealthData healthDataForm = new HealthData();
            healthDataForm.Show();
            this.Close(); // Closes the current form
        }

        private void DisableInputs()
        {
            firstname.Enabled = false;
            lastname.Enabled = false;
            datebirth.Enabled = false;
            conditions.Enabled = false;
            province.Enabled = false;
            MedicationReminders.Enabled = false;
            oneday.Enabled = false;
            onehour.Enabled = false;
        }

        private void ValidateForm()
        {
            save.Enabled = !string.IsNullOrWhiteSpace(firstname.Text) &&
                   !string.IsNullOrWhiteSpace(lastname.Text) &&
                   conditions.SelectedIndex != -1 &&
                   province.SelectedIndex != -1 &&
                   MedicationReminders.Checked && // Ensure checkbox is checked
                   (oneday.Checked || onehour.Checked);
        }

        private void notifcontrol_Click(object sender, EventArgs e)
        {

        }

        private void NotificationPreferences_Click(object sender, EventArgs e)
        {

        }

        private void PopulateConditionsComboBox()
        {
            var conditionsList = new List<string>
            {
                "End-Stage Renal Disease (ESRD)",
                "Acute Kidney Injury (AKI)",
                "Severe Fluid Overload",
                "Severe Hyperkalemia",
                "Uremia",
                "Poisoning or Drug Overdose",
                "Severe Hypertension",
                "Severe Metabolic Acidosis"
            };

            conditions.Items.AddRange(conditionsList.ToArray());
        }

        private void conditions_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void PopulateProvinceComboBox()
        {
            var provinceList = new List<string>
            {
                "Abra",
                "Agusan del Norte",
                "Agusan del Sur",
                "Aklan",
                "Albay",
                "Antique",
                "Apayao",
                "Aurora",
                "Basilan",
                "Bataan",
                "Batanes",
                "Batangas",
                "Benguet",
                "Biliran",
                "Bohol",
                "Bukidnon",
                "Bulacan",
                "Cagayan",
                "Camarines Norte",
                "Camarines Sur",
                "Camiguin",
                "Capiz",
                "Catanduanes",
                "Cavite",
                "Cebu",
                "Compostela Valley",
                "Cotabato",
                "Davao de Oro",
                "Davao del Norte",
                "Davao del Sur",
                "Davao Occidental",
                "Davao Oriental",
                "Dinagat Islands",
                "Eastern Samar",
                "Guimaras",
                "Ifugao",
                "Ilocos Norte",
                "Ilocos Sur",
                "Iloilo",
                "Isabela",
                "Kalinga",
                "La Union",
                "Laguna",
                "Lanao del Norte",
                "Lanao del Sur",
                "Leyte",
                "Maguindanao del Norte",
                "Maguindanao del Sur",
                "Marinduque",
                "Masbate",
                "Misamis Occidental",
                "Misamis Oriental",
                "Mountain Province",
                "Negros Occidental",
                "Negros Oriental",
                "Northern Samar",
                "Nueva Ecija",
                "Nueva Vizcaya",
                "Occidental Mindoro",
                "Oriental Mindoro",
                "Palawan",
                "Pampanga",
                "Pangasinan",
                "Quezon",
                "Quirino",
                "Rizal",
                "Romblon",
                "Samar",
                "Sarangani",
                "Siquijor",
                "Sorsogon",
                "South Cotabato",
                "Southern Leyte",
                "Sultan Kudarat",
                "Sulu",
                "Surigao del Norte",
                "Surigao del Sur",
                "Tarlac",
                "Tawi-Tawi",
                "Zambales",
                "Zamboanga del Norte",
                "Zamboanga del Sur",
                "Zamboanga Sibugay"
            };

            province.Items.AddRange(provinceList.ToArray());
        }

        private void province_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void datebirth_ValueChanged(object sender, EventArgs e)
        {
            datebirth.MaxDate = DateTime.Now; // Maximum date is today
            datebirth.MinDate = new DateTime(1908, 6, 8);
            DateTime selectedDate = datebirth.Value;
            ValidateForm();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
