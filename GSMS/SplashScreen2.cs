using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace GSMS
{
    public partial class SplashScreen2 : RadForm
    {
        public SplashScreen2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(Connection.connectionString());
        SqlCommand cmd;
        SqlDataReader dr;

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value1 < 100)
            {
                progressBar.Value1 = i;
                i++;
            }
            else
            {
                timer1.Enabled = false;
                cmd = new SqlCommand("SELECT_SUPERMARKET_SETTINGS", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Close();
                    LogInForm2 lf = new LogInForm2();
                    this.Hide();
                    lf.ShowDialog();
                    this.Close();
                }
                else
                {
                    SupermarketRegistrationForm srf = new SupermarketRegistrationForm();
                    this.Hide();
                    srf.ShowDialog();
                    this.Close();
                }
                con.Close();
            }
        }

        private void SplashScreen2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
