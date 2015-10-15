using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nameofOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------- CSharp5 ------------------");
            Console.WriteLine("Example #1");
            try {
                CSharp5.DetermineLocalityForOrder(null);
                Console.WriteLine("Failed");
            }
            catch (ArgumentNullException e) {
                Console.WriteLine("Passed - exception thrown for argument '" + e.ParamName + "'");
            } catch (Exception) { 
                Console.WriteLine("Failed");
            }
            Console.WriteLine();
            Console.WriteLine("Example #2");
            try
            {
                CSharp5.DetermineLocalityForOrder(new ShoppingCart());
                Console.WriteLine("Failed");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Passed - exception thrown for argument '" + e.ParamName + "'");
            }
            catch (Exception)
            {
                Console.WriteLine("Failed");
            }
            Console.WriteLine();
            Console.WriteLine("Example #3");
            try
            {
                CSharp5.DetermineLocalityForOrder(new ShoppingCart { Customer = new Customer { } });
                Console.WriteLine("Failed");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Passed - exception thrown for argument '" + e.ParamName + "'");
            }
            catch (Exception)
            {
                Console.WriteLine("Failed");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------- CSharp6 ------------------");
            Console.WriteLine("Example #1");
            try
            {
                CSharp6.DetermineLocalityForOrder(null);
                Console.WriteLine("Failed");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Passed - exception thrown for argument '" + e.ParamName + "'");
            }
            catch (Exception)
            {
                Console.WriteLine("Failed");
            }
            Console.WriteLine();
            Console.WriteLine("Example #2");
            try
            {
                CSharp6.DetermineLocalityForOrder(new ShoppingCart());
                Console.WriteLine("Failed");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Passed - exception thrown for argument '" + e.ParamName + "'");
            }
            catch (Exception)
            {
                Console.WriteLine("Failed");
            }
            Console.WriteLine();
            Console.WriteLine("Example #3");
            try
            {
                CSharp6.DetermineLocalityForOrder(new ShoppingCart { Customer = new Customer { } });
                Console.WriteLine("Failed");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Passed - exception thrown for argument '" + e.ParamName + "'");
            }
            catch (Exception)
            {
                Console.WriteLine("Failed");
            }
        }
    }
}
