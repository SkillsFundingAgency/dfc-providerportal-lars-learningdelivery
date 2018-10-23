using Microsoft.Azure.WebJobs.Host.Config;

namespace Dfc.ProviderPortal.Lars.LearningDelivery.DependencyInjection
{
    internal class InjectConfiguration : IExtensionConfigProvider
    {
        private readonly IInjectBindingProvider _injectBindingProvider;

        public InjectConfiguration(IInjectBindingProvider injectBindingProvider)
        {
            _injectBindingProvider = injectBindingProvider;
        }

        public void Initialize(ExtensionConfigContext context)
        {
            context
                .AddBindingRule<InjectAttribute>()
                .Bind(_injectBindingProvider);
        }
    }
}
