using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Net.Mail;

namespace DialysisInsight
{
    public partial class Form1 : Form
    {
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\DialysisInsight\\DialysisInsight\\db\\user.mdb");
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email.Text) || string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Email and password cannot be empty.");
                return;
            }

            try
            {
                con.Open();

                // Use square brackets to avoid issues with reserved keywords
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [user] WHERE email = ? AND [password] = ?", con);

                // Match parameter order with the query
                cmd.Parameters.AddWithValue("?", email.Text);
                cmd.Parameters.AddWithValue("?", password.Text);

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
            if (string.IsNullOrWhiteSpace(email.Text))
            {
                MessageBox.Show("Please enter your email before proceeding.");
                return;
            }

            try
            {
                con.Open();

                // Again, wrap 'user' in square brackets to avoid conflicts
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [user] WHERE email = ?", con);
                cmd.Parameters.AddWithValue("?", email.Text);

                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    Otp otp = new Otp();
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