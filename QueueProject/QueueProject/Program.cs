using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueProject
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueCreep Queue = new QueueCreep();

            int option = 0;
            do
            {
                Console.WriteLine(" 1. Add person to queue. ");
                Console.WriteLine(" 2. remove person from queue. ");
                Console.WriteLine(" 3. length of queue. ");
                Console.WriteLine(" 4. display queue. ");
                Console.WriteLine(" 5. Quite. ");
                option = Convert.ToInt32(Console.ReadLine());

                switch(option)
                {
                    case 1:

                        break;

                    case 2:

                        break;

                    case 3:

                        break;

                    case 4:

                        break;

                    default:
                        Console.WriteLine("incorrect key entered");
                        break;

                      
                        
                }
            }while (option != 5);
        }
    }
}
