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
    public partial class BookTypeManage : Form
    {
        public BookTypeManage()
        {
            InitializeComponent();
        }

        private UserDataContext udc = new UserDataContext();

        private void ScanDefault()      //定义方法，默认显示全部数据
        {
            bookTypeBindingSource.DataSource =
                from booktypedata in udc.BookType
                orderby booktypedata.BookTypeID
                select booktypedata;
            bookTypeBindingSource.MoveFirst();
        }

        private void bookTypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                bookTypeBindingSource.EndEdit();
                udc.SubmitChanges();
                MessageBox.Show("数据保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BookTypeManage_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryABDataSet.BookType”中。您可以根据需要移动或移除它。
            this.bookTypeTableAdapter.Fill(this.libraryABDataSet.BookType);

            label1.Text = "注：该页的书籍类型已包括\n\n了所有种类，你可以修改它\n\n们以缩小书籍类型的范围，\n\n修改时直接在左边栅格视图\n\n中修改即可。";
            label2.Text = "你所做的每一步只能通过\n\n“保存”按钮才能保存数\n\n据。";

            ScanDefault();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ScanDefault();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bookTypeNameTextBox.Text = "";
            bookTypeNameTextBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)      //可以模糊查询
        {
            bookTypeBindingSource.DataSource =
                from type in udc.BookType
                where type.BookTypeName == textBox1.Text || type.BookTypeName.Contains(textBox1.Text)
                orderby type.BookTypeID
                select type;
        }

    }
}
