using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nameofOperator
{
    class CSharp5
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
    }
}
