namespace GSMS
{
    partial class UsersForm
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
            Telerik.WinControls.UI.RadValidationRule radValidationRule1 = new Telerik.WinControls.UI.RadValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.txtcity = new Telerik.WinControls.UI.RadTextBox();
            this.txtmail = new Telerik.WinControls.UI.RadTextBox();
            this.txtcontactnumber = new Telerik.WinControls.UI.RadTextBox();
            this.txtpassword = new Telerik.WinControls.UI.RadTextBox();
            this.txtusername = new Telerik.WinControls.UI.RadTextBox();
            this.txtlastname = new Telerik.WinControls.UI.RadTextBox();
            this.txtfirstname = new Telerik.WinControls.UI.RadTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbfemale = new Telerik.WinControls.UI.RadRadioButton();
            this.rdbmale = new Telerik.WinControls.UI.RadRadioButton();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnadduser = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dropdownrole = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.visualStudio2022LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2022LightTheme();
            this.epgender = new System.Windows.Forms.ErrorProvider(this.components);
            this.edpcreateddate = new System.Windows.Forms.ErrorProvider(this.components);
            this.eprole = new System.Windows.Forms.ErrorProvider(this.components);
            this.validatorForTextBoxes = new Telerik.WinControls.UI.RadValidationProvider(this.components);
            this.erpEmail = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtcity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcontactnumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtusername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlastname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfirstname)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdbfemale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbmale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropdownrole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epgender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edpcreateddate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorForTextBoxes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcity
            // 
            this.txtcity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtcity.Location = new System.Drawing.Point(156, 466);
            this.txtcity.MaxLength = 20;
            this.txtcity.Name = "txtcity";
            this.txtcity.ShowClearButton = true;
            this.txtcity.Size = new System.Drawing.Size(196, 24);
            this.txtcity.TabIndex = 8;
            this.txtcity.ThemeName = "Crystal";
            this.validatorForTextBoxes.SetValidationRule(this.txtcity, radValidationRule1);
            this.txtcity.TextChanged += new System.EventHandler(this.txtcity_TextChanged);
            this.txtcity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcity_KeyPress);
            // 
            // txtmail
            // 
            this.txtmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtmail.Location = new System.Drawing.Point(156, 406);
            this.txtmail.MaxLength = 50;
            this.txtmail.Name = "txtmail";
            this.txtmail.ShowClearButton = true;
            this.txtmail.Size = new System.Drawing.Size(196, 24);
            this.txtmail.TabIndex = 5;
            this.txtmail.ThemeName = "Crystal";
            this.validatorForTextBoxes.SetValidationRule(this.txtmail, radValidationRule1);
            this.txtmail.TextChanged += new System.EventHandler(this.txtmail_TextChanged);
            // 
            // txtcontactnumber
            // 
            this.txtcontactnumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtcontactnumber.Location = new System.Drawing.Point(156, 376);
            this.txtcontactnumber.MaxLength = 10;
            this.txtcontactnumber.Name = "txtcontactnumber";
            this.txtcontactnumber.ShowClearButton = true;
            this.txtcontactnumber.Size = new System.Drawing.Size(196, 24);
            this.txtcontactnumber.TabIndex = 4;
            this.txtcontactnumber.ThemeName = "Crystal";
            this.validatorForTextBoxes.SetValidationRule(this.txtcontactnumber, radValidationRule1);
            this.txtcontactnumber.TextChanged += new System.EventHandler(this.txtcontactnumber_TextChanged);
            this.txtcontactnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontactnumber_KeyPress);
            // 
            // txtpassword
            // 
            this.txtpassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtpassword.Location = new System.Drawing.Point(156, 346);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.ShowClearButton = true;
            this.txtpassword.Size = new System.Drawing.Size(196, 24);
            this.txtpassword.TabIndex = 3;
            this.txtpassword.ThemeName = "Crystal";
            this.validatorForTextBoxes.SetValidationRule(this.txtpassword, radValidationRule1);
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // txtusername
            // 
            this.txtusername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtusername.Location = new System.Drawing.Point(156, 316);
            this.txtusername.Name = "txtusername";
            this.txtusername.ShowClearButton = true;
            this.txtusername.Size = new System.Drawing.Size(196, 24);
            this.txtusername.TabIndex = 2;
            this.txtusername.ThemeName = "Crystal";
            this.validatorForTextBoxes.SetValidationRule(this.txtusername, radValidationRule1);
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // txtlastname
            // 
            this.txtlastname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtlastname.Location = new System.Drawing.Point(156, 286);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.ShowClearButton = true;
            this.txtlastname.Size = new System.Drawing.Size(196, 24);
            this.txtlastname.TabIndex = 1;
            this.txtlastname.ThemeName = "Crystal";
            this.validatorForTextBoxes.SetValidationRule(this.txtlastname, radValidationRule1);
            this.txtlastname.TextChanged += new System.EventHandler(this.txtlastname_TextChanged);
            this.txtlastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlastname_KeyPress);
            // 
            // txtfirstname
            // 
            this.txtfirstname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtfirstname.Location = new System.Drawing.Point(156, 256);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.ShowClearButton = true;
            this.txtfirstname.Size = new System.Drawing.Size(196, 24);
            this.txtfirstname.TabIndex = 0;
            this.txtfirstname.ThemeName = "Crystal";
            this.validatorForTextBoxes.SetValidationRule(this.txtfirstname, radValidationRule1);
            this.txtfirstname.TextChanged += new System.EventHandler(this.txtfirstname_TextChanged);
            this.txtfirstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfirstname_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.59649F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.40351F));
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel11, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel8, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtcity, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtmail, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtcontactnumber, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtpassword, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtusername, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtlastname, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtfirstname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnadduser, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.dropdownrole, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(399, 563);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(399, 563);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 253F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(399, 563);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel11.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel11.Location = new System.Drawing.Point(107, 498);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(43, 20);
            this.kryptonLabel11.TabIndex = 1;
            this.kryptonLabel11.Values.Text = "Role :";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel8.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel8.Location = new System.Drawing.Point(110, 468);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(40, 20);
            this.kryptonLabel8.TabIndex = 1;
            this.kryptonLabel8.Values.Text = "City :";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel7.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel7.Location = new System.Drawing.Point(91, 438);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(59, 20);
            this.kryptonLabel7.TabIndex = 1;
            this.kryptonLabel7.Values.Text = "Gender :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbfemale);
            this.panel1.Controls.Add(this.rdbmale);
            this.panel1.Location = new System.Drawing.Point(156, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 24);
            this.panel1.TabIndex = 6;
            // 
            // rdbfemale
            // 
            this.rdbfemale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbfemale.Location = new System.Drawing.Point(84, 3);
            this.rdbfemale.Name = "rdbfemale";
            this.rdbfemale.Size = new System.Drawing.Size(60, 19);
            this.rdbfemale.TabIndex = 7;
            this.rdbfemale.TabStop = false;
            this.rdbfemale.Text = "Female";
            this.rdbfemale.ThemeName = "Fluent";
            // 
            // rdbmale
            // 
            this.rdbmale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rdbmale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbmale.Location = new System.Drawing.Point(3, 3);
            this.rdbmale.Name = "rdbmale";
            this.rdbmale.Size = new System.Drawing.Size(48, 19);
            this.rdbmale.TabIndex = 6;
            this.rdbmale.Text = "Male";
            this.rdbmale.ThemeName = "Fluent";
            this.rdbmale.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel6.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel6.Location = new System.Drawing.Point(101, 408);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel6.TabIndex = 1;
            this.kryptonLabel6.Values.Text = "Email :";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel5.Location = new System.Drawing.Point(96, 378);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(54, 20);
            this.kryptonLabel5.TabIndex = 1;
            this.kryptonLabel5.Values.Text = "Phone :";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(78, 348);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel4.TabIndex = 1;
            this.kryptonLabel4.Values.Text = "Password :";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(75, 318);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(75, 20);
            this.kryptonLabel3.TabIndex = 1;
            this.kryptonLabel3.Values.Text = "Username :";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(72, 288);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(78, 20);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Last Name :";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(70, 258);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(80, 20);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "First Name :";
            // 
            // btnadduser
            // 
            this.btnadduser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnadduser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadduser.Location = new System.Drawing.Point(156, 530);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.btnadduser.Size = new System.Drawing.Size(100, 25);
            this.btnadduser.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadduser.TabIndex = 11;
            this.btnadduser.Values.Text = "Add";
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            // 
            // dropdownrole
            // 
            this.dropdownrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownrole.DropDownWidth = 196;
            this.dropdownrole.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Stock Administrator",
            "Billing Clerk"});
            this.dropdownrole.Location = new System.Drawing.Point(156, 496);
            this.dropdownrole.Name = "dropdownrole";
            this.dropdownrole.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.dropdownrole.Size = new System.Drawing.Size(196, 21);
            this.dropdownrole.StateCommon.ComboBox.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.dropdownrole.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dropdownrole.TabIndex = 13;
            this.dropdownrole.SelectedIndexChanged += new System.EventHandler(this.dropdownrole_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GSMS.Properties.Resources.UsersFormImg;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // epgender
            // 
            this.epgender.ContainerControl = this;
            this.epgender.Icon = ((System.Drawing.Icon)(resources.GetObject("epgender.Icon")));
            // 
            // edpcreateddate
            // 
            this.edpcreateddate.ContainerControl = this;
            this.edpcreateddate.Icon = ((System.Drawing.Icon)(resources.GetObject("edpcreateddate.Icon")));
            // 
            // eprole
            // 
            this.eprole.ContainerControl = this;
            this.eprole.Icon = ((System.Drawing.Icon)(resources.GetObject("eprole.Icon")));
            // 
            // validatorForTextBoxes
            // 
            this.validatorForTextBoxes.ValidationMode = Telerik.WinControls.UI.ValidationMode.Programmatically;
            radValidationRule1.Controls.Add(this.txtcity);
            radValidationRule1.Controls.Add(this.txtmail);
            radValidationRule1.Controls.Add(this.txtcontactnumber);
            radValidationRule1.Controls.Add(this.txtpassword);
            radValidationRule1.Controls.Add(this.txtusername);
            radValidationRule1.Controls.Add(this.txtlastname);
            radValidationRule1.Controls.Add(this.txtfirstname);
            radValidationRule1.Operator = Telerik.WinControls.Data.FilterOperator.IsNotLike;
            radValidationRule1.ToolTipText = "It Cannot Be Empty";
            radValidationRule1.ToolTipTitle = "";
            radValidationRule1.Value = "";
            this.validatorForTextBoxes.ValidationRules.AddRange(new Telerik.WinControls.Data.FilterDescriptor[] {
            radValidationRule1});
            // 
            // erpEmail
            // 
            this.erpEmail.ContainerControl = this;
            this.erpEmail.Icon = ((System.Drawing.Icon)(resources.GetObject("erpEmail.Icon")));
            // 
            // UsersForm
            // 
            this.AcceptButton = this.btnadduser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(399, 563);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(401, 600);
            this.MinimumSize = new System.Drawing.Size(401, 600);
            this.Name = "UsersForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(401, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "MaterialBlueGrey";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtcity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcontactnumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtusername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlastname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfirstname)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdbfemale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbmale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropdownrole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epgender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edpcreateddate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorForTextBoxes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.Themes.VisualStudio2022LightTheme visualStudio2022LightTheme1;
        public Telerik.WinControls.UI.RadTextBox txtfirstname;
        public Telerik.WinControls.UI.RadTextBox txtlastname;
        public Telerik.WinControls.UI.RadTextBox txtusername;
        public Telerik.WinControls.UI.RadTextBox txtpassword;
        public Telerik.WinControls.UI.RadTextBox txtcontactnumber;
        public Telerik.WinControls.UI.RadTextBox txtmail;
        public Telerik.WinControls.UI.RadRadioButton rdbfemale;
        public Telerik.WinControls.UI.RadRadioButton rdbmale;
        public Telerik.WinControls.UI.RadTextBox txtcity;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnadduser;
        private System.Windows.Forms.ErrorProvider epgender;
        private System.Windows.Forms.ErrorProvider edpcreateddate;
        private System.Windows.Forms.ErrorProvider eprole;
        public ComponentFactory.Krypton.Toolkit.KryptonComboBox dropdownrole;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadValidationProvider validatorForTextBoxes;
        private System.Windows.Forms.ErrorProvider erpEmail;
    }
}
