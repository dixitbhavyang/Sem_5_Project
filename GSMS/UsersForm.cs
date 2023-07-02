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
    public partial class UsersForm : Telerik.WinControls.UI.RadForm
    {
        public string role = "";
        public UsersForm()
        {
            InitializeComponent();
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            role = "";
            if (String.IsNullOrEmpty(txtfirstname.Text))
            {
                epfirstname.SetError(txtfirstname, "It cannot be Empty");
                txtfirstname.Focus();
            }
            else if (String.IsNullOrEmpty(txtlastname.Text))
            {
                epfirstname.Clear();
                eplastname.SetError(txtlastname, "It cannot be Empty");
                txtlastname.Focus();
            }
            else if (String.IsNullOrEmpty(txtusername.Text))
            {
                epfirstname.Clear();
                eplastname.Clear();
                epusername.SetError(txtusername, "It cannot be Empty");
                txtusername.Focus();
            }
            else if (String.IsNullOrEmpty(txtpassword.Text))
            {
                epfirstname.Clear();
                eplastname.Clear();
                epusername.Clear();
                eppassword.SetError(txtpassword, "It cannot be Empty");
                txtpassword.Focus();
            }
            else if (String.IsNullOrEmpty(txtcontactnumber.Text))
            {
                epfirstname.Clear();
                eplastname.Clear();
                epusername.Clear();
                eppassword.Clear();
                epcontactnumber.SetError(txtcontactnumber, "It cannot be Empty");
                txtcontactnumber.Focus();
            }
            else if (String.IsNullOrEmpty(txtmail.Text))
            {
                epfirstname.Clear();
                eplastname.Clear();
                epusername.Clear();
                eppassword.Clear();
                epcontactnumber.Clear();
                epmail.SetError(txtmail, "It cannot be Empty");
                txtmail.Focus();
            }
            else if (String.IsNullOrEmpty(txtcity.Text))
            {
                epfirstname.Clear();
                eplastname.Clear();
                epusername.Clear();
                eppassword.Clear();
                epcontactnumber.Clear();
                epmail.Clear();
                epcity.SetError(txtcity, "It cannot be Empty");
                txtcity.Focus();
            }
            else if (rdbmale.IsChecked == false && rdbfemale.IsChecked == false)
            {
                epfirstname.Clear();
                eplastname.Clear();
                epusername.Clear();
                eppassword.Clear();
                epcontactnumber.Clear();
                epmail.Clear();
                epcity.Clear();
                epgender.SetError(panel1, "Please select Gender");
            }
            else if (dropdownrole.SelectedIndex < 0)
            {
                epfirstname.Clear();
                eplastname.Clear();
                epusername.Clear();
                eppassword.Clear();
                epcontactnumber.Clear();
                epmail.Clear();
                epcity.Clear(); epgender.Clear();
                eprole.SetError(dropdownrole, "Please Select a Role");
                dropdownrole.Focus();
            }
            else
            {
                epfirstname.Clear();
                epfirstname.Clear();
                eplastname.Clear();
                epusername.Clear();
                eppassword.Clear();
                epcontactnumber.Clear();
                epmail.Clear();
                epcity.Clear();
                epgender.Clear();
                eprole.Clear();
                role = dropdownrole.SelectedItem.ToString();
                btnadduser.DialogResult = DialogResult.Yes;
                //Close();
            }
            //Hide();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            if (MasterForm.userId > 0)
            {
                btnadduser.Text = "Update";
            }
        }
    }
}
