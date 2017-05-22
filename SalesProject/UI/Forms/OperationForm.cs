using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesProject.DataModel;
using SalesProject.Controlles;

namespace SalesProject.UI.Forms
{
    public partial class OperationForm : Form
    {
        /// <summary>
        /// операция, для которой создается форма
        /// </summary>
        public Operation Operation
        {
            get; set;
        }

        public OperationForm(Operation operation)
        {
            InitializeComponent();
            Operation = operation;
            Text = operation.ToString();
        }
    }
}
