using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesProject.DataModel
{
    public partial class ProductPrice
    {
        public override string ToString()
        {
            return Product.ToString() + " " + Price.ToString("F2") + " р. от " + DateBegin.ToShortDateString();
        }

        
    }
}
