﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesProject.DataModel;
using SalesProject.Controlles;
using SalesProject.Controlles.CRUDControllers;

namespace SalesProject.UI.Forms
{
    public partial class OperationForm : Form
    {
        /// <summary>
        /// операция, для которой создается форма
        /// </summary>
        public Operation Operation
        {
            get; set;
        }

        private OperationContent CurrentContent
        {
            get
            {
                return operationContentBindingSource.Current as OperationContent;
            }
        }


        #region LoadData

        private void LoadOperationContent()
        {
            CRUDOperationContent.Read(operationContentBindingSource, Operation);
        }

        private void LoadFormData()
        {
            Text = Operation.ToString();
            CRUDProductPrice.Read(productPriceBindingSource);
            tbProductCount.ValidatingType = typeof(System.Decimal);
            SetOperationContentData(null, 1);
            RefreshStateString();
        }

        public OperationForm(Operation operation)
        {
            InitializeComponent();
            Operation = operation;
            LoadFormData();
            LoadOperationContent();
        }

        #endregion

        #region SmallMethods
        private void ReadOperationContentData()
        {
            if (CurrentContent == null)
                return;
            SetOperationContentData(CurrentContent.Product, CurrentContent.Count);
        }

        private void SetOperationContentData(Product product, decimal count)
        {
            cbProductPrice.SelectedItem = product?? cbProductPrice.SelectedItem;
            tbProductCount.Text = count.ToString();
        }

        private void RefreshStateString()
        {
            stlOperationCurrentSum.Text = "Покупка на сумму " + Operation.OperationCost;
        }
        #endregion

        
        private void btnAddContent_Click(object sender, EventArgs e)
        {
            CRUDOperationContent.Create(Operation, cbProductPrice.SelectedItem as ProductPrice, tbProductCount.ValidateText() as decimal? ?? 0, operationContentBindingSource);
            SetOperationContentData(null, 1);
            cbProductPrice.Select();
            RefreshStateString();
        }


        
        private void btnUpdateContent_Click(object sender, EventArgs e)
        {
            ReadOperationContentData();
        }

        private void DeleteCurrentContent()
        {
            operationContentBindingSource.RemoveCurrent();
        }

        private void btnDeleteContent_Click(object sender, EventArgs e)
        {
            

        }

        private void btnCloseOperation_Click(object sender, EventArgs e)
        {
            DataModelController.Instance.SubmitChanges();
            Close();
        }

        private void btnCancelOperation_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

            //stlOperationCurrentContent.Text = cbProduct.SelectedItem == null ? null : "Товар: " +cbProduct.SelectedItem.ToString()+
        }

        private void dgvOperContent_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyValue.ToString());
            if (CurrentContent == null)
                return;

            if (e.KeyValue == (char)Keys.Delete)
            {
                operationContentBindingSource.RemoveCurrent();
                CRUDOperationContent.Delete(CurrentContent);
            }
        }
    }
}
