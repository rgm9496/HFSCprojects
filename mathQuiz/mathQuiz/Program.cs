using System;

namespace mathQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int Minimum = 10;
            int Maximum = 50;

            int NUM1 ;
            int NUM2 ;
            int answer;


           

            for (int NUM = 0; NUM < 10; NUM++)

            {
               
                NUM1 = rnd.Next(Minimum, Maximum);
                NUM2 = rnd.Next(Minimum, Maximum);
                Console.WriteLine("what is the sum of {0}+{1}", NUM1, NUM2);
                 answer = Convert.ToInt32(Console.ReadLine());
                if (answer == (NUM1 + NUM2))
                {
                    Console.WriteLine("correct");
                }
                else
                {
                    Console.WriteLine("incorrect");
                }
               
                
            
            }
            Console.ReadLine();
        }

    }
}
