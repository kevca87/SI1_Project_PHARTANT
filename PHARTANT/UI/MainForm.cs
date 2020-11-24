using PHARTANT.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHARTANT
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalesHistory_Click(object sender, EventArgs e)
        {
            SaleUI s = new SaleUI();
            s.Show();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            ReservationForm r = new ReservationForm();
            r.Show();
        }
    }
}
