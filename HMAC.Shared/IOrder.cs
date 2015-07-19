using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMAC.Shared
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public interface IOrder
    {
        int OrderID { get; set; }
        string CustomerName { get; set; }
        string ShipperCity { get; set; }
        Boolean IsShipped { get; set; }

    }
}
