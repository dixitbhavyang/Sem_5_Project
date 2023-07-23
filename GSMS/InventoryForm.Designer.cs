namespace GSMS
{
    partial class InventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            Telerik.WinControls.UI.RadValidationRule radValidationRule1 = new Telerik.WinControls.UI.RadValidationRule();
            this.spineditorquantity = new Telerik.WinControls.UI.RadSpinEditor();
            this.spineditorminimumstock = new Telerik.WinControls.UI.RadSpinEditor();
            this.spineditorunit = new Telerik.WinControls.UI.RadSpinEditor();
            this.spineditormaximumstock = new Telerik.WinControls.UI.RadSpinEditor();
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.drpcompany = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.drpcategory = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.drpitem = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnadd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.erpcompany = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpcategory = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpitem = new System.Windows.Forms.ErrorProvider(this.components);
            this.validatorForSpinEditor = new Telerik.WinControls.UI.RadValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spineditorquantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spineditorminimumstock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spineditorunit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spineditormaximumstock)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpcompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpcategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpcompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpcategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorForSpinEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // spineditorquantity
            // 
            this.spineditorquantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.spineditorquantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spineditorquantity.Location = new System.Drawing.Point(147, 326);
            this.spineditorquantity.Name = "spineditorquantity";
            this.spineditorquantity.ShowBorder = false;
            this.spineditorquantity.Size = new System.Drawing.Size(90, 24);
            this.spineditorquantity.TabIndex = 3;
            this.spineditorquantity.ThemeName = "Fluent";
            this.validatorForSpinEditor.SetValidationRule(this.spineditorquantity, radValidationRule1);
            // 
            // spineditorminimumstock
            // 
            this.spineditorminimumstock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.spineditorminimumstock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spineditorminimumstock.Location = new System.Drawing.Point(147, 386);
            this.spineditorminimumstock.Name = "spineditorminimumstock";
            this.spineditorminimumstock.ShowBorder = false;
            this.spineditorminimumstock.Size = new System.Drawing.Size(90, 24);
            this.spineditorminimumstock.TabIndex = 5;
            this.spineditorminimumstock.ThemeName = "Fluent";
            this.validatorForSpinEditor.SetValidationRule(this.spineditorminimumstock, radValidationRule1);
            // 
            // spineditorunit
            // 
            this.spineditorunit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.spineditorunit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spineditorunit.Location = new System.Drawing.Point(147, 356);
            this.spineditorunit.Name = "spineditorunit";
            this.spineditorunit.ShowBorder = false;
            this.spineditorunit.Size = new System.Drawing.Size(90, 24);
            this.spineditorunit.TabIndex = 4;
            this.spineditorunit.ThemeName = "Fluent";
            this.validatorForSpinEditor.SetValidationRule(this.spineditorunit, radValidationRule1);
            // 
            // spineditormaximumstock
            // 
            this.spineditormaximumstock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.spineditormaximumstock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spineditormaximumstock.Location = new System.Drawing.Point(147, 416);
            this.spineditormaximumstock.Name = "spineditormaximumstock";
            this.spineditormaximumstock.ShowBorder = false;
            this.spineditormaximumstock.Size = new System.Drawing.Size(90, 24);
            this.spineditormaximumstock.TabIndex = 6;
            this.spineditormaximumstock.ThemeName = "Fluent";
            this.validatorForSpinEditor.SetValidationRule(this.spineditormaximumstock, radValidationRule1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.70149F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.29851F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.drpcompany, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.drpcategory, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.drpitem, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.spineditorquantity, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.spineditorminimumstock, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.spineditorunit, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.spineditormaximumstock, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnadd, 1, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 473);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(69, 238);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Company :";
            // 
            // drpcompany
            // 
            this.drpcompany.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.drpcompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.drpcompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.drpcompany.DropDownWidth = 174;
            this.drpcompany.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.drpcompany.Items.AddRange(new object[] {
            "Select Company"});
            this.drpcompany.Location = new System.Drawing.Point(147, 237);
            this.drpcompany.Name = "drpcompany";
            this.drpcompany.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.drpcompany.Size = new System.Drawing.Size(174, 21);
            this.drpcompany.TabIndex = 0;
            this.drpcompany.SelectedIndexChanged += new System.EventHandler(this.drpcompany_SelectedIndexChanged);
            this.drpcompany.TextChanged += new System.EventHandler(this.drpcompany_TextChanged);
            // 
            // drpcategory
            // 
            this.drpcategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.drpcategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.drpcategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.drpcategory.DropDownWidth = 174;
            this.drpcategory.Enabled = false;
            this.drpcategory.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.drpcategory.Location = new System.Drawing.Point(147, 267);
            this.drpcategory.Name = "drpcategory";
            this.drpcategory.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.drpcategory.Size = new System.Drawing.Size(174, 21);
            this.drpcategory.TabIndex = 1;
            this.drpcategory.SelectedIndexChanged += new System.EventHandler(this.drpcategory_SelectedIndexChanged);
            this.drpcategory.TextChanged += new System.EventHandler(this.drpcategory_TextChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(71, 268);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(70, 20);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Category :";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(97, 298);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(44, 20);
            this.kryptonLabel3.TabIndex = 1;
            this.kryptonLabel3.Values.Text = "Item :";
            // 
            // drpitem
            // 
            this.drpitem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.drpitem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.drpitem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.drpitem.DropDownWidth = 174;
            this.drpitem.Enabled = false;
            this.drpitem.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.drpitem.Location = new System.Drawing.Point(147, 297);
            this.drpitem.Name = "drpitem";
            this.drpitem.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.drpitem.Size = new System.Drawing.Size(174, 21);
            this.drpitem.TabIndex = 2;
            this.drpitem.TextChanged += new System.EventHandler(this.drpitem_TextChanged);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(73, 328);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(68, 20);
            this.kryptonLabel4.TabIndex = 1;
            this.kryptonLabel4.Values.Text = "Quantity :";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel5.Location = new System.Drawing.Point(99, 358);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(42, 20);
            this.kryptonLabel5.TabIndex = 1;
            this.kryptonLabel5.Values.Text = "Unit :";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel6.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel6.Location = new System.Drawing.Point(32, 388);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(109, 20);
            this.kryptonLabel6.TabIndex = 1;
            this.kryptonLabel6.Values.Text = "Minimum Stock :";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel7.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel7.Location = new System.Drawing.Point(29, 418);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(112, 20);
            this.kryptonLabel7.TabIndex = 1;
            this.kryptonLabel7.Values.Text = "Maximum Stock :";
            // 
            // btnadd
            // 
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Location = new System.Drawing.Point(147, 446);
            this.btnadd.Name = "btnadd";
            this.btnadd.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.btnadd.Size = new System.Drawing.Size(90, 24);
            this.btnadd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnadd.TabIndex = 7;
            this.btnadd.Values.Text = "Add";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // erpcompany
            // 
            this.erpcompany.ContainerControl = this;
            this.erpcompany.Icon = ((System.Drawing.Icon)(resources.GetObject("erpcompany.Icon")));
            // 
            // erpcategory
            // 
            this.erpcategory.ContainerControl = this;
            this.erpcategory.Icon = ((System.Drawing.Icon)(resources.GetObject("erpcategory.Icon")));
            // 
            // erpitem
            // 
            this.erpitem.ContainerControl = this;
            this.erpitem.Icon = ((System.Drawing.Icon)(resources.GetObject("erpitem.Icon")));
            // 
            // validatorForSpinEditor
            // 
            this.validatorForSpinEditor.ValidationMode = Telerik.WinControls.UI.ValidationMode.Programmatically;
            radValidationRule1.Controls.Add(this.spineditorquantity);
            radValidationRule1.Controls.Add(this.spineditorminimumstock);
            radValidationRule1.Controls.Add(this.spineditorunit);
            radValidationRule1.Controls.Add(this.spineditormaximumstock);
            radValidationRule1.Operator = Telerik.WinControls.Data.FilterOperator.IsNotEqualTo;
            radValidationRule1.PropertyName = "Value";
            radValidationRule1.ToolTipText = "Value cannot be 0";
            radValidationRule1.ToolTipTitle = "";
            radValidationRule1.Value = 0;
            this.validatorForSpinEditor.ValidationRules.AddRange(new Telerik.WinControls.Data.FilterDescriptor[] {
            radValidationRule1});
            // 
            // InventoryForm
            // 
            this.AcceptButton = this.btnadd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 473);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InventoryForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "MaterialBlueGrey";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spineditorquantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spineditorminimumstock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spineditorunit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spineditormaximumstock)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpcompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpcategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpcompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpcategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorForSpinEditor)).EndInit();
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
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private System.Windows.Forms.ErrorProvider erpcompany;
        private System.Windows.Forms.ErrorProvider erpcategory;
        private System.Windows.Forms.ErrorProvider erpitem;
        private Telerik.WinControls.UI.RadValidationProvider validatorForSpinEditor;
        public ComponentFactory.Krypton.Toolkit.KryptonComboBox drpcompany;
        public ComponentFactory.Krypton.Toolkit.KryptonComboBox drpcategory;
        public ComponentFactory.Krypton.Toolkit.KryptonComboBox drpitem;
        public Telerik.WinControls.UI.RadSpinEditor spineditorquantity;
        public Telerik.WinControls.UI.RadSpinEditor spineditorminimumstock;
        public Telerik.WinControls.UI.RadSpinEditor spineditorunit;
        public Telerik.WinControls.UI.RadSpinEditor spineditormaximumstock;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnadd;
    }
}