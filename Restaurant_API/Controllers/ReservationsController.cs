using Microsoft.AspNetCore.Mvc;
using Restaurant_API.Data;
using Restaurant_API.Models;
using Restaurant_API.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Restaurant_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {

        private readonly AppDbContext _context;
        // GET: OrdersController

        public ReservationsController(AppDbContext context)
        {
            _context = context;
        }


        // GET: api/<ReservationsController>
        [HttpGet]
        public ActionResult Get()
        {
            var reservations = _context.Reservations
                .Select(r => new ReservationsReadDto
                {
                    Id = r.Id,
                    Name = r.Name,
                    Date = r.Date,
                    MenuItems = _context.ReservationMenuItems
                        .Where(op => op.ReservationsId == r.Id)
                        .Select(m => new MenuItemsReadDto
                        {
                            Id = m.MenuItems.Id,
                            Name = m.MenuItems.Name,
                            Price = m.MenuItems.Price
                        }).ToList()
                })
                .ToList();

            return Ok(reservations);

        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var reservation = _context.Reservations
                .Where(r => r.Id == id)
                .Select(r => new ReservationsReadDto
                {
                    Id = r.Id,
                    Name = r.Name,
                    Date = r.Date,
                    MenuItems = _context.ReservationMenuItems
                        .Where(rm => rm.ReservationsId == r.Id)
                        .Select(c => new MenuItemsReadDto
                        {
                            Id = c.MenuItems.Id,
                            Name = c.MenuItems.Name,
                            Price = c.MenuItems.Price
                        }).ToList()
                })
                .FirstOrDefault();

            if (reservation == null)
            {
                return NotFound($"Order with {id} doen't exist.");
            }

            return Ok(reservation);
        }


        // POST api/<ReservationsController>
        [HttpPost]
        public ActionResult Post(ReservationsWriteDto value)
        {
            Reservations orderToAdd = new Reservations
            {
                Name = value.Name,
                Date = value.Date
            };

            _context.Reservations.Add(orderToAdd);
            _context.SaveChanges();

            foreach (var id in value.MenuItemsIds)
            {
                ReservationMenuItems op = new ReservationMenuItems
                {
                    ReservationsId = orderToAdd.Id,
                    MenuItemsId = id
                };

                _context.ReservationMenuItems.Add(op);
            }

            _context.SaveChanges();

            return NoContent();
        }

        // PUT api/<ReservationsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, ReservationsWriteDto value)
        {
            var reservationsFromDb = _context.Reservations
                .FirstOrDefault(p => p.Id == id);

            if (reservationsFromDb == null) return NotFound();

            reservationsFromDb.Name = value.Name;
            reservationsFromDb.Date = value.Date;

            // _context.Update(prodFromDb);
            _context.SaveChanges();

            return NoContent();
        }

        // DELETE api/<ReservationsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var reservationsFromDb = _context.Reservations
                .FirstOrDefault(p => p.Id == id);

            if (reservationsFromDb == null) return NotFound();

            _context.Reservations.Remove(reservationsFromDb);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
