using System;
using System.Collections.Generic;
using System.Text;

namespace PersonExample
{
    public class Address
    {
        private string houseName = "";
        private string streetName = "";
        private string cityName = "";
        private string Postcode = "";
       

        public void SetHouseName (string TheHouseName)
        {
            houseName = TheHouseName;
        }
        public string GetHouseName()
        {
            return houseName;
        }
        public void  SetStreetName (string TheStreet )
        {
            streetName = TheStreet;
        }
        public string GetStreetName()
        {
            return streetName;
        }
        public void SetCityName (string TheCityName)
        {
            cityName = TheCityName;
        }
        public  string GetCityName()
        {
            return cityName; 
        }
        public void SetPostcode (string ThePostcode)
        {
            Postcode = ThePostcode;
        }
        public string GetPostcode()
        {
            return Postcode;
        }
    }
}
