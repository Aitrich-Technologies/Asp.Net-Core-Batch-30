using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EmailValidation.Exception;

namespace EmailValidation
{
    internal class EmailValidator
    {
        public static void ValidateEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, pattern))
            {
                throw new InvalidEmailException($"Invalid Email Address: {email}");
            }
        }
    }
}
