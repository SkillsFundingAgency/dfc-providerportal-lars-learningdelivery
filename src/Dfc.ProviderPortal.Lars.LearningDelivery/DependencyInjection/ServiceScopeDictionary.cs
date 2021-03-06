﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Dfc.ProviderPortal.Lars.LearningDelivery.DependencyInjection
{
    internal static class ServiceScopeDictionary
    {
        private static readonly ConcurrentDictionary<Guid, IServiceScope> _scopes = new ConcurrentDictionary<Guid, IServiceScope>();

        public static IServiceScope GetOrAdd(Guid key, Func<Guid, IServiceScope> valueFactory)
        {
            return _scopes.GetOrAdd(key, valueFactory);
        }

        public static bool TryRemove(Guid key, out IServiceScope value)
        {
            return _scopes.TryRemove(key, out value);
        }
    }
}
