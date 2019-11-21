using System;
using System.Collections.Generic;
using System.Text;

namespace PersonExample
{
    public class Person

    {
        private string name = "";

        private int age = 0;
        private Address livesAt;



        public void SetName(string theName)
        {
            name = theName;
        }
        public string GetName()
        {
            return name;
        }
        public void SetAge(int theAge)
        {
            age = theAge;

        }
        public int GetAge()

        {
            return age;
        }
        public void SetLivesAt(Address theAddress)
        {
            livesAt = theAddress;
        }
        public Address  GetLivesAt()
        {
            return  livesAt ;
        }
        public override string ToString()
        {
            return this.GetName() + " is aged " + this.GetAge();
        }
    }
}
