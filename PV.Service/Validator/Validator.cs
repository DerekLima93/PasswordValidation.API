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
            return password.Length > 8;
        }

        public bool ValidateDigit(string password)
        {
            return password.ToCharArray().Where(x => Char.IsDigit(x)).Count() > 0;
        }

        public bool ValidateLower(string password)
        {
            return password.ToCharArray().Where(x => Char.IsLower(x)).Count() > 0;
        }

        public bool ValidateRepeated(string password)
        {
            var repeatedChars = password.ToCharArray().GroupBy(x => x).Where(y => y.Count() > 1);

            return repeatedChars.Count() <= 0;
        }

        public bool ValidateSpecial(string password)
        {
            string pattern = @"^(?=.*[!@#$%^&()-+])";
            Regex expression = new(pattern);

            return expression.Match(password).Success;
        }

        public bool ValidateUpper(string password)
        {
            return password.ToCharArray().Where(x => Char.IsUpper(x)).Count() > 0;
        }
    }
}