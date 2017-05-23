namespace SalesProject.UI.Forms
{
    partial class OperationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOperContent = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOperationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationContentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cbProductPrice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddContent = new System.Windows.Forms.Button();
            this.btnUpdateContent = new System.Windows.Forms.Button();
            this.btnDeleteContent = new System.Windows.Forms.Button();
            this.tbProductCount = new System.Windows.Forms.MaskedTextBox();
            this.btnCloseOperation = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelOperation = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stlOperationCurrentContent = new System.Windows.Forms.ToolStripStatusLabel();
            this.productPriceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationContentBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPriceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvOperContent);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список товаров";
            // 
            // dgvOperContent
            // 
            this.dgvOperContent.AllowUserToAddRows = false;
            this.dgvOperContent.AllowUserToDeleteRows = false;
            this.dgvOperContent.AutoGenerateColumns = false;
            this.dgvOperContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idProductPriceDataGridViewTextBoxColumn,
            this.idOperationDataGridViewTextBoxColumn,
            this.ProductPrice,
            this.countDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.Count,
            this.operationDataGridViewTextBoxColumn});
            this.dgvOperContent.DataSource = this.operationContentBindingSource;
            this.dgvOperContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOperContent.Location = new System.Drawing.Point(3, 16);
            this.dgvOperContent.Name = "dgvOperContent";
            this.dgvOperContent.ReadOnly = true;
            this.dgvOperContent.RowHeadersVisible = false;
            this.dgvOperContent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOperContent.Size = new System.Drawing.Size(662, 213);
            this.dgvOperContent.TabIndex = 6;
            this.dgvOperContent.DoubleClick += new System.EventHandler(this.btnUpdateContent_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Price";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn1.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            // operationContentBindingSource
            // 
            this.operationContentBindingSource.DataSource = typeof(SalesProject.DataModel.OperationContent);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Название товара:";
            // 
            // cbProductPrice
            // 
            this.cbProductPrice.DataSource = this.productPriceBindingSource;
            this.cbProductPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductPrice.FormattingEnabled = true;
            this.cbProductPrice.Location = new System.Drawing.Point(6, 30);
            this.cbProductPrice.Name = "cbProductPrice";
            this.cbProductPrice.Size = new System.Drawing.Size(469, 21);
            this.cbProductPrice.TabIndex = 1;
            this.cbProductPrice.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Количество:";
            // 
            // btnAddContent
            // 
            this.btnAddContent.Location = new System.Drawing.Point(356, 68);
            this.btnAddContent.Name = "btnAddContent";
            this.btnAddContent.Size = new System.Drawing.Size(84, 23);
            this.btnAddContent.TabIndex = 3;
            this.btnAddContent.Text = "Ok";
            this.btnAddContent.UseVisualStyleBackColor = true;
            this.btnAddContent.Click += new System.EventHandler(this.btnAddContent_Click);
            // 
            // btnUpdateContent
            // 
            this.btnUpdateContent.Location = new System.Drawing.Point(446, 68);
            this.btnUpdateContent.Name = "btnUpdateContent";
            this.btnUpdateContent.Size = new System.Drawing.Size(102, 23);
            this.btnUpdateContent.TabIndex = 6;
            this.btnUpdateContent.Text = "Редактировать";
            this.btnUpdateContent.UseVisualStyleBackColor = true;
            this.btnUpdateContent.Click += new System.EventHandler(this.btnUpdateContent_Click);
            // 
            // btnDeleteContent
            // 
            this.btnDeleteContent.Location = new System.Drawing.Point(554, 68);
            this.btnDeleteContent.Name = "btnDeleteContent";
            this.btnDeleteContent.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteContent.TabIndex = 7;
            this.btnDeleteContent.Text = "Удалить";
            this.btnDeleteContent.UseVisualStyleBackColor = true;
            this.btnDeleteContent.Click += new System.EventHandler(this.btnDeleteContent_Click);
            // 
            // tbProductCount
            // 
            this.tbProductCount.Location = new System.Drawing.Point(495, 31);
            this.tbProductCount.Name = "tbProductCount";
            this.tbProductCount.Size = new System.Drawing.Size(158, 20);
            this.tbProductCount.TabIndex = 2;
            // 
            // btnCloseOperation
            // 
            this.btnCloseOperation.Location = new System.Drawing.Point(387, 318);
            this.btnCloseOperation.Name = "btnCloseOperation";
            this.btnCloseOperation.Size = new System.Drawing.Size(133, 23);
            this.btnCloseOperation.TabIndex = 4;
            this.btnCloseOperation.Text = "Закрыть продажу";
            this.btnCloseOperation.UseVisualStyleBackColor = true;
            this.btnCloseOperation.Click += new System.EventHandler(this.btnCloseOperation_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbProductCount);
            this.groupBox2.Controls.Add(this.btnDeleteContent);
            this.groupBox2.Controls.Add(this.cbProductPrice);
            this.groupBox2.Controls.Add(this.btnUpdateContent);
            this.groupBox2.Controls.Add(this.btnAddContent);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(3, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(662, 95);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // btnCancelOperation
            // 
            this.btnCancelOperation.Location = new System.Drawing.Point(526, 318);
            this.btnCancelOperation.Name = "btnCancelOperation";
            this.btnCancelOperation.Size = new System.Drawing.Size(133, 23);
            this.btnCancelOperation.TabIndex = 5;
            this.btnCancelOperation.Text = "Отменить продажу";
            this.btnCancelOperation.UseVisualStyleBackColor = true;
            this.btnCancelOperation.Click += new System.EventHandler(this.btnCancelOperation_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlOperationCurrentContent});
            this.statusStrip1.Location = new System.Drawing.Point(0, 348);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(668, 22);
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stlOperationCurrentContent
            // 
            this.stlOperationCurrentContent.Name = "stlOperationCurrentContent";
            this.stlOperationCurrentContent.Size = new System.Drawing.Size(0, 17);
            // 
            // productPriceBindingSource
            // 
            this.productPriceBindingSource.DataSource = typeof(SalesProject.DataModel.ProductPrice);
            // 
            // OperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 370);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCancelOperation);
            this.Controls.Add(this.btnCloseOperation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "OperationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OperationForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationContentBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPriceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOperContent;
        private System.Windows.Forms.BindingSource operationContentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOperationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbProductPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddContent;
        private System.Windows.Forms.Button btnUpdateContent;
        private System.Windows.Forms.Button btnDeleteContent;
        private System.Windows.Forms.MaskedTextBox tbProductCount;
        private System.Windows.Forms.Button btnCloseOperation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelOperation;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stlOperationCurrentContent;
        private System.Windows.Forms.BindingSource productPriceBindingSource;
    }
}