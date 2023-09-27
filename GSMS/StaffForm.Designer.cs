namespace GSMS
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            Telerik.WinControls.UI.RadValidationRule radValidationRule2 = new Telerik.WinControls.UI.RadValidationRule();
            Telerik.WinControls.UI.RadValidationRule radValidationRule1 = new Telerik.WinControls.UI.RadValidationRule();
            this.txtmail = new Telerik.WinControls.UI.RadTextBox();
            this.txtlastname = new Telerik.WinControls.UI.RadTextBox();
            this.txtfirstname = new Telerik.WinControls.UI.RadTextBox();
            this.txtcontactnumber = new Telerik.WinControls.UI.RadTextBox();
            this.txtaddress = new Telerik.WinControls.UI.RadTextBox();
            this.spineditorsalary = new Telerik.WinControls.UI.RadSpinEditor();
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbfemale = new Telerik.WinControls.UI.RadRadioButton();
            this.rdbmale = new Telerik.WinControls.UI.RadRadioButton();
            this.datetimejointdate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.btnaddstaffmember = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.drpdepartment = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.validatorForTextBoxes = new Telerik.WinControls.UI.RadValidationProvider(this.components);
            this.validatorForSpinEditor = new Telerik.WinControls.UI.RadValidationProvider(this.components);
            this.erpdepartment = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpEmail = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlastname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfirstname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcontactnumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spineditorsalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdbfemale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbmale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpdepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorForTextBoxes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorForSpinEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpdepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmail
            // 
            this.txtmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtmail.Location = new System.Drawing.Point(139, 319);
            this.txtmail.MaxLength = 50;
            this.txtmail.Name = "txtmail";
            this.txtmail.ShowClearButton = true;
            this.txtmail.Size = new System.Drawing.Size(219, 24);
            this.txtmail.TabIndex = 3;
            this.txtmail.ThemeName = "Crystal";
            this.validatorForSpinEditor.SetValidationRule(this.txtmail, null);
            this.validatorForTextBoxes.SetValidationRule(this.txtmail, radValidationRule2);
            this.txtmail.TextChanged += new System.EventHandler(this.txtmail_TextChanged);
            // 
            // txtlastname
            // 
            this.txtlastname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtlastname.Location = new System.Drawing.Point(139, 259);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.ShowClearButton = true;
            this.txtlastname.Size = new System.Drawing.Size(219, 24);
            this.txtlastname.TabIndex = 1;
            this.txtlastname.ThemeName = "Crystal";
            this.validatorForSpinEditor.SetValidationRule(this.txtlastname, null);
            this.validatorForTextBoxes.SetValidationRule(this.txtlastname, radValidationRule2);
            this.txtlastname.TextChanged += new System.EventHandler(this.txtlastname_TextChanged);
            this.txtlastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlastname_KeyPress);
            // 
            // txtfirstname
            // 
            this.txtfirstname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtfirstname.Location = new System.Drawing.Point(139, 229);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.ShowClearButton = true;
            this.txtfirstname.Size = new System.Drawing.Size(219, 24);
            this.txtfirstname.TabIndex = 0;
            this.txtfirstname.ThemeName = "Crystal";
            this.validatorForSpinEditor.SetValidationRule(this.txtfirstname, null);
            this.validatorForTextBoxes.SetValidationRule(this.txtfirstname, radValidationRule2);
            this.txtfirstname.TextChanged += new System.EventHandler(this.txtfirstname_TextChanged);
            this.txtfirstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfirstname_KeyPress);
            // 
            // txtcontactnumber
            // 
            this.txtcontactnumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtcontactnumber.Location = new System.Drawing.Point(139, 289);
            this.txtcontactnumber.MaxLength = 10;
            this.txtcontactnumber.Name = "txtcontactnumber";
            this.txtcontactnumber.ShowClearButton = true;
            this.txtcontactnumber.Size = new System.Drawing.Size(219, 24);
            this.txtcontactnumber.TabIndex = 2;
            this.txtcontactnumber.ThemeName = "Crystal";
            this.validatorForSpinEditor.SetValidationRule(this.txtcontactnumber, null);
            this.validatorForTextBoxes.SetValidationRule(this.txtcontactnumber, radValidationRule2);
            this.txtcontactnumber.TextChanged += new System.EventHandler(this.txtcontactnumber_TextChanged);
            this.txtcontactnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontactnumber_KeyPress);
            // 
            // txtaddress
            // 
            this.txtaddress.AcceptsReturn = true;
            this.txtaddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtaddress.AutoScroll = true;
            this.txtaddress.EmbeddedLabelText = "Address";
            this.txtaddress.Location = new System.Drawing.Point(139, 379);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            // 
            // 
            // 
            this.txtaddress.RootElement.StretchVertically = true;
            this.txtaddress.ShortcutsEnabled = false;
            this.txtaddress.ShowClearButton = true;
            this.txtaddress.Size = new System.Drawing.Size(219, 58);
            this.txtaddress.TabIndex = 6;
            this.txtaddress.ThemeName = "Crystal";
            this.validatorForSpinEditor.SetValidationRule(this.txtaddress, null);
            this.validatorForTextBoxes.SetValidationRule(this.txtaddress, radValidationRule2);
            this.txtaddress.TextChanged += new System.EventHandler(this.txtaddress_TextChanged);
            // 
            // spineditorsalary
            // 
            this.spineditorsalary.Location = new System.Drawing.Point(139, 474);
            this.spineditorsalary.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.spineditorsalary.Name = "spineditorsalary";
            this.spineditorsalary.ShowBorder = false;
            this.spineditorsalary.Size = new System.Drawing.Size(100, 24);
            this.spineditorsalary.TabIndex = 8;
            this.spineditorsalary.ThemeName = "Fluent";
            this.spineditorsalary.ThousandsSeparator = true;
            this.validatorForSpinEditor.SetValidationRule(this.spineditorsalary, radValidationRule1);
            this.validatorForTextBoxes.SetValidationRule(this.spineditorsalary, null);
            this.spineditorsalary.ValueChanged += new System.EventHandler(this.spineditorsalary_ValueChanged);
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.33584F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.66416F));
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel9, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtmail, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtlastname, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtfirstname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtcontactnumber, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtaddress, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.datetimejointdate, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.btnaddstaffmember, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel4, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.drpdepartment, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel8, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.spineditorsalary, 1, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(399, 563);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel9.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel9.Location = new System.Drawing.Point(88, 504);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(45, 20);
            this.kryptonLabel9.TabIndex = 2;
            this.kryptonLabel9.Values.Text = "Date :";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(69, 398);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(64, 20);
            this.kryptonLabel3.TabIndex = 13;
            this.kryptonLabel3.Values.Text = "Address :";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel7.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel7.Location = new System.Drawing.Point(74, 351);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(59, 20);
            this.kryptonLabel7.TabIndex = 11;
            this.kryptonLabel7.Values.Text = "Gender :";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel6.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel6.Location = new System.Drawing.Point(84, 321);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel6.TabIndex = 10;
            this.kryptonLabel6.Values.Text = "Email :";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel5.Location = new System.Drawing.Point(79, 291);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(54, 20);
            this.kryptonLabel5.TabIndex = 9;
            this.kryptonLabel5.Values.Text = "Phone :";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(55, 261);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(78, 20);
            this.kryptonLabel2.TabIndex = 8;
            this.kryptonLabel2.Values.Text = "Last Name :";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(53, 231);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(80, 20);
            this.kryptonLabel1.TabIndex = 3;
            this.kryptonLabel1.Values.Text = "First Name :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbfemale);
            this.panel1.Controls.Add(this.rdbmale);
            this.panel1.Location = new System.Drawing.Point(139, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 24);
            this.panel1.TabIndex = 4;
            // 
            // rdbfemale
            // 
            this.rdbfemale.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbfemale.Location = new System.Drawing.Point(84, 3);
            this.rdbfemale.Name = "rdbfemale";
            this.rdbfemale.Size = new System.Drawing.Size(57, 18);
            this.rdbfemale.TabIndex = 5;
            this.rdbfemale.TabStop = false;
            this.rdbfemale.Text = "Female";
            this.rdbfemale.ThemeName = "Fluent";
            // 
            // rdbmale
            // 
            this.rdbmale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rdbmale.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbmale.Location = new System.Drawing.Point(3, 3);
            this.rdbmale.Name = "rdbmale";
            this.rdbmale.Size = new System.Drawing.Size(46, 18);
            this.rdbmale.TabIndex = 4;
            this.rdbmale.Text = "Male";
            this.rdbmale.ThemeName = "Fluent";
            this.rdbmale.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // datetimejointdate
            // 
            this.datetimejointdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.datetimejointdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datetimejointdate.Location = new System.Drawing.Point(139, 504);
            this.datetimejointdate.Name = "datetimejointdate";
            this.datetimejointdate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.datetimejointdate.Size = new System.Drawing.Size(219, 21);
            this.datetimejointdate.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.datetimejointdate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.datetimejointdate.TabIndex = 9;
            // 
            // btnaddstaffmember
            // 
            this.btnaddstaffmember.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnaddstaffmember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddstaffmember.Location = new System.Drawing.Point(139, 533);
            this.btnaddstaffmember.Name = "btnaddstaffmember";
            this.btnaddstaffmember.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.btnaddstaffmember.Size = new System.Drawing.Size(100, 24);
            this.btnaddstaffmember.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddstaffmember.TabIndex = 10;
            this.btnaddstaffmember.Values.Text = "Add";
            this.btnaddstaffmember.Click += new System.EventHandler(this.btnaddstaffmember_Click);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(46, 446);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(87, 20);
            this.kryptonLabel4.TabIndex = 13;
            this.kryptonLabel4.Values.Text = "Department :";
            // 
            // drpdepartment
            // 
            this.drpdepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.drpdepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.drpdepartment.DropDownWidth = 219;
            this.drpdepartment.Location = new System.Drawing.Point(139, 444);
            this.drpdepartment.Name = "drpdepartment";
            this.drpdepartment.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.drpdepartment.Size = new System.Drawing.Size(219, 21);
            this.drpdepartment.StateCommon.ComboBox.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.drpdepartment.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.drpdepartment.TabIndex = 7;
            this.drpdepartment.Text = "Select Department";
            this.drpdepartment.TextChanged += new System.EventHandler(this.drpdepartment_TextChanged);
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel8.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel8.Location = new System.Drawing.Point(80, 476);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(53, 20);
            this.kryptonLabel8.TabIndex = 13;
            this.kryptonLabel8.Values.Text = "Salary :";
            // 
            // validatorForTextBoxes
            // 
            this.validatorForTextBoxes.ValidationMode = Telerik.WinControls.UI.ValidationMode.Programmatically;
            radValidationRule2.Controls.Add(this.txtmail);
            radValidationRule2.Controls.Add(this.txtlastname);
            radValidationRule2.Controls.Add(this.txtfirstname);
            radValidationRule2.Controls.Add(this.txtcontactnumber);
            radValidationRule2.Controls.Add(this.txtaddress);
            radValidationRule2.Operator = Telerik.WinControls.Data.FilterOperator.IsNotLike;
            radValidationRule2.ToolTipText = "It Cannot Be Empty";
            radValidationRule2.ToolTipTitle = "";
            radValidationRule2.Value = "";
            this.validatorForTextBoxes.ValidationRules.AddRange(new Telerik.WinControls.Data.FilterDescriptor[] {
            radValidationRule2});
            // 
            // validatorForSpinEditor
            // 
            this.validatorForSpinEditor.ValidationMode = Telerik.WinControls.UI.ValidationMode.Programmatically;
            radValidationRule1.Controls.Add(this.spineditorsalary);
            radValidationRule1.Operator = Telerik.WinControls.Data.FilterOperator.IsNotEqualTo;
            radValidationRule1.PropertyName = "Value";
            radValidationRule1.ToolTipText = "Value cannot be 0";
            radValidationRule1.ToolTipTitle = "";
            radValidationRule1.Value = 0;
            this.validatorForSpinEditor.ValidationRules.AddRange(new Telerik.WinControls.Data.FilterDescriptor[] {
            radValidationRule1});
            // 
            // erpdepartment
            // 
            this.erpdepartment.ContainerControl = this;
            this.erpdepartment.Icon = ((System.Drawing.Icon)(resources.GetObject("erpdepartment.Icon")));
            // 
            // erpEmail
            // 
            this.erpEmail.ContainerControl = this;
            this.erpEmail.Icon = ((System.Drawing.Icon)(resources.GetObject("erpEmail.Icon")));
            // 
            // StaffForm
            // 
            this.AcceptButton = this.btnaddstaffmember;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 563);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(401, 600);
            this.MinimumSize = new System.Drawing.Size(401, 600);
            this.Name = "StaffForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(401, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "MaterialBlueGrey";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlastname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfirstname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcontactnumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spineditorsalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdbfemale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbmale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpdepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorForTextBoxes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorForSpinEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpdepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        public Telerik.WinControls.UI.RadTextBox txtfirstname;
        public Telerik.WinControls.UI.RadTextBox txtlastname;
        public Telerik.WinControls.UI.RadTextBox txtcontactnumber;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        public Telerik.WinControls.UI.RadTextBox txtmail;
        private System.Windows.Forms.Panel panel1;
        public Telerik.WinControls.UI.RadRadioButton rdbfemale;
        public Telerik.WinControls.UI.RadRadioButton rdbmale;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        public Telerik.WinControls.UI.RadTextBox txtaddress;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        public ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker datetimejointdate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnaddstaffmember;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Telerik.WinControls.UI.RadValidationProvider validatorForTextBoxes;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Telerik.WinControls.UI.RadValidationProvider validatorForSpinEditor;
        private System.Windows.Forms.ErrorProvider erpdepartment;
        public ComponentFactory.Krypton.Toolkit.KryptonComboBox drpdepartment;
        public Telerik.WinControls.UI.RadSpinEditor spineditorsalary;
        private System.Windows.Forms.ErrorProvider erpEmail;
    }
}