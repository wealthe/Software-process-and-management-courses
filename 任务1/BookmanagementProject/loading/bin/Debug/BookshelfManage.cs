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
    public partial class BookshelfManage : Form
    {
        public BookshelfManage()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private UserDataContext udc = new UserDataContext();

        private void ScanDefault()      //定义方法，默认显示全部数据
        {
            bookshelfBindingSource.DataSource =
                from bookshelfdata in udc.Bookshelf
                orderby bookshelfdata.BookshelfID
                select bookshelfdata;
            bookshelfBindingSource.MoveFirst();
        }

        private void BookshelfManage_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryABDataSet.Bookshelf”中。您可以根据需要移动或移除它。
            this.bookshelfTableAdapter.Fill(this.libraryABDataSet.Bookshelf);

            ScanDefault();
        }

        private void bookshelfBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                Validate();
                bookshelfBindingSource.EndEdit();
                udc.SubmitChanges();
                MessageBox.Show("数据保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            ScanDefault();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bookshelfNameTextBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "书架/库名称")
            {
                bookshelfBindingSource.DataSource =
                    from shelf in udc.Bookshelf
                    where shelf.BookshelfName == textBox1.Text || shelf.BookshelfName.Contains(textBox1.Text)
                    orderby shelf.BookshelfID
                    select shelf;
            }
            else if (comboBox1.Text == "书架/库位置")
            {
                bookshelfBindingSource.DataSource =
                    from shelf in udc.Bookshelf
                    where shelf.BookshelfPosition == textBox1.Text || shelf.BookshelfPosition.Contains(textBox1.Text)
                    orderby shelf.BookshelfID
                    select shelf;
            }
            else if (comboBox1.Text == "书架/库备注")
            {
                bookshelfBindingSource.DataSource =
                    from shelf in udc.Bookshelf
                    where shelf.BookshelfNotes == textBox1.Text || shelf.BookshelfNotes.Contains(textBox1.Text)
                    orderby shelf.BookshelfID
                    select shelf;
            }
        }
    }
}
