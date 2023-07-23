using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace GSMS
{
    public partial class LoaderScreen : RadForm
    {
        int i = 0;
        public LoaderScreen()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value1 < 100)
            {
                progressBar1.Value1 = i;
                i++;
            }
            else
            {
                timer1.Enabled = false;
                this.Hide();
                LoginForm lf = new LoginForm();
                lf.ShowDialog();
                this.Close();
            }
        }

        private void LoaderScreen_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
