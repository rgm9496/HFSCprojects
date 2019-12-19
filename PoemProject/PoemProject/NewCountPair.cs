using System;
using System.Collections.Generic;
using System.Text;

namespace PoemWordCounter
{
    public class WordCountPair
    {
        private String word;
        private int count;


        

        // SetWord allows a user to set the Word element of Word Count pair
        public void SetWord(String theWord)
        {
            word = theWord;

        }

        // SetCount allows a user to set the Count element of Word Count pair
        public void SetCount(int theCount)
        {
            count = theCount;
        }

        // GetWord allows a user to get the Word element of Word Count pair
        public String GetWord()
        {
            Console.ReadLine();
            return word;
        }

        // GetCount allows a user to get the Count element of Word Count pair
        public int GetCount()
        {
            return count;
        }



    }
}

