using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Microsoft.ApplicationInsights.Extensibility.Implementation.ApplicationId;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Configuration;
using Microsoft.Extensions.Options;

namespace Dfc.ProviderPortal.Lars.LearningDelivery.Logging.ApplicationInsights
{
    public static class ApplicationInsightsWebJobsBuilderExtensions
    {
        public static IWebJobsBuilder AddApplicationInsights2(this IWebJobsBuilder builder)
        {
            //if (!IsApplicationInsightsAdded(builder.Services))
            //{
            //    builder.Services.AddSingleton(new TelemetryClient());
            //    builder.Services.AddSingleton<ILogger, ApplicationInsightsLogger>();
            //    builder.Services.AddSingleton<ILoggerProvider, ApplicationInsightsLoggerProvider>();

            //    ILoggerFactory loggerFactory = new LoggerFactory();
            //    loggerFactory.AddProvider(new ApplicationInsightsLoggerProvider(new TelemetryClient()));
            //}

            return builder;
        }

        //private static bool IsApplicationInsightsAdded(IServiceCollection services)
        //{
        //    return services.Any(service => service.ImplementationType == typeof(ApplicationInsightsLogger));
        //}
    }
}
