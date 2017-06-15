using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Models.MongoEntities
{
    public class BookingEntity : AbsMongoEntity
    {
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public string CottageId { get; set; }
        public string Email { get; set; }
    }
}
