using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Net.WebRequestMethods;
using System.Net.Mail;

namespace DialysisInsight
{
    public partial class CreateAccount : Form
    {
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\DialysisInsight\\DialysisInsight\\db\\user.mdb");
        public CreateAccount()
        {

            InitializeComponent();

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked)
            {
                password.PasswordChar = '\0';
                confirmpassword.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';
                confirmpassword.PasswordChar = '*';
            }
        }

        private bool IsEmailRegistered(string email)
        {
            string trimmedEmail = email.Trim();

            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM [user] WHERE email = ?", con);
                cmd.Parameters.AddWithValue("?", trimmedEmail);

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int count = reader.GetInt32(0);
                        return count > 0;
                    }
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

            return false;
        }

        private void create_Click(object sender, EventArgs e)
        {
            string trimmedEmail = email.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(trimmedEmail) || string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Email and password cannot be empty.");
                return;
            }

            if (password.Text != confirmpassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (IsEmailRegistered(trimmedEmail))
            {
                MessageBox.Show("Email is already registered. Please use a different email.");
                return;
            }

            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("INSERT INTO [user] (email, [password]) VALUES (?, ?)", con);
                cmd.Parameters.AddWithValue("?", trimmedEmail);
                cmd.Parameters.AddWithValue("password", password.Text);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Account created successfully!");
                    Otp otp = new Otp(trimmedEmail);
                    otp.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error creating account.");
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

        private void login_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}