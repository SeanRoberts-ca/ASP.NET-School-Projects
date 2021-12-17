using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.ModelsDto
{
    public class ReservationsReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<MenuItemsReadDto> MenuItems { get; set; }

    }
}
