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

        private void perfomOperation(string query)
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
                perfomOperation(query);
                con.Close();
                Close();
            }
        }


        private void UsersForm_Load(object sender, EventArgs e)
        {
            if (MasterForm.userId > 0)
            {
                btnadduser.Text = "Update";
            }
            else { btnadduser.Text = "Add"; }
        }

        private void radValidationProvider1_ControlValidation(object sender, RadValidationEventArgs e)
        {
        }
    }
}
