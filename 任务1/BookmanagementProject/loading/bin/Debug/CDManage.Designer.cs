namespace loading
{
    partial class CDManage
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
            System.Windows.Forms.Label cDIDLabel;
            System.Windows.Forms.Label cDNameLabel;
            System.Windows.Forms.Label cDTypeLabel;
            System.Windows.Forms.Label cDPositionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDManage));
            this.libraryABDataSet = new loading.LibraryABDataSet();
            this.cDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDTableAdapter = new loading.LibraryABDataSetTableAdapters.CDTableAdapter();
            this.tableAdapterManager = new loading.LibraryABDataSetTableAdapters.TableAdapterManager();
            this.cDBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cDBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.cDDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDIDTextBox = new System.Windows.Forms.TextBox();
            this.cDNameTextBox = new System.Windows.Forms.TextBox();
            this.cDPositionTextBox = new System.Windows.Forms.TextBox();
            this.cDTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            cDIDLabel = new System.Windows.Forms.Label();
            cDNameLabel = new System.Windows.Forms.Label();
            cDTypeLabel = new System.Windows.Forms.Label();
            cDPositionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryABDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDBindingNavigator)).BeginInit();
            this.cDBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cDDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cDIDLabel
            // 
            cDIDLabel.AutoSize = true;
            cDIDLabel.Location = new System.Drawing.Point(22, 309);
            cDIDLabel.Name = "cDIDLabel";
            cDIDLabel.Size = new System.Drawing.Size(77, 14);
            cDIDLabel.TabIndex = 2;
            cDIDLabel.Text = "光盘编号：";
            // 
            // cDNameLabel
            // 
            cDNameLabel.AutoSize = true;
            cDNameLabel.Location = new System.Drawing.Point(22, 345);
            cDNameLabel.Name = "cDNameLabel";
            cDNameLabel.Size = new System.Drawing.Size(77, 14);
            cDNameLabel.TabIndex = 4;
            cDNameLabel.Text = "光盘名称：";
            // 
            // cDTypeLabel
            // 
            cDTypeLabel.AutoSize = true;
            cDTypeLabel.Location = new System.Drawing.Point(22, 381);
            cDTypeLabel.Name = "cDTypeLabel";
            cDTypeLabel.Size = new System.Drawing.Size(77, 14);
            cDTypeLabel.TabIndex = 6;
            cDTypeLabel.Text = "光盘类型：";
            // 
            // cDPositionLabel
            // 
            cDPositionLabel.AutoSize = true;
            cDPositionLabel.Location = new System.Drawing.Point(22, 417);
            cDPositionLabel.Name = "cDPositionLabel";
            cDPositionLabel.Size = new System.Drawing.Size(77, 14);
            cDPositionLabel.TabIndex = 8;
            cDPositionLabel.Text = "所在库名：";
            // 
            // libraryABDataSet
            // 
            this.libraryABDataSet.DataSetName = "LibraryABDataSet";
            this.libraryABDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cDBindingSource
            // 
            this.cDBindingSource.DataMember = "CD";
            this.cDBindingSource.DataSource = this.libraryABDataSet;
            // 
            // cDTableAdapter
            // 
            this.cDTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookshelfTableAdapter = null;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.BookTypeTableAdapter = null;
            this.tableAdapterManager.CDTableAdapter = this.cDTableAdapter;
            this.tableAdapterManager.HandbookTableAdapter = null;
            this.tableAdapterManager.PressTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = loading.LibraryABDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserDataTableAdapter = null;
            // 
            // cDBindingNavigator
            // 
            this.cDBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cDBindingNavigator.BindingSource = this.cDBindingSource;
            this.cDBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cDBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cDBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cDBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.cDBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cDBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cDBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cDBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cDBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cDBindingNavigator.Name = "cDBindingNavigator";
            this.cDBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cDBindingNavigator.Size = new System.Drawing.Size(600, 25);
            this.cDBindingNavigator.TabIndex = 0;
            this.cDBindingNavigator.Text = "bindingNavigator1";
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
            // cDBindingNavigatorSaveItem
            // 
            this.cDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cDBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cDBindingNavigatorSaveItem.Image")));
            this.cDBindingNavigatorSaveItem.Name = "cDBindingNavigatorSaveItem";
            this.cDBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cDBindingNavigatorSaveItem.Text = "保存数据";
            this.cDBindingNavigatorSaveItem.Click += new System.EventHandler(this.cDBindingNavigatorSaveItem_Click);
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
            // cDDataGridView
            // 
            this.cDDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cDDataGridView.AutoGenerateColumns = false;
            this.cDDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.cDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cDDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.cDDataGridView.DataSource = this.cDBindingSource;
            this.cDDataGridView.Location = new System.Drawing.Point(0, 33);
            this.cDDataGridView.Name = "cDDataGridView";
            this.cDDataGridView.RowTemplate.Height = 23;
            this.cDDataGridView.Size = new System.Drawing.Size(600, 253);
            this.cDDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CDID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CDID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CDName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CDName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 74;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CDType";
            this.dataGridViewTextBoxColumn3.HeaderText = "CDType";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 74;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CDPosition";
            this.dataGridViewTextBoxColumn4.HeaderText = "CDPosition";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 102;
            // 
            // cDIDTextBox
            // 
            this.cDIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cDBindingSource, "CDID", true));
            this.cDIDTextBox.Location = new System.Drawing.Point(112, 306);
            this.cDIDTextBox.Name = "cDIDTextBox";
            this.cDIDTextBox.Size = new System.Drawing.Size(212, 23);
            this.cDIDTextBox.TabIndex = 3;
            // 
            // cDNameTextBox
            // 
            this.cDNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cDBindingSource, "CDName", true));
            this.cDNameTextBox.Location = new System.Drawing.Point(112, 342);
            this.cDNameTextBox.Name = "cDNameTextBox";
            this.cDNameTextBox.Size = new System.Drawing.Size(212, 23);
            this.cDNameTextBox.TabIndex = 5;
            // 
            // cDPositionTextBox
            // 
            this.cDPositionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cDBindingSource, "CDPosition", true));
            this.cDPositionTextBox.Location = new System.Drawing.Point(112, 414);
            this.cDPositionTextBox.Name = "cDPositionTextBox";
            this.cDPositionTextBox.Size = new System.Drawing.Size(212, 23);
            this.cDPositionTextBox.TabIndex = 9;
            // 
            // cDTypeComboBox
            // 
            this.cDTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cDBindingSource, "CDType", true));
            this.cDTypeComboBox.FormattingEnabled = true;
            this.cDTypeComboBox.Items.AddRange(new object[] {
            "CD",
            "DVD",
            "BD"});
            this.cDTypeComboBox.Location = new System.Drawing.Point(112, 378);
            this.cDTypeComboBox.Name = "cDTypeComboBox";
            this.cDTypeComboBox.Size = new System.Drawing.Size(212, 22);
            this.cDTypeComboBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "查询方式：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "输入查找字段：";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "光盘名称",
            "光盘类型",
            "所在库名"});
            this.comboBox1.Location = new System.Drawing.Point(454, 315);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 22);
            this.comboBox1.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(362, 390);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 23);
            this.textBox1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "GO!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CDManage
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cDTypeComboBox);
            this.Controls.Add(cDIDLabel);
            this.Controls.Add(this.cDIDTextBox);
            this.Controls.Add(cDNameLabel);
            this.Controls.Add(this.cDNameTextBox);
            this.Controls.Add(cDTypeLabel);
            this.Controls.Add(cDPositionLabel);
            this.Controls.Add(this.cDPositionTextBox);
            this.Controls.Add(this.cDDataGridView);
            this.Controls.Add(this.cDBindingNavigator);
            this.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CDManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "光盘管理";
            this.Load += new System.EventHandler(this.CDManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryABDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDBindingNavigator)).EndInit();
            this.cDBindingNavigator.ResumeLayout(false);
            this.cDBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cDDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryABDataSet libraryABDataSet;
        private System.Windows.Forms.BindingSource cDBindingSource;
        private loading.LibraryABDataSetTableAdapters.CDTableAdapter cDTableAdapter;
        private loading.LibraryABDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cDBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cDBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cDDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox cDIDTextBox;
        private System.Windows.Forms.TextBox cDNameTextBox;
        private System.Windows.Forms.TextBox cDPositionTextBox;
        private System.Windows.Forms.ComboBox cDTypeComboBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}