using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP_NataliaHerrera
{
    internal class FtoC : Temperature //Derived class (child)
    {
        public override double Convert(double temp)
        {
            return Math.Round((temp - 32) * 0.55); // Fahrenheit to Celsius conversion formula
        }
    }
}
