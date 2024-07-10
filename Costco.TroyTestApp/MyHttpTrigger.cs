using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;

namespace Costco.TroyTestApp;

public class MyHttpTrigger
{
    [Function("HelloWorld")]
    public string HelloWorld(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = "helloworld")] HttpRequestData request)
    {
        return "Hello World";
    }
}