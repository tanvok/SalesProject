using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesProject.DataModel
{
    public partial class Product
    {
        public override string ToString()
        {
            return ProductFullName;
        }

        public string ProductFullName
        {
            get
            {
                return ProductName + " " + Size + " " + MeasureType.MeasureTypeSmallName;
            }
        }
    }
}
