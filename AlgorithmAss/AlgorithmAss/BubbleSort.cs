using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAss
{
    public class BubbleSort
    {
        public static void DisplayUsingBubbleSort(int[] arr)
        {
            int n=arr.Length;
            for(int i=0; i<=n-1; i++)
            {
                for(int j=0; j<n-i-1; j++)
                {
                    //Checking greater element
                    if(arr[j]>arr[j+1])
                    {
                        //swaping element in the order
                        int temp=arr[j];
                        arr[j]=arr[j+1];
                        arr[j+1]=temp;
                    }
                }
            }
           
        }
        public static void printArray(int[] arr)
        {
            int m=arr.Length;
            for (int k = 0; k < m; ++k)
            {
                Console.WriteLine(arr[k]);
                //Console.WriteLine();
            }
        }
    }
}
