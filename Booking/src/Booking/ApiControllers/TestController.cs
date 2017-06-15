using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Booking.Models.MongoEntities;

namespace Mongo.ApiControllers
{
    //[Route("api/[controller]")]
    public class TestController : Controller
    {
        IMongoCollection<BookingEntity> bookings;
        public TestController(IMongoDatabase mongoDb)
        {
            bookings = mongoDb.GetCollection<BookingEntity>("bookings");
        }

        [HttpGet()]
        public IActionResult Test()
        {
            return Ok("Test");
        }

        [HttpGet()]
        public IActionResult TestRead()
        {
            return Ok(bookings.AsQueryable().FirstOrDefault());
        }

        [HttpGet()]
        public IActionResult TestInsert()
        {
            var newBooking = new BookingEntity
            {
            };
            bookings.InsertOne(newBooking);

            return Ok(bookings.AsQueryable().FirstOrDefault());
        }
    }
}
