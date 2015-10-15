using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nameofOperator
{
    class CSharp6
    {
        public static string DetermineLocalityForOrder(ShoppingCart current_cart)
        {
            if (current_cart == null)
            {
                throw new ArgumentNullException("current_cart");
            }
            if (current_cart.Customer == null)
            {
                throw new ArgumentException("ShoppingCart must have a customer", "current_cart");
            }
            if (current_cart.Customer.Addresses == null || !current_cart.Customer.Addresses.Any())
            {
                throw new ArgumentException("ShoppingCart must have a customer address", "current_cart");
            }
            return DetermineLocalityForAddress(current_cart.Customer.Addresses[0]);
        }

        //public static string DetermineLocalityForOrder(ShoppingCart currentCart)
        //{
        //    if (currentCart == null)
        //    {
        //        throw new ArgumentNullException(nameof(currentCart));
        //    }
        //    if (currentCart.Customer == null)
        //    {
        //        throw new ArgumentException("ShoppingCart must have a customer", nameof(currentCart));
        //    }
        //    if (currentCart.Customer.Addresses == null || !currentCart.Customer.Addresses.Any())
        //    {
        //        throw new ArgumentException("ShoppingCart must have a customer address", nameof(currentCart));
        //    }
        //    return DetermineLocalityForAddress(currentCart.Customer.Addresses[0]);
        //}

        public static string DetermineLocalityForAddress(Address address)
        {
            return "Parcel2923-Raleigh-NC"; //FIXME
        }
    }
}
