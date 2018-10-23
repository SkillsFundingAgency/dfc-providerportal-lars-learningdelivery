namespace Dfc.ProviderPortal.Lars.LearningDelivery.Services
{
    public class Formatter : IFormatter
    {
        public string Format(string v)
        {
            return $"--{v}--";
        }
    }
}
