using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "../flights.txt";

        private static void Main(string[] args)
        {
            var listOfFlights = new Dictionary<string, HashSet<string>>();
            var allCities = new HashSet<string>();
            var route = new Stack<string>();
            string startCity = "";
            bool found = false;
            
            var readText = File.ReadAllLines(Path);
            foreach (var s in readText)
            {
                if (s != "")
                {
                    var fromCity = s.Substring(0, s.IndexOf("-")-1);
                    var toCity = s.Substring(s.IndexOf(">")+2);
                    allCities.Add(fromCity);
                    allCities.Add(toCity);

                    if (listOfFlights.ContainsKey(fromCity))
                    {
                        for (var i = 0; i < listOfFlights.Count; i++)
                        {
                            if (listOfFlights.Keys.ElementAt(i) == fromCity)
                            {
                                listOfFlights[listOfFlights.Keys.ElementAt(i)].Add(toCity);
                                break;
                            }
                        }
                    }
                    else
                    {
                        listOfFlights.Add(fromCity, new HashSet<string>(){toCity});
                    }

                }
            }

            char input = ' ';
            bool findingRoute = false;
            do
            {
                //Console.Clear();
                Console.WriteLine("Ko Tu velies darit:");
                Console.WriteLine("Paradit pilsetas spied 1");
                Console.WriteLine("Lai izietu no programmas spied #");
                Console.Write(">");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine("");

                if (input == '1')
                {
                    if (!findingRoute)
                    {
                        ShowCities(allCities);
                        findingRoute = true;
                        do
                        {
                            //Console.Clear();
                            Console.WriteLine("Lai izveletos pilsetu uz kuru gribi lidot spied 1");
                            Console.WriteLine("Lai atgrieztos uz sakumu spied #");
                            Console.Write(">");

                            input = Console.ReadKey().KeyChar;
                            Console.WriteLine("");

                            if (input == '1')
                            {
                                if (route.Count == 0)
                                {
                                    ShowCities(allCities);
                                }
                                else
                                {
                                    ShowCities(listOfFlights[route.Peek()]);
                                }
                                Console.WriteLine("Izvelies pilsetu uz kuru lidosi");
                                Console.Write(">");
                                string nextCity = Console.ReadLine();

                                HashSet<string> aviableCities = route.Count>0 ? listOfFlights[route.Peek()] : allCities;
                                if (aviableCities.Contains(nextCity))
                                {
                                    if (route.Count == 0)
                                    {
                                        startCity = nextCity;
                                    }
                                    route.Push(nextCity);
                                    if (nextCity == startCity&&route.Count>1)
                                    {
                                        found = true;
                                    }
                                }
                            }

                            if (input == '#')
                            {
                                findingRoute = false;
                                route.Clear();
                            }

                        } while (input != '#'&&!found);
                    }
                }
            } while (input != '#'&&!found);

            if (found)
            {
                //Console.Clear();
                Console.WriteLine("Apsveicu ar marsruta izvelesanos! Tavs marsruts:");
                Console.WriteLine(String.Join("->", route));
            }
            Console.ReadKey();
        }

        public static void ShowCities(HashSet<string> cities)
        {
            Console.WriteLine("--------------------");
            foreach (var city in cities)
            {
                Console.WriteLine(city);   
            }
            Console.WriteLine("--------------------");
        }
    }
}
