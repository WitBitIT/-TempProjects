using MediatR;
using TempProject.Service.Controling.Application.Command.Test.Queries;
using TempProject.Service.Controling.Core.Model.Test;
using TempProject.Service.Controling.Core.Repository.Interface;

namespace TempProject.Service.Controling.Core.Queries.Test.Handlers
{
    public class GetStatusHandler : IRequestHandler<GetStatusQueries, IEnumerable<StatusResponse>>
    {
        private readonly IRepositoryTest _repository;

        public GetStatusHandler(IRepositoryTest repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<StatusResponse>> Handle(GetStatusQueries request, CancellationToken cancellationToken)
        {
            return await _repository.GetStatus();
        }
    }
}
