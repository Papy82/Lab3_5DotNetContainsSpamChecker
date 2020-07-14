using System;

namespace Lab3_5DotNetContainsSpamChecker
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World Lab3_5DotNetContainsSpamChecker!");

            string blackListWord = "Fudge";
            bool isSpam = false;

            string message = Console.ReadLine();

            if (message.Contains(blackListWord))
            {
                isSpam = true;
                Console.WriteLine("The message is spam.");
            }
            else
            {
                isSpam = false;
                Console.WriteLine("The message is not spam.");
            }

        }
    }
}