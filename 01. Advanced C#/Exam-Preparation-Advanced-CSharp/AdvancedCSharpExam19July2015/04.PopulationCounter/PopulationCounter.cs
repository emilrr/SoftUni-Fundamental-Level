namespace _04.PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class PopulationCounter
    {
        private static void Main(string[] args)
        {
            Dictionary<String, Dictionary<string, long>> collector =
                   new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input.Equals("report"))
                {
                    break;
                }

                string[] information = input.Split('|');
                string city = information[0];
                string country = information[1];
                int population = int.Parse(information[2]);

                if (!collector.ContainsKey(country))
                {
                    collector.Add(country, new Dictionary<string, long>());
                }

                collector[country].Add(city, population);
            }

            var sortedCollector = collector.OrderByDescending(x => x.Value.Sum(y => y.Value));

            foreach (var countryInfo in sortedCollector)
            {
                long totalPopulation = countryInfo.Value.Sum(x => x.Value);
                Console.WriteLine("{0} (total population: {1})", countryInfo.Key, totalPopulation);

                var orderedCityData = countryInfo.Value.OrderByDescending(x => x.Value);

                foreach (var cityInfo in orderedCityData)
                {
                    Console.WriteLine("=>{0}: {1}", cityInfo.Key, cityInfo.Value);
                }
            }
        }
    }
}
