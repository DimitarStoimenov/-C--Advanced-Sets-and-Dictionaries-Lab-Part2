using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop_Dictionaries_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> output = new Dictionary<string, Dictionary<string, List<string>>>();


            for (int i = 0; i < num; i++)
            {
                string command = Console.ReadLine();

                string continent = command.Split()[0];
                string country = command.Split()[1];
                string city = command.Split()[2];
                if (!output.ContainsKey(continent))
                {
                    output[continent] = new Dictionary<string, List<string>>();


                }
                if (!output[continent].ContainsKey(country))
                {
                    output[continent][country] = new List<string>();
                }
                output[continent][country].Add(city);



            }

            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var it in item.Value)
                {
                    Console.WriteLine($"{it.Key} -> {string.Join(", ", it.Value)}");
                }
            }
        }
    }
}

