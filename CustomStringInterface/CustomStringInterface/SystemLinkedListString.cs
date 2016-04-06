using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringInterface
{
    class SystemLinkedListString : ICustomString
    {
        LinkedList<char> baseLinkedList = new LinkedList<char>();
        public SystemLinkedListString(string toConvert)
        {
            for (int i = 1; i < toConvert.Length; i++)
            {
                baseLinkedList.AddLast(toConvert[i]);
            }
            baseLinkedList.AddFirst(toConvert[0]);
        }
        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            foreach (char character in baseLinkedList)
            {
                toString.Append(character);
            }
            return toString.ToString();
        }
        public void Insert(int startIndex, string stringToInsert)
        //Still am bugging out at the end of the linkedList
        {
            char[] charString = stringToInsert.ToCharArray();
            LinkedListNode<char> indexNode;
            LinkedListNode<char> holdNode;
            indexNode = baseLinkedList.First;
            for (int i = 0; i < startIndex; i++)
            {
                holdNode = indexNode.Next;
                indexNode = holdNode;
            }
            if (startIndex == baseLinkedList.Count())
            {
                foreach (char character in charString)
                {
                    baseLinkedList.AddAfter(baseLinkedList.Last, character);
                }

            }
            else
            {
                foreach (char character in charString)
                {
                    baseLinkedList.AddBefore(indexNode, character);
                }
            }

        }

        public int Length()
        {
            return baseLinkedList.Count;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            LinkedListNode<char> indexNode;
            LinkedListNode<char> holdNode;
            indexNode = baseLinkedList.First;
            for (int i = 0; i < startIndex; i++)
            {
                holdNode = indexNode.Next;
                indexNode = holdNode;
            }
            for (int i = 0; i < numCharsToRemove; i++)
            {
                holdNode = indexNode;
                holdNode = holdNode.Next;
                baseLinkedList.Remove(indexNode);
                indexNode = holdNode;
            }

        }
    }
}
