using SalesProject.DataModel;
using System.Linq;
using System.Windows.Forms;
using SalesProject.UI.Forms;
using SalesProject.Controlles;
using System;

namespace SalesProject.Controlles.CRUDControllers
{
    static class CRUDOperationContent
    {
        public static void Create(Operation operation, Product product, decimal productCount, BindingSource bindingSource)
        {
            if (operation == null)
                throw new ArgumentNullException("Продажа.");
            if (product == null)
                throw new ArgumentNullException("Товар.");
            if (productCount <= 0)
                throw new ArgumentNullException("Количество.");

            OperationContent newContent = new OperationContent()
            {
                Product = product,
                Count = productCount,
                Operation = operation
            };


            DataModelController.Instance.Model.OperationContents.InsertOnSubmit(newContent);
            Read(bindingSource, operation);
        }

        public static void Read(BindingSource bindingSource, Operation operation)
        {
            bindingSource.DataSource = DataModelController.Instance.Model.OperationContents.Where(x => x.Operation == operation).OrderByDescending(x => x.id).ToArray();
        }
    }
}
