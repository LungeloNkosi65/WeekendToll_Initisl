using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekendToll
{
    class Program
    {
        static void Main(string[] args)
        {
            var tollGate = new TollGate("B",100);
            tollGate.Display();
            Console.ReadKey();
            
        }
    }
}
