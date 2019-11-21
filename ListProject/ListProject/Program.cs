using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProject
{
    public class Program
    {
        public static void Main(String[] args)
        {
            ListExercises myList = new ListExercises();
            Console.WriteLine("Enter 10 names, one per line");
            for (int i = 0; i < 10; i++)
            {
                myList.AddNameToList(Console.ReadLine());
            }
            Console.WriteLine("Results are " + myList.GetListAsString());
            Console.ReadLine();
        }
    }
}
