using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int intNumber;

            int intGuess;

            intNumber = rnd.Next(0, 101);
            do

            {

                Console.WriteLine("Enter your guess between 1 and 100");

                 intGuess = Convert.ToInt32(Console.ReadLine());

                if (intGuess > intNumber)

                {

                    Console.WriteLine("Too High");

                }

                if (intGuess < intNumber)

                {

                    Console.WriteLine("Too Low");

                }

                if (intGuess == intNumber)

                {

                    Console.WriteLine("You got it!");

                }

            } while (intGuess != intNumber);
            Console.ReadLine();
        }
    }
}