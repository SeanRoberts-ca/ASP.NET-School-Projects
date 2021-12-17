using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.ModelsDto
{
    public class ReservationsWriteDto
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<int> MenuItemsIds { get; set; }

    }
}
