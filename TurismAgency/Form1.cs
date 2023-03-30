using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp3.domain;
using WindowsFormsApp3.repo;
using WindowsFormsApp3.srv;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private readonly SrvReservation _r;
        private readonly SRVTrip _t;
        private string user;
        IDictionary<string, string> props = new SortedList<string, string>();

        public Form1(IDictionary<string, string> props, string user)
        {
            this.props = props;
            _r = new SrvReservation(props);
            _t = new SRVTrip(props);
            this.user = user;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            var l = new LogIn(props);
            l.ShowDialog();
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Trip t in _t.findAll())
            {
                var rowId = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[rowId];
                row.Cells["id"].Value = t.Id;
                row.Cells["objective"].Value = t.Objective;
                row.Cells["transportFirm"].Value = t.TransportFirm;
                row.Cells["leave"].Value = t.Leave;
                row.Cells["availableTickets"].Value = t.AvailableSeats;
                row.Cells["price"].Value = t.Price;
            }

            foreach (DataGridViewRow r in dataGridView1.Rows)
                if (Convert.ToInt32(r.Cells["availableTickets"].Value) == 0)
                    r.DefaultCellStyle.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(leave1.Text) &&  !string.IsNullOrEmpty(leave1.Text))
            {
                try
                {
                    if (int.Parse(leave1.Text) > int.Parse(leave2.Text))
                    {
                        MessageBox.Show("first value of leave must be lesser than the second");
                    }
                    else
                    {
                    dataGridView2.Rows.Clear();
                        foreach (Trip t in _t.findByObjective(textBox1.Text, int.Parse(leave1.Text), int.Parse(leave2.Text)))
                        {
            
                            var rowId = dataGridView2.Rows.Add();
                            var row = dataGridView2.Rows[rowId];
                            row.Cells["Column1"].Value = t.Objective;
                            row.Cells["Column2"].Value = t.TransportFirm;
                            row.Cells["Column3"].Value = t.Leave;
                            row.Cells["Column4"].Value = t.AvailableSeats;
                            row.Cells["Column5"].Value = t.Price;
                        }
              
                    }
                }
                catch(FormatException formatException)
                {
                    MessageBox.Show("Please provide the proper data types");
                }
                
            }
            else
            {
                MessageBox.Show("Please provide all required data");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Client.Text) &&  !string.IsNullOrEmpty(telephone.Text) &&  !string.IsNullOrEmpty(trip.Text) &&  !string.IsNullOrEmpty(tickets.Text)){

                try
                {
                    var r = new Reservation(Client.Text, telephone.Text, int.Parse(tickets.Text),
                        int.Parse(trip.Text),user);
                    
                    var findOne = _t.findOne(r.Trip);
                    findOne.AvailableSeats -= r.Tickets;
                    if (findOne.AvailableSeats >= 0)
                    {
                            _r.addReservation(r);
                            _t.updateTrip(r.Trip, findOne);
                            MessageBox.Show("Trip booked!");
                            dataGridView1.Rows.Clear();
                            foreach (Trip t in _t.findAll())
                            {
                                var rowId = dataGridView1.Rows.Add();
                                var row = dataGridView1.Rows[rowId];
                                row.Cells["id"].Value = t.Id;
                                row.Cells["objective"].Value = t.Objective;
                                row.Cells["transportFirm"].Value = t.TransportFirm;
                                row.Cells["leave"].Value = t.Leave;
                                row.Cells["availableTickets"].Value = t.AvailableSeats;
                                row.Cells["price"].Value = t.Price;
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                                if (Convert.ToInt32(row.Cells["availableTickets"].Value) == 0)
                                    row.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        MessageBox.Show("There are not enough available tickets");
                    }
                }
                catch (FormatException formatException)
                {
                    MessageBox.Show("Please provide the proper data types\n Client is a string\n,Telephone Trip and Tickets are numbers\n");
                }
                catch (ValidationException exception)
                {
                    MessageBox.Show(exception.Message);
                }
                catch (RepoException repoException)
                {
                    MessageBox.Show(repoException.Message);
                }
            }
            else
            {
                MessageBox.Show("Please provide all required data");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            var l = new Bookings(props,user);
            l.ShowDialog();
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}