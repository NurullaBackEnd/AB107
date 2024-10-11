using System;
using System.Collections.Generic;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] oldArray = { 1, 2, 3, 4, 5 };
                var newNumbers = new System.Collections.Generic.List<int>();
                Console.WriteLine("Add new element (enter 'q' for leaving):");
                while (true)
                {
                    string input = Console.ReadLine();
                    if (input.ToLower() == "q")
                        break;
                    if (int.TryParse(input, out int number))
                    {
                        newNumbers.Add(number);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a correct number.");
                    }
                }
                int[] newArray = new int[oldArray.Length + newNumbers.Count];
                oldArray.CopyTo(newArray, 0);
                newNumbers.CopyTo(newArray, oldArray.Length);
                Console.WriteLine("Old array: " + string.Join(", ", oldArray));
                Console.WriteLine("New array: " + string.Join(", ", newArray));
            }
        }
    }
}