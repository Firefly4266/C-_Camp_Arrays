using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n Greetings user, we would like you to type a sentence. How many words are in your sentence? ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            string[] words = new string[userInput];
            int i;
            Console.Write("\n Enter the words in you sentence 1 by 1 followed by <enter>: ");
            for (i = 0; i < words.Length; i++)
            {
                words[i] = Console.ReadLine();
                int entriesLeft = (userInput - i) - 1;
                if (entriesLeft != 0)
                {
                    Console.Write($"\n You have {entriesLeft} words left to input: ");
                }
            }
            Console.WriteLine();
            foreach (string word in words)
            {
                Console.Write($"{word} ");
            }
            Console.WriteLine("\n");
        }
    }
}
