namespace Dfc.ProviderPortal.Lars.LearningDelivery.Services
{
    public class Greeter : IGreeter
    {
        private readonly IFormatter _formatter;

        public Greeter(IFormatter formatter)
        {
            _formatter = formatter;
        }

        public string Greet()
        {
            return _formatter.Format("Greetings!");
        }
    }
}
