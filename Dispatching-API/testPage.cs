using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Dispatching_API
{
    public partial class testPage : Form
    {
        
        public testPage()
        {
            InitializeComponent();
        }
      
        private void callButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://localhost:8000/?route=" + routeNum.Text);
        }

        private void testPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            configForm cf = new configForm();
            cf.Show();
            //configformVar1.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
