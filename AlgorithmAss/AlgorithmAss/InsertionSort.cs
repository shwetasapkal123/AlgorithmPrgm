using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAss
{
    public class InsertionSort
    {
        public static void DisplayArrayUsingSort()
        {
            Console.WriteLine("Wel-Come in Insertion Sort");
            Console.WriteLine("Enter Ten names or whatever you want");

            string[] arrString = new string[10];//{"Shweta","Sapkal","Car","Pleasure","Scooty","Angry",};
            for (int i = 0; i < arrString.Length; i++)
            {
                arrString[i] = Console.ReadLine();
            }
            Array.Sort(arrString);
            foreach (string str in arrString)
            {
                Console.WriteLine("Printing Sorted Array List");
                Console.WriteLine(str);
            }
        }
    }
}
