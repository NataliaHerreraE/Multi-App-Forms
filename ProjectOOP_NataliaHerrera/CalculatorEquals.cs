using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOOP_NataliaHerrera
{
    internal class CalculatorEquals : Calculator
    {
        // Overrides the base class's Add method
        public override void Add(decimal displayValue)
        {
            // Sets operand1 to the given display value and stores it as the current value with the addition operator
            operand1 = displayValue;
            CurrentValue = displayValue;
            op = "+";
        }

        public override void Subtract(decimal displayValue)
        {
            operand1 = displayValue;
            CurrentValue = displayValue;
            op = "-";
        }

        public override void Multiply(decimal displayValue)
        {
            operand1 = displayValue;
            CurrentValue = displayValue;
            op = "*";
        }

        public override void Divide(decimal displayValue)
        {
            operand1 = displayValue;
            CurrentValue = displayValue;
            op = "/";
        }

        public override void Equals()
        {
            operand1 = CurrentValue;
            PerformOperation();
        }

        // Performs the Equals operation with an operand
        public override void Equals(decimal displayValue)
        {
            operand2 = displayValue;
            PerformOperation();
        }

        // Method to perform arithmetic operations based on the operator
        private void PerformOperation()
        {
            switch (op)
            {
                case "+":
                    CurrentValue = operand1 + operand2;
                    break;
                case "-":
                    CurrentValue = operand1 - operand2;
                    break;
                case "*":
                    CurrentValue = operand1 * operand2;
                    break;
                case "/":
                    if (operand2 != 0)
                    {
                        CurrentValue = operand1 / operand2;
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default:
                    break;
            }

        }
    }
}

