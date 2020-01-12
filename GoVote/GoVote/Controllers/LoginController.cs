using System.Threading.Tasks;
using GoVote.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using GoVote.DTO;

namespace GoVote.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LoginController(IMediator mediator)
        {
            _mediator = mediator;
        }


        /*[HttpPost]
        public async Task<ActionResult<Citizen>> Login([FromBody]CNPContainer container)
        {
            var cnp = await _mediator.Send(container);
            if (cnp == null)
                return NotFound();
            return Ok(cnp);
        }*/

        //[HttpGet("{cnp}")]
        [HttpPost]
        public async Task<ActionResult<Citizen>> Authorize([FromBody]GetCitizenDetails cnp)
        {
            var response = await _mediator.Send(cnp);
            if (response == null)
                return NotFound();
            return Ok(response);
        }
    }
}