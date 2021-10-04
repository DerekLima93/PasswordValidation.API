using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.Domain.Interface
{
    public interface IValidator
    {
        bool ValidateCount(string password);
        bool ValidateDigit(string password);
        bool ValidateLower(string password);
        bool ValidateUpper(string password);
        bool ValidateSpecial(string password);
        bool ValidateRepeated(string password);
    }
}
