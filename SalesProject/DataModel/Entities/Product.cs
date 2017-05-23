using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesProject.Controlles;

namespace SalesProject.DataModel
{
    public partial class Product
    {
        public override string ToString()
        {
            return ProductFullName;
        }

        /// <summary>
        /// полное название товара (включая вес)
        /// </summary>
        public string ProductFullName
        {
            get
            {
                return ProductName + ", " + Size + " " + MeasureType.MeasureTypeSmallName;
            }
        }

        /// <summary>
        /// текущая стоимость товара
        /// </summary>
        public ProductPrice CurrentPrice
        {
            get
            {
                return DataModelController.Instance.Model.ProductPrices.Where(x => ((x.Product == this) && (x.DateBegin <= DateTime.Today) && ((x.DateEnd >= DateTime.Today) || (x.DateEnd == null)))).ToArray().LastOrDefault();
            }
        }

        public string MeasureSmallString
        {
            get
            {
                return Size > 0 ? "шт" : MeasureType.MeasureTypeSmallName;
            }
        }


        public string CurrentPriceString
        {
            get
            {
                return CurrentPrice == null ? null : CurrentPrice?.Price.ToString("F2") + " р./ " + MeasureSmallString;
            }
        }

        public string CurrentPriceDateBeginString
        {
            get
            {
                return CurrentPrice?.DateBegin.ToShortDateString();
            }
        }
}
}
