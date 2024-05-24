using TempProject.Service.Controling.Core.Model;
using TempProject.Service.Controling.Core.Model.Test;
using TempProject.Service.Controling.Core.Repository.Interface;
using TempProject.Service.Controling.Infrastructure.DataBase.Server;
using TempProject.Service.Controling.Infrastructure.DataBase.Server.Table;

namespace TempProject.Service.Controling.Core.Repository.Repository
{
    public class RepositoryTest : IRepositoryTest
    {
        private readonly TestProjectContext _context;

        public RepositoryTest(TestProjectContext context)
        {
            _context = context;
        }

        public Task<ConnectResponse> addStatus(StatusRequest request)
        {
            try
            {
                if (!string.IsNullOrEmpty(request.Name) &&
                    !string.IsNullOrEmpty(request.Description))
                {
                    Status status = new Status
                    {
                        Name = request.Name,
                        Description = request.Description
                    };

                    _context.Statuses.Add(status);
                    _context.SaveChanges();

                    return Task.FromResult(new ConnectResponse(1));
                }
                return Task.FromResult(new ConnectResponse(0));
            }
            catch (Exception e)
            {
                return Task.FromResult(new ConnectResponse(2));
            }
        }

        public Task<IEnumerable<StatusResponse>> GetStatus()
        {
            IEnumerable<StatusResponse> result = _context.Statuses
                .Select(
                s => new StatusResponse
                {
                    Id = s.IdStatus,
                    Name = s.Name,
                    Description = s.Description
                }).ToList();

            return Task.FromResult(result);
        }
    }
}
