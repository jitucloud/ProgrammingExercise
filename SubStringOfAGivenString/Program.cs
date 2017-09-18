using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubStringOfAGivenString
{
    class Program
    {

        string value;
        int j, i;
        string[] a = new string[5];
        void input()
        {
            Console.WriteLine("Enter the String : ");
            value = Console.ReadLine();
            Console.WriteLine("All Possible Substrings of the Given String are :");
            for (i = 1; i <= value.Length; i++)
            {
                for (j = 0; j <= value.Length - i; j++)
                {
                    Console.WriteLine(value.Substring(j, i));
                }
            }
        }
        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.input();
            Console.ReadLine();
        }
    }
}
