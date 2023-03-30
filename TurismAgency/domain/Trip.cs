using System;

namespace WindowsFormsApp3.domain
{
    public class Trip : Entity<long>
    {
        private int _availableSeats;
        private int _leave;
        private string _objective;
        private int _price;
        private string _transportFirm;

        public Trip(string objective, string transportFirm, int leave, int price, int availableSeats)
        {
            _objective = objective;
            _transportFirm = transportFirm;
            _leave = leave;
            _price = price;
            _availableSeats = availableSeats;
        }

        public string Objective
        {
            get => _objective;
            set => _objective = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string TransportFirm
        {
            get => _transportFirm;
            set => _transportFirm = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int Leave
        {
            get => _leave;
            set => _leave = value;
        }

        public int Price
        {
            get => _price;
            set => _price = value;
        }

        public int AvailableSeats
        {
            get => _availableSeats;
            set => _availableSeats = value;
        }

        public override string ToString()
        {
            return
                $"{nameof(_objective)}: {_objective}, {nameof(_transportFirm)}: {_transportFirm}, {nameof(_leave)}: {_leave}, {nameof(_availableSeats)}: {_availableSeats},{nameof(_price)}: {_price}";
        }
    }
}