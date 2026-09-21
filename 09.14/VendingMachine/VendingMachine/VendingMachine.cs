using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
