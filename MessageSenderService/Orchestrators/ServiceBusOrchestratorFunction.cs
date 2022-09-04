using Microsoft.Azure.WebJobs;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;


namespace MessageSenderService.DurableFunctions.Orchestrators
{

    //TODO - Use fan out fan in pattern
    public static class ServiceBusOrchestratorFunction
    {
        [FunctionName("ServiceBusQueueOrchestator")]
        public static async Task<List<string>> RunOrchestrator(
          [OrchestrationTrigger] IDurableOrchestrationContext context)
        {
            var resultOutputLogs = new List<string>();
            var serviceBusQueueMessage = context.GetInput<string>();

            // Call the activity function and pass queue message
            resultOutputLogs.Add(await context.CallActivityAsync<string>("SendEmail", serviceBusQueueMessage));
          
            //Return output for logs 
            return resultOutputLogs;
        }

    }
}
