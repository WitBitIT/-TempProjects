using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TempProject.Service.Controling.Application.Command.Test.Queries;
using TempProject.Service.Controling.Core.Model.Test;
using TempProject.Service.Controling.Core.Repository.Interface;

namespace TempProject.Service.Controling.Core.Queries.Test.Handlers
{
    public class GetStatusHandler : IRequestHandler<GetStatusQueries, StatusResponse>
    {
        private readonly IRepositoryTest _repository;

        public GetStatusHandler(IRepositoryTest repository)
        {
            _repository = repository;
        }

        public async Task<StatusResponse> Handle(GetStatusQueries request, CancellationToken cancellationToken)
        {
            return await _repository.GetStatus();
        }
    }
}
