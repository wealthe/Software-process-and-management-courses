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
    public partial class BookManage : Form
    {
        public BookManage()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        UserDataContext udc = new UserDataContext();

        private void ScanDefault()      //定义方法，默认显示全部数据
        {
            bookBindingSource.DataSource =
                from book in udc.Book
                orderby book.ID
                select book;
            bookBindingSource.MoveFirst();
        }

        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                bookBindingSource.EndEdit();
                udc.SubmitChanges();
                MessageBox.Show("数据保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BookManage_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryABDataSet.Bookshelf”中。您可以根据需要移动或移除它。
            this.bookshelfTableAdapter.Fill(this.libraryABDataSet.Bookshelf);
            // TODO: 这行代码将数据加载到表“libraryABDataSet.Handbook”中。您可以根据需要移动或移除它。
            this.handbookTableAdapter.Fill(this.libraryABDataSet.Handbook);
            // TODO: 这行代码将数据加载到表“libraryABDataSet.CD”中。您可以根据需要移动或移除它。
            this.cDTableAdapter.Fill(this.libraryABDataSet.CD);
            // TODO: 这行代码将数据加载到表“libraryABDataSet.Press”中。您可以根据需要移动或移除它。
            this.pressTableAdapter.Fill(this.libraryABDataSet.Press);
            // TODO: 这行代码将数据加载到表“libraryABDataSet.BookType”中。您可以根据需要移动或移除它。
            this.bookTypeTableAdapter.Fill(this.libraryABDataSet.BookType);
            // TODO: 这行代码将数据加载到表“libraryABDataSet.Book”中。您可以根据需要移动或移除它。
            this.bookTableAdapter.Fill(this.libraryABDataSet.Book);

            ScanDefault();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            BookTypeManage btm = new BookTypeManage();
            btm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PressManage pm = new PressManage();
            pm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            BookshelfManage bsm = new BookshelfManage();
            bsm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CDManage cdm = new CDManage();
            cdm.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            HandbookManage hbm = new HandbookManage();
            hbm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                bookBindingSource.DataSource =
                    from book in udc.Book
                    where book.ID.Contains(textBox1.Text)
                    orderby book.ID
                    select book;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                bookBindingSource.DataSource =
                    from book in udc.Book
                    where book.ISDN.Contains(textBox1.Text)
                    orderby book.ID
                    select book;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                bookBindingSource.DataSource =
                    from book in udc.Book
                    where book.BookName.Contains(textBox1.Text)
                    orderby book.ID
                    select book;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                bookBindingSource.DataSource =
                    from book in udc.Book
                    where book.Author.Contains(textBox1.Text)
                    orderby book.ID
                    select book;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                bookBindingSource.DataSource =
                    from book in udc.Book
                    where book.Translator.Contains(textBox1.Text)
                    orderby book.ID
                    select book;
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                bookBindingSource.DataSource =
                    from book in udc.Book
                    where book.PressName.Contains(textBox1.Text)
                    orderby book.ID
                    select book;
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                bookBindingSource.DataSource =
                    from book in udc.Book
                    where book.CDID.Contains(textBox1.Text)
                    orderby book.ID
                    select book;
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                bookBindingSource.DataSource =
                    from book in udc.Book
                    where book.HandbookID.Contains(textBox1.Text)
                    orderby book.ID
                    select book;
            }
        }
    

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                label4.Text = "输入图书名称：";
                label5.Text = "输入作者：";
            }
            if (comboBox2.SelectedIndex == 1)
            {
                label4.Text = "输入图书名称：";
                label5.Text = "输入出版社：";
            }
            if (comboBox2.SelectedIndex == 2)
            {
                label4.Text = "输入作者：";
                label5.Text = "输入出版社：";
            }
            textBox2.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                bookBindingSource.DataSource =
                    from book in udc.Book
                    where book.BookName.Contains(textBox2.Text) && book.Author.Contains(textBox3.Text)
                    orderby book.ID
                    select book;
            }
            if (comboBox2.SelectedIndex == 1)
            {
                bookBindingSource.DataSource =
                    from book in udc.Book
                    where book.BookName.Contains(textBox2.Text) && book.PressName.Contains(textBox3.Text)
                    orderby book.ID
                    select book;
            }
            if (comboBox2.SelectedIndex == 2)
            {
                bookBindingSource.DataSource =
                    from book in udc.Book
                    where book.Author.Contains(textBox2.Text) && book.PressName.Contains(textBox3.Text)
                    orderby book.ID
                    select book;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.Text = "";
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            iDTextBox.Focus();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            panel1.Visible = !panel1.Visible;
            textBox1.Focus();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            ScanDefault();
        }
    }
}
