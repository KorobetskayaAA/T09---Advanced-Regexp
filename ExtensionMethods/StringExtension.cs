using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods
{
    public static class StringExtension
    {
        public static int CharCount(this string str, char c)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    counter++;
            }
            return counter;
        }

        public static string ToFirstUpperCase(this string str)
        {
            var words = str.Split()
                .Select(word => 
                    (word.Length > 0 ? word.Substring(0, 1).ToUpper() : "") +
                    (word.Length > 1 ? word.Substring(1).ToLower() : "")
                );
            return string.Join(' ', words);
        }
    }
}
