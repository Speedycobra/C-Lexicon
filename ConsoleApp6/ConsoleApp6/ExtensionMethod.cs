using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodTest
{
    public static class ExtensionMethod

    {
        public static long ToLong(this String strg) =>
            long.TryParse(strg, out long longtoreturn) ? longtoreturn : 0;


        
        public static double ToDouble(this String strg) =>
            double.TryParse(strg, out double doubletoreturn) ? doubletoreturn : 0;

        
        public static int WordCount(this String strg)

        {
            return strg.Split(new char[] { '.', ',', ' ', '?' },

            StringSplitOptions.RemoveEmptyEntries).Length;
        }


        public static string UppercaseWords(this string value)
        {
            char[] array = value.ToCharArray();
            // Handle the first letter in the string.
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }
            // Scan through the letters, checking for spaces.
            // ... Uppercase the lowercase letters following spaces.
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }

     }
}

