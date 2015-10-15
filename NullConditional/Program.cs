using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullConditional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------- CSharp5 ------------------");
            Console.WriteLine("Example #1");
            Console.WriteLine(CSharp5.FormatOrderDetails(null, 101.33));
            Console.WriteLine();
            Console.WriteLine("Example #2");
            Console.WriteLine(CSharp5.FormatOrderDetails(new ShoppingCart { Customer = new Customer { FirstName = "Jane", LastName = "Doe" } }, 45.57));
            Console.WriteLine();
            Console.WriteLine("Example #3");
            Console.WriteLine(CSharp5.FormatOrderDetails(new ShoppingCart { Customer = new Customer { FirstName = "Mark", Addresses = new List<Address> { new Address { State = "OH", ZipCode = "58353" } } } }, 12.36));
            Console.WriteLine();
            Console.WriteLine("Example #4");
            Console.WriteLine(CSharp5.FormatOrderDetails(new ShoppingCart { Customer = new Customer { FirstName = "John", LastName = "Doe", Addresses = new List<Address> { new Address { Street = "32 Main St.", Street2 = "Suite #200", City = "Raleigh", State = "NC", ZipCode = "27571" } } } }, 32.50));

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------- CSharp6 ------------------");
            Console.WriteLine("Example #1");
            Console.WriteLine(CSharp6.FormatOrderDetails(null, 101.33));
            Console.WriteLine();
            Console.WriteLine("Example #2");
            Console.WriteLine(CSharp6.FormatOrderDetails(new ShoppingCart { Customer = new Customer { FirstName = "Jane", LastName = "Doe" } }, 45.57));
            Console.WriteLine();
            Console.WriteLine("Example #3");
            Console.WriteLine(CSharp6.FormatOrderDetails(new ShoppingCart { Customer = new Customer { FirstName = "Mark", Addresses = new List<Address> { new Address { State = "OH", ZipCode = "58353" } } } }, 12.36));
            Console.WriteLine();
            Console.WriteLine("Example #4");
            Console.WriteLine(CSharp6.FormatOrderDetails(new ShoppingCart { Customer = new Customer { FirstName = "John", LastName = "Doe", Addresses = new List<Address> { new Address { Street = "32 Main St.", Street2 = "Suite #200", City = "Raleigh", State = "NC", ZipCode = "27571" } } } }, 32.50));

        }
    }
}
