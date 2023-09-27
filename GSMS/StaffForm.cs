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
using System.Text.RegularExpressions;

namespace GSMS
{
    public partial class StaffForm : RadForm
    {
        SqlConnection con = new SqlConnection(Connection.connectionString());
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt = new DataTable();

        public StaffForm()
        {
            InitializeComponent();
        }
        private void getDepartments()
        {
            Dictionary<int, string> source = new Dictionary<int, string>();
            source.Clear();
            dt.Clear();

            da = new SqlDataAdapter("EXEC SELECT_ACTIVE_DEPARTMENTS", con);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    source.Add(Convert.ToInt32(row.ItemArray[0]), row.ItemArray[1].ToString());
                }

                drpdepartment.DataSource = new BindingSource(source, null);
                drpdepartment.DisplayMember = "Value";
                drpdepartment.ValueMember = "Key";
            }
        }

        private void performOperation(string query)
        {
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            if (MasterForm.staffMemberId > 0)
            {
                cmd.Parameters.AddWithValue("@ID", MasterForm.staffMemberId);
            }
            else
            {
                cmd.Parameters.AddWithValue("@CREATEDDATE", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
                cmd.Parameters.AddWithValue("@CREATEDBY", LogInForm2.loggedInUserId);
            }
            cmd.Parameters.AddWithValue("@FNAME", txtfirstname.Text);
            cmd.Parameters.AddWithValue("@LNAME", txtlastname.Text);
            cmd.Parameters.AddWithValue("@PHONE", txtcontactnumber.Text);
            cmd.Parameters.AddWithValue("@EMAIL", txtmail.Text);
            byte gender = 1;
            if (rdbfemale.IsChecked)
            {
                gender = 0;
            }
            cmd.Parameters.AddWithValue("@GENDER", gender);
            cmd.Parameters.AddWithValue("@ADDRESS", txtaddress.Text);
            cmd.Parameters.AddWithValue("@DEPARTMENTID", drpdepartment.SelectedValue);
            cmd.Parameters.AddWithValue("@SALARY", spineditorsalary.Value);
            cmd.Parameters.AddWithValue("@JOINDATE", datetimejointdate.Value.ToString("MM/dd/yyyy"));
            cmd.Parameters.AddWithValue("@LASTUPDATED", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
            cmd.Parameters.AddWithValue("@UPDATEDBY", LogInForm2.loggedInUserId);
            cmd.ExecuteNonQuery();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            getDepartments();
            if (MasterForm.staffMemberId > 0)
            {
                btnaddstaffmember.Text = "Update";
                drpdepartment.SelectedValue = MasterForm.departmentId;
            }
            else
            {
                btnaddstaffmember.Text = "Add";
            }
        }

        private void txtfirstname_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtfirstname.Text))
            {
                validatorForTextBoxes.Validate(txtfirstname);
            }
            else
            {
                validatorForTextBoxes.ClearErrorStatus(txtfirstname);
            }
        }

        private void txtlastname_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtlastname.Text))
            {
                validatorForTextBoxes.Validate(txtlastname);
            }
            else
            {
                validatorForTextBoxes.ClearErrorStatus(txtlastname);
            }
        }

        private void txtcontactnumber_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtcontactnumber.Text))
            {
                validatorForTextBoxes.Validate(txtcontactnumber);
            }
            else
            {
                validatorForTextBoxes.ClearErrorStatus(txtcontactnumber);
            }
        }

        private void txtmail_TextChanged(object sender, EventArgs e)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailPattern);

            if (String.IsNullOrEmpty(txtmail.Text))
            {
                validatorForTextBoxes.Validate(txtmail);
            }
            else if (!regex.IsMatch(txtmail.Text))
            {
                erpEmail.SetError(txtmail, "Not a Valid Email address . . .");
                txtmail.Focus();
            }
            else
            {
                validatorForTextBoxes.ClearErrorStatus(txtmail);
                erpEmail.Clear();
            }
        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtaddress.Text))
            {
                validatorForTextBoxes.Validate(txtaddress);
            }
            else
            {
                validatorForTextBoxes.ClearErrorStatus(txtaddress);
            }
        }

        private void spineditorsalary_ValueChanged(object sender, EventArgs e)
        {
            if (spineditorsalary.Value == 0)
            {
                validatorForSpinEditor.Validate(spineditorsalary);
            }
            else
            {
                validatorForSpinEditor.ClearErrorStatus(spineditorsalary);
            }
        }

        private void txtcontactnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If it's not a digit or a control character, suppress the keypress event
                e.Handled = true;
            }
        }
        private void btnaddstaffmember_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtfirstname.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtlastname);
                validatorForTextBoxes.ClearErrorStatus(txtcontactnumber);
                validatorForTextBoxes.ClearErrorStatus(txtmail);
                validatorForTextBoxes.ClearErrorStatus(txtaddress);
                erpdepartment.Clear();
                validatorForSpinEditor.ClearErrorStatus(spineditorsalary);

                validatorForTextBoxes.Validate(txtfirstname);
                txtfirstname.Focus();
            }
            else if (String.IsNullOrEmpty(txtlastname.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtfirstname);
                validatorForTextBoxes.ClearErrorStatus(txtcontactnumber);
                validatorForTextBoxes.ClearErrorStatus(txtmail);
                validatorForTextBoxes.ClearErrorStatus(txtaddress);
                erpdepartment.Clear();
                validatorForSpinEditor.ClearErrorStatus(spineditorsalary);

                validatorForTextBoxes.Validate(txtlastname);
                txtlastname.Focus();
            }
            else if (String.IsNullOrEmpty(txtcontactnumber.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtfirstname);
                validatorForTextBoxes.ClearErrorStatus(txtlastname);
                validatorForTextBoxes.ClearErrorStatus(txtmail);
                validatorForTextBoxes.ClearErrorStatus(txtaddress);
                erpdepartment.Clear();
                validatorForSpinEditor.ClearErrorStatus(spineditorsalary);

                validatorForTextBoxes.Validate(txtcontactnumber);
                txtcontactnumber.Focus();
            }
            else if (String.IsNullOrEmpty(txtmail.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtfirstname);
                validatorForTextBoxes.ClearErrorStatus(txtlastname);
                validatorForTextBoxes.ClearErrorStatus(txtcontactnumber);
                validatorForTextBoxes.ClearErrorStatus(txtaddress);
                validatorForSpinEditor.ClearErrorStatus(spineditorsalary);
                erpdepartment.Clear();

                validatorForTextBoxes.Validate(txtmail);
                txtmail.Focus();
            }
            else if (String.IsNullOrEmpty(txtaddress.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtfirstname);
                validatorForTextBoxes.ClearErrorStatus(txtlastname);
                validatorForTextBoxes.ClearErrorStatus(txtcontactnumber);
                validatorForTextBoxes.ClearErrorStatus(txtmail);
                validatorForSpinEditor.ClearErrorStatus(spineditorsalary);
                erpdepartment.Clear();

                validatorForTextBoxes.Validate(txtaddress);
                txtaddress.Focus();
            }
            else if (drpdepartment.SelectedItem == null)
            {
                validatorForTextBoxes.ClearErrorStatus(txtfirstname);
                validatorForTextBoxes.ClearErrorStatus(txtlastname);
                validatorForTextBoxes.ClearErrorStatus(txtcontactnumber);
                validatorForTextBoxes.ClearErrorStatus(txtmail);
                validatorForTextBoxes.ClearErrorStatus(txtaddress);
                validatorForSpinEditor.ClearErrorStatus(spineditorsalary);

                erpdepartment.SetError(drpdepartment, "Please Select Deartment ...!");
            }
            else if (spineditorsalary.Value == 0)
            {
                validatorForTextBoxes.ClearErrorStatus(txtfirstname);
                validatorForTextBoxes.ClearErrorStatus(txtlastname);
                validatorForTextBoxes.ClearErrorStatus(txtcontactnumber);
                validatorForTextBoxes.ClearErrorStatus(txtmail);
                validatorForTextBoxes.ClearErrorStatus(txtaddress);
                erpdepartment.Clear();

                validatorForSpinEditor.Validate(spineditorsalary);
                spineditorsalary.Focus();
            }
            else
            {
                validatorForTextBoxes.ClearErrorStatus(txtfirstname);
                validatorForTextBoxes.ClearErrorStatus(txtlastname);
                validatorForTextBoxes.ClearErrorStatus(txtcontactnumber);
                validatorForTextBoxes.ClearErrorStatus(txtmail);
                validatorForTextBoxes.ClearErrorStatus(txtaddress);
                validatorForSpinEditor.ClearErrorStatus(spineditorsalary);
                erpdepartment.Clear();

                string query = "INSERT_STAFF_MEMBER";
                if (MasterForm.staffMemberId>0)
                {
                    query = "UPDATE_STAFF_MEMBER";
                }
                con.Open();
                performOperation(query);
                con.Close();
                this.Close();
            }
        }

        private void drpdepartment_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(drpdepartment.Text) || drpdepartment.Text == "Select Department")
            {
                erpdepartment.SetError(drpdepartment, "Please Select Department ...!");
            }
            else { erpdepartment.Clear(); }
        }

        private void txtfirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Suppress the input if it's not a letter or white space
            }
        }

        private void txtlastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Suppress the input if it's not a letter or white space
            }
        }
    }
}
