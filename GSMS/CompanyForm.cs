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
    public partial class CompanyForm : RadForm
    {
        SqlConnection con = new SqlConnection(Connection.connectionString());
        SqlCommand cmd;
        public CompanyForm()
        {
            InitializeComponent();
        }
        private void perfomOperation(string query)
        {
            con.Open();
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            if (MasterForm.companyId > 0)
            {
                cmd.Parameters.AddWithValue("@ID", MasterForm.companyId);
            }
            else
            {
                cmd.Parameters.AddWithValue("@CREATEDDATE", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
                cmd.Parameters.AddWithValue("@CREATEDBY", LoginForm.loggedInUserId);
            }
            cmd.Parameters.AddWithValue("@NAME", txtcompanyname.Text);
            cmd.Parameters.AddWithValue("@SHORTNAME", txtshortname.Text);
            cmd.Parameters.AddWithValue("@UPDATEDDATE", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
            cmd.Parameters.AddWithValue("@UPDATEDBY", LoginForm.loggedInUserId);
            cmd.Parameters.AddWithValue("@ADDRESS", txtaddress.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void btnaddcomapny_Click_2(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtcompanyname.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtshortname);
                validatorForTextBoxes.ClearErrorStatus(txtaddress);

                validatorForTextBoxes.Validate(txtcompanyname);
                txtcompanyname.Focus();
            }
            else if (String.IsNullOrEmpty(txtshortname.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtcompanyname);
                validatorForTextBoxes.ClearErrorStatus(txtaddress);

                validatorForTextBoxes.Validate(txtshortname);
                txtshortname.Focus();
            }
            else if (String.IsNullOrEmpty(txtaddress.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtcompanyname);
                validatorForTextBoxes.ClearErrorStatus(txtshortname);

                validatorForTextBoxes.Validate(txtaddress);
                txtaddress.Focus();
            }
            else
            {
                validatorForTextBoxes.ClearErrorStatus(txtcompanyname);
                validatorForTextBoxes.ClearErrorStatus(txtshortname);
                validatorForTextBoxes.ClearErrorStatus(txtaddress);

                string query = "INSERT_COMPANY";
                if (MasterForm.companyId > 0)
                {
                    query = "UPDATE_COMPANY";
                }
                perfomOperation(query);
                Close();
            }
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            if (MasterForm.companyId > 0)
            {
                btnaddcomapny.Text = "Update";
            }
            else { btnaddcomapny.Text = "Add"; }
        }
        
    }
}
