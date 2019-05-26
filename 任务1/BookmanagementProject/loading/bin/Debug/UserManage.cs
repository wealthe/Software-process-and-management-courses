using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace loading
{
    public partial class UserManage : Form
    {
        public UserManage()
        {
            InitializeComponent();
        }

        String strCn = "server=.\\MSSQL2008; Database=LibraryAB; Integrated Security=True";

        private UserDataContext udc = new UserDataContext();

        private void ScanDefault()      //定义方法，默认显示全部数据
        {
            userDataBindingSource.DataSource =
                from userdata in udc.UserData
                orderby userdata.UserID
                select userdata;
            userDataBindingSource.MoveFirst();
        }

        private void UserManage_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryABDataSet.UserData”中。您可以根据需要移动或移除它。
            //this.userDataTableAdapter.Fill(this.libraryABDataSet.UserData);
            
            label1.Text = "温馨提醒：对数据经行增删改后记得要用导航栏里的“保存”按钮经行数据保存。";
            panel1.Visible = false;
            panel2.Visible = false;

            ScanDefault();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)     //按权限查询
        {
            userDataBindingSource.DataSource =
                from qx in udc.UserData
                where qx.Authority == comboBox1.Text
                orderby qx.UserID
                select qx;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)     //按性别查询
        {
            userDataBindingSource.DataSource =
                from sex in udc.UserData
                where sex.Sex == comboBox2.Text
                orderby sex.UserID
                select sex;
        }

        private void button1_Click(object sender, EventArgs e)      //重新筛选按钮
        {
            ScanDefault();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)   //组合查询
        {
            userDataBindingSource.DataSource =
                from sex in udc.UserData
                where sex.Sex == comboBox2.Text && sex.Authority == comboBox1.Text
                orderby sex.UserID
                select sex;
        }

        private void button2_Click(object sender, EventArgs e)      //定位查询
        {
            if (comboBox3.Text == "用户姓名")
            {
                userDataBindingSource.DataSource =
                    from person in udc.UserData
                    where person.UserName == textBox3.Text || person.UserName.Contains(textBox3.Text)
                    orderby person.UserID
                    select person;
            }
            else if (comboBox3.Text == "用户编号")
            {
                userDataBindingSource.DataSource =
                    from person in udc.UserData
                    where person.UserID == textBox3.Text || person.UserID.Contains(textBox3.Text)
                    orderby person.UserID
                    select person;
            }
            else if (comboBox3.Text == "所属单位")
            {
                userDataBindingSource.DataSource =
                    from person in udc.UserData
                    where person.Unit == textBox3.Text || person.Unit.Contains(textBox3.Text)
                    orderby person.UserID
                    select person;
            }
        }

        private void button3_Click(object sender, EventArgs e)      //加载图片
        {
            this.openFileDialog1.Filter = "jpg文件(*.jpg)|*.jpg|gif文件(*.gif)|*.gif|BMP图片(*.bmp)|*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] img;
                    string filename = this.openFileDialog1.FileName;
                    FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    System.Drawing.Image image = System.Drawing.Image.FromStream(fs);
                    photoPictureBox.Image = image;
                    img = new byte[fs.Length];
                    fs.Read(img, 0, img.Length);
                    if (userIDTextBox.Text == null)
                    {                
                        SqlConnection conn = new SqlConnection(strCn);
                        SqlCommand comm = new SqlCommand("insert into UserData (UserID,UserName,Password,Email,EmailPassword,Authority,Sex,Unit,Tel,Address,Photo,CardCreateDate) values(@UserID,@UserName,@Password,@Email,@EmailPassword,@Authority,@Sex,@Unit,@Tel,@Address,@Photo,@CardCreateDate)", conn);
                        comm.Parameters.AddWithValue("@UserID", userIDTextBox.Text);
                        comm.Parameters.AddWithValue("@UserName", userNameTextBox.Text);
                        comm.Parameters.AddWithValue("@Password", passwordTextBox.Text);
                        comm.Parameters.AddWithValue("@Email", emailTextBox.Text);
                        comm.Parameters.AddWithValue("@EmailPassword", emailPasswordTextBox.Text);
                        comm.Parameters.AddWithValue("@Authority", authorityComboBox.Text);
                        comm.Parameters.AddWithValue("@Sex", sexTextBox.Text);
                        comm.Parameters.AddWithValue("@Unit", unitTextBox.Text);
                        comm.Parameters.AddWithValue("@Tel", telTextBox.Text);
                        comm.Parameters.AddWithValue("@Address", addressTextBox.Text);
                        comm.Parameters.AddWithValue("@CardCreatDate", cardCreateDateDateTimePicker.Text);
                        comm.Parameters.Add("@Image", SqlDbType.Image, img.Length).Value = img;
                        
                        conn.Open();
                        comm.ExecuteNonQuery();
                        conn.Close();
                    }
                    else if (userIDTextBox.Text != null)
                    {
                        SqlConnection con = new SqlConnection(strCn);
                        SqlCommand com = new SqlCommand("UPDATE UserData SET Photo=@Photo", con);
                        //comm.Parameters.AddWithValue("@Name", nameTextBox.Text);
                        com.Parameters.Add("@Photo", SqlDbType.Image, img.Length).Value = img;
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void userDataBindingNavigatorSaveItem_Click(object sender, EventArgs e)     //tab1中的保存按钮
        {
            try
            {
                Validate();
                userDataBindingSource.EndEdit();
                udc.SubmitChanges();
                MessageBox.Show("数据保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton8_Click_1(object sender, EventArgs e)       //查询按钮
        {
            panel2.Visible = !panel2.Visible;
        }

        private void toolStripButton9_Click_1(object sender, EventArgs e)       //刷新按钮
        {
            ScanDefault();
            panel1.Visible = false;
        }

        private void toolStripButton7_Click_1(object sender, EventArgs e)       //数据保存时一系列安全检查
        {
            try
            {
                if (userIDTextBox.Text == "" || userNameTextBox.Text == "" || passwordTextBox.Text == "" || emailTextBox.Text == "" || emailPasswordTextBox.Text == "" || authorityComboBox.Text == "")
                {
                    MessageBox.Show("必须输入的信息您没有输入完整，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
                else
                {
                    Validate();
                    userDataBindingSource.EndEdit();
                    udc.SubmitChanges();
                    MessageBox.Show("数据保存成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel1.Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)       //添加按钮
        {
            panel1.Visible = !panel1.Visible;
            userIDTextBox.Focus();
        }

        private void textBox1_Leave(object sender, EventArgs e)         //检查输入密码和确认密码是否相同
        {
            if (passwordTextBox.Text != textBox1.Text)
            {
                MessageBox.Show("您输入的用户密码与用户确认密码不相同，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                passwordTextBox.Text = "";
                passwordTextBox.Focus();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)         //检查电子邮件密码与确认密码是否相同
        {
            if (emailPasswordTextBox.Text != textBox2.Text)
            {
                MessageBox.Show("您输入的电子邮件密码与电子邮件确认密码不相同，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Text = "";
                emailPasswordTextBox.Text = "";
                emailPasswordTextBox.Focus();
            }
        }

        private void userIDTextBox_TextChanged(object sender, EventArgs e)      //我动你也动
        {
            if (userIDTextBox.Text.StartsWith("XT"))
            {
                authorityComboBox.SelectedIndex = 0;
            }
            else if (userIDTextBox.Text.StartsWith("JY"))
            {
                authorityComboBox.SelectedIndex = 2;
            }
            else if (userIDTextBox.Text.StartsWith("TS"))
            {
                authorityComboBox.SelectedIndex = 1;
            }
            else if (userIDTextBox.Text.StartsWith("PT"))
            {
                authorityComboBox.SelectedIndex = 3;
            }
        }

        private void userIDTextBox_Leave(object sender, EventArgs e)        //检查用户编号是否有误
        {
            if (!((userIDTextBox.Text.StartsWith("XT")) || (userIDTextBox.Text.StartsWith("JY")) || (userIDTextBox.Text.StartsWith("TS")) || (userIDTextBox.Text.StartsWith("PT"))))
            {
                MessageBox.Show("您输入的用户编号有误，请重新输入!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userIDTextBox.Text = "";
                userIDTextBox.Focus();
            }
        }


    }
}



