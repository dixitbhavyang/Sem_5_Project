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

        private void getCategories()
        {
            Dictionary<int, string> source = new Dictionary<int, string>();
            source.Clear();
            dt.Clear();

            da = new SqlDataAdapter("EXEC SELECT_ACTIVE_CATEGORIES", con);
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
        }

        private void performOperation(string query)
        {
            con.Open();
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            if (MasterForm.itemId > 0)
            {
                cmd.Parameters.AddWithValue("@ID", MasterForm.itemId);
            }
            else
            {
                cmd.Parameters.AddWithValue("@CREATEDDATE", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
                cmd.Parameters.AddWithValue("@CREATEDBY", LoginForm.loggedInUserId);
            }
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
            cmd.Parameters.AddWithValue("@UPDATEDBY", LoginForm.loggedInUserId);
            cmd.Parameters.AddWithValue("@EXPIRYDATE", datetimeexpiration.Value.ToString("MM/dd/yyyy hh:mm:ss tt"));
            cmd.ExecuteNonQuery();
        }
        private void ItemForm_Load(object sender, EventArgs e)
        {
            getCategories();
            if (MasterForm.itemId > 0)
            {
                btnadditem.Text = "Update";
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

        private void spineditorprice_ValueChanged(object sender, EventArgs e)
        {
            if (spineditorprice.Value <= 0)
            {
                validatorForSpinEditor.Validate(spineditorprice);
                spineditorprice.Focus();
            }
            else { validatorForSpinEditor.ClearErrorStatus(spineditorprice); }
        }

        private void spineditordiscount_ValueChanged(object sender, EventArgs e)
        {
            if (spineditordiscount.Value <= 0)
            {
                validatorForSpinEditor.Validate(spineditordiscount);
                spineditordiscount.Focus();
            }
            else if (spineditordiscount.Value >= spineditorprice.Value)
            {
                if (toggleswitchdiscount.Value != true)
                {
                    validatorForDiscount.Validate(spineditordiscount);
                    spineditordiscount.Focus();
                }
            }
            else { validatorForSpinEditor.ClearErrorStatus(spineditordiscount); }
        }

        private void spineditortax_ValueChanged(object sender, EventArgs e)
        {
            if (spineditortax.Value <= 0)
            {
                validatorForSpinEditor.Validate(spineditortax);
                spineditortax.Focus();
            }
            else { validatorForSpinEditor.ClearErrorStatus(spineditortax); }
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
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (drpselectcategory.SelectedIndex < 0)
            {
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
                erpcategory.Clear();
                validatorForTextBoxes.ClearErrorStatus(txtitemname);
                validatorForTextBoxes.ClearErrorStatus(txtshortname);
                validatorForSpinEditor.ClearErrorStatus(spineditordiscount);
                validatorForSpinEditor.ClearErrorStatus(spineditortax);
                erpdate.Clear();

                validatorForSpinEditor.Validate(spineditorprice);
                spineditorprice.Focus();
            }
            else if (spineditordiscount.Value <= 0)
            {
                erpcategory.Clear();
                validatorForTextBoxes.ClearErrorStatus(txtitemname);
                validatorForTextBoxes.ClearErrorStatus(txtshortname);
                validatorForSpinEditor.ClearErrorStatus(spineditorprice);
                validatorForSpinEditor.ClearErrorStatus(spineditortax);
                erpdate.Clear();

                validatorForSpinEditor.Validate(spineditordiscount);
                spineditordiscount.Focus();
            }
            else if (spineditordiscount.Value >= spineditorprice.Value)
            {
                if (toggleswitchdiscount.Value != true)
                {
                    validatorForDiscount.Validate(spineditordiscount);
                    spineditordiscount.Focus();
                }
            }
            else if (spineditortax.Value <= 0)
            {
                erpcategory.Clear();
                validatorForTextBoxes.ClearErrorStatus(txtitemname);
                validatorForTextBoxes.ClearErrorStatus(txtshortname);
                validatorForSpinEditor.ClearErrorStatus(spineditorprice);
                validatorForSpinEditor.ClearErrorStatus(spineditordiscount);
                erpdate.Clear();

                validatorForSpinEditor.Validate(spineditortax);
                spineditortax.Focus();
            }
            else if (datetimeexpiration.Value == DateTime.Now)
            {
                erpcategory.Clear();
                validatorForTextBoxes.ClearErrorStatus(txtitemname);
                validatorForTextBoxes.ClearErrorStatus(txtshortname);
                validatorForSpinEditor.ClearErrorStatus(spineditorprice);
                validatorForSpinEditor.ClearErrorStatus(spineditordiscount);
                validatorForSpinEditor.ClearErrorStatus(spineditordiscount);

                erpdate.SetError(datetimeexpiration, "Its Today's Date, Please select a Valid Date....");
            }
            else
            {
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
                performOperation(query);
                con.Close();
                Close();
            }
        }
    }
}
