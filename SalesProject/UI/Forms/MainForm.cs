using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesProject.Controlles.CRUDControllers;
using SalesProject.DataModel;

namespace SalesProject
{
    /// <summary>
    /// Основная форма приложения.
    /// Реализоавно добавление и редактирование продажи. Остальные кнопки не работают.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// текущая операция / продажа
        /// </summary>
        private Operation CurrentOperation
        {
            get
            {
                return operationBindingSource.Current as Operation;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            Text = "Продажи (" + DateTime.Today.ToShortDateString() + ")";
            tcMain_SelectedIndexChanged(null, null);
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcMain.SelectedTab == tpProducts)
                CRUDProduct.Read(productBindingSource);

            if (tcMain.SelectedTab == tpSalesList)
                LoadOperations();
        }

        private void LoadOperations()
        {
            CRUDOperation.Read(operationBindingSource);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbAddOperation_Click(object sender, EventArgs e)
        {
            CRUDOperation.Create(operationBindingSource);
        }

        private void operationBindingSource_PositionChanged(object sender, EventArgs e)
        {
            CRUDOperationContent.Read(operationContentBindingSource, CurrentOperation);
        }

        private void EditOperationBtn_Click(object sender, EventArgs e)
        {
            CRUDOperation.Update(CurrentOperation, operationBindingSource);
        }
    }
}
