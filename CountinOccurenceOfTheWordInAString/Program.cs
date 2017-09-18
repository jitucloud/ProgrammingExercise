using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountinOccurenceOfTheWordInAString
{
    class Program
    {
        public static void Main()
        {
            string s1;
            Console.WriteLine("Enter the String : ");
            s1 = Console.ReadLine();
            Console.WriteLine(Counting.CountStringOccurrences(s1, "the"));
            Console.ReadLine();
        }
    }
}
