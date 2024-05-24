using MediatR;
using TempProject.Service.Controling.Core.Model;
using TempProject.Service.Controling.Core.Model.Test;

namespace TempProject.Service.Controling.Application.Command.Test.Queries
{
    public class StatusRequestQueries : IRequest<ConnectResponse>
    { 
        public StatusRequest? request;
    }
}
