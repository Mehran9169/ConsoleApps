using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps
{
    internal class Circle
    {
       
        private decimal radius;
        private decimal diameter;
        public decimal r;
        public decimal d;
        public decimal Radius
        {
            get { return radius; }
            set => r = radius;
            }
        public decimal Diameter
        {
            get { return diameter; }
            set => diameter = d;
        }
        
    }
}
