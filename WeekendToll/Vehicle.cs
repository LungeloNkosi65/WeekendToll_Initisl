using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekendToll
{
    public class Vehicle
    {
        public string TypeName { get; set; }
        public decimal TollAmount { get; set; }
        public Vehicle(string typeName, decimal tollAmount)
        {
            TypeName = typeName;
            TollAmount = tollAmount;
        }



    }
}
