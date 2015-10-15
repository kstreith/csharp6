using System;
using System.Collections.Generic;
using System.Linq;

namespace StringInterpolation
{
    class CSharp6
    {
        public static void ValidateCart(ShoppingCart cart)
        {
            List<String> errors = new List<String>();
            foreach (var item in cart.Orders)
            {
                if (item.Quantity < 0)
                {
                    errors.Add(String.Format("'{0}' cannot be ordered in a negative quantity, you ordered, '{1}'", item.Name, item.Quantity));
                }
                if (item.Quantity > 5)
                {
                    errors.Add(String.Format("'{1}' cannot be ordered in a quantity greather than five, you ordered, '{0}'", item.Quantity, item.Name));
                }
                var lineItemTotal = item.Quantity * item.Price;
                if (lineItemTotal > 500)
                {
                    errors.Add(String.Format("Attempted to order '{1:c}' worth of '{0}', max allowed is five hundred dollars", item.Name, lineItemTotal));
                }
            }
            if (errors.Any())
            {
                throw new ValidationException(errors);
            }
        }

        //public static void ValidateCart(ShoppingCart cart)
        //{
        //    List<String> errors = new List<String>();
        //    foreach (var item in cart.Orders)
        //    {
        //        if (item.Quantity < 0)
        //        {
        //            errors.Add($"'{item.Name}' cannot be ordered in a negative quantity, you ordered, '{item.Quantity}'");
        //        }
        //        if (item.Quantity > 5)
        //        {
        //            errors.Add($"'{item.Name}' cannot be ordered in a quantity greather than five, you ordered, '{item.Quantity}'");
        //        }
        //        var lineItemTotal = item.Quantity * item.Price;
        //        if (lineItemTotal > 500)
        //        {
        //            errors.Add($"Attempted to order '{lineItemTotal:c}' worth of '{item.Name}', max allowed is five hundred dollars");
        //        }
        //    }
        //    if (errors.Any())
        //    {
        //        throw new ValidationException(errors);
        //    }
        //}
    }
}
