using Homework08.Enumerations;
using Homework08.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework08.Database
{
    public class ProductRepository 
    {
        private List<Product> _products { get; set; }
        public ProductRepository(Database database)
        {
            _products = database.products;
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public void PrintProducts(List<Product> _products)
        {
            foreach(var product in _products)
            {
                Console.WriteLine(product.Info());
            }
        }

        public List<Product> GetProductByCategory(Category category, List<Product> _products)
        {
            var filteredProductsByCategory = new List<Product>();
            foreach (Product product in _products)
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
            for(int i = 0; i < _products.Count; i++)
            {
                if(_products[i].Price >= from && _products[i].Price <= to)
                {
                    filteredproducts.Add(_products[i]);
                }
            }
            return filteredproducts;
        }

        public List<int> GetProductsId(List<Product> _products)
        {
            var productsId = new List<int>();
            foreach (var p in _products)
            {
                productsId.Add(p.Id);
            }
            return productsId;
        }

        public  Product FindProductByName(string name, List<Product> _products)
        {
            foreach (var p in _products)
            {
                if (p.Name.ToLower().Contains(name.ToLower()))
                {
                    return p;
                }
            }
            return null;
        }

        public int GetProductPrice(int id, List<Product> _products)
        {
            foreach (var p in _products)
            {
                if (p.Id == id)
                {
                    return p.Price;
                }
            }
            return 0;
        }

        public Product GetCheapestProduct()
        {
            Product cheapestProduct = _products[0];
            for (int i = 0; i < _products.Count; i++)
            {
                if(_products[i].Price < cheapestProduct.Price)
                {
                    cheapestProduct = _products[i];
                }
            }
            return cheapestProduct;
        }

        public Product GetExpensiveProduct(List<Product> _products)
        {
            Product expensiveProduct = _products[0];
            for (int i = 0; i < _products.Count; i++)
            {
                if (_products[i].Price > expensiveProduct.Price)
                {
                    expensiveProduct = _products[i];
                }
            }
            return expensiveProduct;
        }

        public void AddProduct(Product product, List<Product> _products)
        {
            _products.Add(product);
        }

        public List<Product> DeleteProduct(int id, List<Product> _products)
        {
            var newList = new List<Product>();
            foreach(var p in _products)
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
