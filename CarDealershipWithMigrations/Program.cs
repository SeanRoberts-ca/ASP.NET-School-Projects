using Microsoft.EntityFrameworkCore;
using Module3Practice.Data;
using System;

namespace Module3Practice
{


    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new CarDealershipContext())
            {
                //var Name= new Customer() { Name = "Bill" };
                //ctx.Customer.Add(Name);
                //ctx.SaveChanges();
            }
        }
    }
}
