namespace GSMS
{
    partial class SupermarketRegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupermarketRegistrationForm));
            Telerik.WinControls.UI.RadValidationRule radValidationRule1 = new Telerik.WinControls.UI.RadValidationRule();
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.btnChooseLogo = new Telerik.WinControls.UI.RadButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAddress = new Telerik.WinControls.UI.RadTextBox();
            this.txtEmail = new Telerik.WinControls.UI.RadTextBox();
            this.txtCity = new Telerik.WinControls.UI.RadTextBox();
            this.txtPhone = new Telerik.WinControls.UI.RadTextBox();
            this.txtPincode = new Telerik.WinControls.UI.RadTextBox();
            this.btnRegister = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtUsername = new Telerik.WinControls.UI.RadTextBox();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.fileLogo = new Telerik.WinControls.UI.RadOpenFileDialog();
            this.erpTxtName = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpTxtAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpTxtCity = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpTxtPincode = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpTxtEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpTxtPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpTxtUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpTxtPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.validatorForTextBoxes = new Telerik.WinControls.UI.RadValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChooseLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPincode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTxtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTxtAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTxtCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTxtPincode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTxtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTxtPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTxtUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTxtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorForTextBoxes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtName, 2);
            this.txtName.Location = new System.Drawing.Point(254, 4);
            this.txtName.Name = "txtName";
            this.txtName.NullText = "Name";
            this.txtName.ShowClearButton = true;
            this.txtName.ShowNullText = true;
            this.txtName.Size = new System.Drawing.Size(449, 36);
            this.txtName.TabIndex = 0;
            this.txtName.ThemeName = "MaterialBlueGrey";
            this.validatorForTextBoxes.SetValidationRule(this.txtName, radValidationRule1);
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 242F));
            this.tableLayoutPanel1.Controls.Add(this.pictureLogo, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnChooseLogo, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtAddress, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCity, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPhone, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtPincode, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnRegister, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.radLabel1, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtUsername, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 2, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(740, 422);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureLogo
            // 
            this.pictureLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureLogo.Image = global::GSMS.Properties.Resources.LogoDefaultImage;
            this.pictureLogo.Location = new System.Drawing.Point(254, 213);
            this.pictureLogo.Name = "pictureLogo";
            this.tableLayoutPanel1.SetRowSpan(this.pictureLogo, 2);
            this.pictureLogo.Size = new System.Drawing.Size(212, 114);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 23;
            this.pictureLogo.TabStop = false;
            // 
            // btnChooseLogo
            // 
            this.btnChooseLogo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnChooseLogo.BackColor = System.Drawing.Color.CadetBlue;
            this.btnChooseLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnChooseLogo.ForeColor = System.Drawing.Color.White;
            this.btnChooseLogo.Location = new System.Drawing.Point(254, 334);
            this.btnChooseLogo.Name = "btnChooseLogo";
            this.btnChooseLogo.Size = new System.Drawing.Size(211, 36);
            this.btnChooseLogo.TabIndex = 6;
            this.btnChooseLogo.Text = "Choose Profile";
            this.btnChooseLogo.ThemeName = "MaterialBlueGrey";
            this.btnChooseLogo.Click += new System.EventHandler(this.btnChooseLogo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GSMS.Properties.Resources.RegistrationFormImage;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 8);
            this.pictureBox1.Size = new System.Drawing.Size(245, 369);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtAddress
            // 
            this.txtAddress.AcceptsReturn = true;
            this.tableLayoutPanel1.SetColumnSpan(this.txtAddress, 2);
            this.txtAddress.Location = new System.Drawing.Point(254, 48);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.NullText = "Address";
            // 
            // 
            // 
            this.txtAddress.RootElement.StretchVertically = true;
            this.tableLayoutPanel1.SetRowSpan(this.txtAddress, 2);
            this.txtAddress.ShowClearButton = true;
            this.txtAddress.ShowNullText = true;
            this.txtAddress.Size = new System.Drawing.Size(449, 64);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.ThemeName = "MaterialBlueGrey";
            this.validatorForTextBoxes.SetValidationRule(this.txtAddress, null);
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(254, 169);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.NullText = "Email";
            this.txtEmail.ShowClearButton = true;
            this.txtEmail.ShowNullText = true;
            this.txtEmail.Size = new System.Drawing.Size(212, 36);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.ThemeName = "MaterialBlueGrey";
            this.validatorForTextBoxes.SetValidationRule(this.txtEmail, null);
            this.txtEmail.TextChanged += new System.EventHandler(this.txtmail_TextChanged);
            // 
            // txtCity
            // 
            this.txtCity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCity.Location = new System.Drawing.Point(254, 124);
            this.txtCity.MaxLength = 20;
            this.txtCity.Name = "txtCity";
            this.txtCity.NullText = "City";
            this.txtCity.ShowClearButton = true;
            this.txtCity.ShowNullText = true;
            this.txtCity.Size = new System.Drawing.Size(212, 36);
            this.txtCity.TabIndex = 2;
            this.txtCity.ThemeName = "MaterialBlueGrey";
            this.validatorForTextBoxes.SetValidationRule(this.txtCity, null);
            this.txtCity.TextChanged += new System.EventHandler(this.txtcity_TextChanged);
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCity_KeyPress);
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPhone.Location = new System.Drawing.Point(501, 169);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.NullText = "Phone No.";
            this.txtPhone.ShowClearButton = true;
            this.txtPhone.ShowNullText = true;
            this.txtPhone.Size = new System.Drawing.Size(202, 36);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.ThemeName = "MaterialBlueGrey";
            this.validatorForTextBoxes.SetValidationRule(this.txtPhone, null);
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtPincode
            // 
            this.txtPincode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPincode.Location = new System.Drawing.Point(501, 124);
            this.txtPincode.MaxLength = 6;
            this.txtPincode.Name = "txtPincode";
            this.txtPincode.NullText = "Pincode";
            this.txtPincode.ShowClearButton = true;
            this.txtPincode.ShowNullText = true;
            this.txtPincode.Size = new System.Drawing.Size(202, 36);
            this.txtPincode.TabIndex = 3;
            this.txtPincode.ThemeName = "MaterialBlueGrey";
            this.validatorForTextBoxes.SetValidationRule(this.txtPincode, null);
            this.txtPincode.TextChanged += new System.EventHandler(this.txtPincode_TextChanged);
            this.txtPincode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPincode_KeyPress);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.CadetBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.btnRegister, 3);
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegister.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(3, 378);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(734, 41);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.ThemeName = "MaterialBlueGrey";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(501, 229);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(125, 21);
            this.radLabel1.TabIndex = 20;
            this.radLabel1.Text = "Admin Credetials :";
            this.radLabel1.ThemeName = "MaterialBlueGrey";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUsername.Location = new System.Drawing.Point(501, 282);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.NullText = "Username";
            this.txtUsername.ShowClearButton = true;
            this.txtUsername.ShowNullText = true;
            this.txtUsername.Size = new System.Drawing.Size(202, 36);
            this.txtUsername.TabIndex = 7;
            this.txtUsername.ThemeName = "MaterialBlueGrey";
            this.validatorForTextBoxes.SetValidationRule(this.txtUsername, null);
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPassword.Location = new System.Drawing.Point(501, 334);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.NullText = "Password";
            this.txtPassword.ShowClearButton = true;
            this.txtPassword.ShowNullText = true;
            this.txtPassword.Size = new System.Drawing.Size(202, 36);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.ThemeName = "MaterialBlueGrey";
            this.validatorForTextBoxes.SetValidationRule(this.txtPassword, null);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // erpTxtName
            // 
            this.erpTxtName.ContainerControl = this;
            this.erpTxtName.Icon = ((System.Drawing.Icon)(resources.GetObject("erpTxtName.Icon")));
            // 
            // erpTxtAddress
            // 
            this.erpTxtAddress.ContainerControl = this;
            this.erpTxtAddress.Icon = ((System.Drawing.Icon)(resources.GetObject("erpTxtAddress.Icon")));
            // 
            // erpTxtCity
            // 
            this.erpTxtCity.ContainerControl = this;
            this.erpTxtCity.Icon = ((System.Drawing.Icon)(resources.GetObject("erpTxtCity.Icon")));
            // 
            // erpTxtPincode
            // 
            this.erpTxtPincode.ContainerControl = this;
            this.erpTxtPincode.Icon = ((System.Drawing.Icon)(resources.GetObject("erpTxtPincode.Icon")));
            // 
            // erpTxtEmail
            // 
            this.erpTxtEmail.ContainerControl = this;
            this.erpTxtEmail.Icon = ((System.Drawing.Icon)(resources.GetObject("erpTxtEmail.Icon")));
            // 
            // erpTxtPhone
            // 
            this.erpTxtPhone.ContainerControl = this;
            this.erpTxtPhone.Icon = ((System.Drawing.Icon)(resources.GetObject("erpTxtPhone.Icon")));
            // 
            // erpTxtUsername
            // 
            this.erpTxtUsername.ContainerControl = this;
            this.erpTxtUsername.Icon = ((System.Drawing.Icon)(resources.GetObject("erpTxtUsername.Icon")));
            // 
            // erpTxtPassword
            // 
            this.erpTxtPassword.ContainerControl = this;
            this.erpTxtPassword.Icon = ((System.Drawing.Icon)(resources.GetObject("erpTxtPassword.Icon")));
            // 
            // validatorForTextBoxes
            // 
            this.validatorForTextBoxes.ValidationMode = Telerik.WinControls.UI.ValidationMode.Programmatically;
            radValidationRule1.Controls.Add(this.txtName);
            radValidationRule1.Operator = Telerik.WinControls.Data.FilterOperator.IsNotLike;
            radValidationRule1.ToolTipText = "It Cannot Be Empty";
            radValidationRule1.ToolTipTitle = "";
            radValidationRule1.Value = "";
            this.validatorForTextBoxes.ValidationRules.AddRange(new Telerik.WinControls.Data.FilterDescriptor[] {
            radValidationRule1});
            // 
            // SupermarketRegistrationForm
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 422);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(742, 459);
            this.MinimumSize = new System.Drawing.Size(742, 459);
            this.Name = "SupermarketRegistrationForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(742, 459);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Supermarket Details";
            this.ThemeName = "MaterialBlueGrey";
            this.Load += new System.EventHandler(this.SupermarketRegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChooseLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPincode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTxtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTxtAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTxtCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTxtPincode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTxtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTxtPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTxtUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTxtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorForTextBoxes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Telerik.WinControls.UI.RadTextBox txtCity;
        public Telerik.WinControls.UI.RadTextBox txtEmail;
        public Telerik.WinControls.UI.RadTextBox txtPhone;
        public Telerik.WinControls.UI.RadTextBox txtPassword;
        public Telerik.WinControls.UI.RadTextBox txtUsername;
        public Telerik.WinControls.UI.RadTextBox txtAddress;
        public Telerik.WinControls.UI.RadTextBox txtName;
        private Telerik.WinControls.UI.RadButton btnRegister;
        public Telerik.WinControls.UI.RadTextBox txtPincode;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadOpenFileDialog fileLogo;
        private System.Windows.Forms.PictureBox pictureLogo;
        private Telerik.WinControls.UI.RadButton btnChooseLogo;
        private System.Windows.Forms.ErrorProvider erpTxtName;
        private System.Windows.Forms.ErrorProvider erpTxtAddress;
        private System.Windows.Forms.ErrorProvider erpTxtCity;
        private System.Windows.Forms.ErrorProvider erpTxtPincode;
        private System.Windows.Forms.ErrorProvider erpTxtEmail;
        private System.Windows.Forms.ErrorProvider erpTxtPhone;
        private System.Windows.Forms.ErrorProvider erpTxtUsername;
        private System.Windows.Forms.ErrorProvider erpTxtPassword;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private Telerik.WinControls.UI.RadValidationProvider validatorForTextBoxes;
    }
}