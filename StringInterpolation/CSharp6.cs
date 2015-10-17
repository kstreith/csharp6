using System;
using System.Collections.Generic;
using System.Linq;

namespace StringInterpolation
{
    class CSharp6
    {
        public static void ValidateCart(ShoppingCart cart, int maxQuantity, double maxLineTotal)
        {
            List<String> errors = new List<String>();
            foreach (var item in cart.Orders)
            {
                if (item.Quantity > maxQuantity)
                {
                    errors.Add(String.Format("'{0}' cannot be ordered in a quantity greather than {2}, you ordered, '{1}'", item.Name, item.Quantity, maxQuantity));
                }
                if (item.Quantity * item.Price > maxLineTotal)
                {
                    errors.Add(String.Format("Attempted to order '{1:c}' worth of '{0}', max allowed is {2:c}", item.Name, item.Quantity * item.Price, maxLineTotal));
                }
            }
            if (errors.Any())
            {
                throw new ValidationException(errors);
            }
        }

        #region CSharp6 Working Code
        //public static void ValidateCart(ShoppingCart cart, int maxQuantity, double maxLineTotal)
        //{
        //    List<String> errors = new List<String>();
        //    foreach (var item in cart.Orders)
        //    {
        //        if (item.Quantity > maxQuantity)
        //        {
        //            errors.Add($"'{item.Name}' cannot be ordered in a quantity greather than {maxQuantity}, you ordered, '{item.Quantity}'");
        //        }
        //        if (item.Quantity * item.Price > maxLineTotal)
        //        {
        //            errors.Add($"Attempted to order '{item.Quantity * item.Price:c}' worth of '{item.Name}', max allowed is {maxLineTotal:c}");
        //        }
        //    }
        //    if (errors.Any())
        //    {
        //        throw new ValidationException(errors);
        //    }
        //}
        #endregion

    }
}
