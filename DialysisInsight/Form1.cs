using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Net.Mail;

namespace DialysisInsight
{
    public partial class Form1 : Form
    {
        private OleDbConnection con;
        public Form1()
        {
            InitializeComponent();
            con = new OleDbConnection(DialysisInsight.ConnectionString);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string trimmedEmail = email.Text.Trim().ToLower();
            string passwordInput = password.Text;

            if (string.IsNullOrWhiteSpace(trimmedEmail) || string.IsNullOrWhiteSpace(passwordInput))
            {
                MessageBox.Show("Email and password cannot be empty.");
                return;
            }

            try
            {
                con.Open();

                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [user] WHERE email = ? AND [password] = ?", con);
                cmd.Parameters.AddWithValue("?", trimmedEmail);
                cmd.Parameters.AddWithValue("?", passwordInput);

                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked)
            {
                password.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';
            }
        }

        private void forgotpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string trimmedEmail = email.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(trimmedEmail))
            {
                MessageBox.Show("Please enter your email before proceeding.");
                return;
            }

            try
            {
                con.Open();

                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [user] WHERE email = ?", con);
                cmd.Parameters.AddWithValue("?", trimmedEmail);

                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    Otp otp = new Otp(trimmedEmail, "ForgotPassword");
                    otp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void createaccount_Click(object sender, EventArgs e)
        {
            CreateAccount createaccount = new CreateAccount();
            createaccount.Show();
            this.Hide();
        }
    }
}