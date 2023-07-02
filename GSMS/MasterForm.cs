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
    public partial class MasterForm : Telerik.WinControls.UI.RadForm
    {
        SqlConnection con = new SqlConnection(Connection.connectionString());
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt = new DataTable();
        SqlDataAdapter da;
        public static int userId, companyId;
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
            gridviewusers.Columns.Add("Updated Date");
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
                string gender = "Male", status = "Active";
                GridViewDataRowInfo rowInfo = new GridViewDataRowInfo(this.gridviewusers.MasterView);
                //rowInfo.Cells[0].Value = item["FirstName"].ToString();
                rowInfo.Cells[0].Value = item["Id"].ToString();
                rowInfo.Cells[1].Value = item["FirstName"].ToString();
                rowInfo.Cells[2].Value = item["LastName"].ToString();
                rowInfo.Cells[3].Value = item["Username"].ToString();
                rowInfo.Cells[4].Value = item["Password"].ToString();
                rowInfo.Cells[5].Value = item["ContactNo"].ToString();
                rowInfo.Cells[6].Value = item["Email"].ToString();
                if (item["Gender"].ToString() == "0")
                {
                    gender = "Female";
                }
                rowInfo.Cells[7].Value = gender;
                rowInfo.Cells[8].Value = item["City"].ToString();
                rowInfo.Cells[9].Value = Convert.ToDateTime(item["CreatedDate"]).ToString("dd/MMM/yyyy hh:mm:ss tt");
                rowInfo.Cells[10].Value = item["Created By"].ToString();
                rowInfo.Cells[11].Value = Convert.ToDateTime(item["UpdatedDate"]).ToString("dd/MMM/yyyy hh:mm:ss tt");
                rowInfo.Cells[12].Value = item["Updated By"].ToString();
                rowInfo.Cells[13].Value = item["Role"].ToString();
                if (item["Status"].ToString() == "0")
                {
                    status = "Not Active";
                }
                rowInfo.Cells[14].Value = status;
                if (item["LastLogIn"] != DBNull.Value)
                {
                    rowInfo.Cells[15].Value = Convert.ToDateTime(item["LastLogIn"]).ToString("dd/MMM/yyyy hh:mm:ss tt"); ;
                }
                else { rowInfo.Cells[15].Value = "Never Logged In"; }


                gridviewusers.Rows.Add(rowInfo);
            }

            gridviewusers.AutoSizeRows = true;
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
            gridviewcompany.Columns.Add("Updated Date");
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
            gridviewcompany.AutoSizeRows = true;
            gridviewcompany.BestFitColumns();
            gridviewcompany.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            gridviewcompany.ShowGroupedColumns = true;
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
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'superMarketMS_ProjectDataSet.Users' table. You can move, or remove it, as needed.
            if (LoginForm.usertype == "Admin")
            {
                btnedituser.Enabled = btndeleteuser.Enabled = btncompanyedit.Enabled = btncompanydelete.Enabled = true;
            }
            else
            {
                btnedituser.Enabled = btndeleteuser.Enabled = btncompanyedit.Enabled = btncompanydelete.Enabled = false;
            }
            getUserRecords();
            getCompanyRecords();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            UsersForm uf = new UsersForm();
            uf.ShowDialog();
            getUserRecords();
        }
        private void btnedituser_Click(object sender, EventArgs e)
        {
            getUserId();
            if (userId > 0)
            {
                dt.Clear();
                cmd = new SqlCommand("EDIT_USER", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", userId);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);

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

        private void btndeleteuser_Click(object sender, EventArgs e)
        {
            getUserId();
            if (userId > 0)
            {
                dr.Close();
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
            }
            userId = 0;
        }

        private void btncompanyadd_Click(object sender, EventArgs e)
        {
            CompanyForm cf = new CompanyForm();
            cf.ShowDialog();
        }

        private void btncompanydelete_Click(object sender, EventArgs e)
        {
            getCompanyId();
            if (companyId > 0)
            {
                cmd = new SqlCommand("EDIT_COMPANY", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", companyId);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DialogResult result = MessageBox.Show("Do you want to Delete ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dr.Close();
                        cmd = new SqlCommand("DELETE_COMPANY", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", companyId);
                        cmd.ExecuteNonQuery();
                        getCompanyRecords();
                    }
                }
                dr.Close();
            }
            companyId = 0;
        }

        private void btncompanyedit_Click(object sender, EventArgs e)
        {
            getCompanyId();
            if (companyId > 0)
            {
                dt.Clear();
                cmd = new SqlCommand("EDIT_COMPANY", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", companyId);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                CompanyForm cf = new CompanyForm();
                cf.txtcompanyname.Text = dt.Rows[0].Field<string>("Name").ToString();
                cf.txtshortname.Text = dt.Rows[0].Field<string>("ShortName").ToString();
                cf.txtaddress.Text = dt.Rows[0].Field<string>("Address").ToString();
                cf.ShowDialog();
                getCompanyRecords();
            }
        }
    }
}
