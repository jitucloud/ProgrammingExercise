using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringWithOutUsingBuiltInFunctions
{
    public static class CustomStringParser
    {
        /// <summary>
        /// Reverse given word
        /// </summary>
        /// <param name="word"></param>
        /// <returns>String</returns>
        public static string ReverseGivenWord(char[] word)
        {
            char[] text = word;
            string reverse = string.Empty;
            foreach (char ch in text)
            {
                if (ch != '\0')
                {
                    reverse = ch + reverse;
                }
            }
            return reverse.ToString().Trim();

        }
        /// <summary>
        /// Find length of String
        /// </summary>
        /// <param name="str"></param>
        /// <returns>Int</returns>
        public static int FindStringLength(String str)
        {
            int numberOfLetters = 0;
            foreach (var c in str)
            {
                numberOfLetters++;
            }
            return numberOfLetters;
        }
    }
}
