using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace loading
{
    public partial class WebBrowser : Form
    {
        public WebBrowser()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text != "")
            {
                webBrowser1.Navigate(toolStripTextBox1.Text);
            }
            else
            {
                MessageBox.Show(this, "请输入网址！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(toolStripTextBox1.Text);
            }
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "http://www.baidu.com";
            webBrowser1.GoHome();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPropertiesDialog();
        }

        private void toolStripLabel7_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowSaveAsDialog();
        }

        private void toolStripLabel8_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPageSetupDialog();
        }

        private void toolStripLabel9_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintPreviewDialog();
        }
    }
}
