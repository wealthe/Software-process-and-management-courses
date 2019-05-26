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
    public partial class CDManage : Form
    {
        public CDManage()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;
        }

        UserDataContext udc = new UserDataContext();

        private void ScanDefault()      //定义方法，默认显示全部数据
        {
            cDBindingSource.DataSource =
                from cddata in udc.CD
                orderby cddata.CDID
                select cddata;
            cDBindingSource.MoveFirst();
        }

        private void cDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                cDBindingSource.EndEdit();
                udc.SubmitChanges();
                MessageBox.Show("数据保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CDManage_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryABDataSet.CD”中。您可以根据需要移动或移除它。
            this.cDTableAdapter.Fill(this.libraryABDataSet.CD);

            ScanDefault();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ScanDefault();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            cDIDTextBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "光盘名称")
            {
                cDBindingSource.DataSource =
                    from cd in udc.CD
                    where cd.CDName == textBox1.Text || cd.CDName.Contains(textBox1.Text)
                    orderby cd.CDID
                    select cd;
            }
            else if (comboBox1.Text == "光盘类型")
            {
                cDBindingSource.DataSource =
                    from cd in udc.CD
                    where cd.CDType == textBox1.Text || cd.CDType.Contains(textBox1.Text)
                    orderby cd.CDID
                    select cd;
            }
            else if (comboBox1.Text == "所在库名")
            {
                cDBindingSource.DataSource =
                    from cd in udc.CD
                    where cd.CDPosition == textBox1.Text || cd.CDPosition.Contains(textBox1.Text)
                    orderby cd.CDID
                    select cd;
            }
        }
    }
}
