using Homework08.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework08.Models
{
    public class Product
    {
        private static int _idGenerator = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Category Category { get; set; }

        public Product(string name, int price, Category category)
        {
            _idGenerator++;
            Id = _idGenerator;
            Name = name;
            Price = price;
            Category = category;
        }

        public string Info()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price}, Category {Category}";
        }
    }
    
    
}
