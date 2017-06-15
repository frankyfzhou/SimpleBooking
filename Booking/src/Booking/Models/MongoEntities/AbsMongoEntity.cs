using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Booking.Models.MongoEntities
{
    [BsonIgnoreExtraElements(Inherited = true)]
    public abstract class AbsMongoEntity
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public virtual string Id { get; set; }
    }
}
