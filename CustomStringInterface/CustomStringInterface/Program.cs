using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //SystemString Tests
            SystemString test1 = new SystemString("the");
            // test1.Insert(2, "adam");
            Console.WriteLine(test1);

            //SystemArrayString Tests
            SystemArrayString test2 = new SystemArrayString("Hello");
            //test2.Remove(3, 1);
            Console.WriteLine(test2.ToString());
            Console.WriteLine(test2.Length());

            //SystemLinkedListString Tests
            SystemLinkedListString test3 = new SystemLinkedListString("Adam");
            //string printTest3 = test3.ToString();
            //test3.Insert(0, "fo");
            //test3.Remove(1, 3);
            Console.WriteLine(test3.ToString());
            Console.WriteLine(test3.Length());
            //Console.WriteLine(test3.Length());

            //CustomLinkedList
            CustomLinkedListString test4 = new CustomLinkedListString("Follmer");
            //test4.Insert(4, "fo"); 
            //test4.Remove(4, 0);
            Console.WriteLine(test4.ToString());

            //Systems.Collections.SortedList
            SortedList<int, ICustomString> sortedStringList = new SortedList<int, ICustomString>();
            sortedStringList.Add(test1.Length(), test1);
            sortedStringList.Add(test2.Length(), test2);
            sortedStringList.Add(test3.Length(), test3);
            sortedStringList.Add(test4.Length(), test4);
            for (int i = 0; i < sortedStringList.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i, sortedStringList.ElementAt(i));
            }
            
            Console.ReadLine();


            //test + adam = teadamst
        }
    }
}
