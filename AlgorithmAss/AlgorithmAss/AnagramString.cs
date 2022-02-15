using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAss
{
    public class AnagramString
    {
        public static bool CheckingAnagram(string str1,string str2)
        {
            char[] arrChar1=str1.ToCharArray();
            char[] arrChar2=str2.ToCharArray();
           
            if(arrChar1.Length != arrChar2.Length) //Checking string Length not equal then not anagram
                return false;
            if(arrChar1.Length == arrChar2.Length)
            {
                Array.Sort(arrChar1);
                Array.Sort(arrChar2);
                for (int i = 0; i < arrChar1.Length; i++)
                {
                    if (arrChar1[i] != arrChar2[i])       //Checking elements of array equal or not
                        return false;
                }
                return true;
            }
            return false;
            
        }
    }
}
