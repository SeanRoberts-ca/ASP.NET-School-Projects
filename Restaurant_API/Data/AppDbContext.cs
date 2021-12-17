using Microsoft.EntityFrameworkCore;
using Restaurant_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Reservations> Reservations { get; set; }
        public DbSet<MenuItems> MenuItems { get; set; }
        public DbSet<ReservationMenuItems> ReservationMenuItems { get; set; }
        public IEnumerable<object> ReservationsMenuItems { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Reservations>().HasData(
            new Reservations { Id = 1, Name = "Sean Roberts", Date = DateTime.Now }
            );

            modelBuilder.Entity<MenuItems>().HasData(
            new MenuItems { Id = 1, Name = "Pasta Bowl", Price = 10.29}
            );

            modelBuilder.Entity<ReservationMenuItems>().HasData(
            new ReservationMenuItems { Id = 1, ReservationsId = 1, MenuItemsId = 1}
            );

        }


    }
}
