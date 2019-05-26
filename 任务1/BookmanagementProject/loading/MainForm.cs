using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace loading
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public string MainFormZhiName
        {
            set;
            get;
        }

        public string MainFormZhiQuanxian
        {
            set;
            get;
        }

        public string MainFormID
        {
            set;
            get;
        }

        private void message()
        {
            ChangePassword cp = new ChangePassword();
            cp.ChangePasswordZhiName = MainFormZhiName;
            cp.ChangePasswordZhiQuanxian = MainFormZhiQuanxian;
            cp.Show();
        }

        private void message1()
        {
            BorrowReturn br = new BorrowReturn();
            br.BorrowReturnZhiName = MainFormZhiName;
            br.Show();
        }

        private void message2()
        {
            UserFreezeManage ufm = new UserFreezeManage();
            ufm.BorrowReturnZhiName = MainFormZhiName;
            ufm.Show();
        }

        private void message3()
        {
            MyInformation mi = new MyInformation();
            mi.MyInformationID = MainFormID;
            mi.MyInformationZhiName = MainFormZhiName;
            mi.MyInformationZhiQuanxian = MainFormZhiQuanxian;
            mi.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)     //切换用户
        {
            Login lo = new Login();
            lo.Show();
            this.Close();
        }

        private void 普通用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        protected override CreateParams CreateParams  //"关闭"按钮禁用，嗨又禁用了
        {
            get
            {
                int CS_NOCLOSE = 0x200;
                CreateParams parameters = base.CreateParams;
                parameters.ClassStyle |= CS_NOCLOSE;
                return parameters;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定关闭系统吗？", "关闭确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void notifyIcon2_MouseDoubleClick(object sender, MouseEventArgs e)      //双击托盘图标，弹出主界面
        {
            this.WindowState = FormWindowState.Normal;   //如果是最小化就把窗体状态改为默认大小
            this.Activate();                             //激活窗体并赋予焦点，这句话可以不写
            this.ShowInTaskbar = true;                  //在Windows任务栏中显示窗体。
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)     //链接网页
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VisitLink()
        {
            if (toolStripTextBox1.Text == "")
            {
                linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start("http://www.baidu.com");
            }
            else
            {
                linkLabel1.LinkVisited = true;      //   让linkLabel1的LinkVisited属性为true.   
                System.Diagnostics.Process.Start("http://www.baidu.com/s?wd=" + toolStripTextBox1.ToString());  //调用Process.Start   方法去打开默认浏览器，设置一个URL:    
            }
        }

        private void 发送电子邮件ToolStripMenuItem_Click(object sender, EventArgs e)    //系统管理菜单下的几个事件，方法名与方法不符，方法与界面上名称相对应。六个事件
        {
            Email email = new Email();
            email.Show();
        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)      //打开系统自带的浏览器
        {
            WebBrowser wb = new WebBrowser();
            wb.Show();
        }

        private void 注销用户并退出ToolStripMenuItem_Click(object sender, EventArgs e)      //打开系统自带的音频播放器
        {
            MediaPlayer mp = new MediaPlayer();
            mp.Show();
        }

        [DllImport("user32.dll")]   //锁定计算机
        private static extern void LockWorkStation();

        private void 以普通用户登录ToolStripMenuItem_Click(object sender, EventArgs e)      //锁定计算机
        {
            LockWorkStation();
        }

        private void 最小化托盘ToolStripMenuItem_Click(object sender, EventArgs e)  //最小化主界面
        {
            this.WindowState = FormWindowState.Minimized;	//最小化窗口
            this.ShowInTaskbar = false;		                //在Windows任务栏中不显示窗体
        }

        private void 退出系统ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定关闭系统吗？", "关闭确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void 打开主界面ToolStripMenuItem2_Click(object sender, EventArgs e)     //托盘右键事件，共7个
        {
            this.WindowState = FormWindowState.Normal;
            this.Activate();
            this.ShowInTaskbar = true;
        }

        private void 锁定计算机ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LockWorkStation();
        }

        private void 退出系统ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定关闭系统吗？", "关闭确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void 打开邮件发送器ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Email em = new Email();
            em.Show();
        }

        private void 打开网页浏览器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebBrowser wb = new WebBrowser();
            wb.Show();
        }

        private void 打开音频播放器ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MediaPlayer mp = new MediaPlayer();
            mp.Show();
        }

        private void 最小化托盘ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        private void 切换用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lo = new Login();
            lo.Show();
            this.Close();
        }

        private void 查找用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManage um = new UserManage();
            um.Show();
        }

        private void 查询书籍类型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookTypeManage btm = new BookTypeManage();
            btm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            message();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (MainFormZhiQuanxian != "系统管理员")
            {
                MessageBox.Show("您没有系统管理员权限，不能进行该功能的相关操作。", "禁止", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                UserManage um = new UserManage();
                um.Show();
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (MainFormZhiQuanxian != "图书管理员")
            {
                MessageBox.Show("您没有图书管理员权限，不能进行该功能的相关操作。", "禁止", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                BookTypeManage btm = new BookTypeManage();
                btm.Show();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)      //显示当前用户及权限
        {
            label1.Text = "当前用户：" + MainFormZhiName + "  用户权限：" + MainFormZhiQuanxian + "     请保存好您的用户名和密码。";
            ChangePassword cp = new ChangePassword();
        }

        private void 出版社管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PressManage pm = new PressManage();
            pm.Show();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            message();
        }

        private void 修改密码ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            message();
        }

        private void 修改密码ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            message();
        }

        private void 修改密码ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            message();
        }

        private void 书架管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookshelfManage bm = new BookshelfManage();
            bm.Show();
        }

        private void 光盘管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CDManage cd = new CDManage();
            cd.Show();
        }

        private void 附赠手册管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandbookManage hb = new HandbookManage();
            hb.Show();
        }

        private void 添加书籍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookManage bm = new BookManage();
            bm.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (MainFormZhiQuanxian != "图书管理员")
            {
                MessageBox.Show("您没有图书管理员权限，不能进行该功能的相关操作。", "禁止", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                BookManage bm = new BookManage();
                bm.Show();
            }
        }

        private void 图书管理员ToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            if (MainFormZhiQuanxian != "图书管理员")
            {
                MessageBox.Show("您没有图书管理员权限，不能进行该菜单下的相关操作。", "禁止", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                添加书籍ToolStripMenuItem.Visible = false;
                查询书籍类型ToolStripMenuItem.Visible = false;
                toolStripSeparator3.Visible = false;
                查询书籍类型ToolStripMenuItem.Visible = false;
                toolStripSeparator8.Visible = false;
                出版社管理ToolStripMenuItem.Visible = false;
                toolStripMenuItem7.Visible = false;
                光盘管理ToolStripMenuItem.Visible = false;
                toolStripMenuItem8.Visible = false;
                附赠手册管理ToolStripMenuItem.Visible = false;
                toolStripMenuItem9.Visible = false;
                书架管理ToolStripMenuItem.Visible = false;
                toolStripMenuItem10.Visible = false;
                修改密码ToolStripMenuItem2.Visible = false;
            }
        }

        private void 用户管理ToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            if (MainFormZhiQuanxian != "系统管理员")
            {
                MessageBox.Show("您没有系统管理员权限，不能进行该菜单下的相关操作。", "禁止", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                查找用户ToolStripMenuItem.Visible = false;
                toolStripSeparator4.Visible = false;
                修改密码ToolStripMenuItem.Visible = false;
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (MainFormZhiQuanxian != "借阅管理员")
            {
                MessageBox.Show("您没有借阅管理员权限，不能进行该功能的相关操作。", "禁止", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                BookManage bm = new BookManage();
                bm.Show();
            }
        }

        private void 借阅书籍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            message1();
        }

        private void 查询书籍ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BookSearch bs = new BookSearch();
            bs.Show();
        }

        private void 冻结普通用户账号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            message2();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (MainFormZhiQuanxian != "借阅管理员")
            {
                MessageBox.Show("您没有借阅管理员权限，不能进行该功能的相关操作。", "禁止", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                BookManage bm = new BookManage();
                bm.Show();
            }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            message3();
        }

        private void 查看个人资料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            message3();
        }

        private void 借阅管理员ToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            if (MainFormZhiQuanxian != "借阅管理员")
            {
                MessageBox.Show("您没有借阅管理员权限，不能进行该菜单下的相关操作。", "禁止", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                查询书籍ToolStripMenuItem2.Visible = false;
                借阅书籍ToolStripMenuItem.Visible = false;
                toolStripSeparator6.Visible = false;
                冻结普通用户账号ToolStripMenuItem.Visible = false;
                toolStripSeparator7.Visible = false;
                修改密码ToolStripMenuItem3.Visible = false;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            BookSearchForPTUser bsf = new BookSearchForPTUser();
            bsf.Show();
        }

        private void 查询书籍ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BookSearchForPTUser bsf = new BookSearchForPTUser();
            bsf.Show();
        }

        private void 更换背景图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "jpg文件(*.jpg)|*.jpg|gif文件(*.gif)|*.gif|BMP图片(*.bmp)|*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = this.openFileDialog1.FileName;
                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                System.Drawing.Image image = System.Drawing.Image.FromStream(fs);
                pictureBox1.Image = image;
            }
        }

    }
}
