using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesProject.DataModel;

namespace SalesProject.Controlles
{
    /// <summary>
    /// контроллер для получения экземпляров данных по справочникам
    /// </summary>
    static class MagicNumberController
    {
        public static OperationType SaleOperationType
        {
            get
            {
                return DataModelController.Instance.Model.OperationTypes.SingleOrDefault(x => x.id == 1);
            }
        }

        public static OperationState OpenOperationState
        {
            get
            {
                return DataModelController.Instance.Model.OperationStates.SingleOrDefault(x => x.id == 1);
            }
        }

        public static OperationState CloseOperationState
        {
            get
            {
                return DataModelController.Instance.Model.OperationStates.SingleOrDefault(x => x.id == 2);
            }
        }

        public static OperationState CancelOperationState
        {
            get
            {
                return DataModelController.Instance.Model.OperationStates.SingleOrDefault(x => x.id == 3);
            }
        }
    }
}
