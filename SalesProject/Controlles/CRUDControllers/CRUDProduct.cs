using SalesProject.DataModel;
using System.Linq;
using System.Windows.Forms;

namespace SalesProject.Controlles.CRUDControllers
{
    static class CRUDProduct
    {

        public static void Read(BindingSource operationBindingSource)
        {
            operationBindingSource.DataSource = DataModelController.Instance.Model.Products.OrderBy(x => x.ProductName).ThenBy(x => x.Size);
        }




    }
}
