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
    public partial class BillForm : RadForm
    {
        SqlConnection con = new SqlConnection(Connection.connectionString());
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        SqlDataReader dr;

        public static int itemPurchasedId, itemPurchased = 0;
        public decimal itemStock, itemPrice, itemDiscount, itemTax, itemQuantity, itemPayableAmount, paidAmount, originalDiscount, originalTax;
        public static string customerBillId = "";
        public BillForm()
        {
            InitializeComponent();
        }
        private void performOperation(string query)
        {

        }
        private void addColumns()
        {
            gridviewpurchaseditems.Columns.Clear();
            gridviewpurchaseditems.Rows.Clear();

            gridviewpurchaseditems.Columns.Add("Id");
            gridviewpurchaseditems.Columns[0].IsVisible = false;
            gridviewpurchaseditems.Columns.Add("Item");
            gridviewpurchaseditems.Columns.Add("Price");
            gridviewpurchaseditems.Columns.Add("Quantity");
            gridviewpurchaseditems.Columns.Add("Total Amount");
            gridviewpurchaseditems.Columns.Add("Discount");
            gridviewpurchaseditems.Columns.Add("Tax");
            gridviewpurchaseditems.Columns.Add("Payable Amount");

            for (int i = 0; i < gridviewpurchaseditems.Columns.Count; i++)
            {
                gridviewpurchaseditems.Columns[i].TextAlignment = ContentAlignment.MiddleCenter;
            }

            gridviewpurchaseditems.BestFitColumns();
            gridviewpurchaseditems.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
        }
        private void getCustomers()
        {
            dt = new DataTable();
            Dictionary<int, string> source = new Dictionary<int, string>();
            source.Clear();

            da = new SqlDataAdapter("EXEC SELECT_CUSTOMERS", con);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    source.Add(Convert.ToInt32(row.ItemArray[0]), row.ItemArray[1].ToString());
                }

                drpexistingcustomer.DataSource = new BindingSource(source, null);
                drpexistingcustomer.DisplayMember = "Value";
                drpexistingcustomer.ValueMember = "Key";
            }
            clearControls();
        }
        private void getItems()
        {
            dt = new DataTable();
            Dictionary<int, string> source = new Dictionary<int, string>();
            source.Clear();

            da = new SqlDataAdapter("EXEC SELECT_ACTIVE_ITEMS", con);
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
            clearControls();
        }
        private void getItemInventory()
        {
            cmd = new SqlCommand("SELECT_ITEM_INVENTORY", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", itemPurchasedId);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                itemStock = Convert.ToDecimal(dr["Quantity"]);
                if (itemStock > 0)
                {
                    lblunit.Text = dr["Unit"].ToString();
                    lblunit.Visible = true;
                }
            }
            else
            {
                itemStock = 0;
            }
            dr.Close();
        }
        private void BillForm_Load(object sender, EventArgs e)
        {
            con.Open();
            customerBillId = lblbillno.Text = "B-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            addColumns();
            getCustomers();
            getItems();
            //MessageBox.Show(drpitem.SelectedItem.ToString());
        }
        private void drpexistingcustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drpexistingcustomer.SelectedItem != null)
            {
                KeyValuePair<int, string> customer = (KeyValuePair<int, string>)drpexistingcustomer.SelectedItem;
                cmd = new SqlCommand("SELECT_CUSTOMER_BASED_ON_ID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", customer.Key);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    txtfirstname.Text = dr["FirstName"].ToString();
                    txtlastname.Text = dr["LastName"].ToString();
                    txtcontactnumber.Text = dr["Phone"].ToString();
                    txtmail.Text = dr["Email"].ToString();
                    if (Convert.ToBoolean(dr["Gender"]))
                    {
                        rdbmale.IsChecked = true;
                    }
                    else
                    {
                        rdbfemale.IsChecked = true;
                    }
                    txtcity.Text = dr["City"].ToString();
                }
                dr.Close();
            }
        }
        private void txtfirstname_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtfirstname.Text))
            {
                validatorForTextBoxes.Validate(txtfirstname);
                txtfirstname.Focus();
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
                txtlastname.Focus();
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
                txtcontactnumber.Focus();
            }
            else
            {
                validatorForTextBoxes.ClearErrorStatus(txtcontactnumber);
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

        private void txtmail_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtmail.Text))
            {
                validatorForTextBoxes.Validate(txtmail);
                txtmail.Focus();
            }
            else
            {
                validatorForTextBoxes.ClearErrorStatus(txtmail);
            }
        }

        private void txtcity_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtcity.Text))
            {
                validatorForTextBoxes.Validate(txtcity);
                txtcity.Focus();
            }
            else
            {
                validatorForTextBoxes.ClearErrorStatus(txtcity);
            }
        }
        private void drpitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drpitem.SelectedItem != null)
            {
                erpitem.Clear();
                KeyValuePair<int, string> item = (KeyValuePair<int, string>)drpitem.SelectedItem;
                itemPurchasedId = item.Key;
                getItemInventory();
                if (itemStock > 0)
                {
                    enableControls();
                    cmd = new SqlCommand("EDIT_ITEM", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", itemPurchasedId);
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        itemPrice = Convert.ToDecimal(dr["Price"]);
                        spineditorprice.Value = itemPrice;

                        if (Convert.ToBoolean(dr["DiscountType"]))
                        {
                            originalDiscount = itemDiscount = Convert.ToDecimal(dr["Discount"]) * Convert.ToDecimal(100);
                            toggleswitchdiscount.Value = true;
                        }
                        else
                        {
                            originalDiscount = itemDiscount = Convert.ToDecimal(dr["Discount"]);
                            toggleswitchdiscount.Value = false;
                        }
                        spineditordiscount.Value = itemDiscount;

                        if (Convert.ToBoolean(dr["TaxType"]))
                        {
                            originalTax = itemTax = Convert.ToDecimal(dr["Tax"]) * Convert.ToDecimal(100);
                            toggleswitchtax.Value = true;
                        }
                        else
                        {
                            originalTax = itemTax = Convert.ToDecimal(dr["Tax"]);
                            toggleswitchtax.Value = false;
                        }
                        spineditortax.Value = itemTax;
                    }
                    dr.Close();
                    spineditorquantity.Value = spineditortotalamount.Value = spineditorpayableamount.Value = spineditorpaidamount.Value = spineditorremainingamount.Value = 0;
                }
                else
                {
                    MessageBox.Show("This Item is Out of Stock", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblunit.Visible = false;
                    disableControls();
                }
            }
        }

        private void drpitem_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(drpitem.Text))
            {
                erpitem.SetError(drpitem, "Please Select an Item .. !");
                drpitem.Focus();
                spineditorprice.Value = spineditorquantity.Value = spineditortotalamount.Value = spineditordiscount.Value = spineditortax.Value = spineditorpayableamount.Value = spineditorpaidamount.Value = spineditorremainingamount.Value = 0;
            }
            else
            {
                erpitem.Clear();
            }
        }

        private decimal getDiscount()
        {
            decimal discount;
            if (toggleswitchdiscount.Value)
            {
                discount = ((spineditordiscount.Value / 100) * spineditortotalamount.Value);
            }
            else
            {
                discount = (spineditordiscount.Value * Convert.ToDecimal(spineditorquantity.Value));
            }
            itemDiscount = discount;
            if (toggleswitchdiscount.Value == false)
            {
                if (itemDiscount != spineditordiscount.Value)
                {
                    spineditordiscount.Value = discount;
                }
            }
            return discount;
        }
        private decimal getTax()
        {
            decimal tax;
            if (toggleswitchtax.Value)
            {
                tax = ((spineditortax.Value / 100) * (spineditortotalamount.Value - itemDiscount));
            }
            else
            {
                tax = (spineditortax.Value * Convert.ToDecimal(spineditorquantity.Value));
            }
            itemTax = tax;
            if (toggleswitchtax.Value == false)
            {
                if (itemTax != spineditortax.Value)
                {
                    spineditortax.Value = tax;
                }
            }
            return tax;
        }
        private void getPayableAmount()
        {
            if (spineditorquantity.Value > 0)
            {
                itemPayableAmount = (spineditortotalamount.Value - getDiscount()) + getTax();
                spineditorpayableamount.Value = itemPayableAmount;
            }

        }

        private void spineditorquantity_ValueChanged(object sender, EventArgs e)
        {
            if (spineditorquantity.Value == 0)
            {
                spineditortotalamount.Value = spineditorpayableamount.Value = spineditorpaidamount.Value = spineditorremainingamount.Value = 0;
            }
            else
            {
                if (spineditorquantity.Value > itemStock)
                {
                    MessageBox.Show("We have Only " + itemStock.ToString() + " " + lblunit.Text + " " + "You cannot Buy More than that...", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    spineditorquantity.Value = 0;
                    spineditordiscount.Value = originalDiscount;
                    spineditortax.Value = originalTax;
                    spineditorpayableamount.Value = spineditorpaidamount.Value = 0;
                }
                else
                {
                    spineditortotalamount.Value = spineditorquantity.Value * spineditorprice.Value;
                    getPayableAmount();
                }
            }
        }

        private void toggleswitchdiscount_ValueChanged(object sender, EventArgs e)
        {
            if (toggleswitchdiscount.Value)
            {
                spineditordiscount.Maximum = 99;
            }
            else
            {
                spineditordiscount.Maximum = 999999;
            }
            getPayableAmount();
        }

        private void toggleswitchtax_ValueChanged(object sender, EventArgs e)
        {
            if (toggleswitchtax.Value)
            {
                spineditortax.Maximum = 99;
            }
            else
            {
                spineditortax.Maximum = 999999;
            }
            getPayableAmount();
        }

        private void spineditordiscount_ValueChanged(object sender, EventArgs e)
        {
            if (itemDiscount != spineditordiscount.Value)
            {
                getPayableAmount();
            }
        }

        private void spineditortax_ValueChanged(object sender, EventArgs e)
        {
            if (itemTax != spineditortax.Value)
            {
                getPayableAmount();
            }
        }

        private void spineditorpaidamount_ValueChanged(object sender, EventArgs e)
        {
            if (spineditorpaidamount.Value == 0)
            {
                spineditorremainingamount.Value = 0;
            }
            else
            {
                spineditorremainingamount.Value = spineditorpayableamount.Value - spineditorpaidamount.Value;
            }
        }
        private void clearControls()
        {
            txtfirstname.Text = txtlastname.Text = txtcontactnumber.Text = txtmail.Text = txtcity.Text = "";
            spineditorprice.Value = spineditorquantity.Value = spineditordiscount.Value = spineditortax.Value = spineditorpaidamount.Value = spineditorremainingamount.Value = 0;
            gridviewpurchaseditems.Rows.Clear();
            itemPurchased = 0;
            toggleswitchdiscount.Value = toggleswitchtax.Value = false;
            lblunit.Visible = false;

            validatorForTextBoxes.ClearErrorStatus(txtfirstname);
            validatorForTextBoxes.ClearErrorStatus(txtlastname);
            validatorForTextBoxes.ClearErrorStatus(txtcontactnumber);
            validatorForTextBoxes.ClearErrorStatus(txtmail);
            validatorForTextBoxes.ClearErrorStatus(txtcity);
            erpitem.Clear();
            validatorForSpinEditor.ClearErrorStatus(spineditorquantity);
            validatorForSpinEditor.ClearErrorStatus(spineditorpaidamount);

            drpitem.Text = "Select an Item..";
        }
        private void disableControls()
        {
            spineditorprice.Value = spineditorquantity.Value = spineditordiscount.Value = spineditortax.Value = spineditorpaidamount.Value = spineditorremainingamount.Value = 0;
            spineditorprice.Enabled = spineditorquantity.Enabled = spineditordiscount.Enabled = spineditortax.Enabled = spineditorpaidamount.Enabled = spineditorremainingamount.Enabled = false;
        }
        private void enableControls()
        {
            spineditorprice.Enabled = spineditorquantity.Enabled = spineditordiscount.Enabled = spineditortax.Enabled = spineditorpaidamount.Enabled = spineditorremainingamount.Enabled = true;
        }

        private void btnadditem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtfirstname.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtlastname);
                validatorForTextBoxes.ClearErrorStatus(txtcontactnumber);
                validatorForTextBoxes.ClearErrorStatus(txtmail);
                validatorForTextBoxes.ClearErrorStatus(txtcity);
                erpitem.Clear();
                validatorForSpinEditor.ClearErrorStatus(spineditorquantity);
                validatorForSpinEditor.ClearErrorStatus(spineditorpaidamount);

                validatorForTextBoxes.Validate(txtfirstname);
                txtfirstname.Focus();
            }
            else if (String.IsNullOrEmpty(txtlastname.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtfirstname);
                validatorForTextBoxes.ClearErrorStatus(txtcontactnumber);
                validatorForTextBoxes.ClearErrorStatus(txtmail);
                validatorForTextBoxes.ClearErrorStatus(txtcity);
                erpitem.Clear();
                validatorForSpinEditor.ClearErrorStatus(spineditorquantity);
                validatorForSpinEditor.ClearErrorStatus(spineditorpaidamount);

                validatorForTextBoxes.Validate(txtlastname);
                txtlastname.Focus();
            }
            else if (String.IsNullOrEmpty(txtcontactnumber.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtfirstname);
                validatorForTextBoxes.ClearErrorStatus(txtlastname);
                validatorForTextBoxes.ClearErrorStatus(txtmail);
                validatorForTextBoxes.ClearErrorStatus(txtcity);
                erpitem.Clear();
                validatorForSpinEditor.ClearErrorStatus(spineditorquantity);
                validatorForSpinEditor.ClearErrorStatus(spineditorpaidamount);

                validatorForTextBoxes.Validate(txtcontactnumber);
                txtcontactnumber.Focus();
            }
            else if (String.IsNullOrEmpty(txtmail.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtfirstname);
                validatorForTextBoxes.ClearErrorStatus(txtlastname);
                validatorForTextBoxes.ClearErrorStatus(txtcontactnumber);
                validatorForTextBoxes.ClearErrorStatus(txtcity);
                erpitem.Clear();
                validatorForSpinEditor.ClearErrorStatus(spineditorquantity);
                validatorForSpinEditor.ClearErrorStatus(spineditorpaidamount);

                validatorForTextBoxes.Validate(txtmail);
                txtmail.Focus();
            }
            else if (String.IsNullOrEmpty(txtcity.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtfirstname);
                validatorForTextBoxes.ClearErrorStatus(txtlastname);
                validatorForTextBoxes.ClearErrorStatus(txtcontactnumber);
                validatorForTextBoxes.ClearErrorStatus(txtmail);
                erpitem.Clear();
                validatorForSpinEditor.ClearErrorStatus(spineditorquantity);
                validatorForSpinEditor.ClearErrorStatus(spineditorpaidamount);

                validatorForTextBoxes.Validate(txtcity);
                txtcity.Focus();
            }
            else if (drpitem.SelectedItem == null)
            {
                validatorForTextBoxes.ClearErrorStatus(txtfirstname);
                validatorForTextBoxes.ClearErrorStatus(txtlastname);
                validatorForTextBoxes.ClearErrorStatus(txtcontactnumber);
                validatorForTextBoxes.ClearErrorStatus(txtmail);
                validatorForTextBoxes.ClearErrorStatus(txtcity);
                validatorForSpinEditor.ClearErrorStatus(spineditorquantity);
                validatorForSpinEditor.ClearErrorStatus(spineditorpaidamount);

                erpitem.SetError(drpitem, "Please Select an Item .. !");
                drpitem.Focus();
            }
            else if (spineditorquantity.Value <= 0)
            {
                validatorForTextBoxes.ClearErrorStatus(txtfirstname);
                validatorForTextBoxes.ClearErrorStatus(txtlastname);
                validatorForTextBoxes.ClearErrorStatus(txtcontactnumber);
                validatorForTextBoxes.ClearErrorStatus(txtmail);
                validatorForTextBoxes.ClearErrorStatus(txtcity);
                erpitem.Clear();
                validatorForSpinEditor.ClearErrorStatus(spineditorpaidamount);

                validatorForSpinEditor.Validate(spineditorquantity);
                spineditorquantity.Focus();
            }
            else if (spineditorpaidamount.Value <= 0)
            {
                validatorForTextBoxes.ClearErrorStatus(txtfirstname);
                validatorForTextBoxes.ClearErrorStatus(txtlastname);
                validatorForTextBoxes.ClearErrorStatus(txtcontactnumber);
                validatorForTextBoxes.ClearErrorStatus(txtmail);
                validatorForTextBoxes.ClearErrorStatus(txtcity);
                erpitem.Clear();
                validatorForSpinEditor.ClearErrorStatus(spineditorquantity);

                validatorForSpinEditor.Validate(spineditorpaidamount);
                spineditorpaidamount.Focus();
            }
            else
            {
                validatorForTextBoxes.ClearErrorStatus(txtfirstname);
                validatorForTextBoxes.ClearErrorStatus(txtlastname);
                validatorForTextBoxes.ClearErrorStatus(txtcontactnumber);
                validatorForTextBoxes.ClearErrorStatus(txtmail);
                validatorForTextBoxes.ClearErrorStatus(txtcity);
                erpitem.Clear();
                validatorForSpinEditor.ClearErrorStatus(spineditorquantity);
                validatorForSpinEditor.ClearErrorStatus(spineditorpaidamount);

                GridViewDataRowInfo rowInfo = new GridViewDataRowInfo(this.gridviewpurchaseditems.MasterView);
                itemPurchased++;
                rowInfo.Cells[0].Value = itemPurchased;
                rowInfo.Cells[1].Value = drpitem.Text;
                rowInfo.Cells[2].Value = spineditorprice.Value.ToString();
                rowInfo.Cells[3].Value = spineditorquantity.Value.ToString();
                rowInfo.Cells[4].Value = spineditortotalamount.Value.ToString();
                rowInfo.Cells[5].Value = itemDiscount.ToString();
                rowInfo.Cells[6].Value = itemTax.ToString();
                rowInfo.Cells[7].Value = itemPayableAmount;

                gridviewpurchaseditems.Rows.Add(rowInfo);
                drpitem.Text = "Select an Item..";
                spineditorprice.Value = spineditorquantity.Value = spineditortotalamount.Value = 0;
                spineditordiscount.Value = spineditortax.Value = spineditorpayableamount.Value = spineditorpaidamount.Value = 0;
                toggleswitchdiscount.Value = toggleswitchtax.Value = false;
            }

        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            clearControls();
        }
    }
}
