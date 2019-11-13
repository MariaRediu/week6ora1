using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6ora1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(2,4);
            var p2 = new Point(3, 7);
            var p3 = p1 + p2;
            var p4 = p3++;

            Console.WriteLine(p3);
      
            Console.WriteLine(p4);

            Console.ReadLine();
           
        }
    }

    
}
