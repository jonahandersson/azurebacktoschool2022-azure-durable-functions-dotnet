using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace MessageSenderService.AzureFunctions
{
    public class ServiceBusTriggerFunction
    {
        [FunctionName("ServiceBusTrigger")]
        public void Run([ServiceBusTrigger("azurebacktoschoolqueue", Connection = "AzureServiceBusConnectionString")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
