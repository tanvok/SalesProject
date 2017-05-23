using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesProject.Controlles;
using SalesProject.Controlles.CRUDControllers;

namespace SalesProject.DataModel
{
    public partial class Operation
    {
        public override string ToString()
        {
            return OperationType.OperationTypeName + " №" + id.ToString() + " от " + OperationDateTime.ToString() + " (" + OperationState.OperationStateName + ")";
        }

        public decimal OperationCost
        {
            get
            {
                decimal operationSumm = 0;
                foreach (var content in OperationContents?.Where(x => !x.IsDeleted))
                    operationSumm += content.Cost;
                return operationSumm;
            }
        }
    }
}
