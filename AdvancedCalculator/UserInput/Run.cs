using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedCalculator;

namespace UserInput
{
    class Run
    {
        Container container;
        Calculator calculator;
        public Run()
        {
            container = new Container();
            calculator = new Calculator(adder, subtractor, divider, multiplier, exponenter);
        }
    }
}
