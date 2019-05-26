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
    public partial class BorrowReturn : Form
    {
        public BorrowReturn()
        {
            InitializeComponent();
        }

        public string BorrowReturnZhiName
        {
            set;
            get;
        }

        private UserDataContext udc = new UserDataContext();

        private void BorrowReturn_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryABDataSet.BookReturn”中。您可以根据需要移动或移除它。
            //this.bookReturnTableAdapter.Fill(this.libraryABDataSet.BookReturn);
            // TODO: 这行代码将数据加载到表“libraryABDataSet.BookBorrow”中。您可以根据需要移动或移除它。
            //this.bookBorrowTableAdapter.Fill(this.libraryABDataSet.BookBorrow);
            
        }

        private void userIDTextBox3_Leave_1(object sender, EventArgs e)
        {
            if (userIDTextBox3.Text == "")
            {
                MessageBox.Show("请输入用户编号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    UserData user = udc.UserData.SingleOrDefault(p => p.UserID == userIDTextBox3.Text);
                    UserFreeze uf = udc.UserFreeze.SingleOrDefault(p => p.UserID == userIDTextBox3.Text);
                    if (user == null)
                    {
                        MessageBox.Show("不存在该用户！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        userIDTextBox3.Text = "";
                        userIDTextBox3.Focus();
                    }
                    else
                    {
                        if (uf != null)
                        {
                            MessageBox.Show("该用户已冻结，不能借阅书籍！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            userIDTextBox3.Text = "";
                            userIDTextBox3.Focus();
                        }
                        else
                        {
                            userNameTextBox3.Text = user.UserName;
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void bookIDTextBox3_Leave_1(object sender, EventArgs e)
        {
            if (bookIDTextBox3.Text == "")
            {
                MessageBox.Show("请输入书籍编号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    Book book = udc.Book.SingleOrDefault(p => p.ID == bookIDTextBox3.Text);
                    if (book == null)
                    {
                        MessageBox.Show("不存在该书籍信息！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bookIDTextBox3.Text = "";
                        bookIDTextBox3.Focus();
                    }
                    else
                    {
                        bookNameTextBox3.Text = book.BookName;
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            userIDTextBox3.Focus();
            statusTextBox3.Text = "借出";
            expiredTextBox3.Text = "否";
            borrowDateDateTimePicker3.Value = System.DateTime.Now;
            returnDateDateTimePicker3.Value = System.DateTime.Now.AddDays(Convert.ToDouble(numericUpDown1.Value));
            operatorTextBox3.Text = BorrowReturnZhiName;
        }

        private void bookBorrowBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.bookBorrowBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.libraryABDataSet);
                MessageBox.Show("数据保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            bookBorrowBindingSource.DataSource =
                from userbook in udc.BookBorrow
                where userbook.UserID == userIDTextBox3.Text
                orderby userbook.BorrowID
                select userbook;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            bookBorrowBindingSource.DataSource =
                from userbook in udc.BookBorrow
                where userbook.BookID == bookIDTextBox1.Text
                orderby userbook.BorrowID
                select userbook;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.bookBorrowBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.libraryABDataSet);
                MessageBox.Show("数据保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            if (bookIDTextBox2.Text != null)
            {
                bookBorrowBindingSource.DataSource =
                    from userbook in udc.BookBorrow
                    where userbook.BookID == bookIDTextBox2.Text
                    orderby userbook.BorrowID
                    select userbook;

            }
            else if (bookIDTextBox2.Text != null && userIDTextBox2.Text != null)
            {
                bookBorrowBindingSource.DataSource =
                    from userbook in udc.BookBorrow
                    where userbook.BookID == bookIDTextBox2.Text && userbook.UserID == userIDTextBox2.Text
                    orderby userbook.BorrowID
                    select userbook;
            }
        }

        private void toolStripButton17_Click(object sender, EventArgs e)
        {

            try
            {
                this.Validate();
                this.bookBorrowBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.libraryABDataSet);
                MessageBox.Show("数据保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton18_Click(object sender, EventArgs e)
        {
            returnDateDateTimePicker2.Value = System.DateTime.Now.AddDays(Convert.ToDouble(numericUpDown2.Value));
        }
    }
}
