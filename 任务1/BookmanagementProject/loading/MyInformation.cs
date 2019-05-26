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
    public partial class MyInformation : Form
    {
        public MyInformation()
        {
            InitializeComponent();
        }

        public string MyInformationZhiName
        {
            set;
            get;
        }
        public string MyInformationZhiQuanxian
        {
            set;
            get;
        }

        public string MyInformationID
        {
            set;
            get;
        }

        UserDataContext udc = new UserDataContext();

        private void MyInformation_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryABDataSet.UserFreeze”中。您可以根据需要移动或移除它。
            //this.userFreezeTableAdapter.Fill(this.libraryABDataSet.UserFreeze);
            // TODO: 这行代码将数据加载到表“libraryABDataSet.BookBorrow”中。您可以根据需要移动或移除它。
            //this.bookBorrowTableAdapter.Fill(this.libraryABDataSet.BookBorrow);
            // TODO: 这行代码将数据加载到表“libraryABDataSet.UserData”中。您可以根据需要移动或移除它。
            //this.userDataTableAdapter.Fill(this.libraryABDataSet.UserData);

            label1.Text = "您好：" + MyInformationZhiName + " ，您的用户编号为：" + MyInformationID + "，您的用户权限为：" + MyInformationZhiQuanxian;
            label1.Location = new Point((this.Width - label1.Width) / 2, 45);

            userDataBindingSource.DataSource =
                from user in udc.UserData
                where user.UserName == MyInformationZhiName
                orderby user.UserID
                select user;

            bookBorrowBindingSource.DataSource =
                from user in udc.BookBorrow
                where user.UserName == MyInformationZhiName
                orderby user.UserID
                select user;

            userFreezeBindingSource.DataSource =
                from user in udc.UserFreeze
                where user.UserID == MyInformationID
                orderby user.ReturnID
                select user;
        }

        private void userDataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userDataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryABDataSet);

        }
    }
}
