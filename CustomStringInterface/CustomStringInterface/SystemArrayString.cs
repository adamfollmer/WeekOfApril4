using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringInterface
{
    class SystemArrayString : ICustomString
    {
        char[] baseArray;
        public SystemArrayString(string toConvert)
        {
            baseArray = toConvert.ToCharArray();
        }
        public override string ToString()
        {
            return new string(baseArray);
        }
        public void Insert(int startIndex, string stringToInsert)
        {
            char[] toAdd = stringToInsert.ToCharArray();
            int insertedArrayLength = toAdd.Length + baseArray.Length;
            char[] insertedArray = new char[insertedArrayLength];
            for (int i = 0; i < startIndex; i++)
            {
                insertedArray[i] = baseArray[i];
            }
            int j = 0;
            for (int i = startIndex; i < (startIndex + stringToInsert.Length); i++)
            {
                insertedArray[i] = toAdd[j];
                j++;
            }
            for (int i = (startIndex + stringToInsert.Length); i < insertedArrayLength; i++)
            {
                insertedArray[i] = baseArray[i - stringToInsert.Length];
            }
            baseArray = insertedArray;
        }

        public int Length()
        {
            return baseArray.Length;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            if (startIndex+numCharsToRemove > baseArray.Length)
            {
                Console.WriteLine("Illegal move");
                return;
            }
            int newArrayLength = baseArray.Length - numCharsToRemove;
            char[] removedArray = new char[newArrayLength];
            for (int i = 0; i < startIndex; i++)
            {
                removedArray[i] = baseArray[i];
            }
            if (startIndex + numCharsToRemove == baseArray.Length)//Checking to see if items removed ends the list
            {
                baseArray = removedArray;
            }
            else
            {
                for (int i = startIndex; i < newArrayLength; i++)
                {
                    removedArray[i] = baseArray[i + numCharsToRemove];
                }
                baseArray = removedArray;
            }
        }
    }
}