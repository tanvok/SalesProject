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

        private void LoadOperationContent()
        {
            CRUDOperationContent.Read(operationContentBindingSource, Operation);
        }

        public OperationForm(Operation operation)
        {
            InitializeComponent();
            Operation = operation;
            Text = operation.ToString();
            CRUDProduct.Read(productBindingSource, true);
            LoadOperationContent();
            tbProductCount.ValidatingType = typeof(System.Decimal);
        }

        private void btnAddContent_Click(object sender, EventArgs e)
        {
            CRUDOperationContent.Create(Operation, cbProduct.SelectedItem as Product, tbProductCount.ValidateText() as decimal? ?? 0, operationContentBindingSource);
            LoadOperationContent();
        }
    }
}
