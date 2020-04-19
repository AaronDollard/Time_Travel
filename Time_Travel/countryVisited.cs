using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Travel
{
    class countryVisited : IComparable<countryVisited>
    {
        public string countryName { get; set; }
        public string countryNotes { get; set; }
        public int visitedCounter { get; set; }

        public countryVisited(string countryName, string countryNotes, int visitedCounter)
        {
            this.countryName = countryName;
            this.countryNotes = countryNotes;
            this.visitedCounter = visitedCounter;
        }

        public override string ToString()
        {
            return $"{countryName}";
        }

        public int CompareTo(countryVisited other)
        {
            return countryName.CompareTo(other.countryName);
        }
        public virtual List<countryVisited> travelHistory { get; set; }
    }
}
