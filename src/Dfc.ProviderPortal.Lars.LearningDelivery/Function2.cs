using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Dfc.ProviderPortal.Lars.LearningDelivery
{
    public static class Function2
    {
        [FunctionName("Function2")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "function2/{someId}")] HttpRequest req,
            ILogger log,
            string someId)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            return someId != null
                ? (ActionResult)new OkObjectResult($"Hello, {someId}")
                : new BadRequestObjectResult($"Please pass a /{nameof(someId)}");
        }
    }
}
