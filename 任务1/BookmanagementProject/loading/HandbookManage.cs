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
    public partial class HandbookManage : Form
    {
        public HandbookManage()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private UserDataContext udc = new UserDataContext();

        private void ScanDefault()      //定义方法，默认显示全部数据
        {
            handbookBindingSource.DataSource = 
                from handbookdata in udc.Handbook
                orderby handbookdata.HandbokID
                select handbookdata;
            handbookBindingSource.MoveFirst();
        }

        private void handbookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                handbookBindingSource.EndEdit();
                udc.SubmitChanges();
                MessageBox.Show("数据保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HandbookManage_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryABDataSet.Handbook”中。您可以根据需要移动或移除它。
            this.handbookTableAdapter.Fill(this.libraryABDataSet.Handbook);

            ScanDefault();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ScanDefault();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            handbokIDTextBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "手册编号")
            {
                handbookBindingSource.DataSource =
                    from handbook in udc.Handbook
                    where handbook.HandbokID == textBox1.Text || handbook.HandbokID.Contains(textBox1.Text)
                    orderby handbook.HandbokID
                    select handbook;
            }
            else if (comboBox1.Text == "手册名称")
            {
                handbookBindingSource.DataSource =
                    from handbook in udc.Handbook
                    where handbook.HandbookName == textBox1.Text || handbook.HandbookName.Contains(textBox1.Text)
                    orderby handbook.HandbokID
                    select handbook;
            }
            else if (comboBox1.Text == "所在库名")
            {
                handbookBindingSource.DataSource =
                    from handbook in udc.Handbook
                    where handbook.HandbookPosition == textBox1.Text || handbook.HandbookPosition.Contains(textBox1.Text)
                    orderby handbook.HandbokID
                    select handbook;
            }
        }
    }
}
