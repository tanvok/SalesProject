using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesProject.DataModel
{
    public partial class Operation
    {
        public override string ToString()
        {
            return OperationType.OperationTypeName + " №" + DocNumber + " от " + OperationDateTime.ToString() + " (" + OperationState.OperationStateName + ")";
        }

        public decimal OperationCost
        {
            get
            {
                decimal operationSumm = 0;
                foreach (OperationContent content in OperationContents)
                    operationSumm += content.Cost;
                return operationSumm;
            }
        }
    }
}
