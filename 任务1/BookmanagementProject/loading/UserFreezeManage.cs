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
    public partial class UserFreezeManage : Form
    {
        public UserFreezeManage()
        {
            InitializeComponent();
        }

        public string BorrowReturnZhiName
        {
            set;
            get;
        }

        UserDataContext udc = new UserDataContext();

        private void userFreezeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userFreezeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryABDataSet);

        }

        private void UserFreezeManage_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryABDataSet.BookBorrow”中。您可以根据需要移动或移除它。
            this.bookBorrowTableAdapter.Fill(this.libraryABDataSet.BookBorrow);
            // TODO: 这行代码将数据加载到表“libraryABDataSet.UserFreeze”中。您可以根据需要移动或移除它。
            this.userFreezeTableAdapter.Fill(this.libraryABDataSet.UserFreeze);

            dateTimePicker1.Value = System.DateTime.Now;//.AddDays(80);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bookBorrowBindingSource.DataSource =
                from outdate in udc.BookBorrow
                where outdate.ReturnDate < dateTimePicker1.Value
                orderby outdate.BorrowID
                select outdate;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            bookBorrowBindingSource.DataSource =
                from outdateuser in udc.BookBorrow
                orderby outdateuser.BorrowID
                select outdateuser;
            userFreezeBindingSource.DataSource =
                from freeze in udc.UserFreeze
                orderby freeze.ReturnID
                select freeze;
        }

        private void userIDTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                UserData user = udc.UserData.SingleOrDefault(p => p.UserID == userIDTextBox.Text);
                if (user == null)
                {
                    MessageBox.Show("不存在该用户！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userIDTextBox.Text = "";
                    userIDTextBox.Focus();
                }
                else
                {
                    textBox1.Text = user.UserName;
                    operatorTextBox.Text = BorrowReturnZhiName;
                    freezeTextBox.Text = "是";
                    freezeDateDateTimePicker.Value = System.DateTime.Now;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
