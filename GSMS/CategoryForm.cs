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
using System.Windows.Controls;
using System.Windows.Documents;

namespace GSMS
{
    public partial class CategoryForm : RadForm
    {
        SqlConnection con = new SqlConnection(Connection.connectionString());
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        public CategoryForm()
        {
            InitializeComponent();
        }



        private void getCompanies()
        {
            Dictionary<int, string> source = new Dictionary<int, string>();
            source.Clear();
            dt.Clear();

            da = new SqlDataAdapter("EXEC SELECT_COMPANIES", con);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                source.Add(Convert.ToInt32(row.ItemArray[0]), row.ItemArray[1].ToString());
            }

            drpselectcompany.DataSource = new BindingSource(source, null);
            drpselectcompany.DisplayMember = "Value";
            drpselectcompany.ValueMember = "Key";
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            getCompanies();
        }
    }
}
