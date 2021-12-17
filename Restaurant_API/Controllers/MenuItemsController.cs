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
    public class MenuItemsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly Mapper _mapper = new Mapper();

        public MenuItemsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/<MenuItemsController>
        [HttpGet]
        public ActionResult<IEnumerable<MenuItems>> Get()
        {
            return Ok(_context.MenuItems.ToList());
        }

        // GET api/<MenuItemsController>/5
        [HttpGet("{id}")]
        public ActionResult<MenuItems> Get(int id)
        {
            var menuItem = _context.MenuItems.FirstOrDefault(p => p.Id == id);

            if (menuItem != null)
            {
                return Ok(menuItem);
            }
            return NotFound();
        }

        // POST api/<MenuItemsController>
        [HttpPost]
        public ActionResult Post(MenuItemsDto value)
        {
            MenuItems menuToAdd = _mapper.Map(value);

            _context.Add(menuToAdd);
            _context.SaveChanges();

            return Ok();

        }

        // PUT api/<MenuItemsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, MenuItemsDto value)
        {
            var menuFromDb = _context.MenuItems
                .FirstOrDefault(p => p.Id == id);

            if (menuFromDb == null) return NotFound();

            menuFromDb.Name = value.Name;
            menuFromDb.Price = value.Price;

            _context.SaveChanges();

            return NoContent();
        }

        // DELETE api/<MenuItemsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var menuFromDb = _context.MenuItems
                .FirstOrDefault(p => p.Id == id);

            if (menuFromDb == null) return NotFound();

            _context.MenuItems.Remove(menuFromDb);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
