using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Data.SqlClient;

namespace GSMS
{
    public partial class UsersForm : Telerik.WinControls.UI.RadForm
    {
        SqlConnection con = new SqlConnection(Connection.connectionString());
        SqlCommand cmd;
        public string role = "";
        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            if (MasterForm.userId > 0)
            {
                btnadduser.Text = "Update";
            }
            else { btnadduser.Text = "Add"; }
        }

        private void performOperation(string query)
        {
            int gender = 1;
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            if (MasterForm.userId > 0)
            {
                cmd.Parameters.AddWithValue("@ID", MasterForm.userId);
            }
            else
            {
                cmd.Parameters.AddWithValue("@CREATEDDATE", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
                cmd.Parameters.AddWithValue("@CREATEDBY", LoginForm.loggedInUserId);
            }
            cmd.Parameters.AddWithValue("@FNAME", txtfirstname.Text);
            cmd.Parameters.AddWithValue("@LNAME", txtlastname.Text);
            cmd.Parameters.AddWithValue("@UNAME", txtusername.Text);
            cmd.Parameters.AddWithValue("@PASSWORD", txtpassword.Text);
            cmd.Parameters.AddWithValue("@PHONENO", txtcontactnumber.Text);
            cmd.Parameters.AddWithValue("@EMAIL", txtmail.Text);
            if (rdbfemale.IsChecked)
            {
                gender = 0;
            }
            cmd.Parameters.AddWithValue("@GENDER", gender);
            cmd.Parameters.AddWithValue("@UPDATEDDATE", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
            cmd.Parameters.AddWithValue("@UPDATEDBY", LoginForm.loggedInUserId);
            cmd.Parameters.AddWithValue("@ROLE", role);
            cmd.Parameters.AddWithValue("@CITY", txtcity.Text);
            cmd.ExecuteNonQuery();
        }
        private void btnadduser_Click(object sender, EventArgs e)
        {
            role = "";
            if (String.IsNullOrEmpty(txtfirstname.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtlastname);
                validatorForTextBoxes.ClearErrorStatus(txtusername);
                validatorForTextBoxes.ClearErrorStatus(txtpassword);
                validatorForTextBoxes.ClearErrorStatus(txtcontactnumber);
                validatorForTextBoxes.ClearErrorStatus(txtmail);
                validatorForTextBoxes.ClearErrorStatus(txtcity);
                epgender.Clear();
                eprole.Clear();

                validatorForTextBoxes.Validate(txtfirstname);
                txtfirstname.Focus();
            }
            else if (String.IsNullOrEmpty(txtlastname.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtfirstname);
                validatorForTextBoxes.ClearErrorStatus(txtusername);
                validatorForTextBoxes.ClearErrorStatus(txtpassword);
                validatorForTextBoxes.ClearErrorStatus(txtcontactnumber);
                validatorForTextBoxes.ClearErrorStatus(txtmail);
                validatorForTextBoxes.ClearErrorStatus(txtcity);
                epgender.Clear();
                eprole.Clear();

                validatorForTextBoxes.Validate(txtlastname);
                txtlastname.Focus();
            }
            else if (String.IsNullOrEmpty(txtusername.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtfirstname);
                validatorForTextBoxes.ClearErrorStatus(txtlastname);
                validatorForTextBoxes.ClearErrorStatus(txtpassword);
                validatorForTextBoxes.ClearErrorStatus(txtcontactnumber);
                validatorForTextBoxes.ClearErrorStatus(txtmail);
                validatorForTextBoxes.ClearErrorStatus(txtcity);
                epgender.Clear();
                eprole.Clear();

                validatorForTextBoxes.Validate(txtusername);
                txtusername.Focus();
            }
            else if (String.IsNullOrEmpty(txtpassword.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtfirstname);
                validatorForTextBoxes.ClearErrorStatus(txtlastname);
                validatorForTextBoxes.ClearErrorStatus(txtusername);
                validatorForTextBoxes.ClearErrorStatus(txtcontactnumber);
                validatorForTextBoxes.ClearErrorStatus(txtmail);
                validatorForTextBoxes.ClearErrorStatus(txtcity);
                epgender.Clear();
                eprole.Clear();

                validatorForTextBoxes.Validate(txtpassword);
                txtpassword.Focus();
            }
            else if (String.IsNullOrEmpty(txtcontactnumber.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtfirstname);
                validatorForTextBoxes.ClearErrorStatus(txtlastname);
                validatorForTextBoxes.ClearErrorStatus(txtusername);
                validatorForTextBoxes.ClearErrorStatus(txtpassword);
                validatorForTextBoxes.ClearErrorStatus(txtmail);
                validatorForTextBoxes.ClearErrorStatus(txtcity);
                epgender.Clear();
                eprole.Clear();

                validatorForTextBoxes.Validate(txtcontactnumber);
                txtcontactnumber.Focus();
            }
            else if (String.IsNullOrEmpty(txtmail.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtfirstname);
                validatorForTextBoxes.ClearErrorStatus(txtlastname);
                validatorForTextBoxes.ClearErrorStatus(txtusername);
                validatorForTextBoxes.ClearErrorStatus(txtpassword);
                validatorForTextBoxes.ClearErrorStatus(txtcontactnumber);
                validatorForTextBoxes.ClearErrorStatus(txtcity);
                epgender.Clear();
                eprole.Clear();

                validatorForTextBoxes.Validate(txtmail);
                txtmail.Focus();
            }
            else if (String.IsNullOrEmpty(txtcity.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtfirstname);
                validatorForTextBoxes.ClearErrorStatus(txtlastname);
                validatorForTextBoxes.ClearErrorStatus(txtusername);
                validatorForTextBoxes.ClearErrorStatus(txtpassword);
                validatorForTextBoxes.ClearErrorStatus(txtcontactnumber);
                validatorForTextBoxes.ClearErrorStatus(txtmail);
                epgender.Clear();
                eprole.Clear();

                validatorForTextBoxes.Validate(txtcity);
                txtcity.Focus();
            }
            else if (rdbmale.IsChecked == false && rdbfemale.IsChecked == false)
            {
                validatorForTextBoxes.ClearErrorStatus(txtfirstname);
                validatorForTextBoxes.ClearErrorStatus(txtlastname);
                validatorForTextBoxes.ClearErrorStatus(txtusername);
                validatorForTextBoxes.ClearErrorStatus(txtpassword);
                validatorForTextBoxes.ClearErrorStatus(txtcontactnumber);
                validatorForTextBoxes.ClearErrorStatus(txtmail);
                validatorForTextBoxes.ClearErrorStatus(txtcity);
                eprole.Clear();

                epgender.SetError(panel1, "Please select Gender");
            }
            else if (dropdownrole.SelectedIndex < 0)
            {
                validatorForTextBoxes.ClearErrorStatus(txtfirstname);
                validatorForTextBoxes.ClearErrorStatus(txtlastname);
                validatorForTextBoxes.ClearErrorStatus(txtusername);
                validatorForTextBoxes.ClearErrorStatus(txtpassword);
                validatorForTextBoxes.ClearErrorStatus(txtcontactnumber);
                validatorForTextBoxes.ClearErrorStatus(txtmail);
                validatorForTextBoxes.ClearErrorStatus(txtcity);
                epgender.Clear();

                eprole.SetError(dropdownrole, "Please Select a Role");
                dropdownrole.Focus();
            }
            else
            {
                validatorForTextBoxes.ClearErrorStatus(txtfirstname);
                validatorForTextBoxes.ClearErrorStatus(txtlastname);
                validatorForTextBoxes.ClearErrorStatus(txtusername);
                validatorForTextBoxes.ClearErrorStatus(txtpassword);
                validatorForTextBoxes.ClearErrorStatus(txtcontactnumber);
                validatorForTextBoxes.ClearErrorStatus(txtmail);
                validatorForTextBoxes.ClearErrorStatus(txtcity);
                epgender.Clear();
                eprole.Clear();

                role = dropdownrole.SelectedItem.ToString();
                con.Open();
                string query = "INSERT_USER";
                if (MasterForm.userId > 0)
                {
                    query = "UPDATE_USER";
                }
                performOperation(query);
                con.Close();
                Close();
            }
        }

        private void txtfirstname_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtfirstname.Text))
            {
                validatorForTextBoxes.Validate(txtfirstname);
                txtfirstname.Focus();
            }
            else { validatorForTextBoxes.ClearErrorStatus(txtfirstname); }
        }

        private void txtlastname_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtlastname.Text))
            {
                validatorForTextBoxes.Validate(txtlastname);
                txtlastname.Focus();
            }
            else { validatorForTextBoxes.ClearErrorStatus(txtlastname); }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtusername.Text))
            {
                validatorForTextBoxes.Validate(txtusername);
                txtusername.Focus();
            }
            else { validatorForTextBoxes.ClearErrorStatus(txtusername); }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtpassword.Text))
            {
                validatorForTextBoxes.Validate(txtpassword);
                txtpassword.Focus();
            }
            else { validatorForTextBoxes.ClearErrorStatus(txtpassword); }
        }

        private void txtcontactnumber_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtcontactnumber.Text))
            {
                validatorForTextBoxes.Validate(txtcontactnumber);
                txtcontactnumber.Focus();
            }
            else { validatorForTextBoxes.ClearErrorStatus(txtcontactnumber); }
        }

        private void txtmail_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtmail.Text))
            {
                validatorForTextBoxes.Validate(txtmail);
                txtmail.Focus();
            }
            else { validatorForTextBoxes.ClearErrorStatus(txtmail); }
        }

        private void txtcity_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtcity.Text))
            {
                validatorForTextBoxes.Validate(txtcity);
                txtcity.Focus();
            }
            else { validatorForTextBoxes.ClearErrorStatus(txtcity); }
        }

        private void dropdownrole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropdownrole.SelectedIndex < 0)
            {
                eprole.SetError(dropdownrole, "Please Select Role...");
                dropdownrole.Focus();
            }
            else { eprole.Clear(); }
        }

        private void txtcontactnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If it's not a digit or a control character, suppress the keypress event
                e.Handled = true;
            }
        }
    }
}
