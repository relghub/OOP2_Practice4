using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Practice4
{
    static class Destinator
    {
        static PublicTransit routeList = new();
        public static void TransitStart()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            FillRouteList();
            routeList.TransitTracker(ArrivalAlert, NextStationAlert, PSA);
        }

        private static void ArrivalAlert(string station) => Console.WriteLine
                                                              ($"Зупинка: " +
                                                              $"{station}.");

        private static void NextStationAlert
            (string nextstation) => Console.WriteLine("Обережно: " +
                                    "двері зачиняються. Наступна " +
                                    $"зупинка - {nextstation}.");
        private static void PSA(string announcement) => Console.
                                                        WriteLine
                                                        (announcement);
        internal static void FillRouteList()
        {
            routeList.Routes.Add(new Route()
            {
                Number = 1,
                Stations = ExampleData.stationsExample
            });
        }
    }
}
