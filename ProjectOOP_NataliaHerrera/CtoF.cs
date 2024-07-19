using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP_NataliaHerrera
{
    internal class CtoF : Temperature //Derived class (child)
    {
        public override double Convert(double temp)
        {
            double result = (temp * 1.8) + 32;
            return Math.Round(result, 1); // Round to one decimal place
        }
    }
}
