using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace loading
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string LoginZhiName
        {
            get;
            set;
        }

        public string LoginZhiQuanxian
        {
            get;
            set;
        }

        public string LoginZhiID
        {
            get;
            set;
        }
        private void Login_Load(object sender, EventArgs e)     //软键盘声明
        {
            panel1.Visible = false;
            panel2.Visible = false;
            lbl_0.Click += new EventHandler(lbl_Click); 
            lbl_1.Click += new EventHandler(lbl_Click);
            lbl_2.Click += new EventHandler(lbl_Click);
            lbl_3.Click += new EventHandler(lbl_Click);
            lbl_4.Click += new EventHandler(lbl_Click);
            lbl_5.Click += new EventHandler(lbl_Click);
            lbl_6.Click += new EventHandler(lbl_Click);
            lbl_7.Click += new EventHandler(lbl_Click);
            lbl_8.Click += new EventHandler(lbl_Click);
            lbl_9.Click += new EventHandler(lbl_Click);
            lbl_Q.Click += new EventHandler(lbl_Click);
            lbl_W.Click += new EventHandler(lbl_Click);
            lbl_R.Click += new EventHandler(lbl_Click);
            lbl_E.Click += new EventHandler(lbl_Click);
            lbl_T.Click += new EventHandler(lbl_Click);
            lbl_Y.Click += new EventHandler(lbl_Click);
            lbl_U.Click += new EventHandler(lbl_Click);
            lbl_I.Click += new EventHandler(lbl_Click);
            lbl_O.Click += new EventHandler(lbl_Click);
            lbl_P.Click += new EventHandler(lbl_Click);
            lbl_A.Click += new EventHandler(lbl_Click);
            lbl_S.Click += new EventHandler(lbl_Click);
            lbl_D.Click += new EventHandler(lbl_Click);
            lbl_F.Click += new EventHandler(lbl_Click);
            lbl_G.Click += new EventHandler(lbl_Click);
            lbl_H.Click += new EventHandler(lbl_Click);
            lbl_J.Click += new EventHandler(lbl_Click);
            lbl_K.Click += new EventHandler(lbl_Click);
            lbl_L.Click += new EventHandler(lbl_Click);
            lbl_Z.Click += new EventHandler(lbl_Click);
            lbl_X.Click += new EventHandler(lbl_Click);
            lbl_C.Click += new EventHandler(lbl_Click);
            lbl_V.Click += new EventHandler(lbl_Click);
            lbl_B.Click += new EventHandler(lbl_Click);
            lbl_N.Click += new EventHandler(lbl_Click);
            lbl_M.Click += new EventHandler(lbl_Click);
            label39.Click += new EventHandler(label39_Click);
        }
        public void label39_Click(object sender, EventArgs e)   //软键盘事件
        {
            Label l = (Label)sender;
            textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
            textBox2.SelectionStart = textBox2.Text.Length;
        }
        public void lbl_Click(object sender, EventArgs e)       //软键盘事件
        {
            Label l = (Label)sender;
            textBox2.Text += l.Name.Substring(4, 1);
            textBox2.SelectionStart = textBox2.Text.Length;
        }
       
        protected override CreateParams CreateParams  //"关闭"按钮禁用
        { 
            get 
            { 
                int CS_NOCLOSE = 0x200; 
                CreateParams parameters = base.CreateParams; 
                parameters.ClassStyle |= CS_NOCLOSE; 
                return parameters; 
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定关闭系统吗？", "关闭确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("您输入的登陆信息不完整，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }
            else //链接数据库
            {
                string ConStr = "server=.; Database=LibraryAB; Integrated Security=True";
                SqlConnection con = new SqlConnection(ConStr);
                con.Open();
                string SqlStr = "select UserID,Authority from UserData where UserName = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'";
                SqlCommand cmm = new SqlCommand(SqlStr, con);
                SqlDataAdapter ada = new SqlDataAdapter(SqlStr, con);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ada.Fill(dt);
                int i = dt.Rows.Count;
                con.Close();
                if (i >= 1)
                {
                    MainForm fmain = new MainForm();
                    LoginZhiID = Convert.ToString(dt.Rows[0]["UserID"]);
                    LoginZhiQuanxian = Convert.ToString(dt.Rows[0]["Authority"]);
                    LoginZhiName = textBox1.Text;
                    MessageBox.Show("您现在的权限是： " + LoginZhiQuanxian, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fmain.MainFormZhiQuanxian = LoginZhiQuanxian;
                    fmain.MainFormZhiName = LoginZhiName;
                    fmain.MainFormID = LoginZhiID;
                    this.Close();
                    fmain.Show();
                }
                else
                {
                    MessageBox.Show("用户名和密码不正确，请重新输入！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Text = "";
                    textBox2.Focus();
                }

            }
        }
        
        private void label3_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
            textBox3.Focus();
        }

        private void button3_Click(object sender, EventArgs e)      //找回密码
        {
            if (textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("您输入的信息不完整，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox3.Text = "";
                textBox4.Text = "";
                textBox3.Focus();
            }
            else //链接数据库
            {
                UserDataContext dataContext = null;
                try
                {
                    dataContext = new UserDataContext();
                    UserData user = dataContext.UserData.SingleOrDefault(p => p.Email == textBox3.Text && p.EmailPassword == textBox4.Text);
                    if (user == null)
                    {
                        MessageBox.Show("电子邮件或密码不正确，请重新输入！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox4.Text = "";
                        textBox4.Focus();
                    }
                    else
                    {
                        MessageBox.Show(string.Format("您的密码是: {0}（系统权限: {1}）", user.Password,user.Authority) + " ,\n请妥善保管好您的密码。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MainForm fmain = new MainForm();
                        fmain.MainFormZhiName = string.Format(user.UserName);
                        fmain.MainFormZhiQuanxian = string.Format(user.Authority);
                        fmain.MainFormID = string.Format(user.UserID);
                        this.Close();
                        fmain.Show();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                finally
                {
                    if (dataContext != null)
                    {
                        dataContext.Dispose();
                        dataContext = null;
                    }
                }
            }
        }

    }
}
 
             

    


