using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringInterface
{
    class CustomLinkedListString : ICustomString
    {
        CustomLinkedList<char> baseLinkedList = new CustomLinkedList<char>();
        public CustomLinkedListString(string toConvert)
        {
            for (int i = 1; i < toConvert.Length; i++)
            {
                baseLinkedList.AddLast(toConvert[i]);
            }
            baseLinkedList.AddFirst(toConvert[0]);
        }
        public override string ToString()
        {
            if (baseLinkedList.List.Count == 0)
            {
                return "";
            }
            StringBuilder toString = new StringBuilder();
            foreach (char character in baseLinkedList)
            {
                toString.Append(character);
            }
            return toString.ToString();
        }
        public void Insert(int startIndex, string stringToInsert)
        {
            char[] charString = stringToInsert.ToCharArray();
            Node<char> indexNode;
            Node<char> holdNode;
            indexNode = baseLinkedList.Head;
            for (int i = 0; i < startIndex; i++)
            {
                holdNode = indexNode.Next;
                indexNode = holdNode;
            }
            if (startIndex == 0)
            {
                Array.Reverse(charString);
                foreach (char character in charString)
                {
                    baseLinkedList.AddBefore(baseLinkedList.Head, character);
                }
            }
            else if (startIndex == baseLinkedList.Count())
            {
                foreach (char character in charString)
                {
                    baseLinkedList.AddAfter(baseLinkedList.Tail, character);
                }
            }
            else
            {
                foreach (char charcter in charString)
                {
                    baseLinkedList.AddBefore(indexNode, charcter);
                }
            }
        }

        public int Length()
        {
            return baseLinkedList.Count();
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            Node<char> indexNode;
            Node<char> holdNode;
            indexNode = baseLinkedList.Head;
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
