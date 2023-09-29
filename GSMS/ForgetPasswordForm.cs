using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace GSMS
{
    public partial class ForgetPasswordForm : RadForm
    {
        public ForgetPasswordForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(Connection.connectionString());
        SqlCommand cmd;
        SqlDataReader dr;
        int timer = 0;
        string workingEmail = "", password = "", OTP = "";
        int id = 0;
        DateTime startTime;

        private int findUser(string email)
        {
            cmd = new SqlCommand("FIND_USER_BY_EMAIL", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EMAIL", email);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                id = Convert.ToInt32(dr["Id"]);
            }
            dr.Close();
            con.Close();
            return id;
        }

        private void getWorkingEmailAndPassword()
        {
            cmd = new SqlCommand("GET_WORKING_EMAIL", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                workingEmail = dr["Email"].ToString();
                password = dr["Password"].ToString();
            }
            else
            {
                RadMessageBox.SetThemeName("MaterialBlueGrey");
                RadMessageBox.Show("Admin have to Configure Email in Settings . . .", "", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            dr.Close();
            con.Close();
        }
        private string generateOTP()
        {
            OTP = "";
            Random rn = new Random();
            OTP += rn.Next(1, 10).ToString();
            OTP += rn.Next(1, 10).ToString();
            OTP += rn.Next(1, 10).ToString();
            OTP += rn.Next(1, 10).ToString();
            return OTP;
        }
        private bool sendEmail(string email)
        {
            try
            {
                // Create a new SmtpClient instance
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");

                getWorkingEmailAndPassword();
                // Specify your SMTP server and port
                smtpClient.Port = 587; // You may need to change this depending on your SMTP server
                smtpClient.Credentials = new NetworkCredential(workingEmail, password);
                smtpClient.EnableSsl = true;

                // Create a new MailMessage
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(workingEmail, "Supermarket Management System");
                mailMessage.To.Add(txtEmail.Text);
                mailMessage.Subject = "OTP";
                mailMessage.Body = generateOTP();

                // Send the email
                smtpClient.Send(mailMessage);

                return true;
            }
            catch (Exception ex)
            {
                RadMessageBox.SetThemeName("MaterialBlueGrey");
                RadMessageBox.Show("An error occurred: " + ex.Message);
            }
            return false;
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailPattern);

            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                erpEmail.SetError(txtEmail, "It cannot be Empty . . .");
                txtEmail.Focus();
            }
            else if (!regex.IsMatch(txtEmail.Text))
            {
                erpEmail.SetError(txtEmail, "Not a Valid Email address . . .");
                txtEmail.Focus();
            }
            else
            {
                erpEmail.Clear();
            }
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                erpNewPassword.SetError(txtNewPassword, "It cannot be Empty . . .");
                txtNewPassword.Focus();
            }
            else
            {
                erpNewPassword.Clear();
            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                erpConfirmPassword.SetError(txtConfirmPassword, "It cannot be Empty . . .");
                txtConfirmPassword.Focus();
            }
            else
            {
                erpConfirmPassword.Clear();
            }
        }

        private void chkShowPassword_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (chkShowPassword.Checked)
            {
                txtNewPassword.UseSystemPasswordChar = txtConfirmPassword.UseSystemPasswordChar = false;
                txtNewPassword.PasswordChar = txtConfirmPassword.PasswordChar = '\0';
            }
            else { txtNewPassword.UseSystemPasswordChar = txtConfirmPassword.UseSystemPasswordChar = true; }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            lblCannotFindEmail.Visible = false;
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                erpEmail.SetError(txtEmail, "It cannot be Empty . . .");
                txtEmail.Focus();
            }
            else
            {
                erpEmail.Clear();
                if (findUser(txtEmail.Text) > 0)
                {
                    if (sendEmail(txtEmail.Text))
                    {
                        RadMessageBox.SetThemeName("MaterialBlueGrey");
                        RadMessageBox.Show("OTP has sent , Check Your Email . . .", "", MessageBoxButtons.OK, RadMessageIcon.Info);
                        timer = 1;
                        startTime = DateTime.Now;
                        txtNo1.Enabled = timer1.Enabled = lblTimer.Visible = true;
                        txtNo1.Focus();
                    }
                }
                else
                {
                    lblCannotFindEmail.Visible = true;
                }
            }
        }

        private void txtNo1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNo1.Text))
            {
                txtNo2.Enabled = false;
            }
            else
            {
                txtNo2.Enabled = true;
                txtNo2.Focus();
            }
        }

        private void txtNo2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNo2.Text))
            {
                txtNo3.Enabled = false;
            }
            else
            {
                txtNo3.Enabled = true;
                txtNo3.Focus();
            }
        }

        private void txtNo3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNo3.Text))
            {
                txtNo4.Enabled = false;
            }
            else
            {
                txtNo4.Enabled = true;
                txtNo4.Focus();
            }
        }

        int totalSeconds = 120; // 2 minutes = 120 seconds


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer >= 0 && timer < 120)
            {
                TimeSpan elapsedTime = DateTime.Now - startTime;
                TimeSpan remainingTime = TimeSpan.FromSeconds(totalSeconds) - elapsedTime;

                string formattedTime = string.Format("{0:D2}:{1:D2}", (int)remainingTime.TotalMinutes, remainingTime.Seconds);
                lblTimer.Text = "Valid Till : " + formattedTime;
            }
            else
            {
                txtNo1.Enabled = timer1.Enabled = false;
                txtNo1.Clear();
                txtNo2.Clear();
                txtNo3.Clear();
                txtNo4.Clear();
                btnSend.Text = "Resend";
                lblTimer.Visible = false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtNo4.Enabled && string.IsNullOrEmpty(txtNo4.Text) == false)
            {
                string enteredOTP = txtNo1.Text + txtNo2.Text + txtNo3.Text + txtNo4.Text;
                if (enteredOTP == OTP)
                {
                    txtNewPassword.Enabled = txtConfirmPassword.Enabled = true;
                    lblTimer.Visible = false;
                }
                else
                {
                    RadMessageBox.SetThemeName("MaterialBlueGrey");
                    RadMessageBox.Show("OTP Doesn't Match . . .", "", MessageBoxButtons.OK, RadMessageIcon.Info);
                }
            }
            else
            {
                txtNewPassword.Enabled = txtConfirmPassword.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                erpConfirmPassword.Clear();

                erpNewPassword.SetError(txtNewPassword, "It cannot be Empty . . .");
                txtNewPassword.Focus();
            }
            else if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                erpNewPassword.Clear();

                erpConfirmPassword.SetError(txtConfirmPassword, "It cannot be Empty . . .");
                txtConfirmPassword.Focus();
            }
            else
            {
                erpNewPassword.Clear();
                erpConfirmPassword.Clear();

                cmd = new SqlCommand("RESET_PASSWORD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@NEW_PASSWORD", txtNewPassword.Text);
                con.Open();
                int r = cmd.ExecuteNonQuery();
                con.Close();
                if (r > 0)
                {
                    RadMessageBox.SetThemeName("MaterialBlueGrey");
                    RadMessageBox.Show("Password Changed Successfully . . .", "", MessageBoxButtons.OK, RadMessageIcon.Info);
                    this.Close();
                }
            }
        }

    }
}
