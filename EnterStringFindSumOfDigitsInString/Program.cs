using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterStringFindSumOfDigitsInString
{
    class Program
    {
        // Important point is how to retrive value from char array (charArray[count] - '0')

        static void Main(string[] args)
        {
            char[] charArray = new char[20];
            int count, nc = 0, sum = 0, n, i;
            Console.WriteLine("Enter the Length of the sentence  :");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the string1 containing both digits and alphabet :");
            for (i = 0; i < n; i++)
            {
                charArray[i] = Convert.ToChar(Console.Read());
            }
            Console.WriteLine("Entered String is: " + new string(charArray));

            for (count = 0; charArray[count] != '\0'; count++)
            {
                if ((charArray[count] >= '0') && (charArray[count] <= '9'))
                {
                    nc += 1;
                    sum += (charArray[count] - '0');
                }
            }
            Console.WriteLine("NO. of Digits in the string1 = {0}", nc);
            Console.WriteLine("Sum of all digits = {0}", sum);
            Console.ReadLine();
            Console.ReadLine();

        }
    }
}
