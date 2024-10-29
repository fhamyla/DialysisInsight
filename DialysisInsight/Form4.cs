﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.OleDb;

namespace DialysisInsight
{
    public partial class Otp : Form
    {
        private string generatedOtp = "";
        private string userEmail = "";
        private DateTime lastOtpSentTime;
        private TimeSpan resendCooldown = TimeSpan.FromMinutes(1);

        public Otp()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Otp_Load(object sender, EventArgs e)
        {
            userEmail = FetchUserEmail();
            if (!string.IsNullOrEmpty(userEmail))
            {
                generatedOtp = GenerateOtp();
                SendOtpToEmail(userEmail, generatedOtp);
            }
            else
            {
                MessageBox.Show("Email not found.");
            }
        }

        private string FetchUserEmail()
        {
            string email = "";
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\DialysisInsight\DialysisInsight\bin\Debug\user.mdb";
            string query = "SELECT email FROM user WHERE ID = 1"; 

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        email = reader["email"]?.ToString() ?? "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error accessing database: " + ex.Message);
                }
            }
            return email ?? "";
        }

        private string GenerateOtp()
        {
            Random random = new Random();
            return random.Next(1000, 9999).ToString();
        }

        private void SendOtpToEmail(string email, string otp)
        {
            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress("fhamyla.devera@gmail.com");
                message.To.Add(email);
                message.Subject = "Your OTP Code";
                message.Body = $"Your OTP code is: {otp}";

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.Credentials = new System.Net.NetworkCredential("fhamyla.devera@gmail.com", "ligs qoqe zeox guar\r\n");
                smtpClient.EnableSsl = true;
                smtpClient.Send(message);

                MessageBox.Show("OTP sent to your email.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending OTP: " + ex.Message);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            CreateAccount createaccount = new CreateAccount();
            createaccount.Show();
            this.Hide();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 1)
            {
                TextBox2.Focus();
            }
        }

        private void TextBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (TextBox2.Text.Length == 1)
            {
                TextBox3.Focus();
            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (TextBox3.Text.Length == 1)
            {
                TextBox4.Focus();
            }
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            if (TextBox4.Text.Length == 1)
            {
                verify.Focus();
            }
        }

        private void linkresendotp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DateTime.Now - lastOtpSentTime < resendCooldown)
            {
                MessageBox.Show("Please wait before requesting a new OTP.");
                return;
            }

            if (!string.IsNullOrEmpty(userEmail))
            {
                generatedOtp = GenerateOtp();

                SendOtpToEmail(userEmail, generatedOtp);

                lastOtpSentTime = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Email not found. Cannot resend OTP.");
            }
        }

        private void verify_Click(object sender, EventArgs e)
        {
            string enteredOtp = TextBox1.Text + TextBox2.Text + TextBox3.Text + TextBox4.Text;
            if (enteredOtp == generatedOtp)
            {
                MessageBox.Show("OTP verified successfully!");
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect OTP. Please try again.");
            }
        }
    }
}