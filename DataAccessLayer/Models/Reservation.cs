using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime startDateTime { get; set; }
        public DateTime endDateTime { get; set; }
        public int RoomId { get; set; }

        public Reservation(DateTime startDateTime, DateTime endDateTime, int roomId)
        {
            this.startDateTime = startDateTime;
            this.endDateTime = endDateTime;
            RoomId = roomId;
        }
    }
}
