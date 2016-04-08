using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInput;

namespace AdvancedCalculator
{
    public class Adder : IAdder
    {
        int? first = null;
        int? second = null;
        public Adder ()
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
        public int? Add()
        {
            if (first == null)
            {
                return null;
            }
            return first + second;
        }
    }
}
