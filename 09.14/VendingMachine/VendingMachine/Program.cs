using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VendingMachine
{
    public class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine1 = new VendingMachine();
            vendingMachine1.LoadProducts("products.txt");
        }
    }

}
