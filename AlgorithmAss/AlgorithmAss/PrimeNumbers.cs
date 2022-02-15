using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAss
{
     public class PrimeNumbers
    {
        public static void findPrimeNumber()
        {
            Console.WriteLine("WELCOME to Prime number program");
            Console.WriteLine("Please Enter starting number: ");
            int start=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter end number: ");
            int end=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime number between {0} and {1} are:  ",start,end);
            int count;
            for (int i = start; i <= end; i++)
            {
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        count = count + 1;
                }
                if (count == 2)
                {
                    Console.WriteLine("Prime number is  "+i + " ");
                    PalindromePrime.Palindrome(i);
                    Console.WriteLine("Is number "+i+" palindrome???  "+ PalindromePrime.Palindrome(i));
                }

            }
        }
    }
}
