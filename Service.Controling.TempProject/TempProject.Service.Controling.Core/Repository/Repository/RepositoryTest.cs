using TempProject.Service.Controling.Core.Model.Test;
using TempProject.Service.Controling.Core.Repository.Interface;

namespace TempProject.Service.Controling.Core.Repository.Repository
{
    public class RepositoryTest : IRepositoryTest
    {
        public Task<StatusResponse> GetStatus()
        {
            throw new NotImplementedException();
        }
    }
}
