using Module3Question2.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3Question2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            using (var ctx = new NorthwindContext())
            {

                List<string> myList = new();

                var queryLondonCustomers = ctx.Customers.OrderBy(c => c.City);

                var cities = queryLondonCustomers.ToList();
                
                foreach (var cust in cities)
                {
                    myList.Add(cust.City);
                }
                
                var itemList = myList.Distinct();

                foreach (var itemCity in itemList)
                {
                    Console.Write(" " + itemCity + ", ");
                }

            }

            Console.WriteLine("\n");

            ConsoleKeyInfo cki;
            do
            {
                Console.Write("Enter the name of a city: ");

                string userInput = Console.ReadLine();

                if (userInput == "")
                {
                    Console.WriteLine("Enter the name of a city: ");
                    userInput = Console.ReadLine();
                }
                
                List<Customer> customers = new List<Customer>();

                using (var ctx = new NorthwindContext())
                {
                    var queryLondonCustomers = from cust in ctx.Customers
                                               where cust.City == userInput
                                               select cust;

                    customers = queryLondonCustomers.ToList();
                    int ccount = queryLondonCustomers.Count();
                    Console.WriteLine($"There are {ccount} customers in: " + userInput);
                }

                foreach (var cust in customers)
                {
                    Console.WriteLine(cust.CompanyName);
                }

                Console.WriteLine("Press ESC to end or any key to try again.");

                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Escape);
            
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
