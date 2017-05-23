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
            

            operation.Payment = payment;
            operation.Delivery = delivery;
            operation.OperationState = MagicNumberController.CloseOperationState;
            return true;
        }
    }
}
