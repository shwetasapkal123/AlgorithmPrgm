using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAss
{
    public class PalindromePrime
    {
        public static bool Palindrome(int num)
        {
            int rem;
            int result = 0;
            if(num< 0)
                return false;
            while(num > 0)
            {
                //reversing the number
                rem = num % 10;
                num=num/10;
                result = (result+rem)*10;
            }
            result /= 10;
            if(result==num)
            return true;
            else
                return false;
        }
       
        

    }
}
