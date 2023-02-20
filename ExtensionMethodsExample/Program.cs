using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ExtensionNamespace;

namespace ExtensionMethodsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create object
            Product p = new Product() { ProductCost = 1000, DiscountPercentage = 10 };
            
            // call the extension method
            Console.WriteLine(p.GetDiscount());
            Console.ReadKey();
        }
    }
}
