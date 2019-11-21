using System;
using System.Collections.Generic;
using System.Text;

namespace CoachProject
{
    public class Person
    {
        private String name = "";
        private int age = 0;
        private String livesAt = "";



        public void SetLivesAt(string newLivesAt)
        {
            livesAt = newLivesAt;
        }
        public void SetName(string newName)
        {
            name = newName;
        }
        public void SetAge(int newAge)
        {
            age = newAge;
        }
        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }
        public string GetLivesAt()
        {
            return livesAt;
        }
        public override string ToString()
        {
            return this.GetName() + " is aged " + this.GetAge() + "lives in" + this.GetLivesAt();
        }
    }
}
