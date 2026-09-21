using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingMachine
    {
        private List<Product> _products;
        private int _balance;
        public int _income;

        public int Balance { get; }
        public int Income { get; }


        public ProductCategory ParseCategory (string szoveg)
        {

            switch (szoveg)
            {
                case "Drink":
                    return ProductCategory.Drink;
                    break;

                case "Snack":
                    return ProductCategory.Snack;
                    break;


                case "Food":
                    return ProductCategory.Food;
                    break;

                default:
                    return ProductCategory.Snack;
                    break;

            }
        }

        public void LoadProducts(string filename)
        {
            List<Product> _products = new List<Product>();
      
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = lines[0].Split(';');
                int price = int.Parse(parts[2]);
                int stock = int.Parse(parts[3]);
                ProductCategory category = ParseCategory(parts[4]);

               _products.Add(new Product(parts[0], parts[1], price, stock, category));
            }
          
        }

        public VendingMachine(string filename)
        { 
            _balance = 0;
            _income = 0;
            LoadProducts(filename);
        }

        public void InsertCoin(int coin)
        { 
            _balance += coin;
        }
        public int ReturnChange()
        {
            int visszajaro = _balance;
            _balance = 0;
            return visszajaro;
            

        }
        public Product FindProduct(string code)
        {
            foreach (Product product in _products)
            {
                if (code == product.Code)

                {
                    return product;
                }
            }
            return null;  
        }


        public void ListProducts()
        {
            foreach (Product product in _products)
            {
                if (product.IsAvailable == true)
                {
                    Console.WriteLine(product.Code, product.Name, product.Price, product.Category);
                }
                else
                {
                    Console.WriteLine($"{product.Code},{product.Name}, {product.Price},{product.Category}, ELFOGYOTT");
                }
                
            }
        }



    }
}
