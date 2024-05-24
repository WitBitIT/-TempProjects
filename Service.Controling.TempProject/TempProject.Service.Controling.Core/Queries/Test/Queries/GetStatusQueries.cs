using MediatR;
using TempProject.Service.Controling.Core.Model.Test;

namespace TempProject.Service.Controling.Application.Command.Test.Queries
{
    public class GetStatusQueries : IRequest<IEnumerable<StatusResponse>>
    {
    }
}
