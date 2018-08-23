using System;
using System.Collections.Generic;

namespace carSets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> showroom = new HashSet<string>()
            {
                {"Land Rover"},
                {"Citroen"},
                {"Alfa Romeo"},
                {"Maserati"}, 
                {"Land Rover"}
            };

            HashSet<string> usedLot = new HashSet<string>()
            {
                {"Honda"},
                {"BMW"}
            };

            HashSet<string> junkyard = new HashSet<string>()
            {
                {"Nissan"},
                {"Honda"},
                {"Bugatti"},
                {"Mercedes"},
                {"Land Rover"},
                {"Citroen"}
            };

            showroom.IntersectWith(junkyard);
            showroom.UnionWith(junkyard);
            showroom.Remove("Honda");

            foreach (string item in showroom)
            {
                System.Console.WriteLine(item);
            }

            // showroom.UnionWith(usedLot);
            // System.Console.WriteLine($"The showroom currently contains {showroom.Count} cars");
            // showroom.Remove("BMW");
            // System.Console.WriteLine($"You've sold a BMW, your showroom now has {showroom.Count} cars");
        }
    }
}
