using System;
using System.IO;
using System.Net;

namespace AdventOfCode_1
{
    static class Fuel
    {
        public static decimal getFuelPerMass(decimal mass)
        {
            if (Math.Round(mass / 3, 0, MidpointRounding.ToZero) - 2 > 0)
                return Math.Round(mass / 3, 0, MidpointRounding.ToZero) - 2;
            return 0;
        }
        public static decimal getFuelPart2(decimal mass)
        {
            mass = getFuelPerMass(mass);
            if(mass > 0)
                return mass + getFuelPart2(mass);
            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("..\\content.txt");
            decimal result = 0;
            foreach (string mass in lines)
                result += Fuel.getFuelPart2(decimal.Parse(mass));

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
