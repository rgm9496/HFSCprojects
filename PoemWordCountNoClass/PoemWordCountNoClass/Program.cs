using System;

namespace PoemWordCounter
{
    public class Program
    {

        static void Main(string[] args)
        {
            WordCounter dictionary = new WordCounter(100);
            string currentWord = "";

            Console.WriteLine("Enter you words, one per line, ending with STOP");

           
            while (currentWord != "STOP")
            {
                currentWord = Console.ReadLine();
                if (currentWord != "STOP")
                {
                    dictionary.AddString(currentWord);
                }
            }
            
            Console.WriteLine(dictionary);
            Console.ReadLine();
        }
    }
}





