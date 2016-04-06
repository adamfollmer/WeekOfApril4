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
            //SystemString test1 = new SystemString("test");
            // test1.Insert(2, "adam");
            // Console.WriteLine(test1);

            //SystemArrayString Tests
            //char[] test = { 'A', 'D', 'A','M','F' };
            //SystemArrayString test2 = new SystemArrayString(test);
            //test2.Remove(3, 1);
            //Console.WriteLine(test2);

            //SystemLinkedListString Tests
            LinkedList<char> test = new LinkedList<char>();
            test.AddLast('D');
            test.AddLast('A');
            test.AddLast('M');
            test.AddFirst('A');
            SystemLinkedListString test3 = new SystemLinkedListString(test);
            //string printTest3 = test3.ToString();
            //test3.Insert(0, "fo");
            //test3.Remove(1, 3);
            //Console.WriteLine(test3.ToString());
            Console.WriteLine(test3.Length());




            
            Console.ReadLine();


            //test + adam = teadamst
        }
    }
}
