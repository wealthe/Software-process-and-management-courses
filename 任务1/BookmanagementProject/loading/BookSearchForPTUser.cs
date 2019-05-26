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
    public partial class BookSearchForPTUser : Form
    {
        public BookSearchForPTUser()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        UserDataContext udc = new UserDataContext();

        string zhi = null;

        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryABDataSet);

        }

        private void BookSearchForPTUser_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryABDataSet.BookBorrow”中。您可以根据需要移动或移除它。
            //this.bookBorrowTableAdapter.Fill(this.libraryABDataSet.BookBorrow);
            // TODO: 这行代码将数据加载到表“libraryABDataSet.Book”中。您可以根据需要移动或移除它。
            //this.bookTableAdapter.Fill(this.libraryABDataSet.Book);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                bookBindingSource.DataSource =
                    from book in udc.Book
                    where book.ID == textBox1.Text
                    orderby book.ID
                    select book;

                bookBorrowBindingSource.DataSource =
                    from bookborrow in udc.BookBorrow
                    where bookborrow.BookID == textBox1.Text
                    orderby bookborrow.BookID
                    select bookborrow;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                bookBindingSource.DataSource =
                    from book in udc.Book
                    where book.BookName.Contains(textBox1.Text)
                    orderby book.ID
                    select book;
                bookBorrowBindingSource.DataSource =
                    from bookborrow in udc.BookBorrow
                    where bookborrow.BookName.Contains(textBox1.Text)
                    orderby bookborrow.BookName
                    select bookborrow;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                bookBindingSource.DataSource =
                    from book in udc.Book
                    where book.ISDN == textBox1.Text
                    orderby book.ID
                    select book;

                Book user = udc.Book.SingleOrDefault(p => p.ISDN == textBox1.Text);
                if (user == null)
                {
                    MessageBox.Show("未找到书籍！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    zhi = string.Format(user.ID);
                }
                bookBorrowBindingSource.DataSource =
                    from bookborrow in udc.BookBorrow
                    where bookborrow.BookID == zhi
                    orderby bookborrow.BookID
                    select bookborrow;
            }
        }
    }
}
