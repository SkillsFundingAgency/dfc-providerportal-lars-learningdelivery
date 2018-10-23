using System.Collections.Generic;

namespace Dfc.ProviderPortal.Lars.LearningDelivery.Logging.ApplicationInsights
{
    public static class DictionaryExtensions
    {
        public static TValue GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key) => 
            dictionary.TryGetValue(key, out var ret) ? ret : default(TValue);
    }
}
