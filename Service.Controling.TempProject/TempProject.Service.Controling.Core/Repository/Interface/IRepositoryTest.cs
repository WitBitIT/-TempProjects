using TempProject.Service.Controling.Core.Model;
using TempProject.Service.Controling.Core.Model.Test;

namespace TempProject.Service.Controling.Core.Repository.Interface
{
    public interface IRepositoryTest
    {
        public Task<ConnectResponse> addStatus(StatusRequest request);
        public Task<IEnumerable<StatusResponse>> GetStatus();
    }
}
