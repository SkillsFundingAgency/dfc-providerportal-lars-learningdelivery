using Dfc.ProviderPortal.Lars.LearningDelivery;
using Dfc.ProviderPortal.Lars.LearningDelivery.DependencyInjection;
using Dfc.ProviderPortal.Lars.LearningDelivery.Logging.ApplicationInsights;
using Dfc.ProviderPortal.Lars.LearningDelivery.Services;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

[assembly: WebJobsStartup(typeof(WebJobsExtensionStartup), "A Web Jobs Extension Startup for Dfc.ProviderPortal.Lars.LearningDelivery")]
namespace Dfc.ProviderPortal.Lars.LearningDelivery
{
    public class WebJobsExtensionStartup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            builder.AddDependencyInjection();
            builder.AddApplicationInsights2();
            //builder.Services.AddApplicationInsightsTelemetry();
            //ILoggerFactory loggerFactory = new LoggerFactory();
            //loggerFactory.AddApplicationInsights(builder.Services.BuildServiceProvider(), LogLevel.Information);

            builder.Services.AddScoped<IGreeter, Greeter>();
            builder.Services.AddScoped<IFormatter, Formatter>();
        }
    }
}
