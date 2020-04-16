using Homework07.Bussines.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework07.Bussines.Models
{
    public class FuelCar : Car
    {
        public FuelCar(string brand, string model, int doors, int topSpeed, Consumption consumption, int fuelCapacity, int currentFuel)
            : base(brand, model, doors, topSpeed, consumption)
        {
            FuelCapacity = fuelCapacity;
            CurrentFuel = currentFuel;
            EngineType = EngineType.Petrol;
        }
        public int FuelCapacity { get; set; }
        public int CurrentFuel { get; set; }
        public EngineType EngineType { get; set; }
        public int Drive(int distance)
        {
            int consumption1 = Convert.ToInt32(Consumption);
            CurrentFuel -= distance * consumption1 / 10;
            if (CurrentFuel < 0)
            {
                Console.WriteLine($"You dont have fuel for the distance of{distance}");
            }
            return CurrentFuel;
        }
        public int Refuel(int fuel)
        {
            int freeCapacity = FuelCapacity - CurrentFuel;
            if (fuel > freeCapacity)
            {
                Console.WriteLine($"Can't refuel more than {freeCapacity} litres");
            }
            else
            {
                CurrentFuel += fuel;
            }
            
            return CurrentFuel;
        }
    }


}

