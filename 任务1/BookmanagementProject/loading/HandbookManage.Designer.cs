namespace loading
{
    partial class HandbookManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HandbookManage));
            System.Windows.Forms.Label handbokIDLabel;
            System.Windows.Forms.Label handbookNameLabel;
            System.Windows.Forms.Label handbookPositionLabel;
            this.libraryABDataSet = new loading.LibraryABDataSet();
            this.handbookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.handbookTableAdapter = new loading.LibraryABDataSetTableAdapters.HandbookTableAdapter();
            this.tableAdapterManager = new loading.LibraryABDataSetTableAdapters.TableAdapterManager();
            this.handbookBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.handbookBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.handbookDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.handbokIDTextBox = new System.Windows.Forms.TextBox();
            this.handbookNameTextBox = new System.Windows.Forms.TextBox();
            this.handbookPositionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            handbokIDLabel = new System.Windows.Forms.Label();
            handbookNameLabel = new System.Windows.Forms.Label();
            handbookPositionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryABDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handbookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handbookBindingNavigator)).BeginInit();
            this.handbookBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.handbookDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // libraryABDataSet
            // 
            this.libraryABDataSet.DataSetName = "LibraryABDataSet";
            this.libraryABDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // handbookBindingSource
            // 
            this.handbookBindingSource.DataMember = "Handbook";
            this.handbookBindingSource.DataSource = this.libraryABDataSet;
            // 
            // handbookTableAdapter
            // 
            this.handbookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookshelfTableAdapter = null;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.BookTypeTableAdapter = null;
            this.tableAdapterManager.CDTableAdapter = null;
            this.tableAdapterManager.HandbookTableAdapter = this.handbookTableAdapter;
            this.tableAdapterManager.PressTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = loading.LibraryABDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserDataTableAdapter = null;
            // 
            // handbookBindingNavigator
            // 
            this.handbookBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.handbookBindingNavigator.BindingSource = this.handbookBindingSource;
            this.handbookBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.handbookBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.handbookBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.handbookBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.handbookBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.handbookBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.handbookBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.handbookBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.handbookBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.handbookBindingNavigator.Name = "handbookBindingNavigator";
            this.handbookBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.handbookBindingNavigator.Size = new System.Drawing.Size(598, 25);
            this.handbookBindingNavigator.TabIndex = 0;
            this.handbookBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // handbookBindingNavigatorSaveItem
            // 
            this.handbookBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.handbookBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("handbookBindingNavigatorSaveItem.Image")));
            this.handbookBindingNavigatorSaveItem.Name = "handbookBindingNavigatorSaveItem";
            this.handbookBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.handbookBindingNavigatorSaveItem.Text = "保存数据";
            this.handbookBindingNavigatorSaveItem.Click += new System.EventHandler(this.handbookBindingNavigatorSaveItem_Click);
            // 
            // handbookDataGridView
            // 
            this.handbookDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.handbookDataGridView.AutoGenerateColumns = false;
            this.handbookDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.handbookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.handbookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.handbookDataGridView.DataSource = this.handbookBindingSource;
            this.handbookDataGridView.Location = new System.Drawing.Point(0, 33);
            this.handbookDataGridView.Name = "handbookDataGridView";
            this.handbookDataGridView.RowTemplate.Height = 23;
            this.handbookDataGridView.Size = new System.Drawing.Size(598, 261);
            this.handbookDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HandbokID";
            this.dataGridViewTextBoxColumn1.HeaderText = "HandbokID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 95;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HandbookName";
            this.dataGridViewTextBoxColumn2.HeaderText = "HandbookName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 116;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HandbookPosition";
            this.dataGridViewTextBoxColumn3.HeaderText = "HandbookPosition";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 144;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // handbokIDLabel
            // 
            handbokIDLabel.AutoSize = true;
            handbokIDLabel.Location = new System.Drawing.Point(27, 316);
            handbokIDLabel.Name = "handbokIDLabel";
            handbokIDLabel.Size = new System.Drawing.Size(77, 14);
            handbokIDLabel.TabIndex = 2;
            handbokIDLabel.Text = "手册编号：";
            // 
            // handbokIDTextBox
            // 
            this.handbokIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.handbookBindingSource, "HandbokID", true));
            this.handbokIDTextBox.Location = new System.Drawing.Point(104, 312);
            this.handbokIDTextBox.Name = "handbokIDTextBox";
            this.handbokIDTextBox.Size = new System.Drawing.Size(178, 23);
            this.handbokIDTextBox.TabIndex = 3;
            // 
            // handbookNameLabel
            // 
            handbookNameLabel.AutoSize = true;
            handbookNameLabel.Location = new System.Drawing.Point(27, 356);
            handbookNameLabel.Name = "handbookNameLabel";
            handbookNameLabel.Size = new System.Drawing.Size(77, 14);
            handbookNameLabel.TabIndex = 4;
            handbookNameLabel.Text = "手册名称：";
            // 
            // handbookNameTextBox
            // 
            this.handbookNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.handbookBindingSource, "HandbookName", true));
            this.handbookNameTextBox.Location = new System.Drawing.Point(104, 353);
            this.handbookNameTextBox.Name = "handbookNameTextBox";
            this.handbookNameTextBox.Size = new System.Drawing.Size(178, 23);
            this.handbookNameTextBox.TabIndex = 5;
            // 
            // handbookPositionLabel
            // 
            handbookPositionLabel.AutoSize = true;
            handbookPositionLabel.Location = new System.Drawing.Point(27, 397);
            handbookPositionLabel.Name = "handbookPositionLabel";
            handbookPositionLabel.Size = new System.Drawing.Size(77, 14);
            handbookPositionLabel.TabIndex = 6;
            handbookPositionLabel.Text = "所在库名：";
            // 
            // handbookPositionTextBox
            // 
            this.handbookPositionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.handbookBindingSource, "HandbookPosition", true));
            this.handbookPositionTextBox.Location = new System.Drawing.Point(104, 393);
            this.handbookPositionTextBox.Name = "handbookPositionTextBox";
            this.handbookPositionTextBox.Size = new System.Drawing.Size(178, 23);
            this.handbookPositionTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "查询方式：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "输入查询字段：";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "手册编号",
            "手册名称",
            "所在库名"});
            this.comboBox1.Location = new System.Drawing.Point(416, 312);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 22);
            this.comboBox1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(517, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "GO!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(323, 388);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 23);
            this.textBox1.TabIndex = 12;
            // 
            // HandbookManage
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 442);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(handbokIDLabel);
            this.Controls.Add(this.handbokIDTextBox);
            this.Controls.Add(handbookNameLabel);
            this.Controls.Add(this.handbookNameTextBox);
            this.Controls.Add(handbookPositionLabel);
            this.Controls.Add(this.handbookPositionTextBox);
            this.Controls.Add(this.handbookDataGridView);
            this.Controls.Add(this.handbookBindingNavigator);
            this.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HandbookManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "手册管理";
            this.Load += new System.EventHandler(this.HandbookManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryABDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handbookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handbookBindingNavigator)).EndInit();
            this.handbookBindingNavigator.ResumeLayout(false);
            this.handbookBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.handbookDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryABDataSet libraryABDataSet;
        private System.Windows.Forms.BindingSource handbookBindingSource;
        private loading.LibraryABDataSetTableAdapters.HandbookTableAdapter handbookTableAdapter;
        private loading.LibraryABDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator handbookBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton handbookBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView handbookDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox handbokIDTextBox;
        private System.Windows.Forms.TextBox handbookNameTextBox;
        private System.Windows.Forms.TextBox handbookPositionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}