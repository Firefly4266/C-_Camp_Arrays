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
            int i = 0;
            Console.Write("\n Enter the words in you sentence 1 by 1 followed by <enter>: ");
            while (i < words.Length)
            {
                words[i] = Console.ReadLine();
                i++;
                int entriesLeft = userInput - i;
                while (entriesLeft != 0)
                {
                    Console.Write($"\n You have {userInput - i} words left to input: ");
                    break;
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
