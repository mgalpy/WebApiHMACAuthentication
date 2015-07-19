using System;
using System.Collections.Generic;
using System.Text;

namespace HMACAuthentication.Share.Model
{
    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public string ShipperCity { get; set; }
        public Boolean IsShipped { get; set; }

    }
}
