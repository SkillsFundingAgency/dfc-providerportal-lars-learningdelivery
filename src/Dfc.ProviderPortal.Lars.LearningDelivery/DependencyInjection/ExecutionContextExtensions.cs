using Microsoft.Azure.WebJobs;

namespace Dfc.ProviderPortal.Lars.LearningDelivery.DependencyInjection
{
    public static class ExecutionContextExtensions
    {
        public static void CleanUpDependencies(this ExecutionContext executionContext)
        {
            if (ServiceScopeDictionary.TryRemove(executionContext.InvocationId, out var scope))
            {
                scope.Dispose();
            }
        }
    }
}
