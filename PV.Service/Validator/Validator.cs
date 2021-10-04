using PV.Domain.Interface;
using System;
using System.Linq;

using System.Text.RegularExpressions;


namespace PV.Domain
{
    public class Validator : IValidator
    {
        public bool ValidateCount(string password)
        {
            if (password.Length <= 8)
            {
                return false;
            }

            return true;
        }

        public bool ValidateDigit(string password)
        {
            if (password.ToCharArray().Where(x => Char.IsDigit(x)).Count() <= 0)
            {
                return false;
            }

            return true;
        }

        public bool ValidateLower(string password)
        {
            if (password.ToCharArray().Where(x => Char.IsLower(x)).Count() <= 0)
            {
                return false;
            }

            return true;
        }

        public bool ValidateRepeated(string password)
        {
            var repeatedChars = password.ToCharArray().GroupBy(x => x).Where(y => y.Count() > 1);

            if (repeatedChars.Count() > 0)
            {
                return false;
            }

            return true;
        }

        public bool ValidateSpecial(string password)
        {
            string pattern = @"^(?=.*[!@#$%^&()-+])";
            Regex expression = new(pattern);

            if (!expression.Match(password).Success)
            {
                return false;
            }

            return true;
        }

        public bool ValidateUpper(string password)
        {
            if (password.ToCharArray().Where(x => Char.IsUpper(x)).Count() <= 0)
            {
                return false;
            }

            return true;
        }
    }
}