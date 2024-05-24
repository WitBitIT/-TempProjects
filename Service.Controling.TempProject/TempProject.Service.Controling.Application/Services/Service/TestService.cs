using TempProject.Service.Controling.Application.Services.Interface;
using TempProject.Service.Controling.Core.Model;
using TempProject.Service.Controling.Core.Model.Test;

namespace TempProject.Service.Controling.Application.Services.Service
{
    public class TestService : ITestService
    {
        public Task<ConnectResponse> AddStatus(StatusRequest? request)
        {
            throw new NotImplementedException();
        }
    }
}
