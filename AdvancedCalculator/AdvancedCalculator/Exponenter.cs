using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    public class Exponenter : IExponenter
    {
        int? first = null;
        int? second = null;
        public Exponenter()
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
        public int? Exponent()
        {
            if (first == null)
            {
                return null;
            }
            int returnValue = 1;
            for (int i = 0; i < second; i++)
            {
                returnValue = returnValue * (int)first;
            }
            return returnValue;

        }
    }
}
