using System;
using System.Collections.Generic;

namespace AnarBalacayevTeacherTasks
{
    internal class Planet
    {
        public int PlanetId { get; set; }
        public string Name { get; set; }
        public int Area { get; set; }
        private List<Country> Countries = new List<Country>();

        public Planet(int planetId, string name, int area)
        {
            PlanetId = planetId;
            Name = name;
            Area = area;
        }

        public void AddCountry(Country country)
        {
            Countries.Add(country);
        }

        public void ShowCountries()
        {
            if (Countries.Count == 0)
            {
                Console.WriteLine("No countries in this planet.");
                return;
            }
            foreach (var country in Countries)
            {
                Console.WriteLine($"Country: {country.CountryName}, Area: {country.Area}, Anthem: {country.Anthem}");
            }
        }
    }
}
