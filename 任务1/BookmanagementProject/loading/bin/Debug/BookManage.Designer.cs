namespace loading
{
    partial class BookManage
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label iSDNLabel;
            System.Windows.Forms.Label bookNameLabel;
            System.Windows.Forms.Label authorLabel;
            System.Windows.Forms.Label translatorLabel;
            System.Windows.Forms.Label bookTypeLabel;
            System.Windows.Forms.Label pressNameLabel;
            System.Windows.Forms.Label pagesLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label pubDateLabel;
            System.Windows.Forms.Label cDIDLabel;
            System.Windows.Forms.Label handbookIDLabel;
            System.Windows.Forms.Label bookshelfNameLabel;
            System.Windows.Forms.Label totalNumLabel;
            System.Windows.Forms.Label storageDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookManage));
            this.libraryABDataSet = new loading.LibraryABDataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new loading.LibraryABDataSetTableAdapters.BookTableAdapter();
            this.tableAdapterManager = new loading.LibraryABDataSetTableAdapters.TableAdapterManager();
            this.bookBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bookBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.bookDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.iSDNTextBox = new System.Windows.Forms.TextBox();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.translatorTextBox = new System.Windows.Forms.TextBox();
            this.bookTypeComboBox = new System.Windows.Forms.ComboBox();
            this.bookTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pressNameComboBox = new System.Windows.Forms.ComboBox();
            this.pressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagesTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.pubDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cDIDComboBox = new System.Windows.Forms.ComboBox();
            this.cDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.handbookIDComboBox = new System.Windows.Forms.ComboBox();
            this.handbookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookshelfNameComboBox = new System.Windows.Forms.ComboBox();
            this.bookshelfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalNumNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.storageDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bookTypeTableAdapter = new loading.LibraryABDataSetTableAdapters.BookTypeTableAdapter();
            this.pressTableAdapter = new loading.LibraryABDataSetTableAdapters.PressTableAdapter();
            this.cDTableAdapter = new loading.LibraryABDataSetTableAdapters.CDTableAdapter();
            this.handbookTableAdapter = new loading.LibraryABDataSetTableAdapters.HandbookTableAdapter();
            this.bookshelfTableAdapter = new loading.LibraryABDataSetTableAdapters.BookshelfTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            iSDNLabel = new System.Windows.Forms.Label();
            bookNameLabel = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            translatorLabel = new System.Windows.Forms.Label();
            bookTypeLabel = new System.Windows.Forms.Label();
            pressNameLabel = new System.Windows.Forms.Label();
            pagesLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            pubDateLabel = new System.Windows.Forms.Label();
            cDIDLabel = new System.Windows.Forms.Label();
            handbookIDLabel = new System.Windows.Forms.Label();
            bookshelfNameLabel = new System.Windows.Forms.Label();
            totalNumLabel = new System.Windows.Forms.Label();
            storageDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryABDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingNavigator)).BeginInit();
            this.bookBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handbookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookshelfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalNumNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(24, 500);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(77, 14);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "图书编号：";
            // 
            // iSDNLabel
            // 
            iSDNLabel.AutoSize = true;
            iSDNLabel.Location = new System.Drawing.Point(24, 529);
            iSDNLabel.Name = "iSDNLabel";
            iSDNLabel.Size = new System.Drawing.Size(42, 14);
            iSDNLabel.TabIndex = 4;
            iSDNLabel.Text = "ISDN:";
            // 
            // bookNameLabel
            // 
            bookNameLabel.AutoSize = true;
            bookNameLabel.Location = new System.Drawing.Point(24, 558);
            bookNameLabel.Name = "bookNameLabel";
            bookNameLabel.Size = new System.Drawing.Size(77, 14);
            bookNameLabel.TabIndex = 6;
            bookNameLabel.Text = "图书名称：";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new System.Drawing.Point(24, 587);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(49, 14);
            authorLabel.TabIndex = 8;
            authorLabel.Text = "作者：";
            // 
            // translatorLabel
            // 
            translatorLabel.AutoSize = true;
            translatorLabel.Location = new System.Drawing.Point(24, 616);
            translatorLabel.Name = "translatorLabel";
            translatorLabel.Size = new System.Drawing.Size(49, 14);
            translatorLabel.TabIndex = 10;
            translatorLabel.Text = "译者：";
            // 
            // bookTypeLabel
            // 
            bookTypeLabel.AutoSize = true;
            bookTypeLabel.Location = new System.Drawing.Point(24, 645);
            bookTypeLabel.Name = "bookTypeLabel";
            bookTypeLabel.Size = new System.Drawing.Size(77, 14);
            bookTypeLabel.TabIndex = 12;
            bookTypeLabel.Text = "图书类型：";
            // 
            // pressNameLabel
            // 
            pressNameLabel.AutoSize = true;
            pressNameLabel.Location = new System.Drawing.Point(24, 673);
            pressNameLabel.Name = "pressNameLabel";
            pressNameLabel.Size = new System.Drawing.Size(91, 14);
            pressNameLabel.TabIndex = 14;
            pressNameLabel.Text = "出版社名称：";
            // 
            // pagesLabel
            // 
            pagesLabel.AutoSize = true;
            pagesLabel.Location = new System.Drawing.Point(24, 702);
            pagesLabel.Name = "pagesLabel";
            pagesLabel.Size = new System.Drawing.Size(77, 14);
            pagesLabel.TabIndex = 16;
            pagesLabel.Text = "图书页数：";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(364, 500);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(77, 14);
            priceLabel.TabIndex = 18;
            priceLabel.Text = "图书价格：";
            // 
            // pubDateLabel
            // 
            pubDateLabel.AutoSize = true;
            pubDateLabel.Location = new System.Drawing.Point(364, 530);
            pubDateLabel.Name = "pubDateLabel";
            pubDateLabel.Size = new System.Drawing.Size(77, 14);
            pubDateLabel.TabIndex = 20;
            pubDateLabel.Text = "出版时间：";
            // 
            // cDIDLabel
            // 
            cDIDLabel.AutoSize = true;
            cDIDLabel.Location = new System.Drawing.Point(364, 558);
            cDIDLabel.Name = "cDIDLabel";
            cDIDLabel.Size = new System.Drawing.Size(77, 14);
            cDIDLabel.TabIndex = 22;
            cDIDLabel.Text = "光盘编号：";
            // 
            // handbookIDLabel
            // 
            handbookIDLabel.AutoSize = true;
            handbookIDLabel.Location = new System.Drawing.Point(364, 586);
            handbookIDLabel.Name = "handbookIDLabel";
            handbookIDLabel.Size = new System.Drawing.Size(77, 14);
            handbookIDLabel.TabIndex = 24;
            handbookIDLabel.Text = "手册编号：";
            // 
            // bookshelfNameLabel
            // 
            bookshelfNameLabel.AutoSize = true;
            bookshelfNameLabel.Location = new System.Drawing.Point(364, 614);
            bookshelfNameLabel.Name = "bookshelfNameLabel";
            bookshelfNameLabel.Size = new System.Drawing.Size(77, 14);
            bookshelfNameLabel.TabIndex = 26;
            bookshelfNameLabel.Text = "书架名称：";
            // 
            // totalNumLabel
            // 
            totalNumLabel.AutoSize = true;
            totalNumLabel.Location = new System.Drawing.Point(364, 639);
            totalNumLabel.Name = "totalNumLabel";
            totalNumLabel.Size = new System.Drawing.Size(77, 14);
            totalNumLabel.TabIndex = 28;
            totalNumLabel.Text = "入库总量：";
            // 
            // storageDateLabel
            // 
            storageDateLabel.AutoSize = true;
            storageDateLabel.Location = new System.Drawing.Point(364, 672);
            storageDateLabel.Name = "storageDateLabel";
            storageDateLabel.Size = new System.Drawing.Size(77, 14);
            storageDateLabel.TabIndex = 30;
            storageDateLabel.Text = "入库时间：";
            // 
            // libraryABDataSet
            // 
            this.libraryABDataSet.DataSetName = "LibraryABDataSet";
            this.libraryABDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.libraryABDataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookBorrowTableAdapter = null;
            this.tableAdapterManager.BookshelfTableAdapter = null;
            this.tableAdapterManager.BookTableAdapter = this.bookTableAdapter;
            this.tableAdapterManager.BookTypeTableAdapter = null;
            this.tableAdapterManager.CDTableAdapter = null;
            this.tableAdapterManager.HandbookTableAdapter = null;
            this.tableAdapterManager.PressTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = loading.LibraryABDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserDataTableAdapter = null;
            this.tableAdapterManager.UserFreezeTableAdapter = null;
            // 
            // bookBindingNavigator
            // 
            this.bookBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bookBindingNavigator.BindingSource = this.bookBindingSource;
            this.bookBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bookBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bookBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bookBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripButton5,
            this.toolStripSeparator5,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripSeparator4,
            this.toolStripButton2,
            this.toolStripSeparator3,
            this.toolStripButton4,
            this.toolStripSeparator6,
            this.toolStripButton6,
            this.toolStripSeparator7,
            this.toolStripButton7});
            this.bookBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bookBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bookBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bookBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bookBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bookBindingNavigator.Name = "bookBindingNavigator";
            this.bookBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bookBindingNavigator.Size = new System.Drawing.Size(1242, 41);
            this.bookBindingNavigator.TabIndex = 0;
            this.bookBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(38, 38);
            this.bindingNavigatorAddNewItem.Text = "添加数据";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            this.bindingNavigatorDeleteItem.Text = "删除数据";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
            // bookBindingNavigatorSaveItem
            // 
            this.bookBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bookBindingNavigatorSaveItem.Image")));
            this.bookBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bookBindingNavigatorSaveItem.Name = "bookBindingNavigatorSaveItem";
            this.bookBindingNavigatorSaveItem.Size = new System.Drawing.Size(41, 38);
            this.bookBindingNavigatorSaveItem.Text = "保存数据";
            this.bookBindingNavigatorSaveItem.Click += new System.EventHandler(this.bookBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(36, 38);
            this.toolStripButton5.Text = "打开书籍类型管理窗口";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(37, 38);
            this.toolStripButton1.Text = "打开出版社管理窗口";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(35, 38);
            this.toolStripButton3.Text = "打开书架/库管理窗口";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(33, 38);
            this.toolStripButton2.Text = "打开光盘管理窗口";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(35, 38);
            this.toolStripButton4.Text = "打开手册管理窗口";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(36, 38);
            this.toolStripButton6.Text = "查询书籍";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(36, 38);
            this.toolStripButton7.Text = "刷新数据";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // bookDataGridView
            // 
            this.bookDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bookDataGridView.AutoGenerateColumns = false;
            this.bookDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.bookDataGridView.DataSource = this.bookBindingSource;
            this.bookDataGridView.Location = new System.Drawing.Point(0, 44);
            this.bookDataGridView.Name = "bookDataGridView";
            this.bookDataGridView.RowTemplate.Height = 23;
            this.bookDataGridView.Size = new System.Drawing.Size(789, 430);
            this.bookDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 46;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ISDN";
            this.dataGridViewTextBoxColumn2.HeaderText = "ISDN";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BookName";
            this.dataGridViewTextBoxColumn3.HeaderText = "BookName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 88;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn4.HeaderText = "Author";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 74;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Translator";
            this.dataGridViewTextBoxColumn5.HeaderText = "Translator";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 102;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BookType";
            this.dataGridViewTextBoxColumn6.HeaderText = "BookType";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 88;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PressName";
            this.dataGridViewTextBoxColumn7.HeaderText = "PressName";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 95;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Pages";
            this.dataGridViewTextBoxColumn8.HeaderText = "Pages";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 67;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn9.HeaderText = "Price";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 67;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PubDate";
            this.dataGridViewTextBoxColumn10.HeaderText = "PubDate";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 81;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CDID";
            this.dataGridViewTextBoxColumn11.HeaderText = "CDID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 60;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "HandbookID";
            this.dataGridViewTextBoxColumn12.HeaderText = "HandbookID";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 102;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "BookshelfName";
            this.dataGridViewTextBoxColumn13.HeaderText = "BookshelfName";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 123;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "TotalNum";
            this.dataGridViewTextBoxColumn14.HeaderText = "TotalNum";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 88;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "StorageDate";
            this.dataGridViewTextBoxColumn15.HeaderText = "StorageDate";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 109;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(107, 497);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(235, 23);
            this.iDTextBox.TabIndex = 3;
            // 
            // iSDNTextBox
            // 
            this.iSDNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "ISDN", true));
            this.iSDNTextBox.Location = new System.Drawing.Point(107, 526);
            this.iSDNTextBox.Name = "iSDNTextBox";
            this.iSDNTextBox.Size = new System.Drawing.Size(235, 23);
            this.iSDNTextBox.TabIndex = 5;
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "BookName", true));
            this.bookNameTextBox.Location = new System.Drawing.Point(107, 555);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(235, 23);
            this.bookNameTextBox.TabIndex = 7;
            // 
            // authorTextBox
            // 
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Author", true));
            this.authorTextBox.Location = new System.Drawing.Point(107, 584);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(235, 23);
            this.authorTextBox.TabIndex = 9;
            // 
            // translatorTextBox
            // 
            this.translatorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Translator", true));
            this.translatorTextBox.Location = new System.Drawing.Point(107, 613);
            this.translatorTextBox.Name = "translatorTextBox";
            this.translatorTextBox.Size = new System.Drawing.Size(235, 23);
            this.translatorTextBox.TabIndex = 11;
            // 
            // bookTypeComboBox
            // 
            this.bookTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "BookType", true));
            this.bookTypeComboBox.DataSource = this.bookTypeBindingSource;
            this.bookTypeComboBox.DisplayMember = "BookTypeName";
            this.bookTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookTypeComboBox.FormattingEnabled = true;
            this.bookTypeComboBox.Location = new System.Drawing.Point(107, 642);
            this.bookTypeComboBox.Name = "bookTypeComboBox";
            this.bookTypeComboBox.Size = new System.Drawing.Size(235, 22);
            this.bookTypeComboBox.TabIndex = 13;
            // 
            // bookTypeBindingSource
            // 
            this.bookTypeBindingSource.DataMember = "BookType";
            this.bookTypeBindingSource.DataSource = this.libraryABDataSet;
            // 
            // pressNameComboBox
            // 
            this.pressNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "PressName", true));
            this.pressNameComboBox.DataSource = this.pressBindingSource;
            this.pressNameComboBox.DisplayMember = "PressName";
            this.pressNameComboBox.FormattingEnabled = true;
            this.pressNameComboBox.Location = new System.Drawing.Point(107, 670);
            this.pressNameComboBox.Name = "pressNameComboBox";
            this.pressNameComboBox.Size = new System.Drawing.Size(235, 22);
            this.pressNameComboBox.TabIndex = 15;
            // 
            // pressBindingSource
            // 
            this.pressBindingSource.DataMember = "Press";
            this.pressBindingSource.DataSource = this.libraryABDataSet;
            // 
            // pagesTextBox
            // 
            this.pagesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Pages", true));
            this.pagesTextBox.Location = new System.Drawing.Point(107, 699);
            this.pagesTextBox.Name = "pagesTextBox";
            this.pagesTextBox.Size = new System.Drawing.Size(235, 23);
            this.pagesTextBox.TabIndex = 17;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(439, 497);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(243, 23);
            this.priceTextBox.TabIndex = 19;
            // 
            // pubDateDateTimePicker
            // 
            this.pubDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bookBindingSource, "PubDate", true));
            this.pubDateDateTimePicker.Location = new System.Drawing.Point(439, 526);
            this.pubDateDateTimePicker.Name = "pubDateDateTimePicker";
            this.pubDateDateTimePicker.Size = new System.Drawing.Size(243, 23);
            this.pubDateDateTimePicker.TabIndex = 21;
            // 
            // cDIDComboBox
            // 
            this.cDIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "CDID", true));
            this.cDIDComboBox.DataSource = this.cDBindingSource;
            this.cDIDComboBox.DisplayMember = "CDID";
            this.cDIDComboBox.FormattingEnabled = true;
            this.cDIDComboBox.Location = new System.Drawing.Point(439, 555);
            this.cDIDComboBox.Name = "cDIDComboBox";
            this.cDIDComboBox.Size = new System.Drawing.Size(243, 22);
            this.cDIDComboBox.TabIndex = 23;
            // 
            // cDBindingSource
            // 
            this.cDBindingSource.DataMember = "CD";
            this.cDBindingSource.DataSource = this.libraryABDataSet;
            // 
            // handbookIDComboBox
            // 
            this.handbookIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "HandbookID", true));
            this.handbookIDComboBox.DataSource = this.handbookBindingSource;
            this.handbookIDComboBox.DisplayMember = "HandbokID";
            this.handbookIDComboBox.FormattingEnabled = true;
            this.handbookIDComboBox.Location = new System.Drawing.Point(439, 583);
            this.handbookIDComboBox.Name = "handbookIDComboBox";
            this.handbookIDComboBox.Size = new System.Drawing.Size(243, 22);
            this.handbookIDComboBox.TabIndex = 25;
            // 
            // handbookBindingSource
            // 
            this.handbookBindingSource.DataMember = "Handbook";
            this.handbookBindingSource.DataSource = this.libraryABDataSet;
            // 
            // bookshelfNameComboBox
            // 
            this.bookshelfNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "BookshelfName", true));
            this.bookshelfNameComboBox.DataSource = this.bookshelfBindingSource;
            this.bookshelfNameComboBox.DisplayMember = "BookshelfName";
            this.bookshelfNameComboBox.FormattingEnabled = true;
            this.bookshelfNameComboBox.Location = new System.Drawing.Point(439, 611);
            this.bookshelfNameComboBox.Name = "bookshelfNameComboBox";
            this.bookshelfNameComboBox.Size = new System.Drawing.Size(243, 22);
            this.bookshelfNameComboBox.TabIndex = 27;
            // 
            // bookshelfBindingSource
            // 
            this.bookshelfBindingSource.DataMember = "Bookshelf";
            this.bookshelfBindingSource.DataSource = this.libraryABDataSet;
            // 
            // totalNumNumericUpDown
            // 
            this.totalNumNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bookBindingSource, "TotalNum", true));
            this.totalNumNumericUpDown.Location = new System.Drawing.Point(439, 639);
            this.totalNumNumericUpDown.Name = "totalNumNumericUpDown";
            this.totalNumNumericUpDown.Size = new System.Drawing.Size(243, 23);
            this.totalNumNumericUpDown.TabIndex = 29;
            // 
            // storageDateDateTimePicker
            // 
            this.storageDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bookBindingSource, "StorageDate", true));
            this.storageDateDateTimePicker.Location = new System.Drawing.Point(439, 668);
            this.storageDateDateTimePicker.Name = "storageDateDateTimePicker";
            this.storageDateDateTimePicker.Size = new System.Drawing.Size(243, 23);
            this.storageDateDateTimePicker.TabIndex = 31;
            // 
            // bookTypeTableAdapter
            // 
            this.bookTypeTableAdapter.ClearBeforeFill = true;
            // 
            // pressTableAdapter
            // 
            this.pressTableAdapter.ClearBeforeFill = true;
            // 
            // cDTableAdapter
            // 
            this.cDTableAdapter.ClearBeforeFill = true;
            // 
            // handbookTableAdapter
            // 
            this.handbookTableAdapter.ClearBeforeFill = true;
            // 
            // bookshelfTableAdapter
            // 
            this.bookshelfTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(715, 491);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 245);
            this.panel1.TabIndex = 32;
            this.panel1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(432, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 49);
            this.button2.TabIndex = 13;
            this.button2.Text = "复合查找";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 12;
            this.button1.Text = "点击查找";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "输入对应信息：";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(193, 196);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(215, 23);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(193, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 23);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 23);
            this.textBox1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "图书名称与作者组合",
            "图书名称与出版社组合",
            "作者与出版社组合"});
            this.comboBox2.Location = new System.Drawing.Point(193, 119);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(215, 22);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "图书编号",
            "ISDN",
            "图书名称",
            "作者",
            "译者",
            "出版社",
            "光盘编号",
            "手册编号"});
            this.comboBox1.Location = new System.Drawing.Point(193, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 22);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "选择复合查找方式：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "选择查找方式：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "以下查找方式可以复合查找";
            // 
            // BookManage
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 564);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pressNameComboBox);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.iSDNTextBox);
            this.Controls.Add(this.bookNameTextBox);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.translatorTextBox);
            this.Controls.Add(this.bookTypeComboBox);
            this.Controls.Add(this.pagesTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.pubDateDateTimePicker);
            this.Controls.Add(this.cDIDComboBox);
            this.Controls.Add(this.handbookIDComboBox);
            this.Controls.Add(this.bookshelfNameComboBox);
            this.Controls.Add(this.totalNumNumericUpDown);
            this.Controls.Add(this.storageDateDateTimePicker);
            this.Controls.Add(iDLabel);
            this.Controls.Add(iSDNLabel);
            this.Controls.Add(bookNameLabel);
            this.Controls.Add(authorLabel);
            this.Controls.Add(translatorLabel);
            this.Controls.Add(bookTypeLabel);
            this.Controls.Add(pressNameLabel);
            this.Controls.Add(pagesLabel);
            this.Controls.Add(priceLabel);
            this.Controls.Add(pubDateLabel);
            this.Controls.Add(cDIDLabel);
            this.Controls.Add(handbookIDLabel);
            this.Controls.Add(bookshelfNameLabel);
            this.Controls.Add(totalNumLabel);
            this.Controls.Add(storageDateLabel);
            this.Controls.Add(this.bookDataGridView);
            this.Controls.Add(this.bookBindingNavigator);
            this.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书信息管理";
            this.Load += new System.EventHandler(this.BookManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryABDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingNavigator)).EndInit();
            this.bookBindingNavigator.ResumeLayout(false);
            this.bookBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handbookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookshelfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalNumNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryABDataSet libraryABDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private loading.LibraryABDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private loading.LibraryABDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bookBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bookBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView bookDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox iSDNTextBox;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox translatorTextBox;
        private System.Windows.Forms.ComboBox bookTypeComboBox;
        private System.Windows.Forms.ComboBox pressNameComboBox;
        private System.Windows.Forms.TextBox pagesTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.DateTimePicker pubDateDateTimePicker;
        private System.Windows.Forms.ComboBox cDIDComboBox;
        private System.Windows.Forms.ComboBox handbookIDComboBox;
        private System.Windows.Forms.ComboBox bookshelfNameComboBox;
        private System.Windows.Forms.NumericUpDown totalNumNumericUpDown;
        private System.Windows.Forms.DateTimePicker storageDateDateTimePicker;
        private System.Windows.Forms.BindingSource bookTypeBindingSource;
        private loading.LibraryABDataSetTableAdapters.BookTypeTableAdapter bookTypeTableAdapter;
        private System.Windows.Forms.BindingSource pressBindingSource;
        private loading.LibraryABDataSetTableAdapters.PressTableAdapter pressTableAdapter;
        private System.Windows.Forms.BindingSource cDBindingSource;
        private loading.LibraryABDataSetTableAdapters.CDTableAdapter cDTableAdapter;
        private System.Windows.Forms.BindingSource handbookBindingSource;
        private loading.LibraryABDataSetTableAdapters.HandbookTableAdapter handbookTableAdapter;
        private System.Windows.Forms.BindingSource bookshelfBindingSource;
        private loading.LibraryABDataSetTableAdapters.BookshelfTableAdapter bookshelfTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    }
}