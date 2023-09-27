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
    public partial class InventoryForm : RadForm
    {
        SqlConnection con = new SqlConnection(Connection.connectionString());
        SqlCommand cmd;
        DataTable dt = new DataTable();
        SqlDataAdapter da;
        public InventoryForm()
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

                drpcompany.DataSource = new BindingSource(source, null);
                drpcompany.DisplayMember = "Value";
                drpcompany.ValueMember = "Key";
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
                drpcategory.DataSource = new BindingSource(source, null);
                drpcategory.DisplayMember = "Value";
                drpcategory.ValueMember = "Key";
            }
        }
        private void getItems(object categoryId)
        {
            Dictionary<int, string> source = new Dictionary<int, string>();
            source.Clear();
            dt.Clear();

            cmd = new SqlCommand("SELECT_ITEMS_BASED_ON_CATEGORYID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", categoryId);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    source.Add(Convert.ToInt32(row.ItemArray[0]), row.ItemArray[1].ToString());
                }
                drpitem.DataSource = new BindingSource(source, null);
                drpitem.DisplayMember = "Value";
                drpitem.ValueMember = "Key";
            }
        }

        private void performOperation(string query)
        {
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            if (MasterForm.inventoryId > 0)
            {
                cmd.Parameters.AddWithValue("@ID", MasterForm.inventoryId);
            }
            else
            {
                cmd.Parameters.AddWithValue("@CREATEDDATE", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
                cmd.Parameters.AddWithValue("CREATEDBY", LogInForm2.loggedInUserId);
            }
            cmd.Parameters.AddWithValue("@COMPANYID", drpcompany.SelectedValue);
            cmd.Parameters.AddWithValue("@CATEGORYID", drpcategory.SelectedValue);
            cmd.Parameters.AddWithValue("@ITEMID", drpitem.SelectedValue);
            cmd.Parameters.AddWithValue("@QUANTITY", Convert.ToDecimal(spineditorquantity.Value));
            cmd.Parameters.AddWithValue("@UNIT", drpunit.SelectedItem);
            cmd.Parameters.AddWithValue("@MINIMUMSTOCK", spineditorminimumstock.Value);
            cmd.Parameters.AddWithValue("@MAXIMUMSTOCK", spineditormaximumstock.Value);
            cmd.Parameters.AddWithValue("@LASTUPDATED", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
            cmd.Parameters.AddWithValue("@UPDATEDBY", LogInForm2.loggedInUserId);
            cmd.ExecuteNonQuery();
        }
        private void InventoryForm_Load(object sender, EventArgs e)
        {
            getCompanies();
            if (MasterForm.inventoryId > 0)
            {
                drpcompany.SelectedValue = MasterForm.companyId;
                drpcategory.SelectedValue = MasterForm.categoryId;
                drpitem.SelectedValue = MasterForm.itemId;
                btnadd.Text = "Update";
            }
            else
            {
                btnadd.Text = "Add";
            }

        }

        private void drpcompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drpcompany.SelectedIndex >= 0)
            {
                KeyValuePair<int, string> selectedPair = (KeyValuePair<int, string>)drpcompany.SelectedItem;
                drpcategory.Enabled = true;
                getCategories(selectedPair.Key);
            }
            else
            {
                drpcategory.Enabled = false;
            }
        }
        private void drpcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drpcategory.SelectedIndex >= 0)
            {
                KeyValuePair<int, string> selectedPair = (KeyValuePair<int, string>)drpcategory.SelectedItem;
                drpitem.Enabled = true;
                getItems(selectedPair.Key);
            }
            else
            {
                drpitem.Enabled = false;
            }
        }

        private void drpcompany_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(drpcompany.Text))
            {
                drpcategory.DataSource = null;
                drpcategory.Enabled = false;

                erpcategory.Clear();
                erpitem.Clear();
                validatorForSpinEditor.ClearErrorStatus(spineditorquantity);
                validatorForSpinEditor.ClearErrorStatus(spineditorminimumstock);
                validatorForSpinEditor.ClearErrorStatus(spineditormaximumstock);

                erpcompany.SetError(drpcompany, "Please Select a Comapny !");
                drpcompany.Focus();
            }
            else
            {
                drpcategory.Enabled = true;
                erpcompany.Clear();
            }
        }

        private void drpcategory_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(drpcategory.Text))
            {
                if (drpcategory.Enabled)
                {
                    drpitem.DataSource = null;
                    drpitem.Enabled = false;

                    erpcompany.Clear();
                    erpitem.Clear();
                    validatorForSpinEditor.ClearErrorStatus(spineditorquantity);
                    validatorForSpinEditor.ClearErrorStatus(spineditorminimumstock);
                    validatorForSpinEditor.ClearErrorStatus(spineditormaximumstock);

                    erpcategory.SetError(drpcategory, "Please Select a Category !");
                    drpcategory.Focus();
                }
            }
            else
            {
                drpitem.Enabled = true;
                erpcategory.Clear();
            }
        }

        private void drpitem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(drpitem.Text))
            {
                if (drpitem.Enabled)
                {
                    erpcompany.Clear();
                    validatorForSpinEditor.ClearErrorStatus(spineditorquantity);
                    validatorForSpinEditor.ClearErrorStatus(spineditorminimumstock);
                    validatorForSpinEditor.ClearErrorStatus(spineditormaximumstock);

                    erpitem.SetError(drpitem, "Please Select an Item !");
                    drpitem.Focus();
                }
            }
            else
            {
                erpitem.Clear();
            }
        }

        private void drpunit_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(drpunit.Text))
            {
                erpdrpunit.SetError(drpunit, "Please Select Unit Measure...!");
            }
            else
            {
                erpdrpunit.Clear();
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (drpcompany.SelectedIndex < 0)
            {
                erpcategory.Clear();
                erpitem.Clear();
                erpdrpunit.Clear();
                validatorForSpinEditor.ClearErrorStatus(spineditorquantity);
                validatorForSpinEditor.ClearErrorStatus(spineditorminimumstock);
                validatorForSpinEditor.ClearErrorStatus(spineditormaximumstock);

                erpcompany.SetError(drpcompany, "Please Select a Comapny !");
                drpcompany.Focus();
            }
            else if (drpcategory.SelectedIndex < 0)
            {
                erpcompany.Clear();
                erpitem.Clear();
                erpdrpunit.Clear();
                validatorForSpinEditor.ClearErrorStatus(spineditorquantity);
                validatorForSpinEditor.ClearErrorStatus(spineditorminimumstock);
                validatorForSpinEditor.ClearErrorStatus(spineditormaximumstock);

                erpcategory.SetError(drpcategory, "Please Select a Category !");
                drpcategory.Focus();
            }
            else if (drpitem.SelectedIndex < 0)
            {
                erpcompany.Clear();
                erpcategory.Clear();
                erpdrpunit.Clear();
                validatorForSpinEditor.ClearErrorStatus(spineditorquantity);
                validatorForSpinEditor.ClearErrorStatus(spineditorminimumstock);
                validatorForSpinEditor.ClearErrorStatus(spineditormaximumstock);

                erpitem.SetError(drpitem, "Please Select an Item !");
                drpitem.Focus();
            }
            else if (spineditorquantity.Value == 0)
            {
                erpcompany.Clear();
                erpcategory.Clear();
                erpdrpunit.Clear();
                validatorForSpinEditor.ClearErrorStatus(spineditorminimumstock);
                validatorForSpinEditor.ClearErrorStatus(spineditormaximumstock);

                validatorForSpinEditor.Validate(spineditorquantity);
                spineditorquantity.Focus();
            }
            else if (drpunit.SelectedItem == null)
            {
                erpcompany.Clear();
                erpcategory.Clear();
                erpitem.Clear();
                validatorForSpinEditor.ClearErrorStatus(spineditorquantity);
                validatorForSpinEditor.ClearErrorStatus(spineditorminimumstock);
                validatorForSpinEditor.ClearErrorStatus(spineditormaximumstock);

                erpdrpunit.SetError(drpunit,"Please Select Unit Measure...!");
                drpunit.Focus();
            }
            else if (spineditorminimumstock.Value == 0)
            {
                erpcompany.Clear();
                erpcategory.Clear();
                erpdrpunit.Clear();
                validatorForSpinEditor.ClearErrorStatus(spineditorquantity);
                validatorForSpinEditor.ClearErrorStatus(spineditormaximumstock);

                validatorForSpinEditor.Validate(spineditorminimumstock);
                spineditorminimumstock.Focus();
            }
            else if (spineditormaximumstock.Value == 0)
            {
                erpcompany.Clear();
                erpcategory.Clear();
                erpdrpunit.Clear();
                validatorForSpinEditor.ClearErrorStatus(spineditorquantity);
                validatorForSpinEditor.ClearErrorStatus(spineditorminimumstock);

                validatorForSpinEditor.Validate(spineditormaximumstock);
                spineditormaximumstock.Focus();
            }
            else
            {
                erpcompany.Clear();
                erpcategory.Clear();
                erpitem.Clear();
                erpdrpunit.Clear();
                validatorForSpinEditor.ClearErrorStatus(spineditorquantity);
                validatorForSpinEditor.ClearErrorStatus(spineditorminimumstock);
                validatorForSpinEditor.ClearErrorStatus(spineditormaximumstock);

                string query = "INSERT_INVENTORY_RECORD";
                if (MasterForm.inventoryId > 0)
                {
                    query = "UPDATE_INVENTORY_RECORD";
                }
                con.Open();
                performOperation(query);
                con.Close();
                this.Close();
            }
        }
    }
}
