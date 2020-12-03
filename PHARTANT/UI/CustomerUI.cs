using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHARTANT.Controller;

namespace PHARTANT.UI
{
    public partial class CustomerUI : Form
    {
        private CustomerController _controller;
        public CustomerUI()
        {
            InitializeComponent();
            _controller = new CustomerController();
        }
        public CustomerController Controller
        {
            get
            {
                return _controller;
            }
        }
        private void CustomerUI_Load(object sender, EventArgs e)
        {
            SetCustomerGrid();
        }
        private void SetCustomerGrid()
        {
            dataGridCustomers.AutoGenerateColumns = false;
            AddColumnsToCustomersGrid();
            RebindCustomersGrid();
        }
        private void AddColumnsToCustomersGrid()
        {
            DataGridViewColumn dataGridViewColumn;

            dataGridViewColumn = new DataGridViewColumn();
            dataGridViewColumn.DataPropertyName = "NIT";
            dataGridViewColumn.HeaderText = "NIT";
            dataGridViewColumn.CellTemplate = new DataGridViewTextBoxCell();
            dataGridViewColumn.Name = "NIT";
            dataGridCustomers.Columns.Add(dataGridViewColumn);

            dataGridViewColumn = new DataGridViewColumn();
            dataGridViewColumn.DataPropertyName = "name";
            dataGridViewColumn.HeaderText = "Nombre para la factura";
            dataGridViewColumn.CellTemplate = new DataGridViewTextBoxCell();
            dataGridViewColumn.Name = "name";
            dataGridCustomers.Columns.Add(dataGridViewColumn);
        }
        private void RebindCustomersGrid()
        {
            var source = new BindingSource();
            var customersList = Controller.Customers;
            source.DataSource = customersList;
            dataGridCustomers.DataSource = source;
        }

    }
}
