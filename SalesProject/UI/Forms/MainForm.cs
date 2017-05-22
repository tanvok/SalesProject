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
    public partial class MainForm : Form
    {

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
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcMain.SelectedTab == tpProducts)
                CRUDProduct.Read(productBindingSource, false);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbAddOperation_Click(object sender, EventArgs e)
        {
            CRUDOperation.Create();
        }

        private void operationBindingSource_PositionChanged(object sender, EventArgs e)
        {

            CRUDOperationContent.Read(operationContentBindingSource, CurrentOperation);
        }
    }
}
