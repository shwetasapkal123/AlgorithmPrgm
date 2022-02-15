using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAss
{
    internal class CheckArrayString
    {
        public static bool CheckingGenString<T>(T[] str1, T[] str2) where T : IComparable
        {
            int res = str1.Length.CompareTo(str2.Length);
            //0 equal,1 greater,-1 lessthan
            if (res == -1)
                return false;
            else if (res == 1)
                return false;
            else if (res == 0)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i].Equals(str2[i]) == false)
                        return false;

                }
                // return true;

            }
            return true;
        }
        public static bool CheckString(string str1, string str2)
        {
            char[] arrChar1 = str1.ToCharArray();
            char[] arrChar2 = str2.ToCharArray();

            if (arrChar1.Length != arrChar2.Length)
                return false;
            // Console.WriteLine("string Not equal bcz length is different");

            if (arrChar1.Length == arrChar2.Length)
            {
                Array.Sort(arrChar1);
                Array.Sort(arrChar2);
                for (int i = 0; i < arrChar1.Length; i++)
                {
                    if (arrChar1[i] != arrChar2[i])
                    {
                        //Console.WriteLine("string is equal upto {0} char",i+1);
                        return false;
                    }
                }
                //Console.WriteLine("string is not equal");
                return true;
            }
            return false;

        }
    }
}
