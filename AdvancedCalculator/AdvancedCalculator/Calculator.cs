using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    public class Calculator
    {
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
    }
}
