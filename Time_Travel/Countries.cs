using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Travel
{
    public class Country
    {
        public enum Zone {Africa, Asia, Europe, Latin_America_and_Carribean, Oceania, North_America }

        //Properities
        public string Name { get; set; }
        public Zone CountryZone { get; set; }

        //Constructor
        public Country(string name, Zone countryzone)
        {
            Name = name;
            CountryZone = countryzone;
        }

        //ToString for the ListBox of countries
        public override string ToString()
        {
            return $"{Name}";
        }

        //Comapring the names of te countries to sort them by name
        public int CompareTo(Country other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
