using System;
using System.Collections.Generic;
using System.Linq;

namespace NullConditional
{
    class CSharp6
    {
        public static string FormatOrderDetails(ShoppingCart cart, double total)
        {
            List<String> details = new List<String>();
            if (cart != null)
            {
                if (cart.Customer != null)
                {
                    //Customer Name - FirstName, Last Name
                    details.Add(cart.Customer.FirstName + " " + cart.Customer.LastName);
                    //Primary Address Details
                    if (cart.Customer.Addresses != null &&
                        cart.Customer.Addresses.Any())
                    {
                        var address = cart.Customer.Addresses[0];
                        //Street details
                        details.Add(address.Street);
                        details.Add(address.Street2);

                        //City, State, Zip line
                        var locationLine = (address.City != null ? address.City + ", " : "");
                        locationLine += address.State;
                        locationLine += " " + address.ZipCode;
                        details.Add(locationLine);
                    }
                }
            }
            //Order Total
            details.Add(String.Format("{0:c}", total));
            return String.Join("\n", details.Where(x => !String.IsNullOrWhiteSpace(x)));
        }

        //public static string FormatOrderDetails(ShoppingCart cart, double total)
        //{
        //    List<String> details = new List<String>();
        //    //Customer Name - FirstName, Last Name
        //    details.Add(cart?.Customer?.FirstName + " " + cart?.Customer?.LastName);
        //    //Primary Address Details
        //    var address = cart?.Customer?.Addresses?.Any() == true ? cart?.Customer?.Addresses?[0] : null;
        //    //Street details
        //    details.Add(address?.Street);
        //    details.Add(address?.Street2);

        //    //City, State, Zip line
        //    var locationLine = (address?.City != null ? address?.City + ", " : "");
        //    locationLine += address?.State;
        //    locationLine += " " + address?.ZipCode;
        //    details.Add(locationLine);
        //    //Order Total
        //    details.Add(String.Format("{0:c}", total));
        //    return String.Join("\n", details.Where(x => !String.IsNullOrWhiteSpace(x)));
        //}
    }
}
