using ProtoBuf.Grpc;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace ExerciseDataAccess.Service.Contracts
{
    [DataContract]
    public class HelloRequest
    {
        [DataMember(Order =1)]
        public string Name { get; set; }
    }
    [DataContract]
    public class HelloResponse
    {
        [DataMember(Order =1)]
        public string Message { get; set; }
    }

    [ServiceContract]
    public interface IGreeterService
    {
        [OperationContract]
        public Task<HelloResponse> SayHelloAsync(HelloRequest request);
    }
}
