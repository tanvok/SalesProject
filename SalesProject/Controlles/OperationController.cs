using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesProject.DataModel;
using System.Windows.Forms;

namespace SalesProject.Controlles
{
    static class OperationController
    {
        /// <summary>
        /// расчет суммы сдачи
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="payment"></param>
        /// <returns></returns>
        public static decimal CalcDelivery(Operation operation, decimal payment)
        {
            if ((payment <= 0) || (operation == null))
                return 0;
            return payment - operation.OperationCost;
        }

        /// <summary>
        /// проверка количества продукта
        /// </summary>
        /// <param name="productPrice"></param>
        /// <param name="productCount"></param>
        /// <returns></returns>
        public static bool CheckProductCount(ProductPrice productPrice, decimal productCount)
        {
            if ((productCount != Decimal.Ceiling(productCount)) && (!productPrice.Product.CanBeDecimalCount))
            {
                MessageBox.Show("Количество выбранного товара может быть только целым числом.", "ИС \"Продажи\"");
                return false;
            }
            return true;
        }


        #region OperationMethods

        public static bool CloseOperation(Operation operation, decimal payment, decimal delivery)
        {
            if (operation == null)
            {
                throw new ArgumentNullException("Продажа.");
            }
            if (payment <= 0)
            {
                MessageBox.Show("Укажите оплату", "ИС \"Продажи\"");
                return false;
            }
            if (payment < operation.OperationCost)
            {
                MessageBox.Show("Указанная оплата меньше суммы продажи.", "ИС \"Продажи\"");
                return false;
            }

            operation.Payment = payment;
            operation.Delivery = delivery;
            operation.OperationState = MagicNumberController.CloseOperationState;
            return true;
        }
        #endregion
    }
}
