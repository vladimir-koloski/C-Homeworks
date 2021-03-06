﻿using Homework07.Bussines.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework07.Bussines.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Doors { get; set; }
        public int TopSpeed { get; set; }

        public Consumption Consumption { get; set; }
        

        public Car(string brand, string model, int doors, int topSpeed, Consumption consumption)
        {
            Id = GenerateId();
            Brand = brand;
            Model = model;
            Doors = doors;
            TopSpeed = topSpeed;
            Consumption = consumption;
            
            
        }

        public string PrintInfo()
        {
            return $"The brand of the car is: {Brand}, model {Model} and its top speed is {TopSpeed} km/h";
        }

        public int GenerateId()
        {
            Random rand = new Random();
            return rand.Next(0, 10_000_000);
        }
    }
}
