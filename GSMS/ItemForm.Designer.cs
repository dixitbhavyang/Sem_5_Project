namespace GSMS
{
    partial class ItemForm
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
            Telerik.WinControls.UI.RadValidationRule radValidationRule2 = new Telerik.WinControls.UI.RadValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemForm));
            Telerik.WinControls.UI.RadValidationRule radValidationRule1 = new Telerik.WinControls.UI.RadValidationRule();
            Telerik.WinControls.UI.RadValidationRuleWithTargetControl radValidationRuleWithTargetControl1 = new Telerik.WinControls.UI.RadValidationRuleWithTargetControl();
            this.txtitemname = new Telerik.WinControls.UI.RadTextBox();
            this.txtshortname = new Telerik.WinControls.UI.RadTextBox();
            this.spineditortax = new Telerik.WinControls.UI.RadSpinEditor();
            this.spineditordiscount = new Telerik.WinControls.UI.RadSpinEditor();
            this.spineditorprice = new Telerik.WinControls.UI.RadSpinEditor();
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnadditem = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.toggleswitchtax = new Telerik.WinControls.UI.RadToggleSwitch();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.toggleswitchdiscount = new Telerik.WinControls.UI.RadToggleSwitch();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.drpselectcategory = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.drpselectcompany = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.validatorForTextBoxes = new Telerik.WinControls.UI.RadValidationProvider(this.components);
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.erpcategory = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpdate = new System.Windows.Forms.ErrorProvider(this.components);
            this.validatorForSpinEditor = new Telerik.WinControls.UI.RadValidationProvider(this.components);
            this.validatorForDiscount = new Telerik.WinControls.UI.RadValidationProvider(this.components);
            this.erpcompany = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtitemname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtshortname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spineditortax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spineditordiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spineditorprice)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleswitchtax)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleswitchdiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpselectcategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpselectcompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorForTextBoxes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpcategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorForSpinEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorForDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpcompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtitemname
            // 
            this.txtitemname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtitemname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtitemname.Location = new System.Drawing.Point(132, 301);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.Size = new System.Drawing.Size(188, 24);
            this.txtitemname.TabIndex = 2;
            this.txtitemname.ThemeName = "Crystal";
            this.validatorForDiscount.SetValidationRule(this.txtitemname, null);
            this.validatorForSpinEditor.SetValidationRule(this.txtitemname, null);
            this.validatorForTextBoxes.SetValidationRule(this.txtitemname, radValidationRule2);
            this.txtitemname.TextChanged += new System.EventHandler(this.txtitemname_TextChanged);
            // 
            // txtshortname
            // 
            this.txtshortname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtshortname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtshortname.Location = new System.Drawing.Point(132, 333);
            this.txtshortname.Name = "txtshortname";
            this.txtshortname.Size = new System.Drawing.Size(188, 24);
            this.txtshortname.TabIndex = 3;
            this.txtshortname.ThemeName = "Crystal";
            this.validatorForDiscount.SetValidationRule(this.txtshortname, null);
            this.validatorForSpinEditor.SetValidationRule(this.txtshortname, null);
            this.validatorForTextBoxes.SetValidationRule(this.txtshortname, radValidationRule2);
            this.txtshortname.TextChanged += new System.EventHandler(this.txtshortname_TextChanged);
            // 
            // spineditortax
            // 
            this.spineditortax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.spineditortax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spineditortax.DecimalPlaces = 2;
            this.spineditortax.Location = new System.Drawing.Point(0, 1);
            this.spineditortax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.spineditortax.Name = "spineditortax";
            this.spineditortax.ShowBorder = false;
            this.spineditortax.Size = new System.Drawing.Size(87, 24);
            this.spineditortax.TabIndex = 6;
            this.spineditortax.ThemeName = "Fluent";
            this.spineditortax.ThousandsSeparator = true;
            this.validatorForDiscount.SetValidationRule(this.spineditortax, null);
            this.validatorForSpinEditor.SetValidationRule(this.spineditortax, null);
            this.validatorForTextBoxes.SetValidationRule(this.spineditortax, null);
            // 
            // spineditordiscount
            // 
            this.spineditordiscount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.spineditordiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spineditordiscount.DecimalPlaces = 2;
            this.spineditordiscount.Location = new System.Drawing.Point(0, 2);
            this.spineditordiscount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.spineditordiscount.Name = "spineditordiscount";
            this.spineditordiscount.ShowBorder = false;
            this.spineditordiscount.Size = new System.Drawing.Size(87, 24);
            this.spineditordiscount.TabIndex = 5;
            this.spineditordiscount.ThemeName = "Fluent";
            this.spineditordiscount.ThousandsSeparator = true;
            this.validatorForDiscount.SetValidationRule(this.spineditordiscount, radValidationRuleWithTargetControl1);
            this.validatorForSpinEditor.SetValidationRule(this.spineditordiscount, null);
            this.validatorForTextBoxes.SetValidationRule(this.spineditordiscount, null);
            // 
            // spineditorprice
            // 
            this.spineditorprice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spineditorprice.Location = new System.Drawing.Point(132, 364);
            this.spineditorprice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.spineditorprice.Name = "spineditorprice";
            this.spineditorprice.ShowBorder = false;
            this.spineditorprice.Size = new System.Drawing.Size(87, 24);
            this.spineditorprice.TabIndex = 4;
            this.spineditorprice.ThemeName = "Fluent";
            this.spineditorprice.ThousandsSeparator = true;
            this.validatorForDiscount.SetValidationRule(this.spineditorprice, null);
            this.validatorForSpinEditor.SetValidationRule(this.spineditorprice, radValidationRule1);
            this.validatorForTextBoxes.SetValidationRule(this.spineditorprice, null);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.54391F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.45609F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnadditem, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel6, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.spineditorprice, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtshortname, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtitemname, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.drpselectcategory, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel10, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.drpselectcompany, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(353, 489);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GSMS.Properties.Resources.ItemFormImage;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnadditem
            // 
            this.btnadditem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadditem.Location = new System.Drawing.Point(132, 460);
            this.btnadditem.Name = "btnadditem";
            this.btnadditem.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.btnadditem.Size = new System.Drawing.Size(90, 24);
            this.btnadditem.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnadditem.TabIndex = 10;
            this.btnadditem.Values.Text = "Add";
            this.btnadditem.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel6.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel6.Location = new System.Drawing.Point(88, 431);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(38, 20);
            this.kryptonLabel6.TabIndex = 1;
            this.kryptonLabel6.Values.Text = "Tax :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.kryptonLabel9);
            this.panel2.Controls.Add(this.toggleswitchtax);
            this.panel2.Controls.Add(this.spineditortax);
            this.panel2.Location = new System.Drawing.Point(132, 428);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 26);
            this.panel2.TabIndex = 13;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonLabel9.Location = new System.Drawing.Point(132, 3);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel9.TabIndex = 11;
            this.kryptonLabel9.Values.Text = "(In Per)";
            // 
            // toggleswitchtax
            // 
            this.toggleswitchtax.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.toggleswitchtax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleswitchtax.Location = new System.Drawing.Point(102, 6);
            this.toggleswitchtax.Name = "toggleswitchtax";
            this.toggleswitchtax.Size = new System.Drawing.Size(30, 15);
            this.toggleswitchtax.TabIndex = 9;
            this.toggleswitchtax.ThemeName = "MaterialBlueGrey";
            this.toggleswitchtax.Value = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kryptonLabel8);
            this.panel1.Controls.Add(this.toggleswitchdiscount);
            this.panel1.Controls.Add(this.spineditordiscount);
            this.panel1.Location = new System.Drawing.Point(132, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 26);
            this.panel1.TabIndex = 12;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonLabel8.Location = new System.Drawing.Point(132, 3);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel8.TabIndex = 10;
            this.kryptonLabel8.Values.Text = "(In Per)";
            // 
            // toggleswitchdiscount
            // 
            this.toggleswitchdiscount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.toggleswitchdiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleswitchdiscount.Location = new System.Drawing.Point(102, 8);
            this.toggleswitchdiscount.Name = "toggleswitchdiscount";
            this.toggleswitchdiscount.Size = new System.Drawing.Size(30, 15);
            this.toggleswitchdiscount.TabIndex = 8;
            this.toggleswitchdiscount.ThemeName = "MaterialBlueGrey";
            this.toggleswitchdiscount.Value = false;
            this.toggleswitchdiscount.ValueChanged += new System.EventHandler(this.toggleswitchdiscount_ValueChanged);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel5.Location = new System.Drawing.Point(57, 399);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(69, 20);
            this.kryptonLabel5.TabIndex = 1;
            this.kryptonLabel5.Values.Text = "Discount :";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(80, 367);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(46, 20);
            this.kryptonLabel4.TabIndex = 1;
            this.kryptonLabel4.Values.Text = "Price :";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(39, 335);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(87, 20);
            this.kryptonLabel3.TabIndex = 1;
            this.kryptonLabel3.Values.Text = "Short Name :";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(44, 303);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(82, 20);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Item Name :";
            // 
            // drpselectcategory
            // 
            this.drpselectcategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.drpselectcategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.drpselectcategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.drpselectcategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drpselectcategory.DropDownWidth = 164;
            this.drpselectcategory.Enabled = false;
            this.drpselectcategory.Location = new System.Drawing.Point(132, 270);
            this.drpselectcategory.Name = "drpselectcategory";
            this.drpselectcategory.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.drpselectcategory.Size = new System.Drawing.Size(188, 21);
            this.drpselectcategory.StateCommon.ComboBox.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.drpselectcategory.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.drpselectcategory.TabIndex = 1;
            this.drpselectcategory.TextChanged += new System.EventHandler(this.drpselectcategory_TextChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(56, 271);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(70, 20);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Category :";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel10.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel10.Location = new System.Drawing.Point(54, 239);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel10.TabIndex = 100;
            this.kryptonLabel10.Values.Text = "Company :";
            // 
            // drpselectcompany
            // 
            this.drpselectcompany.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.drpselectcompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.drpselectcompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.drpselectcompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drpselectcompany.DropDownWidth = 164;
            this.drpselectcompany.Location = new System.Drawing.Point(132, 238);
            this.drpselectcompany.Name = "drpselectcompany";
            this.drpselectcompany.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.drpselectcompany.Size = new System.Drawing.Size(188, 21);
            this.drpselectcompany.StateCommon.ComboBox.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.drpselectcompany.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.drpselectcompany.TabIndex = 0;
            this.drpselectcompany.SelectedIndexChanged += new System.EventHandler(this.drpselectcompany_SelectedIndexChanged);
            this.drpselectcompany.TextChanged += new System.EventHandler(this.drpselectcompany_TextChanged);
            // 
            // validatorForTextBoxes
            // 
            this.validatorForTextBoxes.ValidationMode = Telerik.WinControls.UI.ValidationMode.Programmatically;
            radValidationRule2.Controls.Add(this.txtitemname);
            radValidationRule2.Controls.Add(this.txtshortname);
            radValidationRule2.Operator = Telerik.WinControls.Data.FilterOperator.IsNotLike;
            radValidationRule2.ToolTipText = "It Cannot Be Empty ...";
            radValidationRule2.ToolTipTitle = "";
            radValidationRule2.Value = "";
            this.validatorForTextBoxes.ValidationRules.AddRange(new Telerik.WinControls.Data.FilterDescriptor[] {
            radValidationRule2});
            // 
            // erpcategory
            // 
            this.erpcategory.ContainerControl = this;
            this.erpcategory.Icon = ((System.Drawing.Icon)(resources.GetObject("erpcategory.Icon")));
            // 
            // erpdate
            // 
            this.erpdate.ContainerControl = this;
            this.erpdate.Icon = ((System.Drawing.Icon)(resources.GetObject("erpdate.Icon")));
            // 
            // validatorForSpinEditor
            // 
            this.validatorForSpinEditor.ValidationMode = Telerik.WinControls.UI.ValidationMode.Programmatically;
            radValidationRule1.Controls.Add(this.spineditorprice);
            radValidationRule1.Operator = Telerik.WinControls.Data.FilterOperator.IsNotEqualTo;
            radValidationRule1.PropertyName = "Value";
            radValidationRule1.ToolTipText = "Value cannot be 0";
            radValidationRule1.ToolTipTitle = "";
            radValidationRule1.Value = 0;
            this.validatorForSpinEditor.ValidationRules.AddRange(new Telerik.WinControls.Data.FilterDescriptor[] {
            radValidationRule1});
            // 
            // validatorForDiscount
            // 
            this.validatorForDiscount.ValidationMode = Telerik.WinControls.UI.ValidationMode.Programmatically;
            radValidationRuleWithTargetControl1.Controls.Add(this.spineditordiscount);
            radValidationRuleWithTargetControl1.Operator = Telerik.WinControls.Data.FilterOperator.IsLessThan;
            radValidationRuleWithTargetControl1.PropertyName = "Value";
            radValidationRuleWithTargetControl1.TargetControl = this.spineditorprice;
            radValidationRuleWithTargetControl1.TargetControlPropertyName = "Value";
            radValidationRuleWithTargetControl1.ToolTipText = "Discount cannot be Equal or More than Price";
            radValidationRuleWithTargetControl1.ToolTipTitle = "";
            this.validatorForDiscount.ValidationRules.AddRange(new Telerik.WinControls.Data.FilterDescriptor[] {
            radValidationRuleWithTargetControl1});
            // 
            // erpcompany
            // 
            this.erpcompany.ContainerControl = this;
            this.erpcompany.Icon = ((System.Drawing.Icon)(resources.GetObject("erpcompany.Icon")));
            // 
            // ItemForm
            // 
            this.AcceptButton = this.btnadditem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 489);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(355, 526);
            this.MinimumSize = new System.Drawing.Size(355, 526);
            this.Name = "ItemForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(355, 526);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "MaterialBlueGrey";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtitemname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtshortname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spineditortax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spineditordiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spineditorprice)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleswitchtax)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleswitchdiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpselectcategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpselectcompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorForTextBoxes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpcategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorForSpinEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorForDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpcompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Telerik.WinControls.UI.RadValidationProvider validatorForTextBoxes;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnadditem;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Telerik.WinControls.UI.RadValidationProvider validatorForSpinEditor;
        private System.Windows.Forms.ErrorProvider erpcategory;
        private System.Windows.Forms.ErrorProvider erpdate;
        public ComponentFactory.Krypton.Toolkit.KryptonComboBox drpselectcategory;
        public Telerik.WinControls.UI.RadTextBox txtitemname;
        public Telerik.WinControls.UI.RadTextBox txtshortname;
        public Telerik.WinControls.UI.RadSpinEditor spineditorprice;
        public Telerik.WinControls.UI.RadSpinEditor spineditordiscount;
        public Telerik.WinControls.UI.RadToggleSwitch toggleswitchdiscount;
        public Telerik.WinControls.UI.RadToggleSwitch toggleswitchtax;
        public Telerik.WinControls.UI.RadSpinEditor spineditortax;
        private Telerik.WinControls.UI.RadValidationProvider validatorForDiscount;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        public ComponentFactory.Krypton.Toolkit.KryptonComboBox drpselectcompany;
        private System.Windows.Forms.ErrorProvider erpcompany;
    }
}