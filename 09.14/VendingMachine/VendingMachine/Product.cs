using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Product
    {
        private string _code;
        private string _name;
        private int _price;
        private int _stock;
        private ProductCategory _category;

        public bool IsAvailable;

        public string Code { get { return _code; } }
        public string Name { get { return _name; } }
        public int Price { get { return _price; } }
        public int Stock { get { return _stock; } }
        public ProductCategory Category { get { return _category; } }


        public Product(string Code, string Name,int Price, int Stock, ProductCategory Category)
        {
            _code = Code;
            _name = Name;
            _price = Price;
            _stock = Stock;
            _category = Category;
        }

        public void Sell()
        { 
            _stock -=1;
        }
        
    }
}

