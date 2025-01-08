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
        private Rectangle recemail;
        private Rectangle recedit;
        private Rectangle recpass;
        private Rectangle receditt;
        private Rectangle recmuni;
        private Rectangle recpro;
        private Rectangle recreg;
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
        private string? originalEmail;
        private string? originalPassword;
        public Settings()
        {
            InitializeComponent();
            this.Resize += Dashboard_Resiz;
            LoadUserData();
            InitializeUserFields();
            formOriginalSize = this.Size;
            recminmax = new Rectangle(minmax.Location, minmax.Size);
            recpanel1 = new Rectangle(guna2Panel1.Location, guna2Panel1.Size);
            recfirstname = new Rectangle(firstname.Location, firstname.Size);
            recmiddlename = new Rectangle(middlename.Location, middlename.Size);
            reclastname = new Rectangle(lastname.Location, lastname.Size);
            recdate = new Rectangle(datebirth.Location, datebirth.Size);
            recemail = new Rectangle(email.Location, email.Size);
            recedit = new Rectangle(edit.Location, edit.Size);
            recpass = new Rectangle(password.Location, password.Size);
            receditt = new Rectangle(edit2.Location, edit2.Size);
            recmuni = new Rectangle(municipality.Location, municipality.Size);
            recpro = new Rectangle(province.Location, province.Size);
            recreg = new Rectangle(region.Location, region.Size);
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
        }

        private void Dashboard_Resiz(object? sender, EventArgs e)
        {
            resize_Control(minmax, recminmax);
            resize_Control(guna2Panel1, recpanel1);
            resize_Control(firstname, recfirstname);
            resize_Control(middlename, recmiddlename);
            resize_Control(lastname, reclastname);
            resize_Control(datebirth, recdate);
            resize_Control(email, recemail);
            resize_Control(edit, recedit);
            resize_Control(password, recpass);
            resize_Control(edit2, receditt);
            resize_Control(municipality, recmuni);
            resize_Control(province, recpro);
            resize_Control(region, recreg);
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

        private void LoadUserData()
        {
            string connectionString = DialysisInsight.ConnectionString;
            string userEmail = email.Text.Trim();
            string userPassword = password.Text.Trim();

            string query = "SELECT email, password FROM [user] WHERE email = ? AND password = ?";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", userEmail);
                        command.Parameters.AddWithValue("?", userPassword);

                        OleDbDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            // Retrieve data and update textboxes
                            email.Text = reader["email"]?.ToString() ?? string.Empty;
                            password.Text = reader["password"]?.ToString() ?? string.Empty;

                            MessageBox.Show("User data loaded successfully.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void middlename_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void datebirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeUserFields()
        {
            email.ReadOnly = true;
            password.ReadOnly = true;

            // Optionally mask the password
            password.PasswordChar = '*'; // Uncomment if using a standard TextBox
        }

        private void SaveEmailToDatabase(string newEmail)
        {
            string query = "UPDATE [user] SET email = @newEmail WHERE ID = 1";
            using (OleDbConnection connection = new OleDbConnection(DialysisInsight.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@newEmail", newEmail);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating email: " + ex.Message);
                }
            }
        }

        private void SavePasswordToDatabase(string newPassword)
        {
            string query = "UPDATE [user] SET password = @newPassword WHERE ID = 1";
            using (OleDbConnection connection = new OleDbConnection(DialysisInsight.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@newPassword", newPassword);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating password: " + ex.Message);
                }
            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void edit_Click(object sender, EventArgs e)
        {
            string currentEmail = email.Text;
            Otp otpForm = new Otp(currentEmail, "EmailEdit");
            otpForm.ShowDialog();

            // Step 2: Enable email text box for editing after OTP verification
            if (otpForm.IsOtpVerified)
            {
                email.ReadOnly = false; // Make the email text box editable
                MessageBox.Show("OTP verified. You can now edit your email.");
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void edit2_Click(object sender, EventArgs e)
        {
            string currentEmail = email.Text;
            Otp otpForm = new Otp(currentEmail, "PasswordEdit");
            otpForm.ShowDialog();

            // Step 2: Enable password text box for editing after OTP verification
            if (otpForm.IsOtpVerified)
            {
                password.ReadOnly = false; // Make the password text box editable
                MessageBox.Show("OTP verified. You can now edit your password.");
            }
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

        }

        private void oneday_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void onehour_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ProfileManagement_Click(object sender, EventArgs e)
        {

        }

        private void manage_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!email.ReadOnly && email.Text != originalEmail)
            {
                string newEmail = email.Text;

                // Step 2: Send OTP to the new email
                Otp otpForm = new Otp(newEmail, "NewEmailVerification");
                otpForm.ShowDialog();

                if (!otpForm.IsOtpVerified)
                {
                    MessageBox.Show("OTP verification failed. Email not updated.");
                    return;
                }

                // Step 3: Save the new email to the database
                SaveEmailToDatabase(newEmail);
                originalEmail = newEmail;
            }

            // Step 4: Save the new password to the database if it was edited
            if (!password.ReadOnly && password.Text != originalPassword)
            {
                SavePasswordToDatabase(password.Text);
                originalPassword = password.Text;
            }

            MessageBox.Show("Changes saved successfully.");
            email.ReadOnly = true;
            password.ReadOnly = true;
        }

        private void notifcontrol_Click(object sender, EventArgs e)
        {

        }

        private void NotificationPreferences_Click(object sender, EventArgs e)
        {

        }
    }
}
