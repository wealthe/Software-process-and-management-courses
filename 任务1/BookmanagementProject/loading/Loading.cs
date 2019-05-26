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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = progressBar1.Value;
            switch (i)
            {
                case 0:
                    label2.Text = string.Format("正在查看系统配置...");
                    break;
                case 20:
                    label2.Text = string.Format("正在初始化组件...");
                    break;
                case 50:
                    label2.Text = string.Format("正在连接数据库...");
                    break;
                case 80:
                    label2.Text = string.Format("正在搭建UI...");
                    break;
                case 90:
                    label2.Text = string.Format("正在启动系统...");
                    break;
                case 99:
                    Login f2 = new Login();
                    f2.Show();
                    break;
                case 100:
                    this.Hide();
                    break;
            }
            progressBar1.Increment(1);
            label1.Text = string.Format("当前进度{0}%", progressBar1.Value);
        }

        private void Loading_Load(object sender, EventArgs e)
        {

        }
    }
}
