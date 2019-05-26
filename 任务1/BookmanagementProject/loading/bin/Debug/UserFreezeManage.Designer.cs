namespace loading
{
    partial class UserFreezeManage
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
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label operatorLabel;
            System.Windows.Forms.Label freezeLabel;
            System.Windows.Forms.Label freezeDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserFreezeManage));
            this.libraryABDataSet = new loading.LibraryABDataSet();
            this.userFreezeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userFreezeTableAdapter = new loading.LibraryABDataSetTableAdapters.UserFreezeTableAdapter();
            this.tableAdapterManager = new loading.LibraryABDataSetTableAdapters.TableAdapterManager();
            this.bookBorrowTableAdapter = new loading.LibraryABDataSetTableAdapters.BookBorrowTableAdapter();
            this.userFreezeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.userFreezeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.userFreezeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBorrowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookBorrowDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.operatorTextBox = new System.Windows.Forms.TextBox();
            this.freezeTextBox = new System.Windows.Forms.TextBox();
            this.freezeDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            operatorLabel = new System.Windows.Forms.Label();
            freezeLabel = new System.Windows.Forms.Label();
            freezeDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryABDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userFreezeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userFreezeBindingNavigator)).BeginInit();
            this.userFreezeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userFreezeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBorrowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBorrowDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new System.Drawing.Point(12, 56);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(77, 14);
            userIDLabel.TabIndex = 4;
            userIDLabel.Text = "用户编号：";
            // 
            // operatorLabel
            // 
            operatorLabel.AutoSize = true;
            operatorLabel.Location = new System.Drawing.Point(399, 56);
            operatorLabel.Name = "operatorLabel";
            operatorLabel.Size = new System.Drawing.Size(63, 14);
            operatorLabel.TabIndex = 6;
            operatorLabel.Text = "操作员：";
            // 
            // freezeLabel
            // 
            freezeLabel.AutoSize = true;
            freezeLabel.Location = new System.Drawing.Point(615, 56);
            freezeLabel.Name = "freezeLabel";
            freezeLabel.Size = new System.Drawing.Size(49, 14);
            freezeLabel.TabIndex = 8;
            freezeLabel.Text = "冻结：";
            // 
            // freezeDateLabel
            // 
            freezeDateLabel.AutoSize = true;
            freezeDateLabel.Location = new System.Drawing.Point(535, 99);
            freezeDateLabel.Name = "freezeDateLabel";
            freezeDateLabel.Size = new System.Drawing.Size(77, 14);
            freezeDateLabel.TabIndex = 10;
            freezeDateLabel.Text = "冻结日期：";
            // 
            // libraryABDataSet
            // 
            this.libraryABDataSet.DataSetName = "LibraryABDataSet";
            this.libraryABDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userFreezeBindingSource
            // 
            this.userFreezeBindingSource.DataMember = "UserFreeze";
            this.userFreezeBindingSource.DataSource = this.libraryABDataSet;
            // 
            // userFreezeTableAdapter
            // 
            this.userFreezeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookBorrowTableAdapter = this.bookBorrowTableAdapter;
            this.tableAdapterManager.BookshelfTableAdapter = null;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.BookTypeTableAdapter = null;
            this.tableAdapterManager.CDTableAdapter = null;
            this.tableAdapterManager.HandbookTableAdapter = null;
            this.tableAdapterManager.PressTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = loading.LibraryABDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserDataTableAdapter = null;
            this.tableAdapterManager.UserFreezeTableAdapter = this.userFreezeTableAdapter;
            // 
            // bookBorrowTableAdapter
            // 
            this.bookBorrowTableAdapter.ClearBeforeFill = true;
            // 
            // userFreezeBindingNavigator
            // 
            this.userFreezeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.userFreezeBindingNavigator.BindingSource = this.userFreezeBindingSource;
            this.userFreezeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.userFreezeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.userFreezeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton1,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.userFreezeBindingNavigatorSaveItem,
            this.toolStripButton2});
            this.userFreezeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.userFreezeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.userFreezeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.userFreezeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.userFreezeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.userFreezeBindingNavigator.Name = "userFreezeBindingNavigator";
            this.userFreezeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.userFreezeBindingNavigator.Size = new System.Drawing.Size(794, 41);
            this.userFreezeBindingNavigator.TabIndex = 0;
            this.userFreezeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(38, 38);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 38);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(38, 38);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 38);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 38);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 41);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 41);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 38);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 38);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(37, 38);
            this.toolStripButton1.Text = "查看过期图书";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // userFreezeBindingNavigatorSaveItem
            // 
            this.userFreezeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userFreezeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("userFreezeBindingNavigatorSaveItem.Image")));
            this.userFreezeBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.userFreezeBindingNavigatorSaveItem.Name = "userFreezeBindingNavigatorSaveItem";
            this.userFreezeBindingNavigatorSaveItem.Size = new System.Drawing.Size(41, 38);
            this.userFreezeBindingNavigatorSaveItem.Text = "保存数据";
            this.userFreezeBindingNavigatorSaveItem.Click += new System.EventHandler(this.userFreezeBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 38);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // userFreezeDataGridView
            // 
            this.userFreezeDataGridView.AutoGenerateColumns = false;
            this.userFreezeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.userFreezeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userFreezeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.userFreezeDataGridView.DataSource = this.userFreezeBindingSource;
            this.userFreezeDataGridView.Location = new System.Drawing.Point(0, 134);
            this.userFreezeDataGridView.Name = "userFreezeDataGridView";
            this.userFreezeDataGridView.RowTemplate.Height = 23;
            this.userFreezeDataGridView.Size = new System.Drawing.Size(794, 182);
            this.userFreezeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ReturnID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ReturnID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 88;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn2.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 74;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Operator";
            this.dataGridViewTextBoxColumn3.HeaderText = "Operator";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 88;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Freeze";
            this.dataGridViewTextBoxColumn4.HeaderText = "Freeze";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 74;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FreezeDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "FreezeDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 102;
            // 
            // bookBorrowBindingSource
            // 
            this.bookBorrowBindingSource.DataMember = "BookBorrow";
            this.bookBorrowBindingSource.DataSource = this.libraryABDataSet;
            // 
            // bookBorrowDataGridView
            // 
            this.bookBorrowDataGridView.AutoGenerateColumns = false;
            this.bookBorrowDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.bookBorrowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookBorrowDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.bookBorrowDataGridView.DataSource = this.bookBorrowBindingSource;
            this.bookBorrowDataGridView.Location = new System.Drawing.Point(0, 357);
            this.bookBorrowDataGridView.Name = "bookBorrowDataGridView";
            this.bookBorrowDataGridView.RowTemplate.Height = 23;
            this.bookBorrowDataGridView.Size = new System.Drawing.Size(794, 215);
            this.bookBorrowDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn8.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 74;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn13.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 88;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BookID";
            this.dataGridViewTextBoxColumn7.HeaderText = "BookID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 74;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "BookName";
            this.dataGridViewTextBoxColumn12.HeaderText = "BookName";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 88;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "BorrowDate";
            this.dataGridViewTextBoxColumn9.HeaderText = "BorrowDate";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 102;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ReturnDate";
            this.dataGridViewTextBoxColumn10.HeaderText = "ReturnDate";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 102;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Operator";
            this.dataGridViewTextBoxColumn11.HeaderText = "Operator";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 88;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(656, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 23);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Visible = false;
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userFreezeBindingSource, "UserID", true));
            this.userIDTextBox.Location = new System.Drawing.Point(81, 53);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(100, 23);
            this.userIDTextBox.TabIndex = 5;
            this.userIDTextBox.Leave += new System.EventHandler(this.userIDTextBox_Leave);
            // 
            // operatorTextBox
            // 
            this.operatorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userFreezeBindingSource, "Operator", true));
            this.operatorTextBox.Location = new System.Drawing.Point(468, 53);
            this.operatorTextBox.Name = "operatorTextBox";
            this.operatorTextBox.ReadOnly = true;
            this.operatorTextBox.Size = new System.Drawing.Size(116, 23);
            this.operatorTextBox.TabIndex = 7;
            // 
            // freezeTextBox
            // 
            this.freezeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userFreezeBindingSource, "Freeze", true));
            this.freezeTextBox.Location = new System.Drawing.Point(656, 53);
            this.freezeTextBox.Name = "freezeTextBox";
            this.freezeTextBox.ReadOnly = true;
            this.freezeTextBox.Size = new System.Drawing.Size(112, 23);
            this.freezeTextBox.TabIndex = 9;
            // 
            // freezeDateDateTimePicker
            // 
            this.freezeDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.userFreezeBindingSource, "FreezeDate", true));
            this.freezeDateDateTimePicker.Location = new System.Drawing.Point(618, 93);
            this.freezeDateDateTimePicker.Name = "freezeDateDateTimePicker";
            this.freezeDateDateTimePicker.Size = new System.Drawing.Size(150, 23);
            this.freezeDateDateTimePicker.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 12;
            this.label1.Text = "用户名：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(259, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(104, 23);
            this.textBox1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 14);
            this.label2.TabIndex = 14;
            this.label2.Text = "冻结用户列表：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 14);
            this.label3.TabIndex = 15;
            this.label3.Text = "全部用户借书信息：";
            // 
            // UserFreezeManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 574);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.freezeTextBox);
            this.Controls.Add(this.operatorTextBox);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(freezeDateLabel);
            this.Controls.Add(this.freezeDateDateTimePicker);
            this.Controls.Add(freezeLabel);
            this.Controls.Add(operatorLabel);
            this.Controls.Add(userIDLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bookBorrowDataGridView);
            this.Controls.Add(this.userFreezeDataGridView);
            this.Controls.Add(this.userFreezeBindingNavigator);
            this.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserFreezeManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户冻结管理";
            this.Load += new System.EventHandler(this.UserFreezeManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryABDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userFreezeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userFreezeBindingNavigator)).EndInit();
            this.userFreezeBindingNavigator.ResumeLayout(false);
            this.userFreezeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userFreezeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBorrowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBorrowDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryABDataSet libraryABDataSet;
        private System.Windows.Forms.BindingSource userFreezeBindingSource;
        private loading.LibraryABDataSetTableAdapters.UserFreezeTableAdapter userFreezeTableAdapter;
        private loading.LibraryABDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator userFreezeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton userFreezeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView userFreezeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private loading.LibraryABDataSetTableAdapters.BookBorrowTableAdapter bookBorrowTableAdapter;
        private System.Windows.Forms.BindingSource bookBorrowBindingSource;
        private System.Windows.Forms.DataGridView bookBorrowDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.TextBox operatorTextBox;
        private System.Windows.Forms.TextBox freezeTextBox;
        private System.Windows.Forms.DateTimePicker freezeDateDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}