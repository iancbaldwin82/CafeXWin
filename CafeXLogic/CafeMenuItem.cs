using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CafeXLogic
{
    public class CafeMenuItem 
    {
        public string Name { get; set; }
        public bool IsHot { get; set; }
        public double Price { get; set; }
        public bool Selected { get; set; }
    }
}