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
            Console.WriteLine(test2.ToString());
            //test2.Insert(0, "CHECK"); //inserting at far left
            //test2.Insert(5, "CHECK"); //inserting at far right
            //test2.Insert(2, "CHECK"); //inserting in the middle
            //test2.Remove(3, 2); //removing final letters
            //test2.Remove(0, 2); //removing at start
            //test2.Remove(0, 5); //removing all letters
            //test2.Remove(1, 3); //removing some letters
            Console.WriteLine(test2.ToString());

            //SystemLinkedListString Tests
            SystemLinkedListString test3 = new SystemLinkedListString("Adam");
            Console.WriteLine(test3.ToString());
            //test3.Insert(0, "CHECK"); //inserting at far left
            //test3.Insert(4, "CHECK"); //inserting at far right
            //test3.Insert(2, "CHECK"); //inserting in the middle
            //test3.Remove(4, 5);
            //test3.Remove(2, 2); //removing final letters
            //test3.Remove(0, 2); //removing at start
            //test3.Remove(0, 4); //removing all letters
            //test3.Remove(1, 3); //removing some letters;
            Console.WriteLine(test3.ToString());
            //Console.WriteLine(test3.Length());

            //CustomLinkedList
            CustomLinkedListString test4 = new CustomLinkedListString("Follmer");
            Console.WriteLine(test4.ToString());
            //test4.Insert(0, "CHECK"); //inserting at far left
            //test4.Insert(7, "CHECK"); //inserting at far right
            //test4.Insert(2, "CHECK"); //inserting in the middle
            //test4.Remove(5, 2); //removing final letters
            //test4.Remove(0, 2); //removing at start
            //test4.Remove(0, 7); //removing all letters
            //test4.Remove(1, 3); //removing some letters;
            Console.WriteLine(test4.ToString());

            //Systems.Collections.SortedList
            //SortedList<int, ICustomString> sortedStringList = new SortedList<int, ICustomString>();
            //sortedStringList.Add(test1.Length(), test1);
            //sortedStringList.Add(test2.Length(), test2);
            //sortedStringList.Add(test3.Length(), test3);
            //sortedStringList.Add(test4.Length(), test4);
            //for (int i = 0; i < sortedStringList.Count; i++)
            //{
            //    Console.WriteLine("{0}. {1}", i, sortedStringList.ElementAt(i));
            //}

            Console.ReadLine();
        }
    }
}
