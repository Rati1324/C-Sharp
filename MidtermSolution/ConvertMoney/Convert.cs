using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConvertMoney
{
    public class Convert
    {
        public decimal USD { get; set; }
        public decimal Euro { get; set; }
        public decimal MoneyConvert(int whole, int change, string ConvertTo)
        {
            decimal wholed = whole;
            decimal changed = change;

            if (ConvertTo.Equals("USD"))
                return (wholed * USD) + (changed/100m * USD);

            return (wholed * Euro) + (changed/100m * Euro);

        }
    }
}
