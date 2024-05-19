namespace SOAP.Services
{
    public class MassCalculatorService : IMassCalculatorService
    {
        public double CalculateGravityForce(double mass)
        {
            if (mass <= 0)
            {
                throw new ArgumentException("Mass can not be negative");
            }

            return mass * 9.81;
        }
    }
}
