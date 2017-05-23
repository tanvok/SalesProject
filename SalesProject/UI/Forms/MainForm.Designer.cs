namespace SalesProject
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActions = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьПродажуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpSalesList = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvOperations = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOperationTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip5 = new System.Windows.Forms.ToolStrip();
            this.tsbAddOperation = new System.Windows.Forms.ToolStripButton();
            this.EditEmployeeBtn = new System.Windows.Forms.ToolStripButton();
            this.DelEmployeeBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tpProducts = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.operationContentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvOperContent = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOperationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasureType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpSalesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource)).BeginInit();
            this.toolStrip5.SuspendLayout();
            this.tpProducts.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operationContentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperContent)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.tsmiActions,
            this.справочникиToolStripMenuItem,
            this.сервисToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.toolStripMenuItem4,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "&Файл";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(105, 6);
            this.toolStripSeparator6.Visible = false;
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(105, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.ExitToolStripMenuItem.Text = "&Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // tsmiActions
            // 
            this.tsmiActions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьПродажуToolStripMenuItem});
            this.tsmiActions.Name = "tsmiActions";
            this.tsmiActions.Size = new System.Drawing.Size(70, 20);
            this.tsmiActions.Text = "Действия";
            this.tsmiActions.ToolTipText = "Действия над объектом дерева";
            // 
            // создатьПродажуToolStripMenuItem
            // 
            this.создатьПродажуToolStripMenuItem.Name = "создатьПродажуToolStripMenuItem";
            this.создатьПродажуToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.создатьПродажуToolStripMenuItem.Text = "Создать продажу";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "&Справочники";
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.сервисToolStripMenuItem.Text = "Се&рвис";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справ&ка";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpSalesList);
            this.tcMain.Controls.Add(this.tpProducts);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 24);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(772, 496);
            this.tcMain.TabIndex = 2;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // tpSalesList
            // 
            this.tpSalesList.Controls.Add(this.splitContainer1);
            this.tpSalesList.Location = new System.Drawing.Point(4, 22);
            this.tpSalesList.Name = "tpSalesList";
            this.tpSalesList.Padding = new System.Windows.Forms.Padding(3);
            this.tpSalesList.Size = new System.Drawing.Size(764, 470);
            this.tpSalesList.TabIndex = 0;
            this.tpSalesList.Text = "Продажи";
            this.tpSalesList.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvOperContent);
            this.splitContainer1.Size = new System.Drawing.Size(758, 464);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvOperations, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip5, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(758, 232);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // dgvOperations
            // 
            this.dgvOperations.AllowUserToAddRows = false;
            this.dgvOperations.AllowUserToDeleteRows = false;
            this.dgvOperations.AutoGenerateColumns = false;
            this.dgvOperations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.operationTypeDataGridViewTextBoxColumn,
            this.paymentDataGridViewTextBoxColumn,
            this.deliveryDataGridViewTextBoxColumn,
            this.idOperationTypeDataGridViewTextBoxColumn});
            this.dgvOperations.DataSource = this.operationBindingSource;
            this.dgvOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOperations.Location = new System.Drawing.Point(3, 27);
            this.dgvOperations.Name = "dgvOperations";
            this.dgvOperations.ReadOnly = true;
            this.dgvOperations.RowHeadersVisible = false;
            this.dgvOperations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOperations.Size = new System.Drawing.Size(752, 464);
            this.dgvOperations.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // operationTypeDataGridViewTextBoxColumn
            // 
            this.operationTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.operationTypeDataGridViewTextBoxColumn.DataPropertyName = "OperationType";
            this.operationTypeDataGridViewTextBoxColumn.HeaderText = "Тип операции";
            this.operationTypeDataGridViewTextBoxColumn.Name = "operationTypeDataGridViewTextBoxColumn";
            this.operationTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentDataGridViewTextBoxColumn
            // 
            this.paymentDataGridViewTextBoxColumn.DataPropertyName = "Payment";
            this.paymentDataGridViewTextBoxColumn.HeaderText = "Оплата";
            this.paymentDataGridViewTextBoxColumn.Name = "paymentDataGridViewTextBoxColumn";
            this.paymentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryDataGridViewTextBoxColumn
            // 
            this.deliveryDataGridViewTextBoxColumn.DataPropertyName = "Delivery";
            this.deliveryDataGridViewTextBoxColumn.HeaderText = "Сдача";
            this.deliveryDataGridViewTextBoxColumn.Name = "deliveryDataGridViewTextBoxColumn";
            this.deliveryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idOperationTypeDataGridViewTextBoxColumn
            // 
            this.idOperationTypeDataGridViewTextBoxColumn.DataPropertyName = "idOperationType";
            this.idOperationTypeDataGridViewTextBoxColumn.HeaderText = "idOperationType";
            this.idOperationTypeDataGridViewTextBoxColumn.Name = "idOperationTypeDataGridViewTextBoxColumn";
            this.idOperationTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOperationTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // operationBindingSource
            // 
            this.operationBindingSource.DataSource = typeof(SalesProject.DataModel.Operation);
            this.operationBindingSource.PositionChanged += new System.EventHandler(this.operationBindingSource_PositionChanged);
            // 
            // toolStrip5
            // 
            this.toolStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddOperation,
            this.EditEmployeeBtn,
            this.DelEmployeeBtn,
            this.toolStripSeparator5});
            this.toolStrip5.Location = new System.Drawing.Point(0, 0);
            this.toolStrip5.Name = "toolStrip5";
            this.toolStrip5.Size = new System.Drawing.Size(758, 24);
            this.toolStrip5.TabIndex = 3;
            this.toolStrip5.Text = "toolStrip5";
            // 
            // tsbAddOperation
            // 
            this.tsbAddOperation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddOperation.Name = "tsbAddOperation";
            this.tsbAddOperation.Size = new System.Drawing.Size(63, 21);
            this.tsbAddOperation.Text = "Добавить";
            this.tsbAddOperation.ToolTipText = "Добавить продажу";
            this.tsbAddOperation.Click += new System.EventHandler(this.tsbAddOperation_Click);
            // 
            // EditEmployeeBtn
            // 
            this.EditEmployeeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditEmployeeBtn.Name = "EditEmployeeBtn";
            this.EditEmployeeBtn.Size = new System.Drawing.Size(91, 21);
            this.EditEmployeeBtn.Text = "Редактировать";
            this.EditEmployeeBtn.ToolTipText = "Редактировать продажу";
            // 
            // DelEmployeeBtn
            // 
            this.DelEmployeeBtn.ImageTransparentColor = System.Drawing.Color.Black;
            this.DelEmployeeBtn.Name = "DelEmployeeBtn";
            this.DelEmployeeBtn.Size = new System.Drawing.Size(55, 21);
            this.DelEmployeeBtn.Text = "Удалить";
            this.DelEmployeeBtn.ToolTipText = "Удалить  продажу";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 24);
            // 
            // tpProducts
            // 
            this.tpProducts.Controls.Add(this.tableLayoutPanel2);
            this.tpProducts.Location = new System.Drawing.Point(4, 22);
            this.tpProducts.Name = "tpProducts";
            this.tpProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tpProducts.Size = new System.Drawing.Size(764, 470);
            this.tpProducts.TabIndex = 1;
            this.tpProducts.Text = "Товары";
            this.tpProducts.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(758, 464);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.ProductType,
            this.ProductName,
            this.MeasureType,
            this.dataGridViewTextBoxColumn4,
            this.Balance});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(752, 464);
            this.dataGridView1.TabIndex = 5;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(SalesProject.DataModel.Product);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(758, 24);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(91, 17);
            this.toolStripButton1.Text = "Редактировать";
            this.toolStripButton1.ToolTipText = "Редактировать сотрудника";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(55, 17);
            this.toolStripButton2.Text = "Удалить";
            this.toolStripButton2.ToolTipText = "Удалить сотрудника";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 20);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(126, 17);
            this.toolStripButton3.Text = "Выгрузить в MS Excel";
            // 
            // operationContentBindingSource
            // 
            this.operationContentBindingSource.DataSource = typeof(SalesProject.DataModel.OperationContent);
            // 
            // dgvOperContent
            // 
            this.dgvOperContent.AllowUserToAddRows = false;
            this.dgvOperContent.AllowUserToDeleteRows = false;
            this.dgvOperContent.AutoGenerateColumns = false;
            this.dgvOperContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.idProductPriceDataGridViewTextBoxColumn,
            this.idOperationDataGridViewTextBoxColumn,
            this.ProductPrice,
            this.countDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.Count,
            this.operationDataGridViewTextBoxColumn});
            this.dgvOperContent.DataSource = this.operationContentBindingSource;
            this.dgvOperContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOperContent.Location = new System.Drawing.Point(0, 0);
            this.dgvOperContent.Name = "dgvOperContent";
            this.dgvOperContent.ReadOnly = true;
            this.dgvOperContent.RowHeadersVisible = false;
            this.dgvOperContent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOperContent.Size = new System.Drawing.Size(758, 228);
            this.dgvOperContent.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // idProductPriceDataGridViewTextBoxColumn
            // 
            this.idProductPriceDataGridViewTextBoxColumn.DataPropertyName = "idProductPrice";
            this.idProductPriceDataGridViewTextBoxColumn.HeaderText = "idProductPrice";
            this.idProductPriceDataGridViewTextBoxColumn.Name = "idProductPriceDataGridViewTextBoxColumn";
            this.idProductPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProductPriceDataGridViewTextBoxColumn.Visible = false;
            // 
            // idOperationDataGridViewTextBoxColumn
            // 
            this.idOperationDataGridViewTextBoxColumn.DataPropertyName = "idOperation";
            this.idOperationDataGridViewTextBoxColumn.HeaderText = "idOperation";
            this.idOperationDataGridViewTextBoxColumn.Name = "idOperationDataGridViewTextBoxColumn";
            this.idOperationDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOperationDataGridViewTextBoxColumn.Visible = false;
            // 
            // ProductPrice
            // 
            this.ProductPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductPrice.DataPropertyName = "Product";
            this.ProductPrice.HeaderText = "Название товара";
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Price";
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn2.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.DataPropertyName = "Cost";
            this.Count.HeaderText = "Стоимость";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // operationDataGridViewTextBoxColumn
            // 
            this.operationDataGridViewTextBoxColumn.DataPropertyName = "Operation";
            this.operationDataGridViewTextBoxColumn.HeaderText = "Operation";
            this.operationDataGridViewTextBoxColumn.Name = "operationDataGridViewTextBoxColumn";
            this.operationDataGridViewTextBoxColumn.ReadOnly = true;
            this.operationDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn3.HeaderText = "id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // ProductType
            // 
            this.ProductType.DataPropertyName = "ProductType";
            this.ProductType.HeaderText = "Вид продукта";
            this.ProductType.Name = "ProductType";
            this.ProductType.ReadOnly = true;
            this.ProductType.Width = 150;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "ProductFullName";
            this.ProductName.HeaderText = "Название продукта";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // MeasureType
            // 
            this.MeasureType.DataPropertyName = "CurrentPriceString";
            this.MeasureType.HeaderText = "Текущая цена";
            this.MeasureType.Name = "MeasureType";
            this.MeasureType.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CurrentPriceDateBeginString";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата установления цены";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "Balance";
            this.Balance.HeaderText = "Остаток на складе";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(63, 21);
            this.toolStripButton4.Text = "Добавить";
            this.toolStripButton4.ToolTipText = "Добавить продажу";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 520);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продажи ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tpSalesList.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource)).EndInit();
            this.toolStrip5.ResumeLayout(false);
            this.toolStrip5.PerformLayout();
            this.tpProducts.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operationContentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.MenuStrip menuStrip1;
        protected System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        protected System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        protected System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiActions;
        protected System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpSalesList;
        private System.Windows.Forms.TabPage tpProducts;
        private System.Windows.Forms.DataGridView dgvOperations;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOperationTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource operationBindingSource;
        private System.Windows.Forms.ToolStripMenuItem создатьПродажуToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip5;
        private System.Windows.Forms.ToolStripButton EditEmployeeBtn;
        private System.Windows.Forms.ToolStripButton DelEmployeeBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton tsbAddOperation;
        private System.Windows.Forms.BindingSource operationContentBindingSource;
        private System.Windows.Forms.DataGridView dgvOperContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOperationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasureType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}

