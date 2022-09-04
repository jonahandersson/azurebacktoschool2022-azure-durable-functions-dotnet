using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace MessageSenderService.DurableFunctions.Activities
{
    public static class SendEmailActivity
    {
        [FunctionName("SendEmail")]
        public static string SendEmail([ActivityTrigger] string serviceBusQueueMessage, ILogger log)
        {
         

            try
            {
                log.LogInformation($"SendEmailActivity trigged from the durable orchestratoion");

                if (serviceBusQueueMessage != null)
                {
                    log.LogInformation($"Sending email to recipient with queue message: {serviceBusQueueMessage}.");
                    var result = SendEmailAsync(serviceBusQueueMessage);
                }

             


              
                log.LogInformation($"Sending email with message: {serviceBusQueueMessage}");
                return $"Email sent!";
            }
            catch (Exception)
            {
                //TODO Error handling here
                throw;
            }
           
        }

        private async Task<bool> SendEmailAsync(string serviceBusQueueMessage)
        {
            var apiKey = Environment.GetEnvironmentVariable("SendGrid_API_KEY");
            var adminEmailAddress = Environment.GetEnvironmentVariable("AdminEmailAddress");
            var recipientEmailAddress = Environment.GetEnvironmentVariable("RecipientEmailAddress");

            var client = new SendGridClient(apiKey);
            var emailMessage = new SendGridMessage()
            {
                From = new EmailAddress(adminEmailAddress, "Jonah Andersson"),
                Subject = "Email from Service Bus Receive Function for Azure Back to School 2022!",
                PlainTextContent = myQueueMessageItem
            };

            emailMessage.AddTo(new EmailAddress(recipientEmailAddress, "Jonah at Work Email"));
            var response = await client.SendEmailAsync(emailMessage);

            // A success status code means SendGrid received the email request and will process it.
            // Errors can still occur when SendGrid tries to send the email. 
            // If email is not received, use this URL to debug: https://app.sendgrid.com/email_activity 
            Console.WriteLine(response.IsSuccessStatusCode ? "Email queued successfully!" : "Something went wrong!");
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
