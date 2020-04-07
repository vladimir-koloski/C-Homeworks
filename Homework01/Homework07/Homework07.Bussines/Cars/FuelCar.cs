using Homework07.Bussines.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework07.Bussines.Cars
{
    public class FuelCar
    {
        public int FuelCapacity { get; set; }
        public int CurrentFuel { get; set; }
        public int Drive(int distance)
        {
            int consumption1;
            int.TryParse(FuelCar Consumption, out consumption1);
            CurrentFuel -= distance* consumption1 / 10;
            return CurrentFuel;
        }
        public int Refuel(int fuel)
        {
            int freeCapacity = FuelCapacity - CurrentFuel;
            if (fuel > freeCapacity)
            {
                Console.WriteLine($"You can refill only {freeCapacity}");
            }
            CurrentFuel += fuel;
            return CurrentFuel;
        }
    }


}

