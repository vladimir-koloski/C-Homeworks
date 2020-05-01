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



            //productRepository.PrintProducts(productRepository.GetAllProducts());

            productRepository.GetProductByCategory(Category.LapTop, productRepository.GetAllProducts());


            //productRepository.GetCheapestProduct(productRepository.GetAllProducts());

            //productRepository.DeleteProduct(1, productRepository.GetAllProducts());



            Console.ReadLine();
        }
    }
}
