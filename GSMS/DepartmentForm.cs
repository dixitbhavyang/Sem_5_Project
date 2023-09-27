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
    public partial class DepartmentForm : RadForm
    {
        SqlConnection con = new SqlConnection(Connection.connectionString());
        SqlCommand cmd;
        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void performOperation(string query)
        {
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            if (MasterForm.departmentId > 0)
            {
                cmd.Parameters.AddWithValue("@ID", MasterForm.departmentId);
            }
            else
            {
                cmd.Parameters.AddWithValue("@CREATEDDATE", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
                cmd.Parameters.AddWithValue("@CREATEDBY", LogInForm2.loggedInUserId);
            }
            cmd.Parameters.AddWithValue("@NAME", txtname.Text);
            cmd.Parameters.AddWithValue("@SHORTNAME", txtshortname.Text);
            cmd.Parameters.AddWithValue("@PHONE", txtphone.Text);
            cmd.Parameters.AddWithValue("@DESCRIPTION", txtdescription.Text);
            cmd.Parameters.AddWithValue("@LASTUPDATED", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
            cmd.Parameters.AddWithValue("@UPDATEDBY", LogInForm2.loggedInUserId);
            cmd.ExecuteNonQuery();
        }
        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            if (MasterForm.departmentId > 0)
            {
                btnadddepartment.Text = "Update";
            }
            else
            {
                btnadddepartment.Text = "Add";
            }
        }
        private void txtname_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtname.Text))
            {
                validatorForTextBoxes.Validate(txtname);
            }
            else { validatorForTextBoxes.ClearErrorStatus(txtname); }
        }

        private void txtshortname_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtshortname.Text))
            {
                validatorForTextBoxes.Validate(txtshortname);
            }
            else { validatorForTextBoxes.ClearErrorStatus(txtshortname); }
        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtphone.Text))
            {
                validatorForTextBoxes.Validate(txtphone);
            }
            else { validatorForTextBoxes.ClearErrorStatus(txtphone); }
        }

        private void txtdescription_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtdescription.Text))
            {
                validatorForTextBoxes.Validate(txtdescription);
            }
            else { validatorForTextBoxes.ClearErrorStatus(txtdescription); }
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If it's not a digit or a control character, suppress the keypress event
                e.Handled = true;
            }
        }

        private void btnadddepartment_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtname.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtshortname);
                validatorForTextBoxes.ClearErrorStatus(txtphone);
                validatorForTextBoxes.ClearErrorStatus(txtdescription);

                validatorForTextBoxes.Validate(txtname);
                txtname.Focus();
            }
            else if (String.IsNullOrEmpty(txtshortname.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtname);
                validatorForTextBoxes.ClearErrorStatus(txtphone);
                validatorForTextBoxes.ClearErrorStatus(txtdescription);

                validatorForTextBoxes.Validate(txtshortname);
                txtshortname.Focus();
            }
            else if (String.IsNullOrEmpty(txtphone.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtname);
                validatorForTextBoxes.ClearErrorStatus(txtshortname);
                validatorForTextBoxes.ClearErrorStatus(txtdescription);

                validatorForTextBoxes.Validate(txtphone);
                txtphone.Focus();
            }
            else if (String.IsNullOrEmpty(txtdescription.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtname);
                validatorForTextBoxes.ClearErrorStatus(txtshortname);
                validatorForTextBoxes.ClearErrorStatus(txtphone);

                validatorForTextBoxes.Validate(txtdescription);
                txtdescription.Focus();
            }
            else
            {
                validatorForTextBoxes.ClearErrorStatus(txtname);
                validatorForTextBoxes.ClearErrorStatus(txtshortname);
                validatorForTextBoxes.ClearErrorStatus(txtphone);
                validatorForTextBoxes.ClearErrorStatus(txtdescription);

                string query = "INSERT_DEPARTMENT";
                if (MasterForm.departmentId > 0)
                {
                    query = "UPDATE_DEPARTMENT";
                }
                con.Open();
                performOperation(query);
                con.Close();
                this.Close();
            }
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Suppress the input if it's not a letter or white space
            }
        }

        private void txtshortname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Suppress the input if it's not a letter or white space
            }
        }
    }
}
