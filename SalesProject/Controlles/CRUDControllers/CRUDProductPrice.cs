using SalesProject.DataModel;
using System.Linq;
using System.Windows.Forms;
using SalesProject.UI.Forms;
using System;

namespace SalesProject.Controlles.CRUDControllers
{
    static class CRUDProductPrice
    {
        public static void Read(BindingSource bindingSource)
        {
            bindingSource.DataSource = DataModelController.Instance.Model.ProductPrices.Where(x => (x.DateBegin <= DateTime.Today) && ((x.DateEnd >= DateTime.Today) || (x.DateEnd == null))).OrderBy(x => x.Product.ProductName);
        }
    }
}
