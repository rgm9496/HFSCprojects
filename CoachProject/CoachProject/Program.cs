using System;

namespace CoachProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Coach myCoach = new Coach();
            for (int i = 0; i < 52; i++) 
            {
                Person p = new Person();

                Console.WriteLine(" Enter Name ");

                p.SetName(Console.ReadLine());

                if (myCoach.AddPerson(p) == true)
                
                Console.WriteLine("success");
                else

                Console.WriteLine("false");
                
                        
            }
        }
    }
}
