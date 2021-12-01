using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Google.API.Search;

namespace SearchGoogle
{
    public partial class frmMain : Form
    {
      
        public frmMain()
        {
            InitializeComponent();
          
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GwebSearchClient client = new GwebSearchClient();
            IList<IWebResult> results = client.Search(textBox1.Text, 10);
            frmResult f = new frmResult(results);
            f.Show();
        }
      
    }
}
