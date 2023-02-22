using System;
using System.Collections.Generic;
using System.Xml;
using ECommerce;

namespace CollectionOfObjectsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create an empty collection
            List<Product> products = new List<Product>();

            //loop to read data from user
            string choice;
            do
            {
                Console.WriteLine("Enter Product ID:");
                int pId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Product Name:");
                string pName = Console.ReadLine();
                Console.WriteLine("Enter Price:");
                double unitPrice = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Date of Manufacture (yyyy-MM-dd):");
                DateTime dom = DateTime.Parse(Console.ReadLine());

                //Create a new object of Product class
                Product product = new Product() { ProductId = pId, ProductName = pName, 
                    Price = unitPrice, DateOfManufacture = dom };

                //Add Product object to the collection
                products.Add(product);

                //Ask the user to continue
                Console.WriteLine("Product Added.\n");
                Console.WriteLine("Do you want to continue to next product?(Yes/No)");
                choice = Console.ReadLine();

            } while (choice != "No" && choice != "no" && choice != "n" &&  choice !="N");

            //foreach
            Console.WriteLine("\nProducts:");
            foreach(Product item in products)
            {
                Console.WriteLine(item.ProductId + "," + item.ProductName + "," + item.Price + "," + 
                    item.DateOfManufacture.ToShortDateString());
            }

            Console.ReadKey();
        }
    }
}
