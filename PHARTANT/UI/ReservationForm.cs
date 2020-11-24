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

namespace PHARTANT
{
    public partial class ReservationForm : Form
    {
        private SaleController _controller;
        public ReservationForm()
        {
            InitializeComponent();
            _controller = new SaleController();
        }
        public SaleController Controller
        {
            get
            {
                return _controller;
            }
        }
        private void ReservationForm_Load(object sender, EventArgs e)
        {
            SetSaleGrid();
        }
        private void SetSaleGrid()
        {
            dgvReservationHistory.AutoGenerateColumns = false;

            AddColumnsToSaleGrid();

            RebindReservationGrid();

        }
        private void AddColumnsToSaleGrid()
        {
            DataGridViewColumn dataGridViewColumn;

            dataGridViewColumn = new DataGridViewColumn();
            dataGridViewColumn.DataPropertyName = "id_sale";
            dataGridViewColumn.HeaderText = "ID";
            dataGridViewColumn.CellTemplate = new DataGridViewTextBoxCell();
            dataGridViewColumn.Name = "id_sale";
            dgvReservationHistory.Columns.Add(dataGridViewColumn);

            /* dataGridViewColumn = new DataGridViewColumn();
             dataGridViewColumn.DataPropertyName = "reservation_start_date";
             dataGridViewColumn.HeaderText = "reservationDate";
             dataGridViewColumn.CellTemplate = new DataGridViewTextBoxCell();
             dataGridViewColumn.Name = "reservation_start_date";
             dataGridViewColumn.ReadOnly = true;

             dgSale.Columns.Add(dataGridViewColumn);*/


            dataGridViewColumn = new DataGridViewColumn();
            dataGridViewColumn.DataPropertyName = "unit_price_sale";
            dataGridViewColumn.HeaderText = "unitPrice";
            dataGridViewColumn.CellTemplate = new DataGridViewTextBoxCell();
            dataGridViewColumn.Name = "unit_price_sale";
            dgvReservationHistory.Columns.Add(dataGridViewColumn);

            dataGridViewColumn = new DataGridViewColumn();
            dataGridViewColumn.DataPropertyName = "quantity_product";
            dataGridViewColumn.HeaderText = "quantity";
            dataGridViewColumn.CellTemplate = new DataGridViewTextBoxCell();
            dataGridViewColumn.Name = "quantity_product";
            dgvReservationHistory.Columns.Add(dataGridViewColumn);

            dataGridViewColumn = new DataGridViewColumn();
            dataGridViewColumn.DataPropertyName = "concrete_sale";
            dataGridViewColumn.HeaderText = "concrete_sale";
            dataGridViewColumn.CellTemplate = new DataGridViewTextBoxCell();
            dataGridViewColumn.Name = "concrete_sale";
            dgvReservationHistory.Columns.Add(dataGridViewColumn);

            dataGridViewColumn = new DataGridViewColumn();
            dataGridViewColumn.DataPropertyName = "sale_date_completed";
            dataGridViewColumn.HeaderText = "saleDate";
            dataGridViewColumn.CellTemplate = new DataGridViewTextBoxCell();
            dataGridViewColumn.Name = "sale_date_completed";
            dgvReservationHistory.Columns.Add(dataGridViewColumn);

            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.DataPropertyName = "Delete";
            deleteButton.Name = "dgSaleDeleteBtn";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            deleteButton.CellTemplate = new DataGridViewButtonCell();
            deleteButton.UseColumnTextForButtonValue = true;
            dgvReservationHistory.Columns.Add(deleteButton);
        }
        private void RebindReservationGrid()
        {
            var source = new BindingSource();
            var reservationList = Controller.Reservation;
            source.DataSource = reservationList;
            dgvReservationHistory.DataSource = source;
        }
        private void dgvReservationHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
