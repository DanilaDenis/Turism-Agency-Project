using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp3.domain;
using WindowsFormsApp3.srv;

namespace WindowsFormsApp3
{
    public partial class Bookings : Form
    {
        IDictionary<string, string> props = new SortedList<string, string>();

        private string user;
        private SrvReservation _r;
        public Bookings(IDictionary<string, string> props,string user)
        {
            this.props = props;
            _r = new SrvReservation(props);
            InitializeComponent();
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            var l = new Form1(props,user);
            l.ShowDialog();
            Close();
        }

        private void Reservations_Load(object sender, EventArgs e)
        {
            foreach (Reservation reservation in _r.findAllFromAgent(user))
            {
                var rowId = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[rowId];
                row.Cells["client"].Value = reservation.Client;
                row.Cells["telephone"].Value = reservation.Telephone;
                row.Cells["tickets"].Value = reservation.Tickets;
                row.Cells["trip"].Value = reservation.Trip;
            }
        }
    }
}