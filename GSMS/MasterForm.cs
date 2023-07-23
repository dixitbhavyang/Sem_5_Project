﻿using System;
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
using Telerik.WinControls;

namespace GSMS
{
    public partial class MasterForm : Telerik.WinControls.UI.RadForm
    {
        SqlConnection con = new SqlConnection(Connection.connectionString());
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt = new DataTable();
        SqlDataAdapter da;
        public static int userId, companyId, categoryId, itemId, inventoryId;
        public MasterForm()
        {
            InitializeComponent();
            con.Open();
        }

        private void getUserRecords()
        {
            string query = "EXEC SELECT_USERS";

            da = new SqlDataAdapter(query, con);
            dt.Clear();
            da.Fill(dt);

            gridviewusers.Columns.Clear();
            gridviewusers.Rows.Clear();

            gridviewusers.Columns.Add("Id");
            gridviewusers.Columns["Id"].IsVisible = false;
            gridviewusers.Columns.Add("First Name");
            gridviewusers.Columns.Add("Last Name");
            gridviewusers.Columns.Add("Username");
            gridviewusers.Columns.Add("Password");
            gridviewusers.Columns.Add("ContactNo.");
            gridviewusers.Columns.Add("Email");
            gridviewusers.Columns.Add("Gender");
            gridviewusers.Columns.Add("City");
            gridviewusers.Columns.Add("Created Date");
            gridviewusers.Columns.Add("Created By");
            gridviewusers.Columns.Add("Last Updated");
            gridviewusers.Columns.Add("Updated By");
            gridviewusers.Columns.Add("Role");
            gridviewusers.Columns.Add("Status");
            gridviewusers.Columns.Add("Last LogIn");

            for (int i = 0; i < gridviewusers.Columns.Count; i++)
            {
                gridviewusers.Columns[i].TextAlignment = ContentAlignment.MiddleCenter;
            }

            foreach (DataRow item in dt.Rows)
            {
                string gender = "Female", status = "Not Active";
                GridViewDataRowInfo rowInfo = new GridViewDataRowInfo(this.gridviewusers.MasterView);
                //rowInfo.Cells[0].Value = item["FirstName"].ToString();
                rowInfo.Cells[0].Value = item["Id"].ToString();
                rowInfo.Cells[1].Value = item["FirstName"].ToString();
                rowInfo.Cells[2].Value = item["LastName"].ToString();
                rowInfo.Cells[3].Value = item["Username"].ToString();
                rowInfo.Cells[4].Value = item["Password"].ToString();
                rowInfo.Cells[5].Value = item["ContactNo"].ToString();
                rowInfo.Cells[6].Value = item["Email"].ToString();
                if (Convert.ToBoolean(item["Gender"]))
                {
                    gender = "Male";
                }
                rowInfo.Cells[7].Value = gender;
                rowInfo.Cells[8].Value = item["City"].ToString();
                rowInfo.Cells[9].Value = Convert.ToDateTime(item["CreatedDate"]).ToString("dd/MMM/yyyy hh:mm:ss tt");
                rowInfo.Cells[10].Value = item["Created By"].ToString();
                rowInfo.Cells[11].Value = Convert.ToDateTime(item["UpdatedDate"]).ToString("dd/MMM/yyyy hh:mm:ss tt");
                rowInfo.Cells[12].Value = item["Updated By"].ToString();
                rowInfo.Cells[13].Value = item["Role"].ToString();
                if (Convert.ToBoolean(item["Status"]))
                {
                    status = "Active";
                }
                rowInfo.Cells[14].Value = status;
                if (item["LastLogIn"] != DBNull.Value)
                {
                    rowInfo.Cells[15].Value = Convert.ToDateTime(item["LastLogIn"]).ToString("dd/MMM/yyyy hh:mm:ss tt"); ;
                }
                else { rowInfo.Cells[15].Value = "Never Logged In"; }


                gridviewusers.Rows.Add(rowInfo);
            }

            //gridviewusers.AutoSizeRows = true;
            gridviewusers.BestFitColumns();
            gridviewusers.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            gridviewusers.ShowGroupedColumns = true;
        }

        private void getCompanyRecords()
        {

            string query = "EXEC SELECT_COMPANIES";

            da = new SqlDataAdapter(query, con);
            dt.Clear();
            da.Fill(dt);

            gridviewcompany.Columns.Clear();
            gridviewcompany.Rows.Clear();

            gridviewcompany.Columns.Add("Id");
            gridviewcompany.Columns[0].IsVisible = false;
            gridviewcompany.Columns.Add("Company Name");
            gridviewcompany.Columns.Add("Short Name");
            gridviewcompany.Columns.Add("Created Date");
            gridviewcompany.Columns.Add("Created By");
            gridviewcompany.Columns.Add("Last Updated");
            gridviewcompany.Columns.Add("Updated By");
            gridviewcompany.Columns.Add("Address");
            gridviewcompany.Columns.Add("Status");

            for (int i = 0; i < gridviewcompany.Columns.Count; i++)
            {
                gridviewcompany.Columns[i].TextAlignment = ContentAlignment.MiddleCenter;
            }

            foreach (DataRow row in dt.Rows)
            {
                string status = "";
                GridViewDataRowInfo rowInfo = new GridViewDataRowInfo(this.gridviewcompany.MasterView);
                rowInfo.Cells[0].Value = row["Id"].ToString();
                rowInfo.Cells[1].Value = row["Name"].ToString();
                rowInfo.Cells[2].Value = row["ShortName"].ToString();
                rowInfo.Cells[3].Value = Convert.ToDateTime(row["CreatedDate"]).ToString("dd/MMM/yyyy hh:mm:ss tt");
                rowInfo.Cells[4].Value = row["Created By"].ToString();
                rowInfo.Cells[5].Value = Convert.ToDateTime(row["UpdatedDate"]).ToString("dd/MMM/yyyy hh:mm:ss tt");
                rowInfo.Cells[6].Value = row["Updated By"].ToString();
                rowInfo.Cells[7].Value = row["Address"].ToString();
                if (Convert.ToInt32(row["Status"]) == 1)
                {
                    status = "Active";
                }
                else
                {
                    status = "Not Active";
                }
                rowInfo.Cells[8].Value = status;

                gridviewcompany.Rows.Add(rowInfo);
            }
            //gridviewcompany.AutoSizeRows = true;
            gridviewcompany.BestFitColumns();
            gridviewcompany.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            gridviewcompany.ShowGroupedColumns = true;
        }

        private void getCategoryRecords()
        {
            string query = "EXEC SELECT_CATEGORIES";

            da = new SqlDataAdapter(query, con);
            dt.Clear();
            da.Fill(dt);

            gridviewcategory.Columns.Clear();
            gridviewcategory.Rows.Clear();

            gridviewcategory.Columns.Add("Id");
            gridviewcategory.Columns[0].IsVisible = false;
            gridviewcategory.Columns.Add("Category Name");
            gridviewcategory.Columns.Add("Short Name");
            gridviewcategory.Columns.Add("Created Date");
            gridviewcategory.Columns.Add("Created By");
            gridviewcategory.Columns.Add("Last Updated");
            gridviewcategory.Columns.Add("Updated By");
            gridviewcategory.Columns.Add("Company");
            gridviewcategory.Columns.Add("Status");

            for (int i = 0; i < gridviewcategory.Columns.Count; i++)
            {
                gridviewcategory.Columns[i].TextAlignment = ContentAlignment.MiddleCenter;
            }

            foreach (DataRow row in dt.Rows)
            {
                string status = "";
                GridViewDataRowInfo rowInfo = new GridViewDataRowInfo(this.gridviewcategory.MasterView);
                rowInfo.Cells[0].Value = row["Id"].ToString();
                rowInfo.Cells[1].Value = row["Name"].ToString();
                rowInfo.Cells[2].Value = row["ShortName"].ToString();
                rowInfo.Cells[3].Value = Convert.ToDateTime(row["CreatedDate"]).ToString("dd/MMM/yyyy hh:mm:ss tt");
                rowInfo.Cells[4].Value = row["Created By"].ToString();
                rowInfo.Cells[5].Value = Convert.ToDateTime(row["UpdatedDate"]).ToString("dd/MMM/yyyy hh:mm:ss tt");
                rowInfo.Cells[6].Value = row["Updated By"].ToString();
                rowInfo.Cells[7].Value = row["Company"].ToString();
                if (Convert.ToInt32(row["Status"]) == 1)
                {
                    status = "Active";
                }
                else
                {
                    status = "Not Active";
                }
                rowInfo.Cells[8].Value = status;

                gridviewcategory.Rows.Add(rowInfo);
            }
            //gridviewcategory.AutoSizeRows = true;
            gridviewcategory.BestFitColumns();
            gridviewcategory.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            gridviewcategory.ShowGroupedColumns = true;

        }

        private void getItemRecords()
        {
            string query = "EXEC SELECT_ITEMS";

            da = new SqlDataAdapter(query, con);
            dt.Clear();
            da.Fill(dt);

            gridviewitem.Columns.Clear();
            gridviewitem.Rows.Clear();

            gridviewitem.Columns.Add("Id");
            gridviewitem.Columns[0].IsVisible = false;
            gridviewitem.Columns.Add("Item Name");
            gridviewitem.Columns.Add("Short Name");
            gridviewitem.Columns.Add("Price");
            gridviewitem.Columns.Add("Discount");
            gridviewitem.Columns.Add("Tax");
            gridviewitem.Columns.Add("Expiry Date");
            gridviewitem.Columns.Add("Category");
            gridviewitem.Columns.Add("Company");
            gridviewitem.Columns.Add("Created Date");
            gridviewitem.Columns.Add("Created By");
            gridviewitem.Columns.Add("Last Updated");
            gridviewitem.Columns.Add("Updated By");
            gridviewitem.Columns.Add("Status");

            for (int i = 0; i < gridviewitem.Columns.Count; i++)
            {
                gridviewitem.Columns[i].TextAlignment = ContentAlignment.MiddleCenter;
            }

            foreach (DataRow row in dt.Rows)
            {
                string status = "";
                GridViewDataRowInfo rowInfo = new GridViewDataRowInfo(this.gridviewitem.MasterView);
                rowInfo.Cells[0].Value = row["Id"].ToString();
                rowInfo.Cells[1].Value = row["Name"].ToString();
                rowInfo.Cells[2].Value = row["ShortName"].ToString();
                rowInfo.Cells[3].Value = row["Price"].ToString();
                string discount = row["Discount"].ToString();
                if (Convert.ToInt32(row["DiscountType"]) == 1)
                {
                    discount += " %";
                }
                else
                {
                    discount += " Rs.";
                }
                rowInfo.Cells[4].Value = discount;
                string tax = row["Tax"].ToString();
                if (Convert.ToInt32(row["TaxType"]) == 1)
                {
                    tax += " %";
                }
                else
                {
                    tax += " Rs.";
                }
                rowInfo.Cells[5].Value = tax;
                rowInfo.Cells[6].Value = Convert.ToDateTime(row["ExpiryDate"]).ToString("dd/MMM/yyyy");
                rowInfo.Cells[7].Value = row["Category"].ToString();
                rowInfo.Cells[8].Value = row["Company"].ToString();
                rowInfo.Cells[9].Value = Convert.ToDateTime(row["CreatedDate"]).ToString("dd/MMM/yyyy hh:mm:ss tt");
                rowInfo.Cells[10].Value = row["Created By"].ToString();
                rowInfo.Cells[11].Value = Convert.ToDateTime(row["UpdatedDate"]).ToString("dd/MMM/yyyy hh:mm:ss tt");
                rowInfo.Cells[12].Value = row["Updated By"].ToString();
                if (Convert.ToInt32(row["Status"]) == 1)
                {
                    status = "Active";
                }
                else
                {
                    status = "Not Active";
                }
                rowInfo.Cells[13].Value = status;

                gridviewitem.Rows.Add(rowInfo);
            }
            //gridviewitem.AutoSizeRows = true;
            gridviewitem.BestFitColumns();
            gridviewitem.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            gridviewitem.ShowGroupedColumns = true;

        }

        private void getInventoryRecords()
        {
            string query = "EXEC SELECT_INVENTORY_RECORDS";

            da = new SqlDataAdapter(query, con);
            dt.Clear();
            da.Fill(dt);

            gridviewinventory.Columns.Clear();
            gridviewinventory.Rows.Clear();

            gridviewinventory.Columns.Add("Id");
            gridviewinventory.Columns["Id"].IsVisible = false;
            gridviewinventory.Columns.Add("Company");
            gridviewinventory.Columns.Add("Category");
            gridviewinventory.Columns.Add("Item");
            gridviewinventory.Columns.Add("Quantity");
            gridviewinventory.Columns.Add("Unit");
            gridviewinventory.Columns.Add("Created Date");
            gridviewinventory.Columns.Add("Created By");
            gridviewinventory.Columns.Add("Last Updated");
            gridviewinventory.Columns.Add("Updated By");
            gridviewinventory.Columns.Add("Minimum Stock");
            gridviewinventory.Columns.Add("Maximum Stock");
            gridviewinventory.Columns.Add("Status");

            for (int i = 0; i < gridviewinventory.Columns.Count; i++)
            {
                gridviewinventory.Columns[i].TextAlignment = ContentAlignment.MiddleCenter;
            }

            foreach (DataRow item in dt.Rows)
            {
                string status = "Not Active";
                GridViewDataRowInfo rowInfo = new GridViewDataRowInfo(this.gridviewinventory.MasterView);
                //rowInfo.Cells[0].Value = item["FirstName"].ToString();
                rowInfo.Cells[0].Value = item["Id"].ToString();
                rowInfo.Cells[1].Value = item["Company"].ToString();
                rowInfo.Cells[2].Value = item["Category"].ToString();
                rowInfo.Cells[3].Value = item["Item"].ToString();
                rowInfo.Cells[4].Value = item["Quantity"].ToString();
                rowInfo.Cells[5].Value = item["Unit"].ToString();
                rowInfo.Cells[6].Value = Convert.ToDateTime(item["CreatedDate"]).ToString("dd/MMM/yyyy hh:mm:ss tt");
                rowInfo.Cells[7].Value = item["Created By"].ToString();
                rowInfo.Cells[8].Value = Convert.ToDateTime(item["LastUpdated"]).ToString("dd/MMM/yyyy hh:mm:ss tt");
                rowInfo.Cells[9].Value = item["Updated By"].ToString();
                rowInfo.Cells[10].Value = item["MinimumStock"].ToString();
                rowInfo.Cells[11].Value = item["MaximumStock"].ToString();
                if (Convert.ToBoolean(item["Status"]))
                {
                    status = "Active";
                }
                rowInfo.Cells[12].Value = status;
                gridviewinventory.Rows.Add(rowInfo);
            }

            //gridviewinventory.AutoSizeRows = true;
            gridviewinventory.BestFitColumns();
            gridviewinventory.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            gridviewinventory.ShowGroupedColumns = true;
        }
        private void getUserId()
        {
            userId = 0;
            for (int i = 0; i < gridviewusers.Rows.Count; i++)
            {
                if (gridviewusers.Rows[i].IsSelected)
                {
                    //MessageBox.Show(radGridView1.Rows[i].Cells["Id"].Value.ToString());
                    userId = Convert.ToInt32(gridviewusers.Rows[i].Cells["Id"].Value);
                }
            }
        }
        private void getCompanyId()
        {
            companyId = 0;
            for (int i = 0; i < gridviewcompany.Rows.Count; i++)
            {
                if (gridviewcompany.Rows[i].IsSelected)
                {
                    //MessageBox.Show(radGridView1.Rows[i].Cells["Id"].Value.ToString());
                    companyId = Convert.ToInt32(gridviewcompany.Rows[i].Cells["Id"].Value);
                }
            }
        }
        private void getCategoryId()
        {
            categoryId = 0;
            for (int i = 0; i < gridviewcategory.Rows.Count; i++)
            {
                if (gridviewcategory.Rows[i].IsSelected)
                {
                    //MessageBox.Show(radGridView1.Rows[i].Cells["Id"].Value.ToString());
                    categoryId = Convert.ToInt32(gridviewcategory.Rows[i].Cells["Id"].Value);
                }
            }
        }
        private void getItemId()
        {
            itemId = 0;
            for (int i = 0; i < gridviewitem.Rows.Count; i++)
            {
                if (gridviewitem.Rows[i].IsSelected)
                {
                    //MessageBox.Show(radGridView1.Rows[i].Cells["Id"].Value.ToString());
                    itemId = Convert.ToInt32(gridviewitem.Rows[i].Cells["Id"].Value);
                }
            }
        }
        private void getInventoryId()
        {
            inventoryId = 0;
            for (int i = 0; i < gridviewinventory.Rows.Count; i++)
            {
                if (gridviewinventory.Rows[i].IsSelected)
                {
                    //MessageBox.Show(radGridView1.Rows[i].Cells["Id"].Value.ToString());
                    inventoryId = Convert.ToInt32(gridviewinventory.Rows[i].Cells["Id"].Value);
                }
            }
        }
        private void editUser()
        {
            getUserId();
            dt.Clear();
            cmd = new SqlCommand("EDIT_USER", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", userId);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                UsersForm uf = new UsersForm();
                uf.txtfirstname.Text = dt.Rows[0].ItemArray[1].ToString();
                uf.txtlastname.Text = dt.Rows[0].ItemArray[2].ToString();
                uf.txtusername.Text = dt.Rows[0].ItemArray[3].ToString();
                uf.txtpassword.Text = dt.Rows[0].ItemArray[4].ToString();
                uf.txtcontactnumber.Text = dt.Rows[0].ItemArray[5].ToString();
                uf.txtmail.Text = dt.Rows[0].ItemArray[6].ToString();
                if (dt.Rows[0].ItemArray[7].ToString() == "0")
                {
                    uf.rdbfemale.IsChecked = true;
                }
                else
                {
                    uf.rdbmale.IsChecked = true;
                }
                uf.txtcity.Text = dt.Rows[0].ItemArray[8].ToString();
                if (dt.Rows[0].ItemArray[13].ToString() == "Admin")
                {
                    uf.dropdownrole.SelectedIndex = 0;
                }
                else
                {
                    uf.dropdownrole.SelectedIndex = 1;
                }
                uf.ShowDialog();
                getUserRecords();
            }
            userId = 0;
        }

        private void editCompany()
        {
            getCompanyId();
            dt.Clear();
            cmd = new SqlCommand("EDIT_COMPANY", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", companyId);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                CompanyForm cf = new CompanyForm();
                cf.txtcompanyname.Text = dt.Rows[0].Field<string>("Name").ToString();
                cf.txtshortname.Text = dt.Rows[0].Field<string>("ShortName").ToString();
                cf.txtaddress.Text = dt.Rows[0].Field<string>("Address").ToString();
                cf.ShowDialog();
                getCompanyRecords();
            }
            companyId = 0;
        }

        private void editCategory()
        {
            getCategoryId();
            dt.Clear();
            cmd = new SqlCommand("EDIT_CATEGORY", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", categoryId);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                CategoryForm cf = new CategoryForm();
                companyId = dt.Rows[0].Field<Int32>("CompanyId");
                cf.txtcategoryname.Text = dt.Rows[0].Field<String>("Name");
                cf.txtshortname.Text = dt.Rows[0].Field<String>("ShortName");
                cf.ShowDialog();
                getCategoryRecords();
            }
            categoryId = 0;
            companyId = 0;
        }

        private void editItem()
        {
            getItemId();
            dt.Clear();
            cmd = new SqlCommand("EDIT_ITEM", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", itemId);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                ItemForm itemf = new ItemForm();
                companyId = dt.Rows[0].Field<Int32>("CompanyId");
                categoryId = dt.Rows[0].Field<Int32>("CategoryId");
                itemf.txtitemname.Text = dt.Rows[0].Field<String>("Name");
                itemf.txtshortname.Text = dt.Rows[0].Field<String>("ShortName");
                itemf.spineditorprice.Value = dt.Rows[0].Field<Decimal>("Price");
                decimal discount = dt.Rows[0].Field<Decimal>("Discount");
                if (dt.Rows[0].Field<Boolean>("DiscountType"))
                {
                    itemf.toggleswitchdiscount.Value = true;
                    discount *= 100;
                }
                itemf.spineditordiscount.Value = discount;
                decimal tax = dt.Rows[0].Field<Decimal>("Tax");
                if (dt.Rows[0].Field<Boolean>("TaxType"))
                {
                    itemf.toggleswitchtax.Value = true;
                    tax *= 100;
                }
                itemf.spineditortax.Value = tax;
                itemf.datetimeexpiration.Value = dt.Rows[0].Field<DateTime>("ExpiryDate");
                itemf.ShowDialog();
                getItemRecords();
            }
            itemId = 0;
            companyId = 0;
            categoryId = 0;
        }
        private void editInventoryRecord()
        {
            getInventoryId();
            dt.Clear();
            cmd = new SqlCommand("EDIT_INVENTORY_RECORD", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", inventoryId);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                InventoryForm inventoryF = new InventoryForm();
                companyId = dt.Rows[0].Field<Int32>("CompanyId");
                categoryId = dt.Rows[0].Field<Int32>("CategoryId");
                itemId = dt.Rows[0].Field<Int32>("ItemId");
                inventoryF.spineditorquantity.Value = dt.Rows[0].Field<Decimal>("Quantity");
                inventoryF.spineditorunit.Value = dt.Rows[0].Field<Int32>("Unit");
                inventoryF.spineditorminimumstock.Value = dt.Rows[0].Field<Int32>("MinimumStock");
                inventoryF.spineditormaximumstock.Value = dt.Rows[0].Field<Int32>("MaximumStock");
                inventoryF.ShowDialog();
                getInventoryRecords();
            }
            companyId = 0;
            categoryId = 0;
            itemId = 0;
            inventoryId = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'superMarketMS_ProjectDataSet.Users' table. You can move, or remove it, as needed.
            if (LoginForm.usertype == "Admin")
            {
                btnedituser.Enabled = btndeleteuser.Enabled = btncompanyedit.Enabled = btncompanydelete.Enabled = btncategoryedit.Enabled = btncategorydelete.Enabled = true;
            }
            else
            {
                btnedituser.Enabled = btndeleteuser.Enabled = btncompanyedit.Enabled = btncompanydelete.Enabled = btncategoryedit.Enabled = btncategorydelete.Enabled = false;
            }
            getUserRecords();
            getCompanyRecords();
            getCategoryRecords();
            getItemRecords();
            getInventoryRecords();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            UsersForm uf = new UsersForm();
            uf.ShowDialog();
            getUserRecords();
        }
        private void btnedituser_Click(object sender, EventArgs e)
        {
            editUser();
        }

        private void btndeleteuser_Click(object sender, EventArgs e)
        {
            getUserId();
            cmd = new SqlCommand("EDIT_USER", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", userId);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DialogResult result = MessageBox.Show("Do you want to Delete ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dr.Close();
                    cmd = new SqlCommand("DELETE_USER", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", userId);
                    cmd.ExecuteNonQuery();
                    getUserRecords();
                }
            }
            dr.Close();
            userId = 0;
        }

        private void btncompanyadd_Click(object sender, EventArgs e)
        {
            CompanyForm cf = new CompanyForm();
            cf.ShowDialog();
            getCompanyRecords();
        }
        private void btncompanyedit_Click(object sender, EventArgs e)
        {
            editCompany();
        }
        private void btncompanydelete_Click(object sender, EventArgs e)
        {
            getCompanyId();

            cmd = new SqlCommand("EDIT_COMPANY", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", companyId);
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                DialogResult result = MessageBox.Show("Do you want to Delete ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cmd = new SqlCommand("DELETE_COMPANY", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", companyId);
                    dr.Close();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        string categories = "";
                        while (dr.Read())
                        {
                            categories += "\n" + dr.GetString(0);
                        }
                        MessageBox.Show("It Cannot be deleted because it has Categories : " + categories, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dr.Close();
                        getCompanyRecords();
                    }
                    dr.Close();
                }
            }
            dr.Close();
            companyId = 0;
        }

        private void btncategoryadd_Click(object sender, EventArgs e)
        {
            CategoryForm cf = new CategoryForm();
            cf.ShowDialog();
            getCategoryRecords();
        }
        private void btncategoryedit_Click(object sender, EventArgs e)
        {
            editCategory();
        }
        private void btncategorydelete_Click(object sender, EventArgs e)
        {
            getCategoryId();
            cmd = new SqlCommand("EDIT_CATEGORY", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", categoryId);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DialogResult res = MessageBox.Show("Do You wnat to Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    dr.Close();
                    cmd = new SqlCommand("DELETE_CATEGORY", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", categoryId);
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        string items = "";
                        while (dr.Read())
                        {
                            items += "\n " + dr.GetString(0);
                        }
                        MessageBox.Show("You cannot Delete this Category because it has Items : " + items, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dr.Close();
                        getCategoryRecords();
                    }
                    dr.Close();
                }
            }
            dr.Close();
            categoryId = 0;
        }

        private void btnitemadd_Click(object sender, EventArgs e)
        {
            ItemForm itemf = new ItemForm();
            itemf.ShowDialog();
            getItemRecords();
        }
        private void btnitemedit_Click(object sender, EventArgs e)
        {
            editItem();
        }
        private void btnitemdelete_Click(object sender, EventArgs e)
        {
            getItemId();
            cmd = new SqlCommand("EDIT_ITEM", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", itemId);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DialogResult res = MessageBox.Show("Do You wnat to Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    dr.Close();
                    cmd = new SqlCommand("DELETE_ITEM", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", itemId);
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        int stock = 0;
                        while (dr.Read())
                        {
                            stock += dr.GetInt32(0);
                        }
                        dr.Close();
                        MessageBox.Show("You cannot delete this Item because it has Stock : " + stock.ToString() + " Units", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dr.Close();
                        getItemRecords();
                    }
                }
            }
            dr.Close();
            itemId = 0;
        }
        private void btninventoryadd_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.ShowDialog();
            getInventoryRecords();
        }
        private void btninventoryedit_Click(object sender, EventArgs e)
        {
            editInventoryRecord();
        }
        private void btninventorydelete_Click(object sender, EventArgs e)
        {
            getInventoryId();
            cmd = new SqlCommand("EDIT_INVENTORY_RECORD", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", inventoryId);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DialogResult res = MessageBox.Show("Do You wnat to Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    dr.Close();
                    cmd = new SqlCommand("DELETE_INVENTORY_RECORD", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", inventoryId);
                    cmd.ExecuteNonQuery();
                    getInventoryRecords();
                }
            }
            dr.Close();
            inventoryId = 0;
        }

        private void gridviewusers_SelectionChanged(object sender, EventArgs e)
        {
            bool isSelected = false;
            for (int i = 0; i < gridviewusers.Rows.Count; i++)
            {
                if (gridviewusers.Rows[i].IsSelected)
                {
                    isSelected = true;
                }
            }
            if (isSelected)
            {
                if (LoginForm.usertype == "Admin")
                {
                    btnedituser.Enabled = btndeleteuser.Enabled = true;
                }
            }
            else { btnedituser.Enabled = btndeleteuser.Enabled = false; }
        }
        private void gridviewcompany_SelectionChanged(object sender, EventArgs e)
        {
            bool isSelected = false;
            for (int i = 0; i < gridviewcompany.Rows.Count; i++)
            {
                if (gridviewcompany.Rows[i].IsSelected)
                {
                    isSelected = true;
                }
            }
            if (isSelected)
            {
                if (LoginForm.usertype == "Admin")
                {
                    btncompanydelete.Enabled = btncompanyedit.Enabled = true;
                }
            }
            else { btncompanydelete.Enabled = btncompanyedit.Enabled = false; }
        }
        private void gridviewcategory_SelectionChanged(object sender, EventArgs e)
        {
            bool isSelected = false;
            for (int i = 0; i < gridviewcategory.Rows.Count; i++)
            {
                if (gridviewcategory.Rows[i].IsSelected)
                {
                    isSelected = true;
                }
            }
            if (isSelected)
            {
                if (LoginForm.usertype == "Admin")
                {
                    btncategorydelete.Enabled = btncategoryedit.Enabled = true;
                }
            }
            else { btncategorydelete.Enabled = btncategoryedit.Enabled = false; }
        }
        private void gridviewitem_SelectionChanged(object sender, EventArgs e)
        {
            bool isSelected = false;
            for (int i = 0; i < gridviewitem.Rows.Count; i++)
            {
                if (gridviewitem.Rows[i].IsSelected)
                {
                    isSelected = true;
                }
            }
            if (isSelected)
            {
                if (LoginForm.usertype == "Admin")
                {
                    btnitemedit.Enabled = btnitemdelete.Enabled = true;
                }
            }
            else { btnitemedit.Enabled = btnitemdelete.Enabled = false; }
        }

        private void gridviewusers_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            editUser();
        }
        private void gridviewcompany_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            editCompany();
        }
        private void gridviewcategory_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            editCategory();
        }
        private void gridviewitem_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            editItem();
        }
        private void gridviewinventory_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            editInventoryRecord();
        }

    }
}
