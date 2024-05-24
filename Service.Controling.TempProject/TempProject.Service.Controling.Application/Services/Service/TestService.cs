using TempProject.Service.Controling.Application.Services.Interface;
using TempProject.Service.Controling.Core.Model;
using TempProject.Service.Controling.Core.Model.Test;
using TempProject.Service.Controling.Core.Repository.Interface;

namespace TempProject.Service.Controling.Application.Services.Service
{
    public class TestService : ITestService
    {
        private readonly IRepositoryTest _repository;

        public TestService(IRepositoryTest repository)
        {
            _repository = repository;
        }
        public async Task<ConnectResponse> AddStatus(StatusRequest? request)
        {
            if (request != null)
            {
                return await _repository.addStatus(request);
            }
            else
                return await Task.FromResult(new ConnectResponse(0));
        }
    }
}
