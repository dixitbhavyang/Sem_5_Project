namespace GSMS
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtpassword = new Telerik.WinControls.UI.RadTextBox();
            this.radPictureBox1 = new Telerik.WinControls.UI.RadPictureBox();
            this.btnlogin = new Telerik.WinControls.UI.RadButton();
            this.chkshowpassword = new Telerik.WinControls.UI.RadCheckBox();
            this.txtusername = new Telerik.WinControls.UI.RadTextBox();
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.office2007SilverTheme1 = new Telerik.WinControls.Themes.Office2007SilverTheme();
            this.office2010SilverTheme1 = new Telerik.WinControls.Themes.Office2010SilverTheme();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.windows7Theme1 = new Telerik.WinControls.Themes.Windows7Theme();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkshowpassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtusername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.308824F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.69118F));
            this.tableLayoutPanel1.Controls.Add(this.txtpassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.radPictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnlogin, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.chkshowpassword, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtusername, 1, 1);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(272, 336);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtpassword
            // 
            this.txtpassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtpassword.EmbeddedLabelText = "Enter Password";
            this.txtpassword.ForeColor = System.Drawing.Color.Black;
            this.txtpassword.Location = new System.Drawing.Point(12, 230);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.NullText = "Password";
            this.txtpassword.PasswordChar = '●';
            this.txtpassword.ShowClearButton = true;
            this.txtpassword.ShowNullText = true;
            this.txtpassword.Size = new System.Drawing.Size(254, 36);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.ThemeName = "MaterialBlueGrey";
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // radPictureBox1
            // 
            this.radPictureBox1.AllowPanelAnimations = false;
            this.radPictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.SetColumnSpan(this.radPictureBox1, 2);
            this.radPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPictureBox1.Image = global::GSMS.Properties.Resources.LoginFormImage;
            this.radPictureBox1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radPictureBox1.Location = new System.Drawing.Point(3, 3);
            this.radPictureBox1.Name = "radPictureBox1";
            this.radPictureBox1.PanelDisplayMode = Telerik.WinControls.UI.PictureBoxPanelDisplayMode.None;
            this.radPictureBox1.Size = new System.Drawing.Size(266, 176);
            this.radPictureBox1.TabIndex = 8;
            // 
            // btnlogin
            // 
            this.btnlogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.SetColumnSpan(this.btnlogin, 2);
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Image = global::GSMS.Properties.Resources.LogInIcon;
            this.btnlogin.Location = new System.Drawing.Point(95, 296);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(81, 32);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "LogIn";
            this.btnlogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlogin.ThemeName = "CrystalDark";
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // chkshowpassword
            // 
            this.chkshowpassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkshowpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkshowpassword.DisplayStyle = Telerik.WinControls.DisplayStyle.Text;
            this.chkshowpassword.Location = new System.Drawing.Point(12, 271);
            this.chkshowpassword.Name = "chkshowpassword";
            this.chkshowpassword.Size = new System.Drawing.Size(101, 18);
            this.chkshowpassword.TabIndex = 2;
            this.chkshowpassword.Text = " Show Password";
            this.chkshowpassword.ThemeName = "Office2010Silver";
            this.chkshowpassword.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox1_ToggleStateChanged);
            // 
            // txtusername
            // 
            this.txtusername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtusername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtusername.EmbeddedLabelText = "Please Enter Username";
            this.txtusername.ForeColor = System.Drawing.Color.Black;
            this.txtusername.Location = new System.Drawing.Point(12, 186);
            this.txtusername.Name = "txtusername";
            this.txtusername.NullText = "Username";
            this.txtusername.ShowClearButton = true;
            this.txtusername.ShowNullText = true;
            this.txtusername.Size = new System.Drawing.Size(254, 36);
            this.txtusername.TabIndex = 0;
            this.txtusername.ThemeName = "MaterialBlueGrey";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(272, 336);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(280, 369);
            this.MinimumSize = new System.Drawing.Size(280, 369);
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(280, 369);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " LogIn";
            this.ThemeName = "CrystalDark";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkshowpassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtusername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadTextBox txtusername;
        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private Telerik.WinControls.UI.RadTextBox txtpassword;
        private Telerik.WinControls.UI.RadCheckBox chkshowpassword;
        private Telerik.WinControls.UI.RadButton btnlogin;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private Telerik.WinControls.Themes.Office2007SilverTheme office2007SilverTheme1;
        private Telerik.WinControls.Themes.Office2010SilverTheme office2010SilverTheme1;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.Themes.Windows7Theme windows7Theme1;
        private Telerik.WinControls.UI.RadPictureBox radPictureBox1;
    }
}