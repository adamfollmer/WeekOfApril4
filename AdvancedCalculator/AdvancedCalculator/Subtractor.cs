using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    public class Subtractor : ISubtractor
    {
        int? first = null;
        int? second = null;
        public Subtractor()
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
        public int? Subtract()
        {
            if (first == null)
            {
                return null;
            }
            return first - second;
        }
    }
}
