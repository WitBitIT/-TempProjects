using TempProject.Service.Controling.Core.Model;
using TempProject.Service.Controling.Core.Model.Test;

namespace TempProject.Service.Controling.Application.Services.Interface
{
    public interface ITestService
    {
      public Task<ConnectResponse> AddStatus(StatusRequest? request);
    }
}
