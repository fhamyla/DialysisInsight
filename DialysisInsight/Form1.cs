using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Net.Mail;

namespace DialysisInsight
{
    public partial class Form1 : Form
    {
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\DialysisInsight\\DialysisInsight\\bin\\Debug\\user.mdb");
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
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Users WHERE Email = ? AND Password = ?", con);
                cmd.Parameters.AddWithValue("@Email", email.Text);
                cmd.Parameters.AddWithValue("@Password", password.Text);

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
            Otp otp = new Otp();
            otp.Show();
            this.Hide();
        }

        private void createaccount_Click(object sender, EventArgs e)
        {
            CreateAccount createaccount = new CreateAccount();
            createaccount.Show();
            this.Hide();
        }
    }
}