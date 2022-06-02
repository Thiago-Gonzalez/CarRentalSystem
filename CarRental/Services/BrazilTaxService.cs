

namespace CarRentalSystem.Services
{
    internal class BrazilTaxService : ITaxService // subtipo do ITaxService (Interface)
    {
        public double Tax(double amount)
        {
            if (amount <= 100.00)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
