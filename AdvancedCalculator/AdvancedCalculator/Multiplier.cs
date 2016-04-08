using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    public class Multiplier : IMultiplier
    {
        int? first = null;
        int? second = null;
        public Multiplier()
        {
        }
        public int? First
        {
            set { first = value; }
        }
        public int? Second
        {
            set { second = value; }
        }
        public int? Multiply()
        {
            if (first == null)
            {
                return null;
            }
            return first * second;
        }
    }
}
