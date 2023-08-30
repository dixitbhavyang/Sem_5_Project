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

        public static int itemPurchasedId = 0, gridviewItemSelectedId = 0;
        public decimal itemStock, itemPrice, itemDiscount, itemTax, itemQuantity, itemPayableAmount, paidAmount, originalDiscount, originalTax;
        public static string customerBillId = "";
        private bool igonoreDropdownIndexChangedEvent = false;
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
            gridviewpurchaseditems.Columns["Id"].IsVisible = false;

            gridviewpurchaseditems.Columns.Add("Item");
            gridviewpurchaseditems.Columns.Add("Price");
            gridviewpurchaseditems.Columns.Add("Quantity");
            gridviewpurchaseditems.Columns.Add("Unit");
            gridviewpurchaseditems.Columns.Add("Total Amount");
            gridviewpurchaseditems.Columns.Add("Discount");
            gridviewpurchaseditems.Columns.Add("DiscountType");

            gridviewpurchaseditems.Columns["DiscountType"].IsVisible = false;
            gridviewpurchaseditems.Columns.Add("Tax");

            gridviewpurchaseditems.Columns.Add("TaxType");
            gridviewpurchaseditems.Columns["TaxType"].IsVisible = false;

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
            btngeneratebill.Enabled = false;
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
                //if (igonoreDropdownIndexChangedEvent == false)
                //{
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
                        bool disType, taxType;
                        itemPrice = Convert.ToDecimal(dr["Price"]);
                        spineditorprice.Value = itemPrice;
                        spineditorquantity.Value = 0;
                        spineditortotalamount.Value = 0;

                        if (Convert.ToBoolean(dr["DiscountType"]))
                        {
                            disType = true;
                            originalDiscount = itemDiscount = Convert.ToDecimal(dr["Discount"]) * Convert.ToDecimal(100);
                        }
                        else
                        {
                            disType = false;
                            originalDiscount = itemDiscount = Convert.ToDecimal(dr["Discount"]);
                        }

                        if (Convert.ToBoolean(dr["TaxType"]))
                        {
                            taxType = true;
                            originalTax = itemTax = Convert.ToDecimal(dr["Tax"]) * Convert.ToDecimal(100);
                        }
                        else
                        {
                            taxType = false;
                            originalTax = itemTax = Convert.ToDecimal(dr["Tax"]);
                        }

                        if (igonoreDropdownIndexChangedEvent == false)
                        {
                            toggleswitchdiscount.Value = disType;
                            toggleswitchtax.Value = taxType;
                            spineditordiscount.Value = itemDiscount;
                            spineditortax.Value = itemTax;
                        }
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
                igonoreDropdownIndexChangedEvent = false;
                //}
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
                discount = (originalDiscount * Convert.ToDecimal(spineditorquantity.Value));
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
                tax = (originalTax * Convert.ToDecimal(spineditorquantity.Value));
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
            if (igonoreDropdownIndexChangedEvent == false)
            {
                if (spineditorquantity.Value > 0)
                {
                    itemPayableAmount = (spineditortotalamount.Value - getDiscount()) + getTax();
                    spineditorpayableamount.Value = itemPayableAmount;
                }
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
                if (gridviewpurchaseditems.Rows.Count > 0)
                {
                    for (int i = 0; i < gridviewpurchaseditems.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(gridviewpurchaseditems.Rows[i].Cells[0].Value) == itemPurchasedId && gridviewItemSelectedId != itemPurchasedId)
                        {
                            itemStock -= Convert.ToDecimal(gridviewpurchaseditems.Rows[i].Cells["Quantity"].Value);
                        }
                    }
                }
                if (spineditorquantity.Value > itemStock)
                {
                    if (itemStock == 0)
                    {
                        MessageBox.Show("Sorry This Item is Out of Stock", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("We have Only " + itemStock.ToString() + " " + lblunit.Text + " " + "You cannot Buy More than that...", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
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

        private void gridviewpurchaseditems_CellClick(object sender, GridViewCellEventArgs e)
        {
            btnitemdelete.Enabled = true;
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
            //itemPurchased = 0;
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

        private bool validateControls()
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
                return true;
            }
            return false;
        }

        private void btnadditem_Click(object sender, EventArgs e)
        {
            if (validateControls())
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
                bool disType = false, taxType = false;

                rowInfo.Cells[0].Value = itemPurchasedId;
                rowInfo.Cells[1].Value = drpitem.Text;
                rowInfo.Cells[2].Value = spineditorprice.Value.ToString();
                rowInfo.Cells[3].Value = spineditorquantity.Value.ToString();
                rowInfo.Cells[4].Value = lblunit.Text;
                rowInfo.Cells[5].Value = spineditortotalamount.Value.ToString();

                rowInfo.Cells[6].Value = itemDiscount.ToString();
                if (toggleswitchdiscount.Value)
                {
                    disType = true;
                }
                rowInfo.Cells[7].Value = disType;

                rowInfo.Cells[8].Value = itemTax.ToString();
                if (toggleswitchtax.Value)
                {
                    taxType = true;
                }
                rowInfo.Cells[9].Value = taxType;

                rowInfo.Cells[10].Value = itemPayableAmount;

                gridviewpurchaseditems.Rows.Add(rowInfo);
                gridviewpurchaseditems.BestFitColumns();
                gridviewpurchaseditems.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

                itemPurchasedId = 0;
                lblunit.Visible = false;
                spineditorprice.Value = spineditorquantity.Value = spineditortotalamount.Value = 0;
                spineditordiscount.Value = spineditortax.Value = spineditorpayableamount.Value = spineditorpaidamount.Value = 0;
                toggleswitchdiscount.Value = toggleswitchtax.Value = false;
            }
        }
        private void gridviewpurchaseditems_RowsChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            if (gridviewpurchaseditems.Rows.Count > 0)
            {
                btngeneratebill.Enabled = true;
            }
            else
            {
                btngeneratebill.Enabled = false;
                btnitemdelete.Enabled = false;
            }
        }

        private void gridviewpurchaseditems_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            igonoreDropdownIndexChangedEvent = true;
            btnitemupdate.Enabled = true;

            gridviewItemSelectedId = itemPurchasedId = Convert.ToInt32(gridviewpurchaseditems.SelectedRows[0].Cells[0].Value);
            drpitem.SelectedValue = Convert.ToInt32(gridviewpurchaseditems.SelectedRows[0].Cells[0].Value);
            spineditorprice.Value = Convert.ToDecimal(gridviewpurchaseditems.SelectedRows[0].Cells["Price"].Value);
            spineditorquantity.Value = Convert.ToDecimal(gridviewpurchaseditems.SelectedRows[0].Cells["Quantity"].Value);
            lblunit.Visible = true;
            lblunit.Text = gridviewpurchaseditems.SelectedRows[0].Cells["Unit"].Value.ToString();
            spineditortotalamount.Value = Convert.ToDecimal(gridviewpurchaseditems.SelectedRows[0].Cells["Total Amount"].Value);

            if (Convert.ToBoolean(gridviewpurchaseditems.SelectedRows[0].Cells["DiscountType"].Value))
            {
                toggleswitchdiscount.Value = true;
                decimal discountedPrice = spineditortotalamount.Value - (Convert.ToDecimal(gridviewpurchaseditems.SelectedRows[0].Cells["Discount"].Value));
                spineditordiscount.Value = (Convert.ToDecimal(gridviewpurchaseditems.SelectedRows[0].Cells["Discount"].Value) / spineditortotalamount.Value) * 100;
            }
            else
            {
                toggleswitchdiscount.Value = false;
                spineditordiscount.Value = Convert.ToDecimal(gridviewpurchaseditems.SelectedRows[0].Cells["Discount"].Value);
            }

            if (Convert.ToBoolean(gridviewpurchaseditems.SelectedRows[0].Cells["TaxType"].Value))
            {
                toggleswitchtax.Value = true;
                decimal priceAfterDiscount = (spineditortotalamount.Value - Convert.ToDecimal(gridviewpurchaseditems.SelectedRows[0].Cells["Discount"].Value));
                spineditortax.Value = (Convert.ToDecimal(gridviewpurchaseditems.SelectedRows[0].Cells["Tax"].Value) / priceAfterDiscount) * 100;
            }
            else
            {
                toggleswitchtax.Value = false;
                spineditortax.Value = Convert.ToDecimal(gridviewpurchaseditems.SelectedRows[0].Cells["Tax"].Value);
            }

            spineditorpayableamount.Value = Convert.ToDecimal(gridviewpurchaseditems.SelectedRows[0].Cells["Payable Amount"].Value);

            igonoreDropdownIndexChangedEvent = false;
        }

        private void btnitemupdate_Click(object sender, EventArgs e)
        {
            if (validateControls())
            {
                for (int i = 0; i < gridviewpurchaseditems.Rows.Count; i++)
                {
                    if (Convert.ToInt32(gridviewpurchaseditems.Rows[i].Cells["Id"].Value) == gridviewItemSelectedId)
                    {
                        gridviewpurchaseditems.Rows[i].Cells["Id"].Value = gridviewItemSelectedId;
                        gridviewpurchaseditems.Rows[i].Cells["Item"].Value = drpitem.SelectedText;
                        gridviewpurchaseditems.Rows[i].Cells["Price"].Value = spineditorprice.Value;
                        gridviewpurchaseditems.Rows[i].Cells["Quantity"].Value = spineditorquantity.Value;
                        gridviewpurchaseditems.Rows[i].Cells["Unit"].Value = lblunit.Text;
                        gridviewpurchaseditems.Rows[i].Cells["Total Amount"].Value = spineditortotalamount.Value;
                        gridviewpurchaseditems.Rows[i].Cells["Discount"].Value = itemDiscount;
                        gridviewpurchaseditems.Rows[i].Cells["DiscountType"].Value = toggleswitchdiscount.Value;
                        gridviewpurchaseditems.Rows[i].Cells["Tax"].Value = itemTax;
                        gridviewpurchaseditems.Rows[i].Cells["TaxType"].Value = toggleswitchtax.Value;
                        gridviewpurchaseditems.Rows[i].Cells["Payable Amount"].Value = spineditorpayableamount.Value;

                        gridviewItemSelectedId = itemPurchasedId = 0;
                        lblunit.Visible = false;
                        spineditorprice.Value = spineditorquantity.Value = spineditortotalamount.Value = 0;
                        spineditordiscount.Value = spineditortax.Value = spineditorpayableamount.Value = spineditorpaidamount.Value = 0;
                        toggleswitchdiscount.Value = toggleswitchtax.Value = false;
                        btnitemupdate.Enabled = false;
                        break;
                    }
                }
            }
        }

        private void btnitemdelete_Click(object sender, EventArgs e)
        {
            if (gridviewpurchaseditems.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Do you want to Delete . . . ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    gridviewpurchaseditems.Rows.Remove(gridviewpurchaseditems.SelectedRows[0]);
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clearControls();
        }
    }
}
