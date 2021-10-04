using PV.Domain.Interface;

namespace PV.Domain
{
    public class Repository : IRepository
    {
        private readonly IValidator _validator;
        public Repository(IValidator validator)
        {
            _validator = validator;
        }

        public bool Validation(string password)
        {
            bool state = true;

            state = _validator.ValidateCount(password);
            if (!state) return false;

            state = _validator.ValidateDigit(password);
            if (!state) return false;

            state = _validator.ValidateLower(password);
            if (!state) return false;

            state = _validator.ValidateRepeated(password);
            if (!state) return false;

            state = _validator.ValidateSpecial(password);
            if (!state) return false;

            state = _validator.ValidateUpper(password);
            if (!state) return false;


            return true;
        }
    }
}