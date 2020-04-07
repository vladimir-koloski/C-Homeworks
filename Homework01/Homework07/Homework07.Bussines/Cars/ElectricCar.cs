using Homework07.Bussines.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework07.Bussines.Cars
{
    public class ElectricCar : Car
    {
        public ElectricCar(string brand, string model, int doors, int topSpeed, Consumption consumption, EngineType engineType)
            : base(brand, model, doors, topSpeed, consumption, engineType)
        {
        }
        public int BatteryCapacity { get; set; }
        public int BatteryUsage { get; set; }

        public int Drive(int distance)
        {
            int consumption1;
            int.TryParse(ElectricCar Consumption, out consumption1);
            BatteryUsage -= distance * consumption1 / 10;
            return BatteryUsage
        }
        public int Recharge(int minutes)
        {
            BatteryCapacity += minutes / 10;
            return BatteryCapacity;
                
        }

    }
}

