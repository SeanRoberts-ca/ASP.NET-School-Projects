using Microsoft.EntityFrameworkCore;
using Module3Practice.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3Practice.Data
{
    public class CarDealershipContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Sale> Sale { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=CarDealership;Trusted_Connection=True;");
        }
    }

}
