using System;

namespace Conversation_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string userName = "Beckie";

            int userAge = 16;

            int currentYear = 2019;

            Console.Write("Please enter your name: ");

            userName = Console.ReadLine();

            Console.Write("Please enter your age: ");

            userAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the current year: ");

            currentYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello {beckie}. Your age is {16}, and you were born in {2003}.",

            userName, userAge, currentYear - userAge);

            Console.ReadLine();

        }
    }
}

