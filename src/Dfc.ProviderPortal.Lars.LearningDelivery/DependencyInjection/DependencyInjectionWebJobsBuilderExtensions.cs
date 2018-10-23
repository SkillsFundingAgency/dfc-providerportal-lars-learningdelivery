using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.DependencyInjection;

namespace Dfc.ProviderPortal.Lars.LearningDelivery.DependencyInjection
{
    public static class DependencyInjectionWebJobsBuilderExtensions
    {
        public static IWebJobsBuilder AddDependencyInjection(this IWebJobsBuilder builder)
        {
            builder.Services.AddSingleton<IInjectBindingProvider, InjectBindingProvider>();
            builder.AddExtension<InjectConfiguration>();

            return builder;
        }
    }
}
