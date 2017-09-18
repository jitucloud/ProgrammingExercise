using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringUsingBuiltInFunctions
{
    public static class CustomStringParser
    {
        public static String ReverseString(String input)
        {
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static String UpparCaseFirstWordOfString(String input)
        {
            return char.ToUpper(input[0]) + input.Substring(1);
        }

    }
}
