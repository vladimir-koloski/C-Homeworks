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

            FuelCar fuelCar1 = new FuelCar("Peugeot", "206", 5, 140, Consumption.Medium, EngineType.Diesel, 50, 5);
            ElectricCar electricCar = new ElectricCar("Tesla", "x", 3, 160, Consumption.Economic, EngineType.Electric, 100, 33);
            //Console.WriteLine(fuelCar1.PrintInfo());
            //fuelCar1.Drive(800);
            //electricCar.Drive(1200);
            //fuelCar1.Refuel(85);
            electricCar.Recharge(660);
            Console.WriteLine(electricCar.BatteryUsage);
            //fuelcar1.PrintInfo();

            Console.ReadLine();
        }
    }
}
