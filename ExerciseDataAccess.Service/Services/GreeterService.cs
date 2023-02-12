using ExerciseDataAccess.Service;
using ExerciseDataAccess.Service.Contracts;
using Grpc.Core;

namespace ExerciseDataAccess.Service.Services
{
    public class GreeterService : IGreeterService
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public Task<HelloResponse> SayHelloAsync(Contracts.HelloRequest request)
        {
            return Task.FromResult(new HelloResponse
            {
                Message = "Hello " + request.Name
            });
        }
    }
}