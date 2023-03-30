namespace WindowsFormsApp3.domain
{
    public class Reservation : Entity<long>
    {
        public Reservation(string client, string telephone, int tickets, int trip, string agent)
        {
            Client = client;
            Telephone = telephone;
            Tickets = tickets;
            Trip = trip;
            Agent = agent;
        }

        public string Client { get; set; }

        public string Telephone { get; set; }

        public int Tickets { get; set; }

        public int Trip { get; set; }
        public string Agent { get; set; }
    }
}