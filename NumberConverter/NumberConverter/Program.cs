
using System;

namespace NumberConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Number Converter!");
            Console.WriteLine("Enter '1' to convert number to words.");
            Console.WriteLine("Enter '2' to convert words to number.");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                ConvertNumberToWords();
            }
            else if (choice == "2")
            {
                ConvertWordsToNumber();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

        static void ConvertNumberToWords()
        {
            Console.Write("Enter a number: ");
            string numberStr = Console.ReadLine();
            int number;
            if (int.TryParse(numberStr, out number))
            {
                string words = NumberToWords(number);
                Console.WriteLine($"Words: {words}");
            }
            else
            {
                Console.WriteLine("Invalid number format. Please try again.");
            }
        }

        static void ConvertWordsToNumber()
        {
            Console.Write("Enter words: ");
            string words = Console.ReadLine();
            int number = WordsToNumber(words);
            Console.WriteLine($"Number: {number}");
        }

        static string NumberToWords(int number)
        {
           
            return "Number to words conversion placeholder";
        }

        static int WordsToNumber(string words)
        {
            
            return -1;
            
        }
        
    }
}
