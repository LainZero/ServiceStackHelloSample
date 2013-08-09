using ServiceStack.ServiceInterface;
using ServiceStackHelloSample.ServiceModel.Operations;

namespace ServiceStackHelloSample.Interface
{
    public class HelloService : Service
    {
        public HelloResponse Any(Hello request)
        {
            string name = request.Name ?? "lainzero";
            return new HelloResponse { Result = "Hello, " + name };
        }
    }
}
