using System.Text;
using System.Text.RegularExpressions;

namespace WindowsFormsApp3.domain
{
    public class ReservationValidator: IValidator<Reservation>
    {
        public bool TelephoneValidator(string email)
        {
            Regex validateEmailRegex = new Regex("^[0-9]{10}$");
            return validateEmailRegex.IsMatch(email);
        }
         public void validate(Reservation elem)
        {
            StringBuilder errorString = new StringBuilder();

            if (elem.Tickets < 1)
                errorString.Append("Tickets must be greater than 0\n");
            if (!TelephoneValidator(elem.Telephone))
                errorString.Append("Telephone number must be a 10 digit string\n");

            if (errorString.Length != 0)
                throw new ValidationException(errorString.ToString());
        }
    }
}