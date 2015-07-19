using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMACAuthentication.Shared
{
    public interface IOrder
    {
        int OrderID { get; set; }
        string CustomerName { get; set; }
        string ShipperCity { get; set; }
        Boolean IsShipped { get; set; }

    }
}
