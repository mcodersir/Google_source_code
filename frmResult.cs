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
    public partial class frmResult : Form
    {
        IList<IWebResult> results;
        public frmResult(IList<IWebResult> r)
        {
            InitializeComponent();
            results = r;
        }

        private void frmResult_Load(object sender, EventArgs e)
        {
            foreach (IWebResult result in results)
            {
                richTextBox1.Text += " Tilte : " + result.Title + "\n";
                richTextBox1.Text += " Content : " + result.Content + "\n";
                richTextBox1.Text += " Url : " + result.Url + "\n\n";
                richTextBox1.Text += " --------------------------------------------------------------" + "\n\n";
            }
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore.exe", e.LinkText);
        }
    }
}
