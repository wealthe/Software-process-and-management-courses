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
    public partial class PressManage : Form
    {
        public PressManage()
        {
            InitializeComponent();
            comboBox2.SelectedIndex = 0;
        }

        private void define()
        {
            pressBindingSource.DataSource =
                from pressdata in udc.Press
                orderby pressdata.PressID
                select pressdata;
            pressBindingSource.MoveFirst();
        }

        private UserDataContext udc = new UserDataContext();

        private void pressBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                pressBindingSource.EndEdit();
                udc.SubmitChanges();
                MessageBox.Show("数据保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void PressManage_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryABDataSet.Press”中。您可以根据需要移动或移除它。
            //this.pressTableAdapter.Fill(this.libraryABDataSet.Press);
            define();

            label1.Text = "注意：你所做的每一步只能通过“保存”按钮来保存数据。";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Visible =! numericUpDown1.Visible;
            numericUpDown1.Focus();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = !textBox1.Visible;
            textBox1.Focus();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = !comboBox1.Visible;
            comboBox1.Focus();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            pressNameTextBox.Focus();
            pressWebsiteTextBox.Text = "http://";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(pressWebsiteTextBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)      //这个查询的空间复杂度可想而知
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    {
                        if (numericUpDown1.Visible == true)
                        {
                            pressBindingSource.DataSource =
                                from pressid in udc.Press
                                where pressid.PressID == Convert.ToInt32(numericUpDown1.Value)
                                orderby pressid.PressID
                                select pressid;
                        }
                        else if (textBox1.Visible == true)
                        {
                            pressBindingSource.DataSource =
                                from pressname in udc.Press
                                where pressname.PressName == textBox1.Text || pressname.PressName.Contains(textBox1.Text)
                                orderby pressname.PressID
                                select pressname;
                        }
                        else if (comboBox1.Visible == true)
                        {
                            pressBindingSource.DataSource =
                                from pressaddress in udc.Press
                                where pressaddress.PressAddress == comboBox1.Text || pressaddress.PressAddress.Contains(comboBox1.Text)
                                orderby pressaddress.PressID
                                select pressaddress;
                        }
                    }
                    break;
                case 1:
                    pressBindingSource.DataSource =
                            from pressidname in udc.Press
                            where pressidname.PressID == Convert.ToInt32(numericUpDown1.Value) && (pressidname.PressName == textBox1.Text || pressidname.PressName.Contains(textBox1.Text))
                            orderby pressidname.PressID
                            select pressidname;
                    break;
                case 2:
                    pressBindingSource.DataSource =
                            from pressidaddress in udc.Press
                            where pressidaddress.PressID == Convert.ToInt32(numericUpDown1.Value) && (pressidaddress.PressAddress == comboBox1.Text || pressidaddress.PressAddress.Contains(comboBox1.Text))
                            orderby pressidaddress.PressID
                            select pressidaddress;
                    break;
                case 3:
                    pressBindingSource.DataSource =
                            from pressnameaddress in udc.Press
                            where (pressnameaddress.PressName == textBox1.Text || pressnameaddress.PressName.Contains(textBox1.Text)) && (pressnameaddress.PressName == textBox1.Text || pressnameaddress.PressName.Contains(textBox1.Text))
                            orderby pressnameaddress.PressID
                            select pressnameaddress;
                    break;
                case 4:
                    pressBindingSource.DataSource =
                           from pressidnameaddress in udc.Press
                           where (pressidnameaddress.PressName == textBox1.Text || pressidnameaddress.PressName.Contains(textBox1.Text)) && (pressidnameaddress.PressName == textBox1.Text || pressidnameaddress.PressName.Contains(textBox1.Text)) && pressidnameaddress.PressID == Convert.ToInt32(numericUpDown1.Value)
                           orderby pressidnameaddress.PressID
                           select pressidnameaddress;
                    break;
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            define();
        }

    }
}
