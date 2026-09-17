namespace VendingMachine
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Product
    {
        private string _code {  get; set; }
        private string _name { get; set; }
        private int _price { get; set; }
        private int _stock { get; set; }
        private ProductCategory _category { get; set; }

        
    }

}
