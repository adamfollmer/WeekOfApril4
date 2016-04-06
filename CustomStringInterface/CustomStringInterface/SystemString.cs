using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringInterface
{
    class SystemString : ICustomString
    {
        string baseString;
        public SystemString (string baseString)
        {
            this.baseString = baseString;
        }
        public override string ToString()
        {
            return baseString.ToString();
        }
        public void Insert(int startIndex, string stringToInsert)
        {
            baseString = baseString.Insert(startIndex, stringToInsert);
        }

        public int Length()
        {
            return baseString.Length;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            baseString = baseString.Remove(startIndex, numCharsToRemove);
        }
    }
}
