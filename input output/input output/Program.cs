using System;

namespace input_output
{
    class Program
    {
         static void Main(string[]args)
        {
            int firstnumber = 0;

            int secondnumber = 0;

            int thirdnumber = 0;

            Console.WriteLine("enter first number:");

            firstnumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number:");

            secondnumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter third number:");

            thirdnumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("your total is {0}",

            firstnumber + secondnumber + thirdnumber);

            Console.ReadLine();
          
        }
    } 

}
