namespace loading
{
    partial class PressManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label pressIDLabel;
            System.Windows.Forms.Label pressNameLabel;
            System.Windows.Forms.Label pressTelLabel;
            System.Windows.Forms.Label pressAddressLabel;
            System.Windows.Forms.Label pressZipCodeLabel;
            System.Windows.Forms.Label pressWebsiteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PressManage));
            this.libraryABDataSet = new loading.LibraryABDataSet();
            this.pressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pressTableAdapter = new loading.LibraryABDataSetTableAdapters.PressTableAdapter();
            this.tableAdapterManager = new loading.LibraryABDataSetTableAdapters.TableAdapterManager();
            this.pressBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pressBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pressDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressIDTextBox = new System.Windows.Forms.TextBox();
            this.pressNameTextBox = new System.Windows.Forms.TextBox();
            this.pressTelTextBox = new System.Windows.Forms.TextBox();
            this.pressAddressTextBox = new System.Windows.Forms.TextBox();
            this.pressZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.pressWebsiteTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            pressIDLabel = new System.Windows.Forms.Label();
            pressNameLabel = new System.Windows.Forms.Label();
            pressTelLabel = new System.Windows.Forms.Label();
            pressAddressLabel = new System.Windows.Forms.Label();
            pressZipCodeLabel = new System.Windows.Forms.Label();
            pressWebsiteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryABDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressBindingNavigator)).BeginInit();
            this.pressBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pressDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pressIDLabel
            // 
            pressIDLabel.AutoSize = true;
            pressIDLabel.Location = new System.Drawing.Point(26, 359);
            pressIDLabel.Name = "pressIDLabel";
            pressIDLabel.Size = new System.Drawing.Size(91, 14);
            pressIDLabel.TabIndex = 2;
            pressIDLabel.Text = "出版社编号：";
            // 
            // pressNameLabel
            // 
            pressNameLabel.AutoSize = true;
            pressNameLabel.Location = new System.Drawing.Point(26, 392);
            pressNameLabel.Name = "pressNameLabel";
            pressNameLabel.Size = new System.Drawing.Size(91, 14);
            pressNameLabel.TabIndex = 4;
            pressNameLabel.Text = "出版社名称：";
            // 
            // pressTelLabel
            // 
            pressTelLabel.AutoSize = true;
            pressTelLabel.Location = new System.Drawing.Point(26, 426);
            pressTelLabel.Name = "pressTelLabel";
            pressTelLabel.Size = new System.Drawing.Size(77, 14);
            pressTelLabel.TabIndex = 6;
            pressTelLabel.Text = "联系电话：";
            // 
            // pressAddressLabel
            // 
            pressAddressLabel.AutoSize = true;
            pressAddressLabel.Location = new System.Drawing.Point(26, 460);
            pressAddressLabel.Name = "pressAddressLabel";
            pressAddressLabel.Size = new System.Drawing.Size(77, 14);
            pressAddressLabel.TabIndex = 8;
            pressAddressLabel.Text = "联系地址：";
            // 
            // pressZipCodeLabel
            // 
            pressZipCodeLabel.AutoSize = true;
            pressZipCodeLabel.Location = new System.Drawing.Point(26, 495);
            pressZipCodeLabel.Name = "pressZipCodeLabel";
            pressZipCodeLabel.Size = new System.Drawing.Size(77, 14);
            pressZipCodeLabel.TabIndex = 10;
            pressZipCodeLabel.Text = "邮政编码：";
            // 
            // pressWebsiteLabel
            // 
            pressWebsiteLabel.AutoSize = true;
            pressWebsiteLabel.Location = new System.Drawing.Point(26, 529);
            pressWebsiteLabel.Name = "pressWebsiteLabel";
            pressWebsiteLabel.Size = new System.Drawing.Size(77, 14);
            pressWebsiteLabel.TabIndex = 12;
            pressWebsiteLabel.Text = "官方网站：";
            // 
            // libraryABDataSet
            // 
            this.libraryABDataSet.DataSetName = "LibraryABDataSet";
            this.libraryABDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pressBindingSource
            // 
            this.pressBindingSource.DataMember = "Press";
            this.pressBindingSource.DataSource = this.libraryABDataSet;
            // 
            // pressTableAdapter
            // 
            this.pressTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.BookTypeTableAdapter = null;
            this.tableAdapterManager.PressTableAdapter = this.pressTableAdapter;
            this.tableAdapterManager.UpdateOrder = loading.LibraryABDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserDataTableAdapter = null;
            // 
            // pressBindingNavigator
            // 
            this.pressBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pressBindingNavigator.BindingSource = this.pressBindingSource;
            this.pressBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pressBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pressBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pressBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.pressBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pressBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pressBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pressBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pressBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pressBindingNavigator.Name = "pressBindingNavigator";
            this.pressBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pressBindingNavigator.Size = new System.Drawing.Size(794, 25);
            this.pressBindingNavigator.TabIndex = 0;
            this.pressBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pressBindingNavigatorSaveItem
            // 
            this.pressBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pressBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pressBindingNavigatorSaveItem.Image")));
            this.pressBindingNavigatorSaveItem.Name = "pressBindingNavigatorSaveItem";
            this.pressBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pressBindingNavigatorSaveItem.Text = "保存数据";
            this.pressBindingNavigatorSaveItem.Click += new System.EventHandler(this.pressBindingNavigatorSaveItem_Click);
            // 
            // pressDataGridView
            // 
            this.pressDataGridView.AutoGenerateColumns = false;
            this.pressDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.pressDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pressDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.pressDataGridView.DataSource = this.pressBindingSource;
            this.pressDataGridView.Location = new System.Drawing.Point(0, 33);
            this.pressDataGridView.Name = "pressDataGridView";
            this.pressDataGridView.RowTemplate.Height = 23;
            this.pressDataGridView.Size = new System.Drawing.Size(794, 302);
            this.pressDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PressID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PressID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 81;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PressName";
            this.dataGridViewTextBoxColumn2.HeaderText = "PressName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 95;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PressTel";
            this.dataGridViewTextBoxColumn3.HeaderText = "PressTel";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 88;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PressAddress";
            this.dataGridViewTextBoxColumn4.HeaderText = "PressAddress";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 116;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PressZipCode";
            this.dataGridViewTextBoxColumn5.HeaderText = "PressZipCode";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 116;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PressWebsite";
            this.dataGridViewTextBoxColumn6.HeaderText = "PressWebsite";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 116;
            // 
            // pressIDTextBox
            // 
            this.pressIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pressBindingSource, "PressID", true));
            this.pressIDTextBox.Location = new System.Drawing.Point(121, 356);
            this.pressIDTextBox.Name = "pressIDTextBox";
            this.pressIDTextBox.ReadOnly = true;
            this.pressIDTextBox.Size = new System.Drawing.Size(259, 23);
            this.pressIDTextBox.TabIndex = 3;
            // 
            // pressNameTextBox
            // 
            this.pressNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pressBindingSource, "PressName", true));
            this.pressNameTextBox.Location = new System.Drawing.Point(121, 389);
            this.pressNameTextBox.Name = "pressNameTextBox";
            this.pressNameTextBox.Size = new System.Drawing.Size(259, 23);
            this.pressNameTextBox.TabIndex = 5;
            // 
            // pressTelTextBox
            // 
            this.pressTelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pressBindingSource, "PressTel", true));
            this.pressTelTextBox.Location = new System.Drawing.Point(121, 423);
            this.pressTelTextBox.Name = "pressTelTextBox";
            this.pressTelTextBox.Size = new System.Drawing.Size(259, 23);
            this.pressTelTextBox.TabIndex = 7;
            // 
            // pressAddressTextBox
            // 
            this.pressAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pressBindingSource, "PressAddress", true));
            this.pressAddressTextBox.Location = new System.Drawing.Point(121, 457);
            this.pressAddressTextBox.Name = "pressAddressTextBox";
            this.pressAddressTextBox.Size = new System.Drawing.Size(259, 23);
            this.pressAddressTextBox.TabIndex = 9;
            // 
            // pressZipCodeTextBox
            // 
            this.pressZipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pressBindingSource, "PressZipCode", true));
            this.pressZipCodeTextBox.Location = new System.Drawing.Point(121, 492);
            this.pressZipCodeTextBox.Name = "pressZipCodeTextBox";
            this.pressZipCodeTextBox.Size = new System.Drawing.Size(259, 23);
            this.pressZipCodeTextBox.TabIndex = 11;
            // 
            // pressWebsiteTextBox
            // 
            this.pressWebsiteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pressBindingSource, "PressWebsite", true));
            this.pressWebsiteTextBox.Location = new System.Drawing.Point(121, 526);
            this.pressWebsiteTextBox.Name = "pressWebsiteTextBox";
            this.pressWebsiteTextBox.Size = new System.Drawing.Size(259, 23);
            this.pressWebsiteTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(36, 62);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 18);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "按出版社编号";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(36, 98);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(110, 18);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "按出版社名称";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Location = new System.Drawing.Point(402, 389);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 160);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查找";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(36, 133);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(124, 18);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "按出版社所在地";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(168, 58);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(141, 23);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "北京",
            "上海",
            "天津",
            "重庆",
            "四川",
            "贵州",
            "广东",
            "浙江",
            "福建",
            "湖南",
            "湖北",
            "山东",
            "山西",
            "河南",
            "河北",
            "吉林",
            "辽宁",
            "黑龙江",
            "安徽",
            "江苏",
            "江西",
            "海南",
            "陕西",
            "云南",
            "青海",
            "宁夏",
            "甘肃",
            "新疆",
            "西藏",
            "广西",
            "内蒙古",
            "深圳",
            "香港",
            "澳门",
            "台湾"});
            this.comboBox1.Location = new System.Drawing.Point(168, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 22);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("幼圆", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(375, 523);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 35);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "打开网站";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "刷新数据";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "-------无--------",
            "编号与名称组合",
            "编号与所在地组合",
            "名称与所在地组合",
            "全部组合"});
            this.comboBox2.Location = new System.Drawing.Point(224, 22);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(141, 22);
            this.comboBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(21, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "若想组合查询请选择组合查询的方式";
            // 
            // PressManage
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 574);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(pressIDLabel);
            this.Controls.Add(this.pressIDTextBox);
            this.Controls.Add(pressNameLabel);
            this.Controls.Add(this.pressNameTextBox);
            this.Controls.Add(pressTelLabel);
            this.Controls.Add(this.pressTelTextBox);
            this.Controls.Add(pressAddressLabel);
            this.Controls.Add(this.pressAddressTextBox);
            this.Controls.Add(pressZipCodeLabel);
            this.Controls.Add(this.pressZipCodeTextBox);
            this.Controls.Add(pressWebsiteLabel);
            this.Controls.Add(this.pressDataGridView);
            this.Controls.Add(this.pressBindingNavigator);
            this.Controls.Add(this.pressWebsiteTextBox);
            this.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PressManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "出版社管理";
            this.Load += new System.EventHandler(this.PressManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryABDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressBindingNavigator)).EndInit();
            this.pressBindingNavigator.ResumeLayout(false);
            this.pressBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pressDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryABDataSet libraryABDataSet;
        private System.Windows.Forms.BindingSource pressBindingSource;
        private loading.LibraryABDataSetTableAdapters.PressTableAdapter pressTableAdapter;
        private loading.LibraryABDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pressBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pressBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pressDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox pressIDTextBox;
        private System.Windows.Forms.TextBox pressNameTextBox;
        private System.Windows.Forms.TextBox pressTelTextBox;
        private System.Windows.Forms.TextBox pressAddressTextBox;
        private System.Windows.Forms.TextBox pressZipCodeTextBox;
        private System.Windows.Forms.TextBox pressWebsiteTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
    }
}