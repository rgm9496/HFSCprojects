using System;

namespace computer_guess
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int intNumber;

            int intGuess;
            int intCount;

            intNumber = rnd.Next(1, 11);
            intCount = 0;
            do
            {
                intCount = intCount + 1; 
             Console.WriteLine("Enter your guess between 1 and 10");

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
               
                Console.WriteLine("You got it in  " + intCount + "  guesses");

             }

        }while (intGuess != intNumber);

            Console.ReadLine();

        }
    }
}
