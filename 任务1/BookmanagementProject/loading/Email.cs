using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace loading
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        MailMessage Mail;
        SmtpClient Client;

        public void CreateTimeoutTestMessage(string server)
        {
            try
            {
                Mail = new MailMessage(this.textBox2.Text,this.textBox1.Text);
                Mail.Subject = this.textBox3.Text.Trim().ToString();
                Mail.Body = this.textBox4.Text.Trim().ToString();
                Client = new SmtpClient(server, 25);
                Client.Send(Mail);
                MessageBox.Show("邮件发送成功！");
            }
            catch (Exception ey)
            {
                MessageBox.Show(ey.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox4.Text.Trim().ToString() != "")
            {
                CreateTimeoutTestMessage("pop.163.com");
            }
            else
            {
                MessageBox.Show("邮件填写不完整，请重新填写！");
                    return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.hao123.com/mail.htm");
        }
    }
}
