using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringWithOutUsingBuiltInFunctions
{
    public class Program
    {
        static void Main(string[] args)
        {
            String sentence = "cat; and dog";
            Console.WriteLine("Input String: " + sentence);
            StringBuilder sb = new StringBuilder();
            char[] msg = sentence.ToCharArray();
            int i = 0, j = 0;
            int stringLength = CustomStringParser.FindStringLength(sentence);
            char[] str = new char[stringLength];

            while (i <= stringLength)
            {
                if (i == stringLength)
                {
                    sb.Append(CustomStringParser.ReverseGivenWord(str));
                }
                else if (msg[i] != ' ')
                {
                    str[j] = msg[i];
                    j++;
                }
                else
                {
                    str[j] = ' ';
                    sb.Append(CustomStringParser.ReverseGivenWord(str) + ' ');
                    j = 0;
                }
                i++;
            }
            Console.WriteLine("Output String: " + sb.ToString().Trim());
            Console.ReadLine();
        }
    }
}
