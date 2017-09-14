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
            Console.Write("\n Greetings user, how many words would you like to store? ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            string[] words = new string[userInput];
            int i = 0;
            while (i < words.Length)
            {
                Console.Write("\n Enter the words you want to store. ");
                words[i] = Console.ReadLine();
                i++;
            }
        }
    }
}
