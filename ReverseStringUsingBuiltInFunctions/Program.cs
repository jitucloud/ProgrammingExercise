using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringUsingBuiltInFunctions
{
    /// <summary>
    /// Reverse a given string and make the first word Upparcase
    /// </summary>
    class Program
    {
        //Input : are you sure you don't want to come for the party?
        //Output : Era Uoy Erus Uoy T'nod Tnaw Ot Emoc Rof Eht ?ytrap
        static void Main(string[] args)
        {
            String inputString = "are you sure you don't want to come for the party?";
            Console.WriteLine("Input String: " + inputString);
            StringBuilder sb = new StringBuilder();
            foreach (string s in inputString.Split(' ').ToArray())
            {
                sb.Append(CustomStringParser.UpparCaseFirstWordOfString(CustomStringParser.ReverseString(s) + " "));
            }
            Console.WriteLine("Output String: " + sb);
            Console.ReadLine();
        }
    }
}
