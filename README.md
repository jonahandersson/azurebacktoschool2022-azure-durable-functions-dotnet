# Azure Durable Functions for .NET  Demo Example for Azure Back to School 2022

Relates to GitHub Repo and #AzureBacktoSchool2022 presentation <a href="https://github.com/jonahandersson/azurebacktoschool2022-azure-service-bus-dotnet" target="_blank">A Technical Overview of Azure Service Bus Example</a>

##### Example Code Demo
### Azure Back to School 2022 by <a href="https://linkedin.com/in/jonahandersson" target="_blank">Jonah Anderssson</a>

<p>This is an example demo code for Jonah's community contribution for <a href="https://azurebacktoschool.github.io/edge%20case/azure-back-to-school-2022-speakers/" target="_blank">Azure Back to School 2022</a> - Azure Durable Functions for .NET Developers by Jonah Andersson</p>

![alt text](https://jonahsstorage.blob.core.windows.net/jcaphotos/AzureDurableFunctions_AzureBacktoSchool2022_Cover.png)
#### Description:

.NET 6.0 example implementation of Azure Durable Functions in .NET 6 using Azure Service Bus Queue Trigger (Durable Functions with Function Chaining Pattern) that is used to receive or retrieve the batch of service bus queue messages. Each queue message received will then be forward by email using SendGrid API 

#### Example of Application Pattern - Function Chaining 

![alt text](https://jonahsstorage.blob.core.windows.net/jcaphotos/AzureDurableFunctions_FunctionChaininingDotNet.png) 

 Function Chaining (Start Template)  https://github.com/jonahandersson/serverlesslab-azure-durable-functionchaining-template
![image](https://user-images.githubusercontent.com/14919667/188448265-5ac63c28-3613-4208-ba9d-e37c90e8d6af.png)

#### Prerequisites:

- SendGrid API 
- Azure Subscription to create Azure Resources
- Azure Service Bus Namespace 
- Azure Service Bus Connection Strings/SAS
- Azure Service Bus Queue Name

#### Tools and Packages: 

- VS Code or Visual Studio Code
- SDK .NET for .NET 6
- C# Programming Language
- NuGet packages for Newtonsoft.Json, etc.
- Azure Service Bus 
- SendGrid 
- Azure Functions (Latest Version) 
- Azure Functions Core Tools 

#### Learning References:

- <a href="https://docs.microsoft.com/en-us/azure/azure-functions/durable/durable-functions-overview?tabs=csharp?WT.mc_id=AZ-MVP-5004251">Microsoft Documentation: Azure Durable Functions</a>
- <a href="https://docs.microsoft.com/en-us/azure/azure-functions/durable/durable-functions-dotnet-entities?WT.mc_id=AZ-MVP-5004251">Developer's guide to durable entities in .NET</a>
- <a href="https://docs.microsoft.com/en-us/azure/service-bus-messaging/service-bus-messaging-overview?WT.mc_id=AZ-MVP-5004251" target="_blank">What is Azure Service Bus</a>
- <a href="https://docs.microsoft.com/en-us/azure/service-bus-messaging/service-bus-samples">Service Bus messaging samples or example</a>
- <a href="https://docs.microsoft.com/en-us/azure/azure-functions/?WT.mc_id=AZ-MVP-5004251" target="_blank">Azure Functions Documentation</a>
- <a href="https://www.twilio.com/blog/send-emails-using-the-sendgrid-api-with-dotnetnet-6-and-csharp" target="_blank">How to send Emails with C# and .NET 6 using the SendGrid API</a>
- <a href="https://docs.sendgrid.com/for-developers/sending-email/api-getting-started" target="_blank">Getting Started with SendGrid API / Twilio</a>

#### Contact Author Jonah Andersson for contributions and collaborate to improve this example repo

- Twitter <a href="https://www.twitter.com/cjkodare" target="_blank">@cjkodare</a>
- LinkedIn <a href="https://www.linkedin.com/in/jonahandersson" target="_blank">Jonah Andersson</a>
- Website: https://jonahandersson.tech

