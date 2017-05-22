using System;
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
            CRUDProduct.Read(productBindingSource, true);
            tbProductCount.ValidatingType = typeof(System.Decimal);
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
            cbProduct.SelectedItem = product?? cbProduct.SelectedItem;
            tbProductCount.Text = count.ToString();
        }
        #endregion


        private void btnAddContent_Click(object sender, EventArgs e)
        {
            CRUDOperationContent.Create(Operation, cbProduct.SelectedItem as Product, tbProductCount.ValidateText() as decimal? ?? 0, operationContentBindingSource);
            SetOperationContentData(null, 1);
            cbProduct.Select();
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
            if (CurrentContent == null)
                return;

            operationContentBindingSource.RemoveCurrent();
            CRUDOperationContent.Delete(CurrentContent);

        }

        private void btnCloseOperation_Click(object sender, EventArgs e)
        {
            DataModelController.Instance.SubmitChanges();
        }
    }
}
