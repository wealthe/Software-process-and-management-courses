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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        public string ChangePasswordZhiName
        {
            set;
            get;
        }
        public string ChangePasswordZhiQuanxian
        {
            set;
            get;
        }

        UserDataContext pass = new UserDataContext();

        UserData oldpassword = null;

        private void message()
        {
            if (oldpassword == null)
            {
                MessageBox.Show("原始密码不正确，请重新输入！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            MessageBox.Show("您好：" + ChangePasswordZhiName + "，请不定时的修改您的密码。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label1.Text = "当前用户名：" + ChangePasswordZhiName + " ，当前用户权限：" + ChangePasswordZhiQuanxian;
            label1.Location = new Point((this.Width - label1.Width) / 2, 40);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                if (label2.Text == "原始密码：")
                {
                    oldpassword = pass.UserData.SingleOrDefault(p => p.Password == textBox1.Text);
                    message();
                }
                else if(label2.Text == "电子邮箱原始密码：")
                {
                    oldpassword = pass.UserData.SingleOrDefault(p => p.EmailPassword == textBox1.Text);
                    message();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text != textBox2.Text)
            {
                MessageBox.Show("新密码与确认密码不相同，请重新输入！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Text = "";
                textBox3.Text = "";
                textBox2.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("您必须设定一个有效密码来保护您的信息！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
            }
            else
            {
                UserData newpassword = pass.UserData.Where(p => p.UserName == ChangePasswordZhiName).SingleOrDefault();
                if (label2.Text == "原始密码：")
                {
                    newpassword.Password = textBox2.Text;
                }
                else if (label2.Text == "电子邮箱原始密码：")
                {
                    newpassword.EmailPassword = textBox2.Text;
                }
                pass.SubmitChanges();
                MessageBox.Show("密码修改成功，是否要退出该窗体？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label2.Text = "电子邮箱原始密码：";
            label2.Location = new Point(25,93);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }

    }
}
