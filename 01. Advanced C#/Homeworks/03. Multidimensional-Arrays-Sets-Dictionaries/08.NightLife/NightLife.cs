using System;
using System.Collections.Generic;

class NightLife
{
    static void Main()
    {
        Dictionary<string, SortedDictionary<string, SortedSet<string>>> nightLife = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

        while (true)
        {
            string input = Console.ReadLine();
            string[] data;

            if (input != "END")
            {
                data = input
                    .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                string city = data[0];
                string venue = data[1];
                string performer = data[2];

                if (!nightLife.ContainsKey(city))
                {
                    SortedSet<string> performers = new SortedSet<string>();
                    performers.Add(performer);

                    SortedDictionary<string, SortedSet<string>> venues = new SortedDictionary<string, SortedSet<string>>();
                    venues.Add(venue, performers);

                    nightLife.Add(city, venues);
                }

                else if (nightLife.ContainsKey(city))
                {
                    if (!nightLife[city].ContainsKey(venue))
                    {
                        SortedSet<string> performers = new SortedSet<string>();
                        performers.Add(performer);

                        nightLife[city].Add(venue, performers);
                    }
                    else if (nightLife[city].ContainsKey(venue))
                    {
                        nightLife[city][venue].Add(performer);
                    }
                }
            }
            else
            {
                break;
            }
        }

        foreach (var pair1 in nightLife)
        {
            Console.WriteLine(pair1.Key);
            foreach (var pair2 in pair1.Value)
            {
                Console.WriteLine("->{0}: {1}", pair2.Key, string.Join(", ", pair2.Value));
            }
        }
    }
}