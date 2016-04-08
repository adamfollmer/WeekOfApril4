using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    public class Divider : IDivider
    {
        int? first = null;
        int? second = null;
        public Divider()
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
        public int? Divide()
        {
            if (first == null)
            {
                return null;
            }
            return first / second;
        }
    }
}
