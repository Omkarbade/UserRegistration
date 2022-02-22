using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class UserException : Exception
    {
        //Exception types
        public enum ExceptionType
        {
            INVALID_FIRSTNAME,
            INVALID_LASTNAME,
            INVALID_EMAILID,
            INVALID_PASSWORD,
            INVALID_MOBILENO
        }
        private ExceptionType type;
        //Constructor to initialize types
        public UserException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
