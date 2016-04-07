using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    public class Adder : IAdder
    {
        int IAdder.Add(int first, int second)
        {
            return first + second;
        }
    }
}
