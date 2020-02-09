using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekendToll
{
    public class LoadBracket
    {
        public decimal UperValue { get; set; }
        public decimal LowerValue { get; set; }
        public decimal AdditionalAmount { get; set; }

        public LoadBracket(decimal loweralue,decimal uperValue,decimal additionalAmount)
        {
            LowerValue = loweralue;
            UperValue = uperValue;
            AdditionalAmount = additionalAmount;

        }

    }
}
