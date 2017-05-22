using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesProject.DataModel
{
    public partial class OperationContent
    {
        #region DataFields
        /// <summary>
        /// продукт
        /// </summary>
        public Product Product
        {
            get
            {
                return ProductPrice.Product;
            }
            set
            {
                ProductPrice.Product = value;
            }
        }

        public decimal Price
        {
            get
            {
                return ProductPrice.Price;
            }
        }

        public decimal Cost
        {
            get
            {
                return Count * Price;
            }
        }
        #endregion
    }
}
