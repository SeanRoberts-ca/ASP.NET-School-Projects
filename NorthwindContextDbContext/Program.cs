using Assignment03.Data;
using System;
using System.Linq;
using System.Text.Json;
using System.Text.Encodings.Web;
using Newtonsoft.Json;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Assignment03
{
    class ProductsCategories
    {
        public int ProductId { get; set; }
        public string Product { get; set; }
        public int? CategoryId { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public int? SupplierId { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new NorthwindContext())
            {

                var products = context.Products.ToList();
                var categories = context.Categories.ToList();

                string jsonString = string.Empty;
                string json = string.Empty;
                
                var options = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                    WriteIndented = true
                };

                foreach (var item in products)
                {

                    //gConsole.WriteLine($"The product: '{item.ProductName}' from the category {item.Category.CategoryName}");

                    var productsCategories = new ProductsCategories
                    {
                        ProductId = item.ProductId,
                        Product = item.ProductName,
                        CategoryId = item.CategoryId,
                        Category = item.Category.CategoryName,
                        Description = item.Category.Description,
                        SupplierId = item.SupplierId,
                        QuantityPerUnit = item.QuantityPerUnit,
                        UnitPrice = item.UnitPrice,
                        UnitsInStock = item.UnitsInStock,
                        UnitsOnOrder = item.UnitsOnOrder,
                        ReorderLevel = item.ReorderLevel,
                        Discontinued = item.Discontinued
                    };

                    jsonString += System.Text.Json.JsonSerializer.Serialize<ProductsCategories>(productsCategories, options);

                    json += JsonConvert.SerializeObject(productsCategories, Formatting.Indented);

                }

                var howManyBytes = jsonString.Length * sizeof(Char);

                Console.WriteLine(jsonString + "\n\nThe above json string took: " + howManyBytes + " Bytes to generate & used System.Text.Json.\n\n");

                howManyBytes = json.Length * sizeof(Char);

                Console.WriteLine(json + "\n\nThe above json string took: " + howManyBytes + " Bytes to generate & used Newtonsoft.Json.\n\n");

            }
        }
    }
}