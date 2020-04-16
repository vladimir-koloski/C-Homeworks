using Homework07.Bussines.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework07.Bussines.Models
{
    public class ElectricCar : Car
    {
        public ElectricCar(string brand, string model, int doors, int topSpeed, Consumption consumption, EngineType engineType, int batteryCapacity, int batteryUsage)
            : base(brand, model, doors, topSpeed, consumption)
        {
            BatteryCapacity = batteryCapacity;
            BatteryUsage = batteryUsage;
        }
        public int BatteryCapacity { get; set; }
        public int BatteryUsage { get; set; }

        public int Drive(int distance)
        {

            int consumption1 = Convert.ToInt32(Consumption);
            BatteryUsage -= distance * consumption1 / 10;
            if (BatteryUsage < 0)
            {
                Console.WriteLine($"You dont have baterry for the distance of{distance} km");
            }
            return BatteryUsage;
        }
        public int Recharge(int minutes)
        {
            int newCharge = minutes / 10;
            int freeCapacity = BatteryCapacity - BatteryUsage;
            if(newCharge > freeCapacity)
            {
                Console.WriteLine($"Can't charge more than {freeCapacity} percent");
            }
            BatteryUsage += newCharge;
            return BatteryCapacity;

        }

    }
}

