using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    interface IStore
    {
         string Name { get; set; }

        void Enter(IPerson, IProducer producer, IVehicule vehicule);

        void CancelOrder(IOreder order);

    }
    interface IPerson
    {
        string Name { get; set; }
    }
    interface IOreder
    {
        IPerson Person { get; set; }
        IVehicule Vehicule { get; set; }
        DateTime DeliveryTime { get; set;}
    } 
    interface IProducer
    {
    IProducer Producer { get; set; }
    }
    interface IVehicule
    { 
        IProducer Producer { get; set; }
        decimal Price { get; set; }
        string Name { get; set; }


    }
}
