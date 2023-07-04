namespace GSMS
{
    partial class CompanyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyForm));
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtshortname = new Telerik.WinControls.UI.RadTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtcompanyname = new Telerik.WinControls.UI.RadTextBox();
            this.radPictureBox1 = new Telerik.WinControls.UI.RadPictureBox();
            this.txtaddress = new Telerik.WinControls.UI.RadTextBoxControl();
            this.erpcompanyname = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpshortname = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpaddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnaddcomapny = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtshortname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcompanyname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpcompanyname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpshortname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpaddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.8866F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.1134F));
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtshortname, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtcompanyname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.radPictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtaddress, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnaddcomapny, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(388, 299);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnaddcomapny
            // 

            this.btnaddcomapny.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.SetColumnSpan(this.btnaddcomapny, 2);

            this.btnaddcomapny.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnaddcomapny.Location = new System.Drawing.Point(141, 263);

            this.btnaddcomapny.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnaddcomapny.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddcomapny.Location = new System.Drawing.Point(150, 267);

            this.btnaddcomapny.Name = "btnaddcomapny";
            this.btnaddcomapny.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.btnaddcomapny.Size = new System.Drawing.Size(105, 24);
            this.btnaddcomapny.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.btnaddcomapny.TabIndex = 3;
            this.btnaddcomapny.Values.Text = "Add Comapny";
            this.btnaddcomapny.Click += new System.EventHandler(this.btnaddcomapny_Click);
            this.btnaddcomapny.TabIndex = 15;
            this.btnaddcomapny.Values.Text = "Add Comapny";
            this.btnaddcomapny.Click += new System.EventHandler(this.btnaddcomapny_Click_2);

            this.btnaddcomapny.TabIndex = 3;
            this.btnaddcomapny.Values.Text = "Add Comapny";
            this.btnaddcomapny.Click += new System.EventHandler(this.btnaddcomapny_Click);

            // 

            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(80, 218);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(64, 20);
            this.kryptonLabel3.TabIndex = 1;
            this.kryptonLabel3.Values.Text = "Address :";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(57, 168);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(87, 20);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Short Name :";
            // 
            // txtshortname
            // 
            this.txtshortname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtshortname.Location = new System.Drawing.Point(150, 166);
            this.txtshortname.Name = "txtshortname";
            this.txtshortname.ShowClearButton = true;
            this.txtshortname.Size = new System.Drawing.Size(204, 24);
            this.txtshortname.TabIndex = 1;
            this.txtshortname.ThemeName = "Crystal";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(34, 132);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(110, 20);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Company Name :";
            // 
            // txtcompanyname
            // 
            this.txtcompanyname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtcompanyname.Location = new System.Drawing.Point(150, 130);
            this.txtcompanyname.Name = "txtcompanyname";
            this.txtcompanyname.ShowClearButton = true;
            this.txtcompanyname.Size = new System.Drawing.Size(204, 24);
            this.txtcompanyname.TabIndex = 0;
            this.txtcompanyname.ThemeName = "Crystal";
            // 
            // radPictureBox1
            // 
            this.radPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel1.SetColumnSpan(this.radPictureBox1, 2);
            this.radPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("radPictureBox1.Image")));
            this.radPictureBox1.Location = new System.Drawing.Point(57, 3);
            this.radPictureBox1.Name = "radPictureBox1";
            this.radPictureBox1.Size = new System.Drawing.Size(274, 118);
            this.radPictureBox1.TabIndex = 14;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(150, 199);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(204, 58);
            this.txtaddress.TabIndex = 2;
            this.txtaddress.ThemeName = "Crystal";
            // 
            // erpcompanyname
            // 
            this.erpcompanyname.ContainerControl = this;
            // 
            // erpshortname
            // 
            this.erpshortname.ContainerControl = this;
            // 
            // erpaddress
            // 
            this.erpaddress.ContainerControl = this;
            // 
            // btnaddcomapny
            // 
            this.btnaddcomapny.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.SetColumnSpan(this.btnaddcomapny, 2);
            this.btnaddcomapny.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddcomapny.Location = new System.Drawing.Point(141, 263);
            this.btnaddcomapny.Name = "btnaddcomapny";
            this.btnaddcomapny.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.btnaddcomapny.Size = new System.Drawing.Size(105, 31);
            this.btnaddcomapny.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddcomapny.TabIndex = 15;
            this.btnaddcomapny.Values.Text = "Add Comapny";
            this.btnaddcomapny.Click += new System.EventHandler(this.btnaddcomapny_Click_2);
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 299);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(390, 336);
            this.MinimumSize = new System.Drawing.Size(390, 336);
            this.Name = "CompanyForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Enter Company Details";
            this.ThemeName = "MaterialBlueGrey";
            this.Load += new System.EventHandler(this.CompanyForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtshortname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcompanyname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpcompanyname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpshortname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpaddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Telerik.WinControls.UI.RadPictureBox radPictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private System.Windows.Forms.ErrorProvider erpcompanyname;
        private System.Windows.Forms.ErrorProvider erpshortname;
        private System.Windows.Forms.ErrorProvider erpaddress;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnaddcomapny;
        public Telerik.WinControls.UI.RadTextBox txtcompanyname;
        public Telerik.WinControls.UI.RadTextBox txtshortname;
        public Telerik.WinControls.UI.RadTextBoxControl txtaddress;
    }
}