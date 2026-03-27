using System;

namespace AssetTracking.Helpers
{
    public static class ConsoleTableHelper
    {
        public static void PrintHeader()
        {
            Console.WriteLine(new string('-', 120));
            Console.WriteLine(
                $"{"Office",-12} " +
                $"{"Asset",-12} " +
                $"{"Brand",-12} " +
                $"{"Model",-20} " +
                $"{"Price (USD)",-15} " +
                $"{"Price (Local)",-18} " +
                $"{"Purchase Date",-15}");
            Console.WriteLine(new string('-', 120));
        }

        public static void PrintFooter()
        {
            Console.WriteLine(new string('-', 120));
        }
    }
}