using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Data;
using System.Data.SqlClient;
using Telerik.WinControls;

namespace GSMS
{
    public partial class EmailConfigurationForm : RadForm
    {
        public EmailConfigurationForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(Connection.connectionString());
        SqlCommand cmd;

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                erpEmail.SetError(lblGmail, "It cannot be Empty . . .");
                txtEmail.Focus();
            }
            else
            {
                erpEmail.Clear();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                erpPassword.SetError(txtPassword, "It cannot be Empty . . .");
                txtPassword.Focus();
            }
            else
            {
                erpPassword.Clear();
            }
        }

        private void chkShowPassword_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PasswordChar = '\0';
            }
            else { txtPassword.UseSystemPasswordChar = true; }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                erpPassword.Clear();

                erpEmail.SetError(lblGmail, "It cannot be Empty . . .");
                txtEmail.Focus();
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                erpEmail.Clear();

                erpPassword.SetError(txtPassword, "It cannot be Empty . . .");
                txtPassword.Focus();
            }
            else
            {
                erpEmail.Clear();
                erpPassword.Clear();

                cmd = new SqlCommand("CONFIGURE_EMAIL", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EMAIL", (txtEmail.Text + lblGmail.Text));
                cmd.Parameters.AddWithValue("@PASSWORD", txtPassword.Text);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    RadMessageBox.Show("Email Configured . . .", "", MessageBoxButtons.OK, RadMessageIcon.Info);
                    con.Close();
                    this.Close();
                }
                con.Close();
            }
        }

        private void lblHowToCreateAppPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HowToCreateAppPasswordForm h = new HowToCreateAppPasswordForm();
            h.ShowDialog();
        }
    }
}
