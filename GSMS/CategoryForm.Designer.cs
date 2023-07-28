namespace GSMS
{
    partial class CategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            Telerik.WinControls.UI.RadValidationRule radValidationRule1 = new Telerik.WinControls.UI.RadValidationRule();
            this.txtshortname = new Telerik.WinControls.UI.RadTextBox();
            this.txtcategoryname = new Telerik.WinControls.UI.RadTextBox();
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.drpselectcompany = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnaddcategory = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.erpcomapny = new System.Windows.Forms.ErrorProvider(this.components);
            this.validatorForTextBoxes = new Telerik.WinControls.UI.RadValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtshortname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcategoryname)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drpselectcompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpcomapny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorForTextBoxes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtshortname
            // 
            this.txtshortname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtshortname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtshortname.Location = new System.Drawing.Point(146, 244);
            this.txtshortname.Name = "txtshortname";
            this.txtshortname.ShowClearButton = true;
            this.txtshortname.Size = new System.Drawing.Size(197, 24);
            this.txtshortname.TabIndex = 2;
            this.txtshortname.ThemeName = "Crystal";
            this.validatorForTextBoxes.SetValidationRule(this.txtshortname, radValidationRule1);
            this.txtshortname.TextChanged += new System.EventHandler(this.txtshortname_TextChanged);
            // 
            // txtcategoryname
            // 
            this.txtcategoryname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtcategoryname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtcategoryname.Location = new System.Drawing.Point(146, 211);
            this.txtcategoryname.Name = "txtcategoryname";
            this.txtcategoryname.ShowClearButton = true;
            this.txtcategoryname.Size = new System.Drawing.Size(197, 24);
            this.txtcategoryname.TabIndex = 1;
            this.txtcategoryname.ThemeName = "Crystal";
            this.validatorForTextBoxes.SetValidationRule(this.txtcategoryname, radValidationRule1);
            this.txtcategoryname.TextChanged += new System.EventHandler(this.txtcategoryname_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.1134F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.8866F));
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtshortname, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtcategoryname, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.drpselectcompany, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnaddcategory, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(388, 309);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(53, 246);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(87, 20);
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "Short Name :";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(32, 213);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(108, 20);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Category Name :";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(68, 181);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "Company :";
            // 
            // drpselectcompany
            // 
            this.drpselectcompany.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.drpselectcompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.drpselectcompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.drpselectcompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drpselectcompany.DropDownWidth = 197;
            this.drpselectcompany.Location = new System.Drawing.Point(146, 181);
            this.drpselectcompany.Name = "drpselectcompany";
            this.drpselectcompany.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.drpselectcompany.Size = new System.Drawing.Size(197, 21);
            this.drpselectcompany.StateCommon.ComboBox.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.drpselectcompany.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.drpselectcompany.TabIndex = 4;
            this.drpselectcompany.TextChanged += new System.EventHandler(this.drpselectcompany_TextChanged);
            // 
            // btnaddcategory
            // 
            this.btnaddcategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnaddcategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddcategory.Location = new System.Drawing.Point(146, 278);
            this.btnaddcategory.Name = "btnaddcategory";
            this.btnaddcategory.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.btnaddcategory.Size = new System.Drawing.Size(105, 25);
            this.btnaddcategory.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddcategory.TabIndex = 3;
            this.btnaddcategory.Values.Text = "Add Category";
            this.btnaddcategory.Click += new System.EventHandler(this.btnaddcomapny_Click);
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GSMS.Properties.Resources.CategoryFormImage;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // erpcomapny
            // 
            this.erpcomapny.ContainerControl = this;
            this.erpcomapny.Icon = ((System.Drawing.Icon)(resources.GetObject("erpcomapny.Icon")));
            // 
            // validatorForTextBoxes
            // 
            this.validatorForTextBoxes.ValidationMode = Telerik.WinControls.UI.ValidationMode.Programmatically;
            radValidationRule1.Controls.Add(this.txtshortname);
            radValidationRule1.Controls.Add(this.txtcategoryname);
            radValidationRule1.Operator = Telerik.WinControls.Data.FilterOperator.IsNotLike;
            radValidationRule1.ToolTipText = "It cannot be Empty";
            radValidationRule1.ToolTipTitle = "";
            radValidationRule1.Value = "";
            this.validatorForTextBoxes.ValidationRules.AddRange(new Telerik.WinControls.Data.FilterDescriptor[] {
            radValidationRule1});
            // 
            // CategoryForm
            // 
            this.AcceptButton = this.btnaddcategory;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 309);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(390, 346);
            this.MinimumSize = new System.Drawing.Size(390, 346);
            this.Name = "CategoryForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(390, 346);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "MaterialBlueGrey";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtshortname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcategoryname)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drpselectcompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpcomapny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorForTextBoxes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnaddcategory;
        public Telerik.WinControls.UI.RadTextBox txtcategoryname;
        public Telerik.WinControls.UI.RadTextBox txtshortname;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        public ComponentFactory.Krypton.Toolkit.KryptonComboBox drpselectcompany;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider erpcomapny;
        private Telerik.WinControls.UI.RadValidationProvider validatorForTextBoxes;
    }
}