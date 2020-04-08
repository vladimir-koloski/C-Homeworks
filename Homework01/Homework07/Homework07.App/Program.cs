using Homework07.Bussines.Enumerations;
using Homework07.Bussines.Models;
using System;

namespace Homework07.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            FuelCar fuelcar1 = new FuelCar("Peugeot", "206", 5, 140, Consumption.Economic, EngineType.Diesel, 15, 40);

            //fuelcar1.PrintInfo();
            Console.WriteLine(fuelcar1);
            Console.ReadLine();
        }
    }
}
