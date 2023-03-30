using System;

namespace WindowsFormsApp3.domain
{
    public class Agent : Entity<long>
    {
        private string _agency;
        private string _email;
        private string _name;
        private string _password;

        public Agent(string name, string password, string email, string agency)
        {
            _name = name;
            _password = password;
            _email = email;
            _agency = agency;
        }

        public string Name
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Password
        {
            get => _password;
            set => _password = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Email
        {
            get => _email;
            set => _email = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Agency
        {
            get => _agency;
            set => _agency = value ?? throw new ArgumentNullException(nameof(value));
        }

        public override string ToString()
        {
            return
                $"{nameof(_name)}: {_name}, {nameof(_password)}: {_password}, {nameof(_email)}: {_email}, {nameof(_agency)}: {_agency}";
        }
    }
}