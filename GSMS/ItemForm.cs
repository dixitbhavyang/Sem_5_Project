using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Telerik.WinControls.UI;
using System.Data.SqlClient;

namespace GSMS
{
    public partial class ItemForm : RadForm
    {
        SqlConnection con = new SqlConnection(Connection.connectionString());
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        public ItemForm()
        {
            InitializeComponent();
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
        private void getCategories(object comapnyId)
        {
            Dictionary<int, string> source = new Dictionary<int, string>();
            source.Clear();
            dt.Clear();

            cmd = new SqlCommand("SELECT_CATEGORIES_BASED_ON_COMPANYID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", comapnyId);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    source.Add(Convert.ToInt32(row.ItemArray[0]), row.ItemArray[1].ToString());
                }
                drpselectcategory.DataSource = new BindingSource(source, null);
                drpselectcategory.DisplayMember = "Value";
                drpselectcategory.ValueMember = "Key";
            }
            else
            {
                drpselectcategory.DataSource = null;
            }
        }

        private void performOperation(string query)
        {
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            if (MasterForm.itemId > 0)
            {
                cmd.Parameters.AddWithValue("@ID", MasterForm.itemId);
            }
            else
            {
                cmd.Parameters.AddWithValue("@CREATEDDATE", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
                cmd.Parameters.AddWithValue("@CREATEDBY", LogInForm2.loggedInUserId);
            }
            cmd.Parameters.AddWithValue("@COMPANYID", drpselectcompany.SelectedValue);
            cmd.Parameters.AddWithValue("@CATEGORYID", drpselectcategory.SelectedValue);
            cmd.Parameters.AddWithValue("@NAME", txtitemname.Text);
            cmd.Parameters.AddWithValue("@SHORTNAME", txtshortname.Text);
            cmd.Parameters.AddWithValue("@PRICE", spineditorprice.Value);
            decimal discount = spineditordiscount.Value;
            int discountType = 0; // 0 FOR RUPEES
            if (toggleswitchdiscount.Value)
            {
                discount = spineditordiscount.Value / 100;
                discountType = 1; // 1 FOR PERCENTAGE
            }
            cmd.Parameters.AddWithValue("@DISCOUNT", discount);
            cmd.Parameters.AddWithValue("@DISCOUNTTYPE", discountType);
            decimal tax = spineditortax.Value;
            int taxType = 0; // 0 FOR RUPEES
            if (toggleswitchtax.Value)
            {
                tax = spineditortax.Value / 100;
                taxType = 1; // 1 FOR PERCENTAGE
            }
            cmd.Parameters.AddWithValue("@TAX", tax);
            cmd.Parameters.AddWithValue("@TAXTYPE", taxType);
            cmd.Parameters.AddWithValue("@UPDATEDDATE", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
            cmd.Parameters.AddWithValue("@UPDATEDBY", LogInForm2.loggedInUserId);
            cmd.ExecuteNonQuery();
        }
        private void ItemForm_Load(object sender, EventArgs e)
        {
            getCompanies();
            if (MasterForm.itemId > 0)
            {
                btnadditem.Text = "Update";
                drpselectcompany.SelectedValue = MasterForm.companyId;
                drpselectcategory.SelectedValue = MasterForm.categoryId;
            }
            else { btnadditem.Text = "Add"; }
        }

        private void txtitemname_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtitemname.Text))
            {
                validatorForTextBoxes.Validate(txtitemname);
                txtitemname.Focus();
            }
            else { validatorForTextBoxes.ClearErrorStatus(txtitemname); }
        }

        private void txtshortname_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtshortname.Text))
            {
                validatorForTextBoxes.Validate(txtshortname);
                txtshortname.Focus();
            }
            else { validatorForTextBoxes.ClearErrorStatus(txtshortname); }
        }
        
        private void drpselectcategory_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(drpselectcategory.Text))
            {
                erpcategory.SetError(drpselectcategory, "Please Select Category...");
                drpselectcategory.Focus();
            }
            else { erpcategory.Clear(); }
        }

        private void toggleswitchdiscount_ValueChanged(object sender, EventArgs e)
        {
            if (toggleswitchdiscount.Value)
            {
                spineditordiscount.Maximum = 100;
            }
            else
            {
                spineditordiscount.Maximum = spineditorprice.Value;
            }
        }
        private void drpselectcompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drpselectcompany.SelectedIndex >= 0)
            {
                KeyValuePair<int, string> selectedPair = (KeyValuePair<int, string>)drpselectcompany.SelectedItem;
                drpselectcategory.Enabled = true;
                getCategories(selectedPair.Key);
            }
            else
            {
                drpselectcategory.Enabled = false;
            }
        }
        private void drpselectcompany_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(drpselectcompany.Text))
            {
                drpselectcategory.DataSource = null;
                drpselectcategory.Enabled = false;

                erpcategory.Clear();
                validatorForTextBoxes.ClearErrorStatus(txtitemname);
                validatorForTextBoxes.ClearErrorStatus(txtshortname);
                validatorForSpinEditor.ClearErrorStatus(spineditorprice);
                validatorForSpinEditor.ClearErrorStatus(spineditordiscount);
                validatorForSpinEditor.ClearErrorStatus(spineditordiscount);
                erpdate.Clear();

                erpcompany.SetError(drpselectcompany, "Please Select a Comapny !");
                drpselectcompany.Focus();
            }
            else
            {
                drpselectcategory.Enabled = true;
                erpcompany.Clear();
            }
        }
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (drpselectcompany.SelectedIndex < 0)
            {
                erpcategory.Clear();
                validatorForTextBoxes.ClearErrorStatus(txtitemname);
                validatorForTextBoxes.ClearErrorStatus(txtshortname);
                validatorForSpinEditor.ClearErrorStatus(spineditorprice);
                validatorForSpinEditor.ClearErrorStatus(spineditordiscount);
                validatorForSpinEditor.ClearErrorStatus(spineditortax);
                erpdate.Clear();

                erpcompany.SetError(drpselectcategory, "Please Select Company...");
                drpselectcompany.Focus();
            }
            else if (drpselectcategory.SelectedIndex < 0)
            {
                erpcompany.Clear();
                validatorForTextBoxes.ClearErrorStatus(txtitemname);
                validatorForTextBoxes.ClearErrorStatus(txtshortname);
                validatorForSpinEditor.ClearErrorStatus(spineditorprice);
                validatorForSpinEditor.ClearErrorStatus(spineditordiscount);
                validatorForSpinEditor.ClearErrorStatus(spineditortax);
                erpdate.Clear();

                erpcategory.SetError(drpselectcategory, "Please Select Category...");
                drpselectcategory.Focus();
            }
            else if (string.IsNullOrEmpty(txtitemname.Text))
            {
                erpcompany.Clear();
                erpcategory.Clear();
                validatorForTextBoxes.ClearErrorStatus(txtshortname);
                validatorForSpinEditor.ClearErrorStatus(spineditorprice);
                validatorForSpinEditor.ClearErrorStatus(spineditordiscount);
                validatorForSpinEditor.ClearErrorStatus(spineditortax);
                erpdate.Clear();

                validatorForTextBoxes.Validate(txtitemname);
                txtitemname.Focus();
            }
            else if (string.IsNullOrEmpty(txtshortname.Text))
            {
                erpcompany.Clear();
                erpcategory.Clear();
                validatorForTextBoxes.ClearErrorStatus(txtitemname);
                validatorForSpinEditor.ClearErrorStatus(spineditorprice);
                validatorForSpinEditor.ClearErrorStatus(spineditordiscount);
                validatorForSpinEditor.ClearErrorStatus(spineditortax);
                erpdate.Clear();

                validatorForTextBoxes.Validate(txtshortname);
                txtshortname.Focus();
            }
            else if (spineditorprice.Value <= 0)
            {
                erpcompany.Clear();
                erpcategory.Clear();
                validatorForTextBoxes.ClearErrorStatus(txtitemname);
                validatorForTextBoxes.ClearErrorStatus(txtshortname);
                validatorForSpinEditor.ClearErrorStatus(spineditordiscount);
                validatorForSpinEditor.ClearErrorStatus(spineditortax);
                erpdate.Clear();

                validatorForSpinEditor.Validate(spineditorprice);
                spineditorprice.Focus();
            }
            else if (spineditordiscount.Value >= spineditorprice.Value)
            {
                if (toggleswitchdiscount.Value != true)
                {
                    validatorForDiscount.Validate(spineditordiscount);
                    spineditordiscount.Focus();
                }
            }
            else
            {
                erpcompany.Clear();
                erpcategory.Clear();
                validatorForTextBoxes.ClearErrorStatus(txtitemname);
                validatorForTextBoxes.ClearErrorStatus(txtshortname);
                validatorForSpinEditor.ClearErrorStatus(spineditorprice);
                validatorForSpinEditor.ClearErrorStatus(spineditordiscount);
                validatorForSpinEditor.ClearErrorStatus(spineditordiscount);
                erpdate.Clear();

                string query = "INSERT_ITEM";
                if (MasterForm.itemId > 0)
                {
                    query = "UPDATE_ITEM";
                }
                con.Open();
                performOperation(query);
                con.Close();
                this.Close();
            }
        }

        private void txtitemname_KeyPress(object sender, KeyPressEventArgs e)
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
