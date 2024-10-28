using System;
using System.Collections.Generic;
using System.Linq;

namespace AnarBalacayevTeacherTasks
{
    internal class Program
    {
        private static string selectedPlanet;
        private static List<Planet> planets = new List<Planet>();

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Write 1 for open system, write 0 for exit: ");
                if (!int.TryParse(Console.ReadLine(), out int num))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                if (num == 1)
                {
                    ShowInstructions();
                    HandlePlanetMenu();
                }
                else if (num == 0)
                {
                    Console.WriteLine("Exit");
                    break;
                }
                else
                {
                    Console.WriteLine("Type correct number");
                }
            }
        }

        public static void ShowInstructions()
        {
            Console.WriteLine("Write 1 for create a planet");
            Console.WriteLine("Write 2 for show planets");
            Console.WriteLine("Enter a planet name to choose a planet");
            Console.WriteLine("Type 0 for exit");
        }

        public static void HandlePlanetMenu()
        {
            while (true)
            {
                Console.Write("Select an option: ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.Write("Enter planet ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter planet name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter planet area: ");
                    int area = int.Parse(Console.ReadLine());

                    Planet planet = new Planet(id, name, area);
                    planets.Add(planet);
                    Console.WriteLine("Planet created.");
                }
                else if (input == "2")
                {
                    foreach (var planet in planets)
                    {
                        Console.WriteLine($"Planet: {planet.Name}");
                    }
                }
                else if (planets.Any(p => p.Name.Equals(input, StringComparison.OrdinalIgnoreCase)))
                {
                    selectedPlanet = input;
                    HandleCountryMenu(planets.First(p => p.Name.Equals(selectedPlanet, StringComparison.OrdinalIgnoreCase)));
                }
                else if (input == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Type correct number or planet name");
                }
            }
        }

        public static void HandleCountryMenu(Planet planet)
        {
            while (true)
            {
                Console.WriteLine($"Selected Planet: {planet.Name}");
                Console.WriteLine("1. Create a country");
                Console.WriteLine("2. Show countries");
                Console.WriteLine("3. Go back to the previous menu");
                Console.WriteLine("0. Exit");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.Write("Enter country ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter country name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter country area: ");
                    int area = int.Parse(Console.ReadLine());
                    Console.Write("Enter country anthem: ");
                    string anthem = Console.ReadLine();

                    Console.WriteLine("Select a region (1: Africa, 2: Asia, 3: CentralAmerica, 4: Europe, 5: MiddleEast, 6: NorthAmerica, 7: Pacific, 8: SouthAmerica): ");
                    if (int.TryParse(Console.ReadLine(), out int regionInput) && Enum.IsDefined(typeof(Country.Region), regionInput))
                    {
                        var country = new Country(id, name, area, anthem, (Country.Region)regionInput);
                        planet.AddCountry(country);
                        Console.WriteLine("Country created.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid region selection.");
                    }
                }
                else if (input == "2")
                {
                    planet.ShowCountries();
                }
                else if (input == "3")
                {
                    break;
                }
                else if (input == "0")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Type correct number");
                }
            }
        }
    }
}
