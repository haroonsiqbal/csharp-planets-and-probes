using System;
using System.Collections.Generic;

namespace planets_and_probes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };

            List<KeyValuePair<string, string>> probeDestinations = new List<KeyValuePair<string, string>>();

            probeDestinations.Add(new KeyValuePair<string, string>("Viking 1", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Mariner 1", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Voyager 1", "Jupiter"));
            probeDestinations.Add(new KeyValuePair<string, string>("Voyager 1", "Saturn"));
            probeDestinations.Add(new KeyValuePair<string, string>("Mariner 10", "Mercury"));
            probeDestinations.Add(new KeyValuePair<string, string>("Messenger", "Mercury"));
            probeDestinations.Add(new KeyValuePair<string, string>("Mariner 1", "Venus"));
            probeDestinations.Add(new KeyValuePair<string, string>("Mariner 10", "Venus"));
            probeDestinations.Add(new KeyValuePair<string, string>("Voyager 2", "Uranus"));
            probeDestinations.Add(new KeyValuePair<string, string>("Voyager 2", "Neptune"));
            probeDestinations.Add(new KeyValuePair<string, string>("Pioneer 10", "Jupiter"));
            probeDestinations.Add(new KeyValuePair<string, string>("Pioneer 11", "Jupiter"));
            probeDestinations.Add(new KeyValuePair<string, string>("Pioneer 11", "Saturn"));
            probeDestinations.Add(new KeyValuePair<string, string>("Voyager 2", "Saturn"));

            // Iterate planets
            foreach (string planet in planetList)
            {
                // List to store probes that visited the planet
                List<string> matchingProbes = new List<string>();

                // Iterate probeDestinations
                foreach (KeyValuePair<string, string> destination in probeDestinations)
                {
                    /*
                        Does the current probe's destination
                        match the value of the `planet` variable?
                        If so, add it to the list.
                    */
                    if (destination.Value == planet) {
                        matchingProbes.Add(destination.Key);
                    }

                }

                /*
                    Use String.Join(",", matchingProbes) as part of the
                    solution to get the output below. It's the C# way of
                    writing `array.join(",")` in JavaScript.
                */
                Console.WriteLine($"{planet}: {String.Join(", ", matchingProbes)}");
            }


        }
    }
}
