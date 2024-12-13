using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIVN_APP
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = true;
            progressBar.Increment(10);
            if(progressBar.Value == 100 ) {
                timer.Enabled=false;
                this.Hide();
                HomePage homePage= new HomePage();
                homePage.Show();               
            }
        }
    }
}
