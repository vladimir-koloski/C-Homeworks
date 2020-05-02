using Homework08.Enumerations;
using Homework08.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework08.Database
{
    public class ProductRepository : Database
    {
        public ProductRepository()
            : base()
        {
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public void PrintProducts(List<Product> products)
        {
            foreach(var product in products)
            {
                Console.WriteLine(product.Info());
            }
        }

        public List<Product> GetProductByCategory(Category category, List<Product> products)
        {
            var filteredProductsByCategory = new List<Product>();
            foreach (Product product in products)
            {
                if (product.Category == category)
                {
                    filteredProductsByCategory.Add(product);
                }
            }
            return filteredProductsByCategory;
        }

        public List<Product> GetProductsInPriceRange(int from, int to)
        {
            var filteredproducts = new List<Product>();
            for(int i = 0; i < products.Count; i++)
            {
                if(products[i].Price >= from && products[i].Price <= to)
                {
                    filteredproducts.Add(products[i]);
                }
            }
            return filteredproducts;
        }

        public List<int> GetProductsId(List<Product> products)
        {
            var productsId = new List<int>();
            foreach (var p in products)
            {
                productsId.Add(p.Id);
            }
            return productsId;
        }

        public  Product FindProductByName(string name, List<Product> products)
        {
            foreach (var p in products)
            {
                if (p.Name.ToLower().Contains(name.ToLower()))
                {
                    return p;
                }
            }
            return null;
        }

        public int GetProductPrice(int id, List<Product> products)
        {
            foreach (var p in products)
            {
                if (p.Id == id)
                {
                    return p.Price;
                }
            }
            return 0;
        }

        public Product GetCheapestProduct(List<Product> products)
        {
            Product cheapestProduct = products[0];
            for (int i = 0; i < products.Count; i++)
            {
                if(products[i].Price < cheapestProduct.Price)
                {
                    cheapestProduct = products[i];
                }
            }
            return cheapestProduct;
        }

        public Product GetExpensiveProduct(List<Product> products)
        {
            Product expensiveProduct = products[0];
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Price > expensiveProduct.Price)
                {
                    expensiveProduct = products[i];
                }
            }
            return expensiveProduct;
        }

        public void AddProduct(Product product, List<Product> products)
        {
            products.Add(product);
        }

        public List<Product> DeleteProduct(int id, List<Product> products)
        {
            var newList = new List<Product>();
            foreach(var p in products)
            {
                if(p.Id != id)
                {
                    newList.Add(p);
                }
            }
            return newList;
        }

    }
}
