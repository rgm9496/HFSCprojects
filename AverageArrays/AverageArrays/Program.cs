using System;

namespace AverageArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            int total = 0;
            int average = 0;
            int lessThanTotal = 0;

            for (int i = 0; i < 10; i ++)
            {
                Console.WriteLine(" please enter number ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
                total = total + nums[i];
            }
            average = total / 10;

            for (int i = 0; i > 10; i ++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
                lessThanTotal = nums[i] < average
            }



        }
    }
}
