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
                epfirstname.SetError(txtfirstname, "It cannot be Empty");
                txtfirstname.Focus();
            }
            else if (String.IsNullOrEmpty(txtlastname.Text))
            {
                epfirstname.Clear();
                eplastname.SetError(txtlastname, "It cannot be Empty");
                txtlastname.Focus();
            }
            else if (String.IsNullOrEmpty(txtusername.Text))
            {
                epfirstname.Clear();
                eplastname.Clear();
                epusername.SetError(txtusername, "It cannot be Empty");
                txtusername.Focus();
            }
            else if (String.IsNullOrEmpty(txtpassword.Text))
            {
                epfirstname.Clear();
                eplastname.Clear();
                epusername.Clear();
                eppassword.SetError(txtpassword, "It cannot be Empty");
                txtpassword.Focus();
            }
            else if (String.IsNullOrEmpty(txtcontactnumber.Text))
            {
                epfirstname.Clear();
                eplastname.Clear();
                epusername.Clear();
                eppassword.Clear();
                epcontactnumber.SetError(txtcontactnumber, "It cannot be Empty");
                txtcontactnumber.Focus();
            }
            else if (String.IsNullOrEmpty(txtmail.Text))
            {
                epfirstname.Clear();
                eplastname.Clear();
                epusername.Clear();
                eppassword.Clear();
                epcontactnumber.Clear();
                epmail.SetError(txtmail, "It cannot be Empty");
                txtmail.Focus();
            }
            else if (String.IsNullOrEmpty(txtcity.Text))
            {
                epfirstname.Clear();
                eplastname.Clear();
                epusername.Clear();
                eppassword.Clear();
                epcontactnumber.Clear();
                epmail.Clear();
                epcity.SetError(txtcity, "It cannot be Empty");
                txtcity.Focus();
            }
            else if (rdbmale.IsChecked == false && rdbfemale.IsChecked == false)
            {
                epfirstname.Clear();
                eplastname.Clear();
                epusername.Clear();
                eppassword.Clear();
                epcontactnumber.Clear();
                epmail.Clear();
                epcity.Clear();
                epgender.SetError(panel1, "Please select Gender");
            }
            else if (dropdownrole.SelectedIndex < 0)
            {
                epfirstname.Clear();
                eplastname.Clear();
                epusername.Clear();
                eppassword.Clear();
                epcontactnumber.Clear();
                epmail.Clear();
                epcity.Clear(); epgender.Clear();
                eprole.SetError(dropdownrole, "Please Select a Role");
                dropdownrole.Focus();
            }
            else
            {
                epfirstname.Clear();
                epfirstname.Clear();
                eplastname.Clear();
                epusername.Clear();
                eppassword.Clear();
                epcontactnumber.Clear();
                epmail.Clear();
                epcity.Clear();
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
            }
            Close();
        }


        private void UsersForm_Load(object sender, EventArgs e)
        {
            if (MasterForm.userId > 0)
            {
                btnadduser.Text = "Update";
            }
            else { btnadduser.Text = "Add"; }
        }
    }
}
