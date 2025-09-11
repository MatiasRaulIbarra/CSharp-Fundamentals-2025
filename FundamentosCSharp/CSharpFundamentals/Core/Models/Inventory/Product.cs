namespace CSharpFundamentals.Core.Models.Inventory
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() { }

         public Product(string name, double price)
         {
             Name = name;
             Price = price;
         }
    }
}
