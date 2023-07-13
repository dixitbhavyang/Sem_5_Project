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
using System.Windows.Controls;
using System.Windows.Documents;
using System.Drawing.Drawing2D;

namespace GSMS
{
    public partial class CategoryForm : RadForm
    {
        SqlConnection con = new SqlConnection(Connection.connectionString());
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        public CategoryForm()
        {
            InitializeComponent();
        }
        private void perfomOperation(string query)
        {
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            if (MasterForm.categoryId > 0)
            {
                cmd.Parameters.AddWithValue("@ID", MasterForm.categoryId);
            }
            else
            {
                cmd.Parameters.AddWithValue("@CREATEDDATE", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
                cmd.Parameters.AddWithValue("CREATEDBY", LoginForm.loggedInUserId);
            }
            cmd.Parameters.AddWithValue("@COMPANY_ID", drpselectcompany.SelectedValue);
            cmd.Parameters.AddWithValue("@NAME", txtcategoryname.Text);
            cmd.Parameters.AddWithValue("@SHORTNAME", txtshortname.Text);
            cmd.Parameters.AddWithValue("@UPDATEDDATE", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
            cmd.Parameters.AddWithValue("UPDATEDBY", LoginForm.loggedInUserId);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void getCompanies()
        {
            Dictionary<int, string> source = new Dictionary<int, string>();
            source.Clear();
            dt.Clear();

            da = new SqlDataAdapter("EXEC SELECT_ACTIVE_COMPANIES", con);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    source.Add(Convert.ToInt32(row.ItemArray[0]), row.ItemArray[1].ToString());
                }

                drpselectcompany.DataSource = new BindingSource(source, null);
                drpselectcompany.DisplayMember = "Value";
                drpselectcompany.ValueMember = "Key";
            }
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            getCompanies();
            if (MasterForm.categoryId > 0)
            {
                btnaddcategory.Text = "Update";
                drpselectcompany.SelectedValue = MasterForm.companyId;
            }
            else { btnaddcategory.Text = "Add"; }
        }

        private void btnaddcomapny_Click(object sender, EventArgs e)
        {
            if (drpselectcompany.SelectedIndex < 0)
            {
                erpcomapny.SetError(drpselectcompany, "Please Select Comapny");
                drpselectcompany.Focus();
            }
            else if (String.IsNullOrEmpty(txtcategoryname.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtshortname);
                erpcomapny.Clear();

                validatorForTextBoxes.Validate(txtcategoryname);
                txtcategoryname.Focus();
            }
            else if (String.IsNullOrEmpty(txtshortname.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtcategoryname);
                erpcomapny.Clear();

                validatorForTextBoxes.Validate(txtshortname);
                txtshortname.Focus();
            }
            else
            {
                erpcomapny.Clear();
                validatorForTextBoxes.ClearErrorStatus(txtcategoryname);
                validatorForTextBoxes.ClearErrorStatus(txtshortname);

                string query = "INSERT_CATEGORY";
                if (MasterForm.categoryId > 0)
                {
                    query = "UPDATE_CATEGORY";
                }
                perfomOperation(query);
                Close();
            }
        }
    }
}
