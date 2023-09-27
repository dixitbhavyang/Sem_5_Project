namespace GSMS
{
    partial class DepartmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentForm));
            Telerik.WinControls.UI.RadValidationRule radValidationRule2 = new Telerik.WinControls.UI.RadValidationRule();
            this.txtname = new Telerik.WinControls.UI.RadTextBox();
            this.txtshortname = new Telerik.WinControls.UI.RadTextBox();
            this.txtphone = new Telerik.WinControls.UI.RadTextBox();
            this.txtdescription = new Telerik.WinControls.UI.RadTextBox();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnadddepartment = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.validatorForTextBoxes = new Telerik.WinControls.UI.RadValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtshortname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtphone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdescription)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorForTextBoxes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(122, 243);
            this.txtname.Name = "txtname";
            this.txtname.ShowClearButton = true;
            this.txtname.Size = new System.Drawing.Size(186, 24);
            this.txtname.TabIndex = 0;
            this.txtname.ThemeName = "Crystal";
            this.validatorForTextBoxes.SetValidationRule(this.txtname, radValidationRule2);
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // txtshortname
            // 
            this.txtshortname.Location = new System.Drawing.Point(122, 273);
            this.txtshortname.Name = "txtshortname";
            this.txtshortname.ShowClearButton = true;
            this.txtshortname.Size = new System.Drawing.Size(186, 24);
            this.txtshortname.TabIndex = 1;
            this.txtshortname.ThemeName = "Crystal";
            this.validatorForTextBoxes.SetValidationRule(this.txtshortname, radValidationRule2);
            this.txtshortname.TextChanged += new System.EventHandler(this.txtshortname_TextChanged);
            this.txtshortname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtshortname_KeyPress);
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(122, 303);
            this.txtphone.MaxLength = 10;
            this.txtphone.Name = "txtphone";
            this.txtphone.ShowClearButton = true;
            this.txtphone.Size = new System.Drawing.Size(186, 24);
            this.txtphone.TabIndex = 2;
            this.txtphone.ThemeName = "Crystal";
            this.validatorForTextBoxes.SetValidationRule(this.txtphone, radValidationRule2);
            this.txtphone.TextChanged += new System.EventHandler(this.txtphone_TextChanged);
            this.txtphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphone_KeyPress);
            // 
            // txtdescription
            // 
            this.txtdescription.AcceptsReturn = true;
            this.txtdescription.Location = new System.Drawing.Point(122, 333);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            // 
            // 
            // 
            this.txtdescription.RootElement.StretchVertically = true;
            this.txtdescription.ShowClearButton = true;
            this.txtdescription.Size = new System.Drawing.Size(186, 64);
            this.txtdescription.TabIndex = 3;
            this.txtdescription.ThemeName = "Crystal";
            this.validatorForTextBoxes.SetValidationRule(this.txtdescription, radValidationRule2);
            this.txtdescription.TextChanged += new System.EventHandler(this.txtdescription_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.69388F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.30612F));
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtshortname, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtphone, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtdescription, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnadddepartment, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(343, 430);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(64, 245);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(52, 20);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Name :";
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(337, 234);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(337, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(29, 275);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(87, 20);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Short Name :";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(62, 305);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(54, 20);
            this.kryptonLabel3.TabIndex = 1;
            this.kryptonLabel3.Values.Text = "Phone :";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(32, 355);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(84, 20);
            this.kryptonLabel4.TabIndex = 1;
            this.kryptonLabel4.Values.Text = "Description :";
            // 
            // btnadddepartment
            // 
            this.btnadddepartment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnadddepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadddepartment.Location = new System.Drawing.Point(122, 403);
            this.btnadddepartment.Name = "btnadddepartment";
            this.btnadddepartment.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.btnadddepartment.Size = new System.Drawing.Size(100, 24);
            this.btnadddepartment.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadddepartment.TabIndex = 11;
            this.btnadddepartment.Values.Text = "Add";
            this.btnadddepartment.Click += new System.EventHandler(this.btnadddepartment_Click);
            // 
            // validatorForTextBoxes
            // 
            this.validatorForTextBoxes.ValidationMode = Telerik.WinControls.UI.ValidationMode.Programmatically;
            radValidationRule2.Controls.Add(this.txtname);
            radValidationRule2.Controls.Add(this.txtshortname);
            radValidationRule2.Controls.Add(this.txtphone);
            radValidationRule2.Controls.Add(this.txtdescription);
            radValidationRule2.Operator = Telerik.WinControls.Data.FilterOperator.IsNotLike;
            radValidationRule2.ToolTipText = "It Cannot Be Empty";
            radValidationRule2.ToolTipTitle = "";
            radValidationRule2.Value = "";
            this.validatorForTextBoxes.ValidationRules.AddRange(new Telerik.WinControls.Data.FilterDescriptor[] {
            radValidationRule2});
            // 
            // DepartmentForm
            // 
            this.AcceptButton = this.btnadddepartment;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 430);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(345, 467);
            this.MinimumSize = new System.Drawing.Size(345, 467);
            this.Name = "DepartmentForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(345, 467);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "MaterialBlueGrey";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtshortname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtphone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdescription)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorForTextBoxes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnadddepartment;
        private Telerik.WinControls.UI.RadValidationProvider validatorForTextBoxes;
        public Telerik.WinControls.UI.RadTextBox txtname;
        public Telerik.WinControls.UI.RadTextBox txtshortname;
        public Telerik.WinControls.UI.RadTextBox txtphone;
        public Telerik.WinControls.UI.RadTextBox txtdescription;
    }
}