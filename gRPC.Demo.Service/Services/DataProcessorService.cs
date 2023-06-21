using Grpc.Core;

namespace gRPC.Demo.Service.Services
{
    public class DataProcessorService : DataProcessor.DataProcessorBase
    {
        private readonly ILogger<DataProcessorService> _logger;
        public DataProcessorService(ILogger<DataProcessorService> logger)
        {
            _logger = logger;
        }

        public override Task<RegistrationReply> ProcessRegistration(RegistrationRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Successfully made a request to register an account!");
            return Task.FromResult(new RegistrationReply
            {
                EmployerId = 1, BusinessName = request.BusinessName, IsActive = request.IsActive, IsRegistrationComplete = true
            });
        }
    }
}
