using Homework08.Database;
using Homework08.Enumerations;
using Homework08.Models;
using System;
using System.Collections.Generic;

namespace Homework08.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var productRepository = new ProductRepository();



            productRepository.PrintProducts(productRepository.GetAllProducts());

            productRepository.GetProductByCategory(Category.LapTop, productRepository.GetAllProducts());
            Console.WriteLine(productRepository.FindProductByName("Mouse", productRepository.GetAllProducts()));

            List<Product> filterProductPriceRange = productRepository.GetProductsInPriceRange(100, 20000);
            foreach(var p in filterProductPriceRange)
            {
                Console.WriteLine(p.Info());
            }
            Console.WriteLine("-----------------------");
            List<Product> filterProductsByCategory = productRepository.GetProductByCategory(Category.LapTop, productRepository.GetAllProducts());
            foreach (var p in filterProductsByCategory)
            {
                Console.WriteLine(p.Info());
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine(productRepository.GetCheapestProduct(productRepository.GetAllProducts()).Info());
            Console.WriteLine(productRepository.GetExpensiveProduct(productRepository.GetAllProducts()).Info());
            Console.WriteLine("-----------------------");
            Console.WriteLine(productRepository.FindProductByName("mouse", productRepository.GetAllProducts()).Info());
            Console.WriteLine("-----------------------");
            productRepository.AddProduct(new Product("Panasonic TV", 35500, Category.TV), productRepository.GetAllProducts());
            productRepository.PrintProducts(productRepository.GetAllProducts());
            Console.WriteLine("Show list without removed Product-----------------------");
            List<Product> newList = productRepository.DeleteProduct(3, productRepository.GetAllProducts());
            foreach(var p in newList)
            {
                Console.WriteLine(p.Info());
            }


            Console.ReadLine();
        }
    }
}
