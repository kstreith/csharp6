using System;
using System.Linq;

namespace nameofOperator
{
    class CSharp6
    {
        public static void MergeCarts(ShoppingCart current_cart, ShoppingCart other_cart)
        {
            if (current_cart == null)
            {
                throw new ArgumentNullException("current_cart");
            }
            if (other_cart == null)
            {
                throw new ArgumentNullException("other_cart");
            }
            // merge cart logic goes here...
        }

        #region CSharp6 Working Code
        //public static void MergeCarts(ShoppingCart current_cart, ShoppingCart other_cart)
        //{
        //    if (current_cart == null)
        //    {
        //        throw new ArgumentNullException(nameof(current_cart));
        //    }
        //    if (other_cart == null)
        //    {
        //        throw new ArgumentNullException(nameof(other_cart));
        //    }
        //    // merge cart logic goes here...
        //}
        #endregion
    }
}
