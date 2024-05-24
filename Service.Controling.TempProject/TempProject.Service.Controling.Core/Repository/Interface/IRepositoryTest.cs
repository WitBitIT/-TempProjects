using TempProject.Service.Controling.Core.Model.Test;

namespace TempProject.Service.Controling.Core.Repository.Interface
{
    public interface IRepositoryTest
    {

        public Task<StatusResponse> GetStatus();
    }
}
