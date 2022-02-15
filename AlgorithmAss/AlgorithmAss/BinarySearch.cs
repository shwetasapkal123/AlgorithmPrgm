using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAss
{
    internal class BinarySearch
    {
        public static void SearchWord()
        {

            FileStream fileStream = new FileStream(@"C:\Users\SearchFile.txt", FileMode.Open, FileAccess.Read);
            Console.WriteLine("Searching word in the filepath C:/Users/SearchFile.txt");
            StreamReader reader = new StreamReader(fileStream);
            string record;
            string input;
            Console.WriteLine("Enter word to search");
            input = Console.ReadLine();
            try
            {
                record = reader.ReadLine();
                while (record != null)
                {
                    if (record.Contains(input))
                    {
                        Console.WriteLine("word present in the file");
                        SearchWord();
                    }
                    else
                    {
                        Console.WriteLine("word not present");
                        break;
                    }

                    record = reader.ReadLine();
                }
            }
            finally
            {
                reader.Close();
                fileStream.Close();
            }
        }

        public static void WordArray()
        {
            string[] words = null;
            FileStream fileStream = new FileStream(@"C:\Users\SearchFile.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            string filepath = @"C:\Users\SearchFile.txt";
            if (File.Exists(filepath))
            {
                words = File.ReadAllText(filepath).Split(',');
            }
            Array.Sort(words);
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("Enter word to search");
            string searchWord = Console.ReadLine();
            string record = reader.ReadLine();
            while (searchWord != null)
            {
                if (record.Contains(searchWord))
                    Console.WriteLine("Word present");
                else
                {
                    Console.WriteLine("word not present");
                    reader.Close();
                    fileStream.Close();
                    break;
                }
                record = reader.ReadLine();
            }

        }
    }
}
