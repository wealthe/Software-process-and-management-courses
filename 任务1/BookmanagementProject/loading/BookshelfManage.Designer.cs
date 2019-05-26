namespace loading
{
    partial class BookshelfManage
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
            System.Windows.Forms.Label bookshelfIDLabel;
            System.Windows.Forms.Label bookshelfNameLabel;
            System.Windows.Forms.Label bookshelfPositionLabel;
            System.Windows.Forms.Label bookshelfNotesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookshelfManage));
            this.libraryABDataSet = new loading.LibraryABDataSet();
            this.bookshelfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookshelfTableAdapter = new loading.LibraryABDataSetTableAdapters.BookshelfTableAdapter();
            this.tableAdapterManager = new loading.LibraryABDataSetTableAdapters.TableAdapterManager();
            this.bookshelfBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bookshelfBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.bookshelfDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookshelfIDTextBox = new System.Windows.Forms.TextBox();
            this.bookshelfNameTextBox = new System.Windows.Forms.TextBox();
            this.bookshelfPositionTextBox = new System.Windows.Forms.TextBox();
            this.bookshelfNotesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            bookshelfIDLabel = new System.Windows.Forms.Label();
            bookshelfNameLabel = new System.Windows.Forms.Label();
            bookshelfPositionLabel = new System.Windows.Forms.Label();
            bookshelfNotesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryABDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookshelfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookshelfBindingNavigator)).BeginInit();
            this.bookshelfBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookshelfDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bookshelfIDLabel
            // 
            bookshelfIDLabel.AutoSize = true;
            bookshelfIDLabel.Location = new System.Drawing.Point(17, 312);
            bookshelfIDLabel.Name = "bookshelfIDLabel";
            bookshelfIDLabel.Size = new System.Drawing.Size(98, 14);
            bookshelfIDLabel.TabIndex = 2;
            bookshelfIDLabel.Text = "书架/库编号：";
            // 
            // bookshelfNameLabel
            // 
            bookshelfNameLabel.AutoSize = true;
            bookshelfNameLabel.Location = new System.Drawing.Point(17, 346);
            bookshelfNameLabel.Name = "bookshelfNameLabel";
            bookshelfNameLabel.Size = new System.Drawing.Size(98, 14);
            bookshelfNameLabel.TabIndex = 4;
            bookshelfNameLabel.Text = "书架/库名称：";
            // 
            // bookshelfPositionLabel
            // 
            bookshelfPositionLabel.AutoSize = true;
            bookshelfPositionLabel.Location = new System.Drawing.Point(17, 381);
            bookshelfPositionLabel.Name = "bookshelfPositionLabel";
            bookshelfPositionLabel.Size = new System.Drawing.Size(98, 14);
            bookshelfPositionLabel.TabIndex = 6;
            bookshelfPositionLabel.Text = "书架/库位置：";
            // 
            // bookshelfNotesLabel
            // 
            bookshelfNotesLabel.AutoSize = true;
            bookshelfNotesLabel.Location = new System.Drawing.Point(17, 417);
            bookshelfNotesLabel.Name = "bookshelfNotesLabel";
            bookshelfNotesLabel.Size = new System.Drawing.Size(98, 14);
            bookshelfNotesLabel.TabIndex = 8;
            bookshelfNotesLabel.Text = "书架/库备注：";
            // 
            // libraryABDataSet
            // 
            this.libraryABDataSet.DataSetName = "LibraryABDataSet";
            this.libraryABDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookshelfBindingSource
            // 
            this.bookshelfBindingSource.DataMember = "Bookshelf";
            this.bookshelfBindingSource.DataSource = this.libraryABDataSet;
            // 
            // bookshelfTableAdapter
            // 
            this.bookshelfTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookshelfTableAdapter = this.bookshelfTableAdapter;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.BookTypeTableAdapter = null;
            this.tableAdapterManager.CDTableAdapter = null;
            this.tableAdapterManager.HandbookTableAdapter = null;
            this.tableAdapterManager.PressTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = loading.LibraryABDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserDataTableAdapter = null;
            // 
            // bookshelfBindingNavigator
            // 
            this.bookshelfBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bookshelfBindingNavigator.BindingSource = this.bookshelfBindingSource;
            this.bookshelfBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bookshelfBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bookshelfBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bookshelfBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.bookshelfBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bookshelfBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bookshelfBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bookshelfBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bookshelfBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bookshelfBindingNavigator.Name = "bookshelfBindingNavigator";
            this.bookshelfBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bookshelfBindingNavigator.Size = new System.Drawing.Size(559, 25);
            this.bookshelfBindingNavigator.TabIndex = 0;
            this.bookshelfBindingNavigator.Text = "bindingNavigator1";
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
            // bookshelfBindingNavigatorSaveItem
            // 
            this.bookshelfBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookshelfBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bookshelfBindingNavigatorSaveItem.Image")));
            this.bookshelfBindingNavigatorSaveItem.Name = "bookshelfBindingNavigatorSaveItem";
            this.bookshelfBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bookshelfBindingNavigatorSaveItem.Text = "保存数据";
            this.bookshelfBindingNavigatorSaveItem.Click += new System.EventHandler(this.bookshelfBindingNavigatorSaveItem_Click_1);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "刷新数据";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // bookshelfDataGridView
            // 
            this.bookshelfDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bookshelfDataGridView.AutoGenerateColumns = false;
            this.bookshelfDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.bookshelfDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookshelfDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.bookshelfDataGridView.DataSource = this.bookshelfBindingSource;
            this.bookshelfDataGridView.Location = new System.Drawing.Point(0, 28);
            this.bookshelfDataGridView.Name = "bookshelfDataGridView";
            this.bookshelfDataGridView.RowTemplate.Height = 23;
            this.bookshelfDataGridView.Size = new System.Drawing.Size(559, 257);
            this.bookshelfDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BookshelfID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BookshelfID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 109;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BookshelfName";
            this.dataGridViewTextBoxColumn2.HeaderText = "BookshelfName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 123;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BookshelfPosition";
            this.dataGridViewTextBoxColumn3.HeaderText = "BookshelfPosition";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 151;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BookshelfNotes";
            this.dataGridViewTextBoxColumn4.HeaderText = "BookshelfNotes";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // bookshelfIDTextBox
            // 
            this.bookshelfIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookshelfBindingSource, "BookshelfID", true));
            this.bookshelfIDTextBox.Location = new System.Drawing.Point(113, 309);
            this.bookshelfIDTextBox.Name = "bookshelfIDTextBox";
            this.bookshelfIDTextBox.ReadOnly = true;
            this.bookshelfIDTextBox.Size = new System.Drawing.Size(181, 23);
            this.bookshelfIDTextBox.TabIndex = 3;
            // 
            // bookshelfNameTextBox
            // 
            this.bookshelfNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookshelfBindingSource, "BookshelfName", true));
            this.bookshelfNameTextBox.Location = new System.Drawing.Point(113, 343);
            this.bookshelfNameTextBox.Name = "bookshelfNameTextBox";
            this.bookshelfNameTextBox.Size = new System.Drawing.Size(181, 23);
            this.bookshelfNameTextBox.TabIndex = 5;
            // 
            // bookshelfPositionTextBox
            // 
            this.bookshelfPositionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookshelfBindingSource, "BookshelfPosition", true));
            this.bookshelfPositionTextBox.Location = new System.Drawing.Point(113, 378);
            this.bookshelfPositionTextBox.Name = "bookshelfPositionTextBox";
            this.bookshelfPositionTextBox.Size = new System.Drawing.Size(181, 23);
            this.bookshelfPositionTextBox.TabIndex = 7;
            // 
            // bookshelfNotesTextBox
            // 
            this.bookshelfNotesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookshelfBindingSource, "BookshelfNotes", true));
            this.bookshelfNotesTextBox.Location = new System.Drawing.Point(113, 414);
            this.bookshelfNotesTextBox.Name = "bookshelfNotesTextBox";
            this.bookshelfNotesTextBox.Size = new System.Drawing.Size(181, 23);
            this.bookshelfNotesTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "查找方式：";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "书架/库名称",
            "书架/库位置",
            "书架/库备注"});
            this.comboBox1.Location = new System.Drawing.Point(407, 309);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 22);
            this.comboBox1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "输入查找字段：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(313, 381);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 23);
            this.textBox1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "GO!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookshelfManage
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 460);
            this.Controls.Add(this.bookshelfIDTextBox);
            this.Controls.Add(this.bookshelfNameTextBox);
            this.Controls.Add(this.bookshelfPositionTextBox);
            this.Controls.Add(this.bookshelfNotesTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(bookshelfIDLabel);
            this.Controls.Add(bookshelfNameLabel);
            this.Controls.Add(bookshelfPositionLabel);
            this.Controls.Add(bookshelfNotesLabel);
            this.Controls.Add(this.bookshelfDataGridView);
            this.Controls.Add(this.bookshelfBindingNavigator);
            this.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BookshelfManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "书架/库管理";
            this.Load += new System.EventHandler(this.BookshelfManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryABDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookshelfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookshelfBindingNavigator)).EndInit();
            this.bookshelfBindingNavigator.ResumeLayout(false);
            this.bookshelfBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookshelfDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryABDataSet libraryABDataSet;
        private System.Windows.Forms.BindingSource bookshelfBindingSource;
        private loading.LibraryABDataSetTableAdapters.BookshelfTableAdapter bookshelfTableAdapter;
        private loading.LibraryABDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bookshelfBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bookshelfBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView bookshelfDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox bookshelfIDTextBox;
        private System.Windows.Forms.TextBox bookshelfNameTextBox;
        private System.Windows.Forms.TextBox bookshelfPositionTextBox;
        private System.Windows.Forms.TextBox bookshelfNotesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;

    }
}