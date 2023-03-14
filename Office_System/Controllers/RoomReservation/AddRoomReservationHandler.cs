using DataAccessLayer;
using DataAccessLayer.Models;
using MediatR;
using SQLitePCL;

namespace Office_System.Controllers.RoomReservation
{
    public class AddRoomReservationHandler : IRequestHandler<AddRoomReservationCommand>
    {
        private readonly IContext _context;

        public AddRoomReservationHandler(IContext context)
        {
            _context = context;
        }

        public async Task Handle(AddRoomReservationCommand request, CancellationToken cancellationToken)
        {
            var newReservation = new Reservation(request.startDateTime, request.endDateTime,request.roomId );
            _context.Reservations.Add(newReservation);
            await _context.SaveChangesAsync();
        }
    }

    public record AddRoomReservationCommand(DateTime startDateTime, DateTime endDateTime, int roomId) : IRequest;
}
