using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAplication
{
    interface IOrder
    {
        ICustomer Customer { get; set; }
        IVehicule Vehicule { get; set; }
        DateTime DeliveryTime { get; set; }
    }
}
}
