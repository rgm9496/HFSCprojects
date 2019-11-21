using System;
using System.Collections.Generic;
using System.Text;

namespace CoachProject
{
    public class Address
    {
        private string townName = "";
        private string streetName = "";
        private int houseNumber = 0;
       

        public void SetTownName(string newtownname)
        {
            townName = newtownname;
        }

        public void SetStreetName(string newstreetname)
        {
            streetName = newstreetname;
        }

        public void SetHouseNumber(int newhousenumber)
        {
            houseNumber = newhousenumber;
        }

        public string GetTownName()
        {
            return townName;
        }

        public string GetStreetName()
        {
            return streetName;
        }

        public int GetHouseNumber()
        {
            return houseNumber;
        }

        public override string ToString()
        {
            return this.GetTownName() + " " + this.GetStreetName() + " " + this.GetHouseNumber();
        }
    }
}
