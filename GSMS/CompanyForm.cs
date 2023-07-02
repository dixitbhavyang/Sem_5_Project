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
    public partial class CompanyForm : RadForm
    {
        public CompanyForm()
        {
            InitializeComponent();
        }

        private void btnaddcomapny_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtcompanyname.Text))
            {
                erpcompanyname.SetError(txtcompanyname, "It Cannot be Empty");
                txtcompanyname.Focus();
            }
            else if (String.IsNullOrEmpty(txtshortname.Text))
            {
                erpcompanyname.Clear();
                erpshortname.SetError(txtshortname, "It Cannot be Empty");
                txtshortname.Focus();
            }
            else if (String.IsNullOrEmpty(txtaddress.Text))
            {
                erpcompanyname.Clear();
                erpshortname.Clear();
                erpaddress.SetError(txtaddress, "It Cannot be Empty");
                txtaddress.Focus();
            }
            else
            {
                erpcompanyname.Clear();
                erpshortname.Clear();
                erpaddress.Clear();
                btnaddcomapny.DialogResult = DialogResult.Yes;
            }
        }
    }
}
