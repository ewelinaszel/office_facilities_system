using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Office_System.Controllers.RoomReservation
{
    [ApiController]
    [Route("[controller]")]
    public class RoomReservationController : ControllerBase
    {
        private IMediator _mediator;

        public RoomReservationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task Post([FromBody] AddRoomReservationCommand command)
        {
            await _mediator.Send(command);
        }

    }
}
