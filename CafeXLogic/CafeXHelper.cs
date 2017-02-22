using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeXLogic
{
    public static class CafeXHelper
    {        
        public static double CalculateTotalBill(IEnumerable<CafeMenuItem> items)
        {
            var sum = items.Sum(i => i.Price);
            return sum;
        }

        public static double CalculateServiceCharge(IEnumerable<CafeMenuItem> items)
        {
            var justDrinks = items.All(i => i.IsDrink);
            if (justDrinks)
            {
                return 0;
            }
            else
            {
                var hotFood = items.Any(i => i.IsHot & i.IsDrink == false);
                if (hotFood)
                {
                    return Math.Round(CalculateTotalBill(items) * 0.20, 2);
                }
                else
                {
                    return Math.Round(CalculateTotalBill(items) * 0.10, 2);
                }
            }
        }
    }
}
