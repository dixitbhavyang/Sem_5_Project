using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace GSMS
{
    public partial class SupermarketRegistrationForm : RadForm
    {
        public SupermarketRegistrationForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(Connection.connectionString());
        SqlCommand cmd;
        public static object supermarket;
        bool logoChoosed = false;
        byte[] ImageData;

        private bool chooseLogo()
        {
            fileLogo.OpenFileDialogForm.ThemeName = "MaterialBlueGrey";
            fileLogo.OpenFileDialogForm.Text = "  Select Logo";
            fileLogo.OpenFileDialogForm.StartPosition = FormStartPosition.CenterScreen;
            fileLogo.OpenFileDialogForm.FileName = "Logo";
            fileLogo.OpenFileDialogForm.Filter = "|Image Files|*.jpg;*.png";
            DialogResult dr = fileLogo.ShowDialog();
            //MessageBox.Show(dr.ToString());
            if (dr == DialogResult.OK)
            {
                pictureLogo.Image = new Bitmap(fileLogo.OpenFileDialogForm.FileName);
                pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
                pictureLogo.BorderStyle = BorderStyle.None;

                return true;
            }
            return false;
        }

        public string imageToBase64()
        {
            MemoryStream ms = new MemoryStream();
            pictureLogo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            ImageData = ms.ToArray();
            return Convert.ToBase64String(ImageData);
        }
        private void SupermarketRegistrationForm_Load(object sender, EventArgs e)
        {
            RadMessageBox.ThemeName = "MaterialBlueGrey";
        }
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Suppress the input if it's not a letter or white space
            }
        }

        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Suppress the input if it's not a letter or white space
            }
        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If it's not a digit or a control character, suppress the keypress event
                e.Handled = true;
            }
        }

        private void txtPincode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If it's not a digit or a control character, suppress the keypress event
                e.Handled = true;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                erpTxtName.SetError(txtName, "It cannot be Empty . . .");
                txtName.Focus();
            }
            else
            {
                erpTxtName.Clear();
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                erpTxtAddress.SetError(txtAddress, "It cannot be Empty . . .");
                txtAddress.Focus();
            }
            else
            {
                erpTxtAddress.Clear();
            }
        }

        private void txtcity_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCity.Text))
            {
                erpTxtCity.SetError(txtCity, "It cannot be Empty . . .");
                txtCity.Focus();
            }
            else
            {
                erpTxtCity.Clear();
            }
        }

        private void txtPincode_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPincode.Text))
            {
                erpTxtPincode.SetError(txtPincode, "It cannot be Empty . . .");
                txtPincode.Focus();
            }
            else
            {
                erpTxtPincode.Clear();
            }
        }

        private void txtmail_TextChanged(object sender, EventArgs e)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailPattern);

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                erpTxtEmail.SetError(txtEmail, "It cannot be Empty . . .");
                txtEmail.Focus();
            }
            else if (!regex.IsMatch(txtEmail.Text))
            {
                erpTxtEmail.SetError(txtEmail, "Not a Valid Email address . . .");
                txtEmail.Focus();
            }
            else { erpTxtEmail.Clear(); }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                erpTxtPhone.SetError(txtPhone, "It cannot be Empty . . .");
                txtPhone.Focus();
            }
            else
            {
                erpTxtPhone.Clear();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                erpTxtUsername.SetError(txtUsername, "It cannot be Empty . . .");
                txtUsername.Focus();
            }
            else
            {
                erpTxtUsername.Clear();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                erpTxtPassword.SetError(txtPassword, "It cannot be Empty . . .");
                txtPassword.Focus();
            }
            else
            {
                erpTxtPassword.Clear();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                erpTxtAddress.Clear();
                erpTxtCity.Clear();
                erpTxtPincode.Clear();
                erpTxtEmail.Clear();
                erpTxtPhone.Clear();
                erpTxtUsername.Clear();
                erpTxtPassword.Clear();

                erpTxtName.SetError(txtName, "It cannot be Empty . . .");
                txtName.Focus();
            }
            else if (string.IsNullOrEmpty(txtAddress.Text))
            {
                erpTxtName.Clear();
                erpTxtCity.Clear();
                erpTxtPincode.Clear();
                erpTxtEmail.Clear();
                erpTxtPhone.Clear();
                erpTxtUsername.Clear();
                erpTxtPassword.Clear();

                erpTxtAddress.SetError(txtAddress, "It cannot be empty . . .");
                txtAddress.Focus();
            }
            else if (string.IsNullOrEmpty(txtCity.Text))
            {
                erpTxtName.Clear();
                erpTxtAddress.Clear();
                erpTxtPincode.Clear();
                erpTxtEmail.Clear();
                erpTxtPhone.Clear();
                erpTxtUsername.Clear();
                erpTxtPassword.Clear();

                erpTxtCity.SetError(txtCity, "It cannot be Empty . . .");
                txtCity.Focus();
            }
            else if (string.IsNullOrEmpty(txtPincode.Text))
            {
                erpTxtName.Clear();
                erpTxtAddress.Clear();
                erpTxtCity.Clear();
                erpTxtEmail.Clear();
                erpTxtPhone.Clear();
                erpTxtUsername.Clear();
                erpTxtPassword.Clear();

                erpTxtPincode.SetError(txtPincode, "It cannot be Empty . . .");
                txtPincode.Focus();
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                erpTxtName.Clear();
                erpTxtAddress.Clear();
                erpTxtCity.Clear();
                erpTxtPincode.Clear();
                erpTxtPhone.Clear();
                erpTxtUsername.Clear();
                erpTxtPassword.Clear();

                erpTxtEmail.SetError(txtEmail, "It cannot be Empty . . .");
                txtEmail.Focus();
            }
            else if (string.IsNullOrEmpty(txtPhone.Text))
            {
                erpTxtName.Clear();
                erpTxtAddress.Clear();
                erpTxtCity.Clear();
                erpTxtPincode.Clear();
                erpTxtEmail.Clear();
                erpTxtUsername.Clear();
                erpTxtPassword.Clear();

                erpTxtPhone.SetError(txtPhone, "It cannot be Empty . . .");
                txtPhone.Focus();
            }
            else if (string.IsNullOrEmpty(txtUsername.Text))
            {
                erpTxtName.Clear();
                erpTxtAddress.Clear();
                erpTxtCity.Clear();
                erpTxtPincode.Clear();
                erpTxtEmail.Clear();
                erpTxtPhone.Clear();
                erpTxtPassword.Clear();

                erpTxtUsername.SetError(txtUsername, "It cannot be Empty . . .");
                txtUsername.Focus();
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                erpTxtName.Clear();
                erpTxtAddress.Clear();
                erpTxtCity.Clear();
                erpTxtPincode.Clear();
                erpTxtEmail.Clear();
                erpTxtPhone.Clear();
                erpTxtUsername.Clear();

                erpTxtPassword.SetError(txtPassword, "It cannot be Empty . . .");
                txtPassword.Focus();
            }
            else if (!logoChoosed)
            {
                erpTxtName.Clear();
                erpTxtAddress.Clear();
                erpTxtCity.Clear();
                erpTxtPincode.Clear();
                erpTxtEmail.Clear();
                erpTxtPhone.Clear();
                erpTxtUsername.Clear();
                erpTxtPassword.Clear();

                RadMessageBox.Show("Please Select your Logo . . .", "", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
            }
            else
            {
                erpTxtName.Clear();
                erpTxtAddress.Clear();
                erpTxtCity.Clear();
                erpTxtPincode.Clear();
                erpTxtEmail.Clear();
                erpTxtPhone.Clear();
                erpTxtUsername.Clear();
                erpTxtPassword.Clear();

                cmd = new SqlCommand("SUPERMARKET_REGISTRATION", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NAME", txtName.Text);
                cmd.Parameters.AddWithValue("@ADDRESS", txtAddress.Text);
                cmd.Parameters.AddWithValue("@CITY", txtCity.Text);
                cmd.Parameters.AddWithValue("@PINCODE", txtPincode.Text);
                cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                cmd.Parameters.AddWithValue("@PHONE", txtPhone.Text);
                cmd.Parameters.AddWithValue("@LOGO", imageToBase64());
                con.Open();
                supermarket = cmd.ExecuteScalar();
                if ((Convert.ToInt32(supermarket) > 0))
                {
                    //MessageBox.Show("Data Inserted");
                    cmd = new SqlCommand("INSERT_USER", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FNAME", "-");
                    cmd.Parameters.AddWithValue("@LNAME", "-");
                    cmd.Parameters.AddWithValue("@UNAME", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@PASSWORD", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@PHONENO", "-");
                    cmd.Parameters.AddWithValue("@EMAIL", "-");
                    cmd.Parameters.AddWithValue("@GENDER", 1);
                    cmd.Parameters.AddWithValue("@CREATEDDATE", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
                    cmd.Parameters.AddWithValue("@CREATEDBY", Convert.ToInt32(supermarket));
                    cmd.Parameters.AddWithValue("@UPDATEDDATE", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
                    cmd.Parameters.AddWithValue("@UPDATEDBY", 1);
                    cmd.Parameters.AddWithValue("@ROLE", "Admin");
                    cmd.Parameters.AddWithValue("@CITY", "-");
                    int I = cmd.ExecuteNonQuery();
                    if (I > 0)
                    {
                        RadMessageBox.Show("You have to Give Name and Other Details of Admin After You log in . . . ", "", MessageBoxButtons.OK, RadMessageIcon.Info);
                        LogInForm2 lf = new LogInForm2();
                        this.Hide();
                        lf.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        cmd = new SqlCommand("DELETE_SUPERMARKET", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(supermarket));
                        RadMessageBox.Show("Cannot Insert Data, Please Try Again . . .", "", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    RadMessageBox.Show("Sorry there is Something Exception , Please try again . . .", "", MessageBoxButtons.OK);
                }
                con.Close();
            }
        }

        private void btnChooseLogo_Click(object sender, EventArgs e)
        {
            logoChoosed = chooseLogo();
        }
    }
}
