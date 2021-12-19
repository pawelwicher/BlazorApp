using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using System.Threading.Tasks;

namespace BlazorApp.Api
{
    public static class ItemsGet
    {
        [Function("ItemsGet")]
        public static async Task<HttpResponseData> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "items")] HttpRequestData req,
            FunctionContext executionContext)
        {
            var response = req.CreateResponse(HttpStatusCode.OK);

            await response.WriteAsJsonAsync(BlazorApp.Domain.Data.Items);

            return response;
        }
    }
}
