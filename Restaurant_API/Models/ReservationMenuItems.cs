using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Models
{
    public class ReservationMenuItems
    {

        [Key]
        public int Id { get; set; }

        [ForeignKey("Reservations")]
        public int ReservationsId { get; set; }
        public Reservations Reservations { get; set; }

        [ForeignKey("MenuItems")]

        public int MenuItemsId { get; set; }
        public MenuItems MenuItems { get; set; }

    }
}
