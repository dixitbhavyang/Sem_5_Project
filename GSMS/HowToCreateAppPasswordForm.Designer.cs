namespace GSMS
{
    partial class HowToCreateAppPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToCreateAppPasswordForm));
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            this.radPictureBox1 = new Telerik.WinControls.UI.RadPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.radPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPictureBox1
            // 
            this.radPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("radPictureBox1.Image")));
            this.radPictureBox1.ImageLayout = Telerik.WinControls.UI.RadImageLayout.FitIntoBounds;
            this.radPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.radPictureBox1.Name = "radPictureBox1";
            this.radPictureBox1.Size = new System.Drawing.Size(774, 486);
            this.radPictureBox1.TabIndex = 0;
            this.radPictureBox1.ThemeName = "MaterialBlueGrey";
            // 
            // HowToCreateAppPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 486);
            this.Controls.Add(this.radPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(776, 523);
            this.MinimumSize = new System.Drawing.Size(776, 523);
            this.Name = "HowToCreateAppPasswordForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(776, 523);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  How to Create App Password";
            this.ThemeName = "MaterialBlueGrey";
            ((System.ComponentModel.ISupportInitialize)(this.radPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private Telerik.WinControls.UI.RadPictureBox radPictureBox1;
    }
}