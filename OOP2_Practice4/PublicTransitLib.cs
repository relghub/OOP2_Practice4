using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace OOP2_Practice4
{
    internal class PublicTransit
    {
        public delegate void TransitTrack(string station);
        public List<Route> Routes { get; set; } = new();
        private readonly Random rand = new();

        public void TransitTracker(TransitTrack track, TransitTrack nstrack, Action<string> PSA)
        {
            foreach (Route route in Routes)
            {
                for (int i = 0; i < route.Stations.Count; i++)
                {
                    List<string> station = route.Stations;
                    List<string> announcements = ExampleData.publicAnnouncements;
                    int j = rand.Next(5);
                    track(station[i]);
                    if (i == station.Count - 1)
                    {
                        Console.WriteLine("КІНЦЕВА");
                        station.Reverse();
                        break;
                    }
                    Thread.Sleep(1000);
                    nstrack(station[i+1]);
                    Thread.Sleep(1000);
                    switch (j)
                    {
                        case 0:
                        case 1:
                        case 2:
                            PSA(announcements[j]);
                            break;
                        default:
                            break;
                    }
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
