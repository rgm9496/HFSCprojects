using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueProject
{
    class QueueCreep
    {
        public int length = 0;
        public int front = 0;
        public int back = 0;
        private string[] contents;

        public int Length()
        {
            return length; //finding the length and returning the interger
        }

        public void Add(string theName)
        {
            if (length == 0)
                contents[front] = theName; // using the loaction of front ,as there are no values inside the queue ,and then adding it in the new values  
            else
            {
               
                back = back + 1; // and then if the next free space isnt at front you then need to increment the back of the quqe to then create room for then next values into the queue
                contents[back] = theName; //this then creates a way tot hen refrence the value later on as theName instead of the work back as back has now been changed 
            }
            length = length + 1; // length of the queue is then increased by one as new values have been added to the queue
        }
        public string Remove()
        {
            string temp = contents[front];// create a temparary variable to store the front value as it will change once we have removed a name from the queue
            length = length - 1; // need to decrease the length value as a name has been removed 
            front = front + 1;
            return temp;// returns the original value of the front to return the name that was in the queue so it tells you "who" has left the queue
        }
        
        public void Display()
        {
            for (int i = front; i < back; i++) // this will find out that if the queue has more then 0 names in, it will wrie out what is in the queue
              Console.WriteLine(i);

        }
    }
}
