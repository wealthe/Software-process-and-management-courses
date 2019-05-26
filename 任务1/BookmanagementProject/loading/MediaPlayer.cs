using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace loading
{
    public partial class MediaPlayer : Form
    {
        public MediaPlayer()
        {
            InitializeComponent();
        }

        private string[] playList = new string[1000];
        private int num;

        public void AddFile(string path)    //添加歌曲文件
        {
            if (num < 1000)                 //歌曲数量不超过1000
            {
                num++;
                playList[num] = path;
            }
        }

        public void DelFile(int selectNum)      //删除文件
        {
            for (int i = selectNum; i <= num - 1; i++)
            {
                playList[i] = playList[i + 1];
            }
            num--;
        }

        private void AddFiles(string path, ListBox listBox1)    //歌曲目录
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (FileInfo f in dir.GetFiles("*.mp3"))
            {
                AddFile(f.FullName);
                string strTmp = Convert.ToString(num);
                for (int i = 1; i <= 5 - strTmp.Length; i++)
                    strTmp += ' ';
                strTmp += "--" + f.Name;
                this.listBox1.Items.Add(strTmp);
            }
            foreach (DirectoryInfo f in dir.GetDirectories())
            {
                AddFiles(f.FullName, listBox1);
            }
        }

        public void PlaySong(int selectNum)         //唱呗
        {
            MediaPlayer1.URL = playList[selectNum];
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void MediaPlayer_Load(object sender, EventArgs e)
        {
            listBox1.Items.CopyTo(playList, 0);
            num = 0;

            if (this.WindowState == FormWindowState.Minimized)  //判断是否最小化
            {
                this.ShowInTaskbar = false;  //不显示在系统任务栏
                notifyIcon1.Visible = true;  //托盘图标可见
            }
        }

        private void button5_Click(object sender, EventArgs e)      //设置目录
        {
            folderBrowserDialog1.SelectedPath = "i:\\";
            folderBrowserDialog1.ShowNewFolderButton = true;
            folderBrowserDialog1.Description = "请选择音乐文件目录：";
            folderBrowserDialog1.ShowDialog();
            AddFiles(folderBrowserDialog1.SelectedPath, listBox1);
        }

        private void button1_Click(object sender, EventArgs e)      //播放音乐
        {
            int SelectOne;
            if (listBox1.SelectedIndex < 0)
                SelectOne = 1;
            else
                SelectOne = listBox1.SelectedIndex + 1;
            if (listBox1.Items.Count < 0)
                listBox1.SelectedIndex = 0;
            PlaySong(SelectOne);
        }

        private void button2_Click(object sender, EventArgs e)      //停止
        {
            MediaPlayer1.URL = "";
        }

        private void button3_Click(object sender, EventArgs e)      //添加歌曲
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = this.openFileDialog1.FileName;
                FileInfo f = new FileInfo(path);
                AddFile(f.FullName);
                string strTmp = Convert.ToString(num);
                for (int i = 1; i <= 5 - strTmp.Length; i++)
                    strTmp += ' ';
                strTmp += "--" + f.Name;
                this.listBox1.Items.Add(strTmp);
            }
        }

        private void button4_Click(object sender, EventArgs e)      //删除歌曲
        {
            if(listBox1.SelectedIndex >= 0)
            {
                DelFile(listBox1.SelectedIndex + 1);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)      //打开界面
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = true;  //显示在系统任务栏
                this.WindowState = FormWindowState.Normal;  //还原窗体
                notifyIcon1.Visible = false;  //托盘图标隐藏
            }
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)    //打开界面
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = true;  //显示在系统任务栏
                this.WindowState = FormWindowState.Normal;  //还原窗体
                notifyIcon1.Visible = false;  //托盘图标隐藏
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
