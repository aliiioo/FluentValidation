using FluentValidationing.Data;


namespace FluentValidationing.Services
{
    public class StuentServices
    {
        private readonly FluentValdatetionContext _context;
        public StuentServices(FluentValdatetionContext fluentValdatetionContext)
        {
            _context = fluentValdatetionContext;
        }

        public bool IsExistEmail(string? Email)
        {
            // contect get Emailof Student
            return true;
        }
    }
}
