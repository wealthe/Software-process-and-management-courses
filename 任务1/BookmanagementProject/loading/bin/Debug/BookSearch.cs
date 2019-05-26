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
    public partial class BookSearch : Form
    {
        public BookSearch()
        {
            InitializeComponent();
        }

        UserDataContext udc = new UserDataContext();

        private void bookBorrowBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBorrowBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryABDataSet);

        }

        private void BookSearch_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryABDataSet.BookBorrow”中。您可以根据需要移动或移除它。
            this.bookBorrowTableAdapter.Fill(this.libraryABDataSet.BookBorrow);

            dateTimePicker1.Value = System.DateTime.Now;//.AddDays(100);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                bookBorrowBindingSource.DataSource =
                   from book in udc.BookBorrow
                   where book.BookID == bookIDTextBox.Text || book.UserID == userIDTextBox.Text
                   orderby book.BorrowID
                   select book;                
            }
            if (checkBox1.Checked == true)
            {
                if (bookIDTextBox.Text != null && userIDTextBox.Text != null)
                {
                    bookBorrowBindingSource.DataSource =
                        from bookuser in udc.BookBorrow
                        where bookuser.BookID == bookIDTextBox.Text && bookuser.UserID == userIDTextBox.Text
                        orderby bookuser.BorrowID
                        select bookuser;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bookBorrowBindingSource.DataSource =
                from outdate in udc.BookBorrow
                where outdate.ReturnDate < dateTimePicker1.Value
                orderby outdate.BorrowID
                select outdate;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bookBorrowBindingSource.DataSource =
                from data in udc.BookBorrow
                orderby data.BorrowID
                select data;
        }
    }
}
