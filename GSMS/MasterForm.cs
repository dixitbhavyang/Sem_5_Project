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
        public static int userId, companyId, categoryId, itemId, inventoryId, staffMemberId, departmentId;
        public MasterForm()
        {
            InitializeComponent();
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
            gridviewusers.Columns.Add("Phone");
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
            int totalAvailableUsers = 0;
            foreach (DataRow item in dt.Rows)
            {
                string gender = "Female", status = "Not Active";
                GridViewDataRowInfo rowInfo = new GridViewDataRowInfo(this.gridviewusers.MasterView);
                //rowInfo.Cells[0].Value = item["FirstName"].ToString();
                rowInfo.Cells[0].Value = item["Id"].ToString();
                rowInfo.Cells[1].Value = item["FirstName"].ToString();
                rowInfo.Cells[2].Value = item["LastName"].ToString();
                rowInfo.Cells[3].Value = item["Username"].ToString();

                if (LoginForm.usertype.ToLower() != "admin")
                {
                    // For Encrypt Password . . .
                    string encrypted = "";
                    byte[] b1;

                    string original = item["Password"].ToString();
                    int hashCode = original.GetHashCode();
                    string withHash = original + hashCode.ToString();
                    b1 = Encoding.BigEndianUnicode.GetBytes(withHash);
                    encrypted = Convert.ToBase64String(b1);
                    rowInfo.Cells[4].Value = encrypted.Substring(0, 4);
                }
                else
                {
                    rowInfo.Cells[4].Value = item["Password"].ToString();
                }

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
                    totalAvailableUsers++;
                    status = "Active";
                    rowInfo.Cells[14].Style.ForeColor = Color.Green;
                    rowInfo.Cells[14].Style.BackColor = Color.Green;
                }
                else
                {
                    rowInfo.Cells[14].Style.ForeColor = Color.Red;
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
            btnTotalUsers.ButtonElement.ShowBorder = false;
            btnTotalUsers.Text = totalAvailableUsers.ToString();

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
            int totalAvailableComapnies = 0;
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
                    totalAvailableComapnies++;
                    status = "Active";
                    rowInfo.Cells[8].Style.ForeColor = Color.Green;
                }
                else
                {
                    rowInfo.Cells[8].Style.ForeColor = Color.Red;
                    status = "Not Active";
                }
                rowInfo.Cells[8].Value = status;

                gridviewcompany.Rows.Add(rowInfo);
            }
            //gridviewcompany.AutoSizeRows = true;
            btnTotalCompanies.ButtonElement.ShowBorder = false;
            btnTotalCompanies.Text = totalAvailableComapnies.ToString();

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
            int totalAvailableCategories = 0;
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
                    totalAvailableCategories++;
                    status = "Active";
                    rowInfo.Cells[8].Style.ForeColor = Color.Green;
                }
                else
                {
                    rowInfo.Cells[8].Style.ForeColor = Color.Red;
                    status = "Not Active";
                }
                rowInfo.Cells[8].Value = status;

                gridviewcategory.Rows.Add(rowInfo);
            }
            btnTotalCategories.ButtonElement.ShowBorder = false;
            btnTotalCategories.Text = totalAvailableCategories.ToString();

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
            int totalAvailableItems = 0;
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
                rowInfo.Cells[6].Value = row["Category"].ToString();
                rowInfo.Cells[7].Value = row["Company"].ToString();
                rowInfo.Cells[8].Value = Convert.ToDateTime(row["CreatedDate"]).ToString("dd/MMM/yyyy hh:mm:ss tt");
                rowInfo.Cells[9].Value = row["Created By"].ToString();
                rowInfo.Cells[10].Value = Convert.ToDateTime(row["UpdatedDate"]).ToString("dd/MMM/yyyy hh:mm:ss tt");
                rowInfo.Cells[11].Value = row["Updated By"].ToString();
                if (Convert.ToInt32(row["Status"]) == 1)
                {
                    totalAvailableItems++;
                    status = "Active";
                    rowInfo.Cells[12].Style.ForeColor = Color.Green;
                }
                else
                {
                    status = "Not Active";
                    rowInfo.Cells[12].Style.ForeColor = Color.Red;
                }
                rowInfo.Cells[12].Value = status;

                gridviewitem.Rows.Add(rowInfo);
            }
            //gridviewitem.AutoSizeRows = true;
            btnTotalItems.ButtonElement.ShowBorder = false;
            btnTotalItems.Text = totalAvailableItems.ToString();

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
                    rowInfo.Cells[12].Style.ForeColor = Color.Green;
                }
                else
                {
                    rowInfo.Cells[12].Style.ForeColor = Color.Red;
                }
                rowInfo.Cells[12].Value = status;
                gridviewinventory.Rows.Add(rowInfo);
            }

            //gridviewinventory.AutoSizeRows = true;
            gridviewinventory.BestFitColumns();
            gridviewinventory.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            gridviewinventory.ShowGroupedColumns = true;
        }

        private void getDepartmentRecords()
        {

            string query = "EXEC SELECT_DEPARTMENTS";

            da = new SqlDataAdapter(query, con);
            dt.Clear();
            da.Fill(dt);

            gridviewdepartment.Columns.Clear();
            gridviewdepartment.Rows.Clear();

            gridviewdepartment.Columns.Add("Id");
            gridviewdepartment.Columns[0].IsVisible = false;
            gridviewdepartment.Columns.Add("Name");
            gridviewdepartment.Columns.Add("Short Name");
            gridviewdepartment.Columns.Add("Phone");
            gridviewdepartment.Columns.Add("Description");
            gridviewdepartment.Columns.Add("Created Date");
            gridviewdepartment.Columns.Add("Created By");
            gridviewdepartment.Columns.Add("Last Updated");
            gridviewdepartment.Columns.Add("Updated By");
            gridviewdepartment.Columns.Add("Status");

            for (int i = 0; i < gridviewdepartment.Columns.Count; i++)
            {
                gridviewdepartment.Columns[i].TextAlignment = ContentAlignment.MiddleCenter;
            }
            int totalavailableDepartments = 0;
            foreach (DataRow row in dt.Rows)
            {
                string status = "";
                GridViewDataRowInfo rowInfo = new GridViewDataRowInfo(this.gridviewdepartment.MasterView);
                rowInfo.Cells[0].Value = row["Id"].ToString();
                rowInfo.Cells[1].Value = row["Name"].ToString();
                rowInfo.Cells[2].Value = row["ShortName"].ToString();
                rowInfo.Cells[3].Value = row["Phone"].ToString();
                rowInfo.Cells[4].Value = row["Description"].ToString();
                rowInfo.Cells[5].Value = Convert.ToDateTime(row["CreatedDate"]).ToString("dd/MMM/yyyy hh:mm:ss tt");
                rowInfo.Cells[6].Value = row["Created By"].ToString();
                rowInfo.Cells[7].Value = Convert.ToDateTime(row["LastUpdated"]).ToString("dd/MMM/yyyy hh:mm:ss tt");
                rowInfo.Cells[8].Value = row["Updated By"].ToString();
                if (Convert.ToInt32(row["Status"]) == 1)
                {
                    totalavailableDepartments++;
                    status = "Active";
                    rowInfo.Cells[9].Style.ForeColor = Color.Green;
                }
                else
                {
                    rowInfo.Cells[9].Style.ForeColor = Color.Red;
                    status = "Not Active";
                }
                rowInfo.Cells[9].Value = status;

                gridviewdepartment.Rows.Add(rowInfo);
            }
            //gridviewdepartment.AutoSizeRows = true;
            btnTotalDepartments.ButtonElement.ShowBorder = false;
            btnTotalDepartments.Text = totalavailableDepartments.ToString();

            gridviewdepartment.BestFitColumns();
            gridviewdepartment.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
        }

        private void getStaffRcords()
        {

            string query = "EXEC SELECT_STAFF";

            da = new SqlDataAdapter(query, con);
            dt.Clear();
            da.Fill(dt);

            gridviewstaff.Columns.Clear();
            gridviewstaff.Rows.Clear();

            gridviewstaff.Columns.Add("Id");
            gridviewstaff.Columns[0].IsVisible = false;
            gridviewstaff.Columns.Add("First Name");
            gridviewstaff.Columns.Add("Last Name");
            gridviewstaff.Columns.Add("Phone");
            gridviewstaff.Columns.Add("Email");
            gridviewstaff.Columns.Add("Gender");
            gridviewstaff.Columns.Add("Address");
            gridviewstaff.Columns.Add("Department");
            gridviewstaff.Columns.Add("Salary");
            gridviewstaff.Columns.Add("Join Date");
            gridviewstaff.Columns.Add("Created Date");
            gridviewstaff.Columns.Add("Created By");
            gridviewstaff.Columns.Add("Last Updated");
            gridviewstaff.Columns.Add("Updated By");
            gridviewstaff.Columns.Add("Status");

            for (int i = 0; i < gridviewstaff.Columns.Count; i++)
            {
                gridviewstaff.Columns[i].TextAlignment = ContentAlignment.MiddleCenter;
            }
            int totalAvailableStaff = 0;
            foreach (DataRow row in dt.Rows)
            {
                string status = "", gender = "";
                GridViewDataRowInfo rowInfo = new GridViewDataRowInfo(this.gridviewstaff.MasterView);
                rowInfo.Cells[0].Value = row["Id"].ToString();
                rowInfo.Cells[1].Value = row["FirstName"].ToString();
                rowInfo.Cells[2].Value = row["LastName"].ToString();
                rowInfo.Cells[3].Value = row["Phone"].ToString();
                rowInfo.Cells[4].Value = row["Email"].ToString();
                if (Convert.ToInt32(row["Gender"]) == 1)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                rowInfo.Cells[5].Value = gender;
                rowInfo.Cells[6].Value = row["Address"].ToString();
                rowInfo.Cells[7].Value = row["Department"].ToString();
                rowInfo.Cells[8].Value = row["Salary"].ToString();
                rowInfo.Cells[9].Value = Convert.ToDateTime(row["JoinDate"]).ToString("dd/MMM/yyyy");
                rowInfo.Cells[10].Value = Convert.ToDateTime(row["CreatedDate"]).ToString("dd/MMM/yyyy hh:mm:ss tt");
                rowInfo.Cells[11].Value = row["Created By"].ToString();
                rowInfo.Cells[12].Value = Convert.ToDateTime(row["LastUpdated"]).ToString("dd/MMM/yyyy hh:mm:ss tt");
                rowInfo.Cells[13].Value = row["Updated By"].ToString();
                if (Convert.ToInt32(row["Status"]) == 1)
                {
                    totalAvailableStaff++;
                    status = "Active";
                    rowInfo.Cells[14].Style.ForeColor = Color.Green;
                }
                else
                {
                    status = "Not Active";
                    rowInfo.Cells[14].Style.ForeColor = Color.Red;
                }
                rowInfo.Cells[14].Value = status;

                gridviewstaff.Rows.Add(rowInfo);
            }
            //gridviewstaff.AutoSizeRows = true;
            btnTotalStaff.ButtonElement.ShowBorder = false;
            btnTotalStaff.Text = totalAvailableStaff.ToString();

            gridviewstaff.BestFitColumns();
            gridviewstaff.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            gridviewstaff.ShowGroupedColumns = true;
        }
        private void getCustomerRecords()
        {

            string query = "EXEC SELECT_CUSTOMERS";

            da = new SqlDataAdapter(query, con);
            dt.Clear();
            da.Fill(dt);

            gridviewcustomer.Columns.Clear();
            gridviewcustomer.Rows.Clear();

            gridviewcustomer.Columns.Add("Id");
            gridviewcustomer.Columns[0].IsVisible = false;
            gridviewcustomer.Columns.Add("First Name");
            gridviewcustomer.Columns.Add("Last Name");
            gridviewcustomer.Columns.Add("Phone");
            gridviewcustomer.Columns.Add("Email");
            gridviewcustomer.Columns.Add("Gender");
            gridviewcustomer.Columns.Add("City");

            for (int i = 0; i < gridviewcustomer.Columns.Count; i++)
            {
                gridviewcustomer.Columns[i].TextAlignment = ContentAlignment.MiddleCenter;
            }

            foreach (DataRow row in dt.Rows)
            {
                string gender = "";
                GridViewDataRowInfo rowInfo = new GridViewDataRowInfo(this.gridviewcustomer.MasterView);
                rowInfo.Cells[0].Value = row["Id"].ToString();
                rowInfo.Cells[1].Value = row["FirstName"].ToString();
                rowInfo.Cells[2].Value = row["LastName"].ToString();
                rowInfo.Cells[3].Value = row["Phone"].ToString();
                rowInfo.Cells[4].Value = row["Email"].ToString();
                if (Convert.ToInt32(row["Gender"]) == 1)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                rowInfo.Cells[5].Value = gender;
                rowInfo.Cells[6].Value = row["City"].ToString();

                gridviewcustomer.Rows.Add(rowInfo);
            }
            //gridviewcustomer.AutoSizeRows = true;
            gridviewcustomer.BestFitColumns();
            gridviewcustomer.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
        }
        private void getBillRecords()
        {

            string query = "EXEC SELECT_BILLS";

            da = new SqlDataAdapter(query, con);
            dt.Clear();
            da.Fill(dt);

            gridviewbill.Columns.Clear();
            gridviewbill.Rows.Clear();

            gridviewbill.Columns.Add("Id");
            gridviewbill.Columns[0].IsVisible = false;
            gridviewbill.Columns.Add("Bill No.");
            gridviewbill.Columns.Add("Customer Name");
            gridviewbill.Columns.Add("Total Amount");
            gridviewbill.Columns.Add("Discount");
            gridviewbill.Columns.Add("Tax");
            gridviewbill.Columns.Add("Payable Amount");
            gridviewbill.Columns.Add("Bill Date");
            gridviewbill.Columns.Add("Created Date");
            gridviewbill.Columns.Add("Created By");

            for (int i = 0; i < gridviewbill.Columns.Count; i++)
            {
                gridviewbill.Columns[i].TextAlignment = ContentAlignment.MiddleCenter;
            }

            foreach (DataRow row in dt.Rows)
            {
                GridViewDataRowInfo rowInfo = new GridViewDataRowInfo(this.gridviewbill.MasterView);
                rowInfo.Cells[0].Value = row["Id"].ToString();
                rowInfo.Cells[1].Value = row["BillNo"].ToString();
                rowInfo.Cells[2].Value = row["Customer"].ToString();
                rowInfo.Cells[3].Value = row["TotalAmount"].ToString();
                rowInfo.Cells[4].Value = row["Discount"].ToString();
                rowInfo.Cells[5].Value = row["Tax"].ToString();
                rowInfo.Cells[6].Value = row["PayableAmount"].ToString();
                rowInfo.Cells[7].Value = Convert.ToDateTime(row["BillDate"]).ToString("dd/MM/yyyy hh:mm:ss tt");
                rowInfo.Cells[8].Value = Convert.ToDateTime(row["CreatedDate"]).ToString("dd/MM/yyyy hh:mm:ss tt");
                rowInfo.Cells[9].Value = row["Created By"].ToString();
                gridviewbill.Rows.Add(rowInfo);
            }
            //gridviewbill.AutoSizeRows = true;
            gridviewbill.BestFitColumns();
            gridviewbill.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
        }

        private void getSales()
        {
            string query = "EXEC SELECT_SALES";

            da = new SqlDataAdapter(query, con);
            dt.Clear();
            da.Fill(dt);

            gridviewsales.Columns.Clear();
            gridviewsales.Rows.Clear();

            gridviewsales.Columns.Add("Id");
            gridviewsales.Columns[0].IsVisible = false;
            gridviewsales.Columns.Add("Bill No.");
            gridviewsales.Columns.Add("Company");
            gridviewsales.Columns.Add("Category");
            gridviewsales.Columns.Add("Item");
            gridviewsales.Columns.Add("Quantity");
            gridviewsales.Columns.Add("Sale Date");

            for (int i = 0; i < gridviewsales.Columns.Count; i++)
            {
                gridviewsales.Columns[i].TextAlignment = ContentAlignment.MiddleCenter;
            }

            foreach (DataRow row in dt.Rows)
            {
                GridViewDataRowInfo rowInfo = new GridViewDataRowInfo(this.gridviewsales.MasterView);
                rowInfo.Cells[0].Value = row["Id"].ToString();
                rowInfo.Cells[1].Value = row["Bill Number"].ToString();
                rowInfo.Cells[2].Value = row["Company"].ToString();
                rowInfo.Cells[3].Value = row["Category"].ToString();
                rowInfo.Cells[4].Value = row["Item"].ToString();
                rowInfo.Cells[5].Value = row["Quantity"].ToString() + " " + row["Unit"].ToString();
                rowInfo.Cells[6].Value = Convert.ToDateTime(row["Date"]).ToString("dd/MM/yyyy hh:mm:ss tt");
                gridviewsales.Rows.Add(rowInfo);
            }
            //gridviewsales.AutoSizeRows = true;
            gridviewsales.BestFitColumns();
            gridviewsales.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
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
        private void getDepartmetnId()
        {
            departmentId = 0;
            for (int i = 0; i < gridviewdepartment.Rows.Count; i++)
            {
                if (gridviewdepartment.Rows[i].IsSelected)
                {
                    //MessageBox.Show(radGridView1.Rows[i].Cells["Id"].Value.ToString());
                    departmentId = Convert.ToInt32(gridviewdepartment.Rows[i].Cells["Id"].Value);
                }
            }
        }
        private void getStaffMemberId()
        {
            staffMemberId = 0;
            for (int i = 0; i < gridviewstaff.Rows.Count; i++)
            {
                if (gridviewstaff.Rows[i].IsSelected)
                {
                    //MessageBox.Show(radGridView1.Rows[i].Cells["Id"].Value.ToString());
                    staffMemberId = Convert.ToInt32(gridviewstaff.Rows[i].Cells["Id"].Value);
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
                inventoryF.drpunit.SelectedItem = dt.Rows[0].Field<String>("Unit");
                inventoryF.spineditorminimumstock.Value = dt.Rows[0].Field<Int32>("MinimumStock");
                inventoryF.spineditormaximumstock.Value = dt.Rows[0].Field<Int32>("MaximumStock");
                inventoryF.ShowDialog();
                getInventoryRecords();
            }
            inventoryId = 0;
            companyId = 0;
            categoryId = 0;
            itemId = 0;
        }

        private void editDepartment()
        {
            getDepartmetnId();
            dt.Clear();
            cmd = new SqlCommand("EDIT_DEPARTMENT", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", departmentId);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DepartmentForm df = new DepartmentForm();
                df.txtname.Text = dt.Rows[0].Field<string>("Name").ToString();
                df.txtshortname.Text = dt.Rows[0].Field<string>("ShortName").ToString();
                df.txtphone.Text = dt.Rows[0].Field<string>("Phone").ToString();
                df.txtdescription.Text = dt.Rows[0].Field<string>("Description");
                df.ShowDialog();
                getDepartmentRecords();
            }
            departmentId = 0;
        }
        private void editStaffMemebr()
        {
            getStaffMemberId();
            dt.Clear();
            cmd = new SqlCommand("EDIT_STAFF_MEMBER", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", staffMemberId);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                StaffForm sf = new StaffForm();
                sf.txtfirstname.Text = dt.Rows[0].Field<string>("FirstName").ToString();
                sf.txtlastname.Text = dt.Rows[0].Field<string>("LastName").ToString();
                sf.txtcontactnumber.Text = dt.Rows[0].Field<string>("Phone").ToString();
                sf.txtmail.Text = dt.Rows[0].Field<string>("Email");
                if (dt.Rows[0].Field<Boolean>("Gender"))
                {
                    sf.rdbmale.IsChecked = true;
                }
                else
                {
                    sf.rdbfemale.IsChecked = true;
                }
                sf.txtaddress.Text = dt.Rows[0].Field<string>("Address");
                departmentId = dt.Rows[0].Field<int>("DepartmentId");
                sf.txtmail.Text = dt.Rows[0].Field<string>("Email");
                sf.spineditorsalary.Value = dt.Rows[0].Field<Decimal>("Salary");
                sf.datetimejointdate.Value = dt.Rows[0].Field<DateTime>("JoinDate");
                sf.ShowDialog();
                getStaffRcords();
            }
            staffMemberId = 0;
            departmentId = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RadMessageBox.SetThemeName("MaterialBlueGrey");
            con.Open();
            // TODO: This line of code loads data into the 'superMarketMS_ProjectDataSet.Users' table. You can move, or remove it, as needed.
            if (LoginForm.usertype.ToLower() == "admin")
            {
                btnedituser.Enabled = btndeleteuser.Enabled = btncompanyedit.Enabled = btncompanydelete.Enabled = btncategoryedit.Enabled = btncategorydelete.Enabled = btnitemedit.Enabled = btnitemdelete.Enabled = btninventoryedit.Enabled = btninventorydelete.Enabled = true;
            }
            else
            {
                btnedituser.Enabled = btndeleteuser.Enabled = btncompanyedit.Enabled = btncompanydelete.Enabled = btncategoryedit.Enabled = btncategorydelete.Enabled = btnitemedit.Enabled = btnitemdelete.Enabled = btninventoryedit.Enabled = btninventorydelete.Enabled = false;
            }
            getUserRecords();
            getCompanyRecords();
            getCategoryRecords();
            getItemRecords();
            getInventoryRecords();
            getDepartmentRecords();
            getStaffRcords();
            getCustomerRecords();
            getBillRecords();
            getSales();
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
                DialogResult result = RadMessageBox.Show("Do you want to Delete ?", "", MessageBoxButtons.YesNo, RadMessageIcon.Question);
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
                DialogResult result = RadMessageBox.Show("Do you want to Delete ?", "", MessageBoxButtons.YesNo, RadMessageIcon.Question);
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
                        RadMessageBox.Show("It Cannot be deleted because it has Categories : " + categories, "", MessageBoxButtons.OK, RadMessageIcon.Info, "You cannot delete this Company Because it has Some Categories , first You have to Delete those Categories to delete this Company");
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
                DialogResult res = RadMessageBox.Show("Do You wnat to Delete ?", "", MessageBoxButtons.YesNo, RadMessageIcon.Question);
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
                        RadMessageBox.Show("You cannot Delete this Category because it has Items : " + items, "Information", MessageBoxButtons.OK, RadMessageIcon.Info, "You cannot delete this Category Because it has Some Items , first You have to Delete those Items to delete this Category");
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
                DialogResult res = RadMessageBox.Show("Do You wnat to Delete ?", "", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (res == DialogResult.Yes)
                {
                    dr.Close();
                    cmd = new SqlCommand("DELETE_ITEM", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", itemId);
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        decimal stock = 0;
                        string unit = "";
                        while (dr.Read())
                        {
                            stock += Convert.ToDecimal(dr["Stock"]);
                            unit = dr["Unit"].ToString();
                        }
                        dr.Close();
                        RadMessageBox.Show("You cannot delete this Item because it has Stock : " + stock.ToString() + " " + unit, "", MessageBoxButtons.OK, RadMessageIcon.Info, "You cannot delete this Item because it has Stock in Inventory");
                    }
                    else
                    {
                        dr.Close();
                        getItemRecords();
                    }
                }
            }
            dr.Close();
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
                DialogResult res = RadMessageBox.Show("Do You wnat to Delete ?", "", MessageBoxButtons.YesNo, RadMessageIcon.Question);
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
        }
        private void btndepartmentadd_Click(object sender, EventArgs e)
        {
            DepartmentForm df = new DepartmentForm();
            df.ShowDialog();
            getDepartmentRecords();
        }
        private void btndepartmentedit_Click(object sender, EventArgs e)
        {
            editDepartment();
        }
        private void btndepartmentdelete_Click(object sender, EventArgs e)
        {
            getDepartmetnId();
            if (departmentId > 0)
            {
                cmd = new SqlCommand("EDIT_DEPARTMENT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", departmentId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DialogResult res = RadMessageBox.Show("Do You Want to Delete ?", "", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        dr.Close();
                        cmd = new SqlCommand("DELETE_DEPARTMENT", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID", departmentId);
                        dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            string staff = "";
                            while (dr.Read())
                            {
                                staff += "\n" + dr.GetString(0);
                            }
                            RadMessageBox.Show("You cannot Delete this Department because it has Staff : " + staff, "", MessageBoxButtons.OK, RadMessageIcon.Info, "You cannot delete this Department Because it has Staff");
                        }
                        else
                        {
                            dr.Close();
                            getDepartmentRecords();
                        }
                        dr.Close();
                    }
                }
                dr.Close();
            }
        }


        private void btnstaffmemberadd_Click(object sender, EventArgs e)
        {
            StaffForm sf = new StaffForm();
            sf.ShowDialog();
            getStaffRcords();
        }
        private void btnstaffmemberedit_Click(object sender, EventArgs e)
        {
            editStaffMemebr();
        }
        private void btnstaffmemberdelete_Click(object sender, EventArgs e)
        {
            getStaffMemberId();
            cmd = new SqlCommand("EDIT_STAFF_MEMBER", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", staffMemberId);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DialogResult res = RadMessageBox.Show("Do You Want to Delete ?", "", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (res == DialogResult.Yes)
                {
                    dr.Close();
                    cmd = new SqlCommand("DELETE_STAFF_MEMBER", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", staffMemberId);
                    cmd.ExecuteNonQuery();
                    getStaffRcords();
                }
            }
            dr.Close();
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
                if (LoginForm.usertype.ToLower() == "admin")
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
                if (LoginForm.usertype.ToLower() == "admin")
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
                if (LoginForm.usertype.ToLower() == "admin")
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
                if (LoginForm.usertype.ToLower() == "admin")
                {
                    btnitemedit.Enabled = btnitemdelete.Enabled = true;
                }
            }
            else { btnitemedit.Enabled = btnitemdelete.Enabled = false; }
        }
        private void gridviewinventory_SelectionChanged(object sender, EventArgs e)
        {
            bool isSelected = false;
            for (int i = 0; i < gridviewinventory.Rows.Count; i++)
            {
                if (gridviewinventory.Rows[i].IsSelected)
                {
                    isSelected = true;
                }
            }
            if (isSelected)
            {
                if (LoginForm.usertype.ToLower() == "admin")
                {
                    btninventoryedit.Enabled = btninventorydelete.Enabled = true;
                }
            }
            else { btninventoryedit.Enabled = btninventorydelete.Enabled = false; }
        }

        private void gridviewdepartment_SelectionChanged(object sender, EventArgs e)
        {
            bool isSelected = false;
            for (int i = 0; i < gridviewdepartment.Rows.Count; i++)
            {
                if (gridviewdepartment.Rows[i].IsSelected)
                {
                    isSelected = true;
                }
            }
            if (isSelected)
            {
                if (LoginForm.usertype.ToLower() == "admin")
                {
                    btndepartmentedit.Enabled = btndepartmentdelete.Enabled = true;
                }
            }
            else { btndepartmentedit.Enabled = btndepartmentdelete.Enabled = false; }
        }

        private void gridviewstaff_SelectionChanged(object sender, EventArgs e)
        {
            bool isSelected = false;
            for (int i = 0; i < gridviewstaff.Rows.Count; i++)
            {
                if (gridviewstaff.Rows[i].IsSelected)
                {
                    isSelected = true;
                }
            }
            if (isSelected)
            {
                if (LoginForm.usertype.ToLower() == "admin")
                {
                    btnstaffmemberedit.Enabled = btnstaffmemberdelete.Enabled = true;
                }
            }
            else { btnstaffmemberedit.Enabled = btnstaffmemberdelete.Enabled = false; }
        }

        private void btnbillnew_Click(object sender, EventArgs e)
        {
            BillForm bf = new BillForm();
            bf.ShowDialog();
            getBillRecords();
            getSales();
        }

        private void gridviewusers_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            if (LoginForm.usertype.ToLower() == "admin")
            {
                editUser();
            }
        }
        private void gridviewcompany_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            if (LoginForm.usertype.ToLower() == "admin")
            {
                editCompany();
            }
        }
        private void gridviewcategory_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            if (LoginForm.usertype.ToLower() == "admin")
            {
                editCategory();
            }
        }
        private void gridviewitem_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            if (LoginForm.usertype.ToLower() == "admin")
            {
                editItem();
            }
        }
        private void gridviewinventory_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            if (LoginForm.usertype.ToLower() == "admin")
            {
                editInventoryRecord();
            }
        }
        private void gridviewdepartment_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            if (LoginForm.usertype.ToLower() == "admin")
            {
                editDepartment();
            }
        }
        private void gridviewstaff_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            if (LoginForm.usertype.ToLower() == "admin")
            {
                editStaffMemebr();
            }
        }


        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text))
            {
                validatorForTextBoxes.Validate(txtCurrentPassword);
                txtCurrentPassword.Focus();
            }
            else { validatorForTextBoxes.ClearErrorStatus(txtCurrentPassword); }
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                validatorForTextBoxes.Validate(txtNewPassword);
                txtNewPassword.Focus();
            }
            else { validatorForTextBoxes.ClearErrorStatus(txtNewPassword); }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                validatorForTextBoxes.Validate(txtConfirmPassword);
                txtConfirmPassword.Focus();
            }
            else { validatorForTextBoxes.ClearErrorStatus(txtConfirmPassword); }
        }

        private void chkShowPassword_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (chkShowPassword.Checked)
            {
                txtCurrentPassword.UseSystemPasswordChar = txtNewPassword.UseSystemPasswordChar = txtConfirmPassword.UseSystemPasswordChar = false;
                txtCurrentPassword.PasswordChar = txtNewPassword.PasswordChar = txtConfirmPassword.PasswordChar = '\0';
            }
            else { txtCurrentPassword.UseSystemPasswordChar = txtNewPassword.UseSystemPasswordChar = txtConfirmPassword.UseSystemPasswordChar = true; }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtNewPassword);
                validatorForTextBoxes.ClearErrorStatus(txtConfirmPassword);

                validatorForTextBoxes.Validate(txtCurrentPassword);
                txtCurrentPassword.Focus();
            }
            else if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtCurrentPassword);
                validatorForTextBoxes.ClearErrorStatus(txtConfirmPassword);

                validatorForTextBoxes.Validate(txtNewPassword);
                txtNewPassword.Focus();
            }
            else if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                validatorForTextBoxes.ClearErrorStatus(txtCurrentPassword);
                validatorForTextBoxes.ClearErrorStatus(txtNewPassword);

                validatorForTextBoxes.Validate(txtConfirmPassword);
                txtConfirmPassword.Focus();
            }
            else if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                validatorForTextBoxes.ClearErrorStatus(txtCurrentPassword);
                validatorForTextBoxes.ClearErrorStatus(txtNewPassword);
                validatorForTextBoxes.ClearErrorStatus(txtConfirmPassword);

                validatorForConfirmPassword.Validate(txtConfirmPassword);
                txtConfirmPassword.Focus();
            }
            else
            {
                // CODE TO CHANGE PASSWORD . . .
                cmd = new SqlCommand("LOG_IN", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@USERNAME", LoginForm.username);
                cmd.Parameters.AddWithValue("@PASSWORD", txtCurrentPassword.Text);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    int userId = 0;
                    userId = Convert.ToInt32(dr["Id"]);
                    dr.Close();
                    cmd = new SqlCommand("CHANGE_PASSWORD", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", userId);
                    cmd.Parameters.AddWithValue("@NEWPASSWORD", txtConfirmPassword.Text);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        RadMessageBox.Show("Password Changed Successfully, You have to Restart the Application and Login again . . .", "", MessageBoxButtons.OK, RadMessageIcon.Info);
                        this.Close();
                    }
                }
                dr.Close();
            }
        }
    }
}
