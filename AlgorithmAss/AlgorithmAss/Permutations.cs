using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAss
{
    public class Permutations
    {
        public static string SwapChar(string array, int startChar, int endChar)
        {
            char temp;
            char[] charArray = array.ToCharArray();
            temp = charArray[startChar];
            charArray[startChar] = charArray[endChar];
            charArray[endChar] = temp;
            string newStringForm = new string(charArray);
            return newStringForm;
            //Console.WriteLine(newStringForm);
        }

        public static void PerformPermutation(string str, int start, int end)
        {
            if (start == end)
                Console.WriteLine(str);

            else
            {
                for (int i = start; i <= end; i++)
                {
                    str = SwapChar(str, start, i);
                    PerformPermutation(str, start + 1, end);
                    str = SwapChar(str, start, i);
                }
            }
        }
    }
}
