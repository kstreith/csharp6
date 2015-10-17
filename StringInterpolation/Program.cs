using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------- CSharp5 ------------------");
            Console.WriteLine("Example #1");
            try
            {
                CSharp5.ValidateCart(new ShoppingCart { Orders = new List<Order> { new Order { Quantity = 500, Name = "USB Car Charger" }, new Order { Quantity = 2, Price = 550.00, Name = "Lumia Phone" } } }, 5, 500);
                Console.WriteLine("Failed");
            } catch (ValidationException ve) when (ve?.Exceptions?.Count == 2) {
                Console.WriteLine("Passed");
                foreach (var err in ve.Exceptions)
                {
                    Console.WriteLine(err);
                }
            } catch (Exception) {
                Console.WriteLine("Failed");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------- CSharp6 ------------------");
            Console.WriteLine("Example #1");
            try
            {
                CSharp6.ValidateCart(new ShoppingCart { Orders = new List<Order> { new Order { Quantity = 500, Name = "USB Car Charger" }, new Order { Quantity = 2, Price = 550.00, Name = "Lumia Phone" } } }, 5, 500);
                Console.WriteLine("Failed");
            }
            catch (ValidationException ve) when (ve?.Exceptions?.Count == 2)
            {
                Console.WriteLine("Passed");
                foreach (var err in ve.Exceptions)
                {
                    Console.WriteLine(err);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Failed");
            }

        }
    }
}
