using HMACAuthentication.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMACAuthentication.Client
{
    public class Order : IOrder
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public string ShipperCity { get; set; }
        public Boolean IsShipped { get; set; }

    }
}
