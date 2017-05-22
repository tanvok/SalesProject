using SalesProject.DataModel;
using System.Linq;
using System.Windows.Forms;

namespace SalesProject.Controlles.CRUDControllers
{
    static class CRUDProduct
    {

        public static void Read(BindingSource operationBindingSource, bool withPrice)
        {
            operationBindingSource.DataSource = DataModelController.Instance.Model.Products.ToArray().Where(x => ((!withPrice) || (x.CurrentPrice != null))).OrderBy(x => x.ProductName).ThenBy(x => x.Size);
        }




    }
}
