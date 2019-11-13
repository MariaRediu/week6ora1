using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson alex;
            IStore ford;
            IVehicule focus;

            IStore skoda;
            IVehicule fabia;

            IOrder order = ford.Enter(alex, focus);
            IOrder orderf = skoda.Enter(alex, fabia);

            if (order.develirydata<orderf.deliverydata)
            { //deliveryorder(skodaorder)

            }else
            {
             //cancelorder(fabiaorder)
            }
        }
    }
}
