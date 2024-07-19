using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOOP_NataliaHerrera
{
    public abstract class Calculator : IAdd, ISubtract, IMultiply, IDivide
    {
        // Fields and properties
        protected decimal currentValue;
        protected decimal operand1;
        protected decimal operand2;
        protected string op;

        public decimal CurrentValue
        {
            get { return currentValue; }
            set { currentValue = value; }
        }

        // Methods from interfaces
        public abstract void Add(decimal displayValue);
        public abstract void Subtract(decimal displayValue);
        public abstract void Multiply(decimal displayValue);
        public abstract void Divide(decimal displayValue);

        public abstract void Equals();

        public abstract void Equals(decimal displayValue);

        
    }

}
