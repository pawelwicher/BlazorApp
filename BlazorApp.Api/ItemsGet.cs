using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace BlazorApp.Api
{
    public static class ItemsGet
    {
        [FunctionName(nameof(ItemsGet))]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "items")] HttpRequest req,
            ILogger log)
        {
            var items = await Task.FromResult(Domain.Data.Items);

            return new OkObjectResult(items);
        }
    }
}
