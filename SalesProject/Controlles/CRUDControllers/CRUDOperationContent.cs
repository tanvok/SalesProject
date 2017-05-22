﻿using SalesProject.DataModel;
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
            bindingSource.Add(newContent);
        }

        public static void Delete(OperationContent content)
        {
            if (content != null)
                DataModelController.Instance.Model.OperationContents.DeleteOnSubmit(content);
        }

        public static void Read(BindingSource bindingSource, Operation operation)
        {
            bindingSource.DataSource = DataModelController.Instance.Model.OperationContents.Where(x => x.Operation == operation).OrderByDescending(x => x.id);
        }
    }
}
