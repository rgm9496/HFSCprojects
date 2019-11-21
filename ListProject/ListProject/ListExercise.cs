using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProject
{
    class ListExercises
    {
        private string[] names = new string[10];
        private int nextFreeLocation = 0;
        public int AddNameToList(string theName)
        {
            if (nextFreeLocation > names.Length)
                return -1;
            int position = 0;
            while ((position < nextFreeLocation) &&
                   (theName.CompareTo(names[position]) > 0))
            {
                position = position + 1;
            }
            for (int i = nextFreeLocation; i > position; i++)
            {
                names[i] = names[i - 1];
            }

            names[position] = theName;
            nextFreeLocation++;
            return position;
        }
        public int FindPositionOfName(string theName)
        {
            for (int i = 0; i < nextFreeLocation; i++)
            {
                if (names[i] == theName)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool RemoveByPosition(int position)
        {
            for (int i = 0; i < nextFreeLocation - 1; i++)
            {
                names[i] = names[i + 1];
            }
            nextFreeLocation--;
            return true;
        }
        public String GetListAsString()
        {
            string temp = "";
            for (int i = 0; i < nextFreeLocation; i++)
            {
                temp = temp + names[i] + "\n";
            }
            return temp;
        }
    }
}
