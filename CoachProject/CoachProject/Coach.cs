using System;
using System.Collections.Generic;
using System.Text;

namespace CoachProject
{
    public class Coach
    {
        Person[] contents = new Person[52];
        public int nextFreeSeat = 0;
        public int nextFreeLocation = 0;


        public bool AddPerson(Person thePerson)
        {
           
                if (nextFreeLocation > 52)
                {
                    return false;
                }
                contents[nextFreeLocation] = thePerson;
                nextFreeLocation++;
                return true;       
        }

        public int GetSeatByName(string theName)
        {
            for (int i = 0; i < nextFreeLocation; i++)
            {
                if (contents[1].GetName() == theName)
                {
                    return i;
                }
            }
            return -1;
        }


        public bool RemovePerson(Person thePerson)
        {
            for (int i = 0; i < nextFreeLocation; i++)
            {
                if (contents)
                {
                    return
                }
            }
        }

        public int GetNumOfPassengers
        {

        }
        int location = GetNameBySeat(string theName)
        {
            contents[location]= Contents[nextFreeLocation - 1]
            nextFreeLocation --
        }   

        private class Contents
        {
        }
    }
}
