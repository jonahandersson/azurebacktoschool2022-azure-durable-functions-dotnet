using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.IO;
using Microsoft.Azure;

namespace MessageSenderService.DurableFunctions.ClientFunctions
{
    public static class ServiceBusQueueTrigger
    {
        [FunctionName("ServiceBusQueueTrigger")]
        public static async Task ServiceBusTriggerFunction(
            [ServiceBusTrigger("azurebacktoschoolqueue", Connection = "AzureServiceBusConnectionString")]
            string myServiceBusQueueItem, [DurableClient] IDurableOrchestrationClient starter, ILogger log)
        {

            try
            {
                log.LogInformation($"C# ServiceBus queue trigger function processed message: {myServiceBusQueueItem}");

                // When the service bus is triggered by a new queue message it initiates the orchestrator 
                string orchestrationInstanceId = await starter.StartNewAsync("ServiceBusQueueOrchestrator", myServiceBusQueueItem);

                log.LogInformation($"Started orchestration with ID = '{orchestrationInstanceId}'.");
            }
            catch (Exception)
            {

                throw;
            }        
            
        }
    }

}
