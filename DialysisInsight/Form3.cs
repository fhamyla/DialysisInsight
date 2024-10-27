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

namespace DialysisInsight
{
    public partial class CreateAccount : Form
    {
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\DialysisInsight\\DialysisInsight\\bin\\Debug\\user.mdb");
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

        private void create_Click(object sender, EventArgs e)
        {
            if (password.Text == confirmpassword.Text)
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand("INSERT INTO Users (Email, Password) VALUES (?, ?)", con);
                    cmd.Parameters.AddWithValue("@Email", email.Text);
                    cmd.Parameters.AddWithValue("@Password", password.Text);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Account created successfully!");
                        Otp otp = new Otp();
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
            else
            {
                MessageBox.Show("Passwords do not match.");
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