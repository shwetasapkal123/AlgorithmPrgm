using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAss
{
    public class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine("Choose an option ");
            Console.WriteLine("1.Permutations of string\t2.Binary search word from word list\t3.Insertion sort\t4.Bubble sort\t5.Anagram of string\t6.Prime number and palindrome prime number");
            int option=Convert.ToInt32(Console.ReadLine());
            //bool flag = true;
            switch (option)
            {                
               case 1:
                    Console.WriteLine("Enter string for permutation: ");
                    string arr = Console.ReadLine();
                    Console.WriteLine("Permutation of string is: ");
                    //Using Iterative Method
                    Permutations.PerformPermutation(arr, 0, arr.Length - 1);

                    //using method
                    Console.WriteLine("Enter first string:");
                    string arr1 = Console.ReadLine();
                    Console.WriteLine("Enter second string:");
                    string arr2 = Console.ReadLine();
                    CheckArrayString.CheckString(arr1, arr2);
                    Console.WriteLine("string is" + CheckArrayString.CheckString(arr1, arr2));
                    break;
               case 2:
                    BinarySearch.SearchWord();

                    BinarySearch.WordArray();
                    Console.WriteLine();
                    break;
                case 3:
                    InsertionSort.DisplayArrayUsingSort();
                    break;
                case 4:
                    Console.WriteLine("Wel-Come in Bubble Sort");
                    Console.WriteLine("Enter Ten names");
                    int[] arrInt = new int[7];
                    for (int i = 0; i < arrInt.Length; i++)
                    {
                        arrInt[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    BubbleSort.DisplayUsingBubbleSort(arrInt);
                    Console.WriteLine("Sorted Array is: ");
                    BubbleSort.printArray(arrInt);
                    break;
                case 5:
                    Console.WriteLine("WelCome in Anagram: ");
                    Console.WriteLine("enter first string");
                    string str1 = Console.ReadLine();
                    Console.WriteLine("Enter second string");
                    string str2 = Console.ReadLine();
                    AnagramString.CheckingAnagram(str1, str2);
                    Console.WriteLine("Is strings are Anagram?\n" + AnagramString.CheckingAnagram(str1, str2));
                    break;
                case 6:
                    PrimeNumbers.findPrimeNumber();
                    break;
                default:
                    Console.WriteLine("Incorrect option choosed");
                    //flag=false; 
                    break;
            }
            //if(flag==false)
            //{
            //    Console.WriteLine("choose some option");
            //    flag = true;
            //}
            Console.ReadLine();
        }
    }
}
