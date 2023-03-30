using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WindowsFormsApp3.domain
{

    public class AgentValidator : IValidator<Agent>
    {
        public bool EmailValidator(string email)
        {
            Regex validateEmailRegex = new Regex("^\\S+@\\S+\\.\\S+$");
            return validateEmailRegex.IsMatch(email);
        }
        public void validate(Agent elem)
        {
            StringBuilder errorString = new StringBuilder();

            if (elem.Name == "")
                errorString.Append("Name can not be void\n");
            if (!EmailValidator(elem.Email))
                errorString.Append("Email is in the wrong format. Must be: username@domain.com\n");
            if (elem.Agency == "")
                errorString.Append("Agency can not be void\n");
            if (elem.Password.Length < 8)
                errorString.Append("Password must be at least 8 characters\n");

            if (errorString.Length != 0)
                throw new ValidationException(errorString.ToString());
        }
    }
}
