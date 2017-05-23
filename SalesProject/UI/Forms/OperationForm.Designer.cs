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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.productPriceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddContent = new System.Windows.Forms.Button();
            this.tbProductCount = new System.Windows.Forms.MaskedTextBox();
            this.btnCloseOperation = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbPayment = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelOperation = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stlOperationCurrentSum = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDelivery = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationContentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPriceBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(667, 251);
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
            this.dgvOperContent.Size = new System.Drawing.Size(661, 232);
            this.dgvOperContent.TabIndex = 6;
            this.dgvOperContent.DoubleClick += new System.EventHandler(this.btnUpdateContent_Click);
            this.dgvOperContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvOperContent_KeyDown);
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
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Название текущего товара:";
            // 
            // cbProductPrice
            // 
            this.cbProductPrice.DataSource = this.productPriceBindingSource;
            this.cbProductPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductPrice.FormattingEnabled = true;
            this.cbProductPrice.Location = new System.Drawing.Point(6, 30);
            this.cbProductPrice.Name = "cbProductPrice";
            this.cbProductPrice.Size = new System.Drawing.Size(427, 21);
            this.cbProductPrice.TabIndex = 1;
            // 
            // productPriceBindingSource
            // 
            this.productPriceBindingSource.DataSource = typeof(SalesProject.DataModel.ProductPrice);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Количество:";
            // 
            // btnAddContent
            // 
            this.btnAddContent.Location = new System.Drawing.Point(557, 28);
            this.btnAddContent.Name = "btnAddContent";
            this.btnAddContent.Size = new System.Drawing.Size(99, 23);
            this.btnAddContent.TabIndex = 3;
            this.btnAddContent.Text = "Ok";
            this.btnAddContent.UseVisualStyleBackColor = true;
            this.btnAddContent.Click += new System.EventHandler(this.btnAddContent_Click);
            // 
            // tbProductCount
            // 
            this.tbProductCount.Location = new System.Drawing.Point(439, 30);
            this.tbProductCount.Name = "tbProductCount";
            this.tbProductCount.Size = new System.Drawing.Size(112, 20);
            this.tbProductCount.TabIndex = 2;
            // 
            // btnCloseOperation
            // 
            this.btnCloseOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCloseOperation.Location = new System.Drawing.Point(421, 312);
            this.btnCloseOperation.Name = "btnCloseOperation";
            this.btnCloseOperation.Size = new System.Drawing.Size(114, 23);
            this.btnCloseOperation.TabIndex = 4;
            this.btnCloseOperation.Text = "Закрыть продажу";
            this.btnCloseOperation.UseVisualStyleBackColor = true;
            this.btnCloseOperation.Click += new System.EventHandler(this.btnCloseOperation_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbProductCount);
            this.groupBox2.Controls.Add(this.cbProductPrice);
            this.groupBox2.Controls.Add(this.btnAddContent);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(3, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(751, 60);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // tbPayment
            // 
            this.tbPayment.Location = new System.Drawing.Point(70, 313);
            this.tbPayment.Name = "tbPayment";
            this.tbPayment.Size = new System.Drawing.Size(112, 20);
            this.tbPayment.TabIndex = 21;
            this.tbPayment.Validated += new System.EventHandler(this.tbPayment_Validated);
            // 
            // btnCancelOperation
            // 
            this.btnCancelOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelOperation.Location = new System.Drawing.Point(541, 312);
            this.btnCancelOperation.Name = "btnCancelOperation";
            this.btnCancelOperation.Size = new System.Drawing.Size(118, 23);
            this.btnCancelOperation.TabIndex = 5;
            this.btnCancelOperation.Text = "Отменить продажу";
            this.btnCancelOperation.UseVisualStyleBackColor = true;
            this.btnCancelOperation.Click += new System.EventHandler(this.btnCancelOperation_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlOperationCurrentSum});
            this.statusStrip1.Location = new System.Drawing.Point(0, 340);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(667, 22);
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stlOperationCurrentSum
            // 
            this.stlOperationCurrentSum.Name = "stlOperationCurrentSum";
            this.stlOperationCurrentSum.Size = new System.Drawing.Size(0, 17);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Получено:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Сдача:";
            // 
            // tbDelivery
            // 
            this.tbDelivery.Location = new System.Drawing.Point(253, 313);
            this.tbDelivery.Name = "tbDelivery";
            this.tbDelivery.ReadOnly = true;
            this.tbDelivery.Size = new System.Drawing.Size(121, 20);
            this.tbDelivery.TabIndex = 30;
            // 
            // OperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 362);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDelivery);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPayment);
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
            ((System.ComponentModel.ISupportInitialize)(this.productPriceBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox tbProductCount;
        private System.Windows.Forms.Button btnCloseOperation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelOperation;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stlOperationCurrentSum;
        private System.Windows.Forms.BindingSource productPriceBindingSource;
        private System.Windows.Forms.MaskedTextBox tbPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox tbDelivery;
    }
}