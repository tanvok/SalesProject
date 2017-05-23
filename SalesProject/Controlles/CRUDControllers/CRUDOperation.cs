using SalesProject.DataModel;
using System.Linq;
using System.Windows.Forms;
using SalesProject.UI.Forms;
using System;

namespace SalesProject.Controlles.CRUDControllers
{ 
    static class CRUDOperation
    {
        
        public static void Create(BindingSource operationBindingSource)
        {
            Operation newOperation = new Operation()
            {
                OperationType = MagicNumberController.SaleOperationType,
                OperationState = MagicNumberController.OpenOperationState,
                OperationDateTime = DateTime.Now
            };

            DataModelController.Instance.Model.Operations.InsertOnSubmit(newOperation);

            using (OperationForm operForm = new OperationForm(newOperation))
            {
                operForm.ShowDialog();
            };

            Read(operationBindingSource);
    
        }

        public static void Update(Operation operation, BindingSource operationBindingSource)
        {
            if (operation == null)
                return;
            using (OperationForm operForm = new OperationForm(operation))
            {
                operForm.ShowDialog();
            };

            Read(operationBindingSource);
        }
        
        public static void Read(BindingSource operationBindingSource)
        {
            operationBindingSource.DataSource = DataModelController.Instance.Model.Operations.
                Where(x => x.OperationDateTime.Date == DateTime.Today).
                OrderByDescending(x => x.OperationDateTime).ToArray();
        }

            

    }
}
