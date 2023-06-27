using System.Net;
using System.Net.Http;
using System.Text;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.Http;

using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.WebJobs.Extensions.Http;

namespace Company.Function
{
    public class GetResumeCounter
    {
        

        [FunctionName("GetResumeCounter")]
        public HttpResponseMessage Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestMessage req,
            [CosmosDB(databaseName:"azresumetal", collectionName:"Counter", ConnectionStringSetting="AzureResumeTALConnectString", Id = "1", PartitionKey = "1")] Counter counter,
            [CosmosDB(databaseName:"azresumetal", collectionName:"Counter", ConnectionStringSetting="AzureResumeTALConnectString", Id = "1", PartitionKey = "1")] out Counter updatedCounter,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            updatedCounter = counter;
            updatedCounter.Count += 1;

            var jsonToReturn = JsonConvert.SerializeObject(counter);

            return new HttpResponseMessage(System.Net.HttpStatusCode.OK){
                Content = new StringContent(jsonToReturn, Encoding.UTF8, "application/json")
            };
        }
    }
}
