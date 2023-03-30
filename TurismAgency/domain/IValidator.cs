using System;

namespace WindowsFormsApp3.domain
{
    public interface IValidator<T>
    {
        void validate(T elem);
    }

    public class ValidationException : ApplicationException
    {
        public ValidationException(string message)
            : base(message) { }
    }
}
