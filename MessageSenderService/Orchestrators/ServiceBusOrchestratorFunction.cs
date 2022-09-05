using Microsoft.Azure.WebJobs;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;
using System;

namespace MessageSenderService.DurableFunctions.Orchestrators
{

    //TODO - Use fan out fan in pattern
    public static class ServiceBusOrchestratorFunction
    {
        [FunctionName("ServiceBusQueueOrchestrator")]
        public static async Task<string> RunOrchestrator([OrchestrationTrigger] IDurableOrchestrationContext context, ILogger logger)
        {

            try
            {
                var serviceBusQueueMessage = context.GetInput<string>();

                if (serviceBusQueueMessage != null)
                {
                    // Call the activity function and pass queue message
                  await context.CallActivityAsync<bool>("SendEmail", serviceBusQueueMessage);

                }              
                return $"Done with the orchestration with Durable Context Id:  {context.InstanceId}";
            }
            catch (Exception ex)
            {
                //TODO Handle possible errors and do a retry if needed or retry a function
                logger.LogError($"Something went wrong " + ex.Message);
                throw;
            }
        
        }

    }
}
