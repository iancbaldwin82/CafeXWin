using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeXLogic
{
    public static class CafeXHelper
    {        
        public static double Calculate(List<CafeMenuItem> items)
        {
            var sum = items.Where(i => i.Selected == true).Sum(i => i.Price);
            return sum;
        }
    }
}
