using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindThirdNumberByPythagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Enter the First Value ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Value ");
            b = double.Parse(Console.ReadLine());
            c = Math.Sqrt(a * a + b * b);
            Console.WriteLine("The Other Number is : {0}", c);
            Console.ReadLine();
        }
    }
}
