using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInput;

namespace AdvancedCalculator
{
    public class Calculator
    {
        string selectOperator;
        IAdder adder;
        ISubtractor subtractor;
        IDivider divider;
        IMultiplier multiplier;
        IExponenter exponenter;
        public Calculator (IAdder adder, ISubtractor subtractor, IDivider divider, IMultiplier multiplier, IExponenter exponenter)
        {
            this.adder = adder;
            this.subtractor = subtractor;
            this.divider = divider;
            this.multiplier = multiplier;
            this.exponenter = exponenter;
        }
        public void OnOperatorAssigned(object source, EventArgs e)
        {
            selectOperator = (string)source;
        } 
        public void DoMath()
        {
            switch (selectOperator)
            {
                case "+":
                    Console.WriteLine(adder.Add()); 
                    break;
                case "-":
                    Console.WriteLine(subtractor.Subtract( ));
                    break;
                case "*":
                    Console.WriteLine(multiplier.Multiply());
                    break;
                case "/":
                    Console.WriteLine(divider.Divide());
                    break;
                case "^":
                    Console.WriteLine(exponenter.Exponent());
                    break;
                default:
                    break;
            }
        }    
    }
}
