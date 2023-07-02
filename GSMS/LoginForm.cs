using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Telerik.WinForms.UI;

namespace GSMS
{
    public partial class LoginForm : Telerik.WinControls.UI.RadForm
    {
        public static string usertype = "", username = "";
        public static int loggedInUserId = 0;
        SqlConnection con = new SqlConnection(Connection.connectionString());
        SqlCommand cmd;

        SqlDataReader dr;
        DataTable dt = new DataTable();


        public LoginForm()
        {

            InitializeComponent();
        }

        private void radCheckBox1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (chkshowpassword.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
                txtpassword.PasswordChar = '\0';
            }
            else { txtpassword.UseSystemPasswordChar = true; }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtusername.Text))
            {
                txtusername.Focus();
            }
            else if (String.IsNullOrEmpty(txtpassword.Text))
            {
                txtpassword.Focus();
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM USERS WHERE USERNAME=@uname AND PASSWORD=@password AND STATUS=1", con);
                cmd.Parameters.AddWithValue("@uname", txtusername.Text);
                cmd.Parameters.AddWithValue("@password", txtpassword.Text);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Hide();
                    dr.Read();
                    usertype = dr["Role"].ToString();
                    username = dr["Username"].ToString();
                    loggedInUserId = Convert.ToInt32(dr["Id"]);

                    dr.Close();

                    cmd = new SqlCommand("LAST_LOGIN", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", loggedInUserId);
                    cmd.Parameters.AddWithValue("@LASTLOGIN", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
                    cmd.ExecuteNonQuery();

                    MasterForm mf = new MasterForm();
                    mf.ShowDialog();
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Username or Password is Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dr.Close();
                con.Close();
            }
        }
    }
}
