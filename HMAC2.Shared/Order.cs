using System;
using System.Collections.Generic;
using System.Text;

namespace HMACAuthentication.Shared
{
    public partial class Order : IOrder
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public string ShipperCity { get; set; }
        public Boolean IsShipped { get; set; }

    }
}
