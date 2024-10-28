using System;
using System.Collections.Generic;

namespace AnarBalacayevTeacherTasks
{
    internal class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public int Area { get; set; }
        public string Anthem { get; set; }
        public Region CountryRegion { get; set; }

        public enum Region
        {
            Africa = 1,
            Asia,
            CentralAmerica,
            Europe,
            MiddleEast,
            NorthAmerica,
            Pacific,
            SouthAmerica,
        }

        public Country(int countryId, string countryName, int area, string anthem, Region region)
        {
            CountryId = countryId;
            CountryName = countryName;
            Area = area;
            Anthem = anthem;
            CountryRegion = region;
        }
    }
}
