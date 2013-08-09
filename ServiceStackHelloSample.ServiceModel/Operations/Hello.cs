using System.Runtime.Serialization;
using ServiceStack.ServiceHost;

namespace ServiceStackHelloSample.ServiceModel.Operations
{
    /// <summary>
    /// Request DTO
    /// </summary>
    [Route("/hello")]
    [Route("/hello/{name]")]
    [DataContract(Namespace = HelloConfig.DefaultNamespace)]
    public class Hello : IReturn<HelloResponse>
    {
        [DataMember]
        public string Name { get; set; }
    }

    /// <summary>
    /// Response DTO
    /// </summary>
    [DataContract(Namespace = HelloConfig.DefaultNamespace)]
    public class HelloResponse
    {
        [DataMember]
        public string Result { get; set; }
    }
}
