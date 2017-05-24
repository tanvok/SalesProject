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
    /// <summary>
    /// Форма для работы с продажей (добавление/редактирование)
    /// Редактировать товар можно по двойному клику левой клавишей мыши по нему в таблице
    /// Удалить товар можно нажав на Delete по нему в таблице
    /// </summary>
    public partial class OperationForm : Form
    {
        /// <summary>
        /// операция, для которой создается форма
        /// </summary>
        public Operation Operation
        {
            get; set;
        }

        /// <summary>
        /// текущая строка с товаром
        /// </summary>
        private OperationContent CurrentContent
        {
            get
            {
                return operationContentBindingSource.Current as OperationContent;
            }
        }

        /// <summary>
        /// строка с товаром, которая используется для редактирования записи Content
        /// </summary>
        private OperationContent updatedContent = null;



        #region LoadData

        /// <summary>
        /// загрузка списка товаров
        /// </summary>
        private void LoadOperationContent()
        {
            CRUDOperationContent.Read(operationContentBindingSource, Operation);
        }

        /// <summary>
        /// загрузка основных данных для формы
        /// </summary>
        private void LoadFormData()
        {
            Text = Operation.ToString();
            CRUDProductPrice.Read(productPriceBindingSource);
            tbProductCount.ValidatingType = typeof(System.Decimal);
            tbDelivery.ValidatingType = typeof(System.Decimal);
            tbPayment.ValidatingType = typeof(System.Decimal);
            SetOperationContentData(null, 1);
            RefreshStateString();
            if (Operation.id > 0)
            {
                btnCloseOperation.Text = "Сохранить изменения";
                btnCancelOperation.Text = "Отменить изменения";
                tbPayment.Text = Operation.Payment.ToString();
                tbDelivery.Text = Operation.Delivery.ToString();
            }
        }

        public OperationForm(Operation operation)
        {
            InitializeComponent();
            Operation = operation;
            LoadFormData();
            LoadOperationContent();
        }

        /// <summary>
        /// обновление строки состояния (с суммой продажи)
        /// </summary>
        private void RefreshStateString()
        {
            stlOperationCurrentSum.Text = "Покупка на общую сумму " + Operation.OperationCost.ToString("F2");
            if ((tbPayment.Text == null) || (tbPayment.Text == "") || ((tbPayment.ValidateText() as decimal? ?? 0) <= Operation.OperationCost))
            {
                tbPayment.Text = Operation.OperationCost.ToString("F2");
            }
            CalcDelivery();
        }

        /// <summary>
        /// обновление списка товаров
        /// </summary>
        /// <param name="bindingSource"></param>
        private void RefreshBindingSource(BindingSource bindingSource)
        {
            operationContentBindingSource.MoveNext();   //обновление BindingSource
            operationContentBindingSource.MovePrevious();
            RefreshStateString();
        }
        #endregion


        #region OperationContentMethods
        private void SetOperationContentData(ProductPrice productPrice, decimal count)
        {
            cbProductPrice.SelectedItem = productPrice ?? cbProductPrice.SelectedItem;
            tbProductCount.Text = count.ToString();
        }

        /// <summary>
        /// Добавление/редактирование текущего товара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddContent_Click(object sender, EventArgs e)
        {
            if (!OperationController.CheckProductCount(cbProductPrice.SelectedItem as ProductPrice, tbProductCount.ValidateText() as decimal? ?? 0))
            {
                tbProductCount.Text = decimal.Floor(tbProductCount.ValidateText() as decimal? ?? 0).ToString();
                return;
            }

            if (updatedContent == null)
            {   //добавление нового товара
                CRUDOperationContent.Create(Operation, cbProductPrice.SelectedItem as ProductPrice, tbProductCount.ValidateText() as decimal? ?? 0, operationContentBindingSource);
            }
            else
            {   //редактирование текущего товара
                updatedContent.ProductPrice = cbProductPrice.SelectedItem as ProductPrice ?? updatedContent.ProductPrice;
                updatedContent.Count = tbProductCount.ValidateText() as decimal? ?? updatedContent.Count;
                RefreshBindingSource(operationContentBindingSource);
            }
            SetOperationContentData(null, 1);
            cbProductPrice.Select();
            RefreshStateString();
        }


        /// <summary>
        /// редактирование текущего товара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateContent_Click(object sender, EventArgs e)
        {
            updatedContent = CurrentContent;
            if (updatedContent != null)
            {
                SetOperationContentData(updatedContent.ProductPrice, updatedContent.Count);
            }
        }

        /// <summary>
        /// удаление текущего товара
        /// </summary>
        private void DeleteCurrentContent()
        {
            OperationContent deletedContent = CurrentContent;
            if (deletedContent == null)
                return;
            operationContentBindingSource.Remove(deletedContent);
            CRUDOperationContent.Delete(deletedContent);
            deletedContent.IsDeleted = true;
            RefreshStateString();
        }

        private void dgvOperContent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Delete)
            {
                DeleteCurrentContent();
            }
        }

        private void btnDeleteContent_Click(object sender, EventArgs e)
        {
            DeleteCurrentContent();
        }

        #endregion

        #region OperationData
        private void btnCloseOperation_Click(object sender, EventArgs e)
        {
            if (!OperationController.CloseOperation(Operation, tbPayment.ValidateText() as decimal? ?? 0, tbDelivery.ValidateText() as decimal? ?? 0))
                return;
            DataModelController.Instance.SubmitChanges();
            Close();
        }

        private void btnCancelOperation_Click(object sender, EventArgs e)
        {
            DataModelController.Instance.DeleteModel();
            Close();
        }

        private void tbPayment_Validated(object sender, EventArgs e)
        {
            CalcDelivery();
        }

        private void CalcDelivery()
        {
            tbDelivery.Text = (OperationController.CalcDelivery(Operation, tbPayment.ValidateText() as decimal? ?? 0)).ToString("F2");
        }

        #endregion
    }
}
