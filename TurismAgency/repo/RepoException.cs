using System;

namespace WindowsFormsApp3.repo
{
    public class RepoException : ApplicationException
    {
        public RepoException(string message)
            : base(message) { }
    }
}
