using MediatR;
using Microsoft.AspNetCore.Mvc;
using TempProject.Service.Controling.Application.Command.Test.Queries;
using TempProject.Service.Controling.Core.Model;
using TempProject.Service.Controling.Core.Model.Test;

namespace Temp.Service.Controling.APi.Controlers
{
    [Route("api/test")]
    [ApiController]
    public class TestContener : ControllerBase
    {

        private readonly IMediator _mediator;

        public TestContener(IMediator mediator)
        {
            _mediator = mediator;
        }

        #region GET
        [HttpGet()]
        public ActionResult<IEnumerable<StatusResponse>> GetStatus()
        {
            try
            {
                return Ok(_mediator.Send(new GetStatusQueries()).Result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        #endregion

        #region POST

        [HttpPost()]
        public ActionResult<ConnectResponse> PostStatus([FromBody] StatusRequest status)
        {
            try
            {
                return Ok(_mediator.Send(new StatusRequestQueries() { request = status}).Result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion

        #region PUT
        #endregion

        #region DELETE

        #endregion
    }
}
