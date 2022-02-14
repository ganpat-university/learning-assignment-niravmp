using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo22_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product { ProductID = 4, ProductName = "Wheat", Price = 45.50M, Quantity = 30 },
                new Product { ProductID = 1, ProductName = "Rice", Price = 36.00M, Quantity = 50 },
                new Product { ProductID = 5, ProductName = "Salt", Price = 12.00M, Quantity = 23 },
                new Product { ProductID = 3, ProductName = "Sugar", Price = 20.50M, Quantity = 18 },
                new Product { ProductID = 2, ProductName = "Daal", Price = 24.75M, Quantity = 11 }
            };

            Console.WriteLine("--- List of Products:");
            Console.WriteLine("{0:000}  {1,-20} {2,15} {3,15} {4,15}",
                "ID", "Name", "Price", "Quantity", "Cost");
            foreach (Product p in products)
            {
                Console.WriteLine("{0:000} {1,-20} {2,15} {3,15} {4,15}",
                    p.ProductID, p.ProductName, p.Price, p.Quantity, p.Price * p.Quantity);
            }
            Console.WriteLine();

            products.Sort();

            Console.WriteLine("--- List of Products after sorting:");
            Console.WriteLine("{0:000}  {1,-20} {2,15} {3,15} {4,15}",
                "ID", "Name", "Price", "Quantity", "Cost");
            foreach (Product p in products)
            {
                Console.WriteLine("{0:000} {1,-20} {2,15} {3,15} {4,15}",
                    p.ProductID, p.ProductName, p.Price, p.Quantity, p.Price * p.Quantity);
            }
            Console.WriteLine();

            // LINQ: Language Integrated Query
            var query = from p in products
                        orderby p.ProductName descending
                        select p;
            Console.WriteLine("--- List of Products after sorting using LINQ:");
            Console.WriteLine("{0:000}  {1,-20} {2,15} {3,15} {4,15}",
                "ID", "Name", "Price", "Quantity", "Cost");
            foreach (Product p in query)
            {
                Console.WriteLine("{0:000} {1,-20} {2,15} {3,15} {4,15}",
                    p.ProductID, p.ProductName, p.Price, p.Quantity, p.Price * p.Quantity);
            }
            Console.WriteLine();

            var query2 = from p in products
                         orderby p.ProductName descending
                         where p.ProductID >= 3
                         select new                         // projection of data into a new anonymous type
                         {
                             ID = p.ProductID,
                             Name = p.ProductName,
                             p.Price,
                             Qty = p.Quantity,
                             Cost = p.Price * p.Quantity
                         };
            Console.WriteLine("--- List of Products after sorting using LINQ:");
            Console.WriteLine("{0:000}  {1,-20} {2,15} {3,15} {4,15}",
                "ID", "Name", "Price", "Quantity", "Cost");
            foreach (var row in query2)
            {
                Console.WriteLine("{0:000} {1,-20} {2,15} {3,15} {4,15}",
                    row.ID, row.Name, row.Price, row.Qty, row.Cost);
            }
            Console.WriteLine();

            // LAMBDA version of the LINQ Query
            // FLUENT API Style of Programming
            var query3 = products
                         .Where(p => p.ProductID >= 3)
                         .OrderByDescending(p => p.ProductName)
                         .Skip(1)
                         .Take(2);


            var isFound = products.Any(p => p.ProductID == 3);
            if (isFound)
            {
                Console.WriteLine("Product with ID == 3 was found!");
            }
            Console.WriteLine();

            var prod4 = products.SingleOrDefault(p => p.ProductID == 4);
            if(prod4 != null)
            {
                Console.WriteLine("Product with ID == 4 was found!");
                Console.WriteLine("{0} {1}", prod4.ProductID, prod4.ProductName);
            }
            else
            {
                Console.WriteLine("Product with ID == 4 was not found");
            }
            Console.WriteLine();

        }
    }
}
