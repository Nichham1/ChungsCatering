using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChungsCatering
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderForm order = new OrderForm();
            order.MdiParent = this;
            order.Show();

        }

        private void AdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void Reservation_Click(object sender, EventArgs e)
        {
            ReservationForm reservation = new ReservationForm();
            reservation.MdiParent = this;
            reservation.Show();
        }
    }
}
