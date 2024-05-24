using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TempProject.Service.Controling.Application.Command.Test.Queries;
using TempProject.Service.Controling.Application.Services.Interface;
using TempProject.Service.Controling.Core.Model;

namespace TempProject.Service.Controling.Application.Command.Test.Handlers
{
    internal class StatusQequestHandler : IRequestHandler<StatusRequestQueries, ConnectResponse>
    {
        private readonly ITestService _service;

        public StatusQequestHandler(ITestService service)
        {
            _service = service;
        }

        public async Task<ConnectResponse> Handle(StatusRequestQueries request, CancellationToken cancellationToken)
        {
            return await _service.AddStatus(request.request);
        }
    }
}
