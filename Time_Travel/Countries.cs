using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Time_Travel
{

    public class Country : IComparable<Country>
    {
        public enum Zone { Africa, Asia, Europe, Latin_America_and_Carribean, Oceania, North_America }

        //Properities
        public string CountryID { get; set; }
        public Zone CountryZone { get; set; }

        //Constructor
        public Country(string name, Zone countryzone)
        {
            CountryID = name;
            CountryZone = countryzone;
        }

        //ToString for the ListBox of countries
        public override string ToString()
        {
            return $"{CountryID}";
        }

        //Comapring the names of te countries to sort them by name
        public int CompareTo(Country other)
        {
            return CountryID.CompareTo(other.CountryID);
        }
        public virtual List<Country> WorldCountry { get; set; }

    }//End of the country class 

    //Subclasses of each zone in the world
    public class AfricanCountry : Country
    {
        public AfricanCountry(string name, Zone countryzone) : base(name, countryzone)
        {
        }
        public override string ToString()
        {
            return $"{CountryID} - Africa";
        }
    }

    public class AsianCountry : Country
    {
        public AsianCountry(string name, Zone countryzone) : base(name, countryzone)
        {
        }
        public override string ToString()
        {
            return $"{CountryID} - Asia";
        }
    }

    public class EuropeanCountry : Country
    {
        public EuropeanCountry(string name, Zone countryzone) : base(name, countryzone)
        {
        }
        public override string ToString()
        {
            return $"{CountryID} - Europe";
        }
    }

    public class LatinCaribbeanCountry : Country
    {
        public LatinCaribbeanCountry(string name, Zone countryzone) : base(name, countryzone)
        {
        }
        public override string ToString()
        {
            return $"{CountryID} - Latin America & Caribbean";
        }
    }

    public class OceanicCountry : Country
    {
        public OceanicCountry(string name, Zone countryzone) : base(name, countryzone)
        {
        }
        public override string ToString()
        {
            return $"{CountryID} - Oceanic";
        }
    }

    public class NorthAmericanCountry : Country
    {
        public NorthAmericanCountry(string name, Zone countryzone) : base(name, countryzone)
        {
        }
        public override string ToString()
        {
            return $"{CountryID} - North America";
        }
    }

    //Database code
    public class CountryData : DbContext
    {
        public CountryData() : base("WorldDatabase") { }
        public DbSet<Country> WorldCountry { get; set; }
    }
}
