using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekendToll
{
   public class TollGate
    {
        private string _vehicleType;
        private decimal _vehicleLoad;
        public List<Vehicle> vehicles;
        public List<LoadBracket> loadBrackets;
     
        public TollGate(string vehicleType,decimal vehicleLoad)
        {
            _vehicleType = vehicleType;
            _vehicleLoad = vehicleLoad;
            vehicles = new List<Vehicle>()
            {
                new Vehicle("A",10),
                new Vehicle("B",20),
                new Vehicle("C",30),
            };
            loadBrackets = new List<LoadBracket>()
            {
                new LoadBracket(100,200,10),
                new LoadBracket(200,300,20),
            };
        }
        public  decimal CalcAmount()
        {
            decimal passamount = 0;
            foreach (var item in vehicles)
            {
                if (_vehicleType == item.TypeName)
                {
                    passamount = item.TollAmount;
                    break;
                }
            }
            return passamount;
        }
        public decimal CalcAdditionalCost()
        {
            if (_vehicleType == "B")
            {
                foreach (var item in loadBrackets)
                {
                    if (_vehicleLoad >=item.LowerValue && _vehicleLoad<item.UperValue)
                    {
                        return item.AdditionalAmount;
                        break;
                    }
                }
            }
            return 0;
        }

        public decimal CalcTotal()
        {
            return CalcAmount() + CalcAdditionalCost();
        }
        public void Display()
        {
            Console.WriteLine("Vehicle Type : " +_vehicleType +"\n Vehicle Load "+ _vehicleLoad
                +"\n Amount Due "+ CalcTotal());
        }
    }
}
