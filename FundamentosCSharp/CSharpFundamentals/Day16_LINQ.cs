using CSharpFundamentals.Core.Models.Inventory;
using CSharpFundamentals.Core.Models.Vehicles;
using System.Diagnostics;

namespace CSharpFundamentals
{
    public static class Day16_LINQ
    {

        public static void ExecuteCarDataManagement()
        {
            List<Car> cars = new List<Car> {

            new Car { Brand = "Toyota", Model = "Corolla" },
            new Car { Brand = "Honda", Model = "Civic" },
            new Car { Brand= "Volkswagen", Model= "Golf" },
            new Car { Brand = "Ford", Model = "Mustang" },
            new Car { Brand = "Chevrolet", Model = "Camaro" },
            new Car { Brand ="Toyota", Model = "Camry" },
            new Car { Brand = "Tesla", Model = "Model 3" },
            new Car { Brand = "Toyota", Model = "RAV4" },
            new Car { Brand = "Hyundai", Model = "Elantra" },
            new Car { Brand = "Nissan", Model = "Sentra" }
            };


            Console.WriteLine("---- Original List(unfiltered) ----");
            foreach (var car1 in cars)
            {
                Console.WriteLine($"Brand: {car1.Brand}, Model: {car1.Model} ");
            }



            var filterCar = cars.Where(x => x.Brand == "Toyota").OrderBy(x => x.Model).ToList();

            Console.WriteLine("\n---- Filtered list  of cars(Toyota)----");
            foreach (var car2 in filterCar)
            {

                Console.WriteLine($"Brand: {car2.Brand}, Model: {car2.Model} ");
            }

        }


        public static void ExecuteProductPriceAnalysis()
        {
            List<Product> products = new List<Product>()
            {
                new Product { Name = "Laptop", Price = 1200.50 },
                new Product { Name = "Smartphone", Price = 750.25 },
                new Product { Name = "Headphones", Price = 150.00 },
                new Product { Name = "Keyboard", Price = 75.99 },
                new Product { Name = "Mouse", Price = 45.50 },
                new Product { Name = "Monitor", Price = 300.00 },
                new Product { Name = "Webcam", Price = 65.75 },
                new Product { Name = "Printer", Price = 220.00 },
                new Product { Name = "External Hard Drive", Price = 90.00 },
                new Product { Name = "USB Drive", Price = 15.25 }
            };

            var minimumPrice = products.Min(x => x.Price);
            var maximumPrice = products.Max(x => x.Price);
            var averagePrice = products.Average(x => x.Price);

            Console.WriteLine($"The Minimum prices is:  {minimumPrice} ");

            Console.WriteLine($"The Maximum prices is: {maximumPrice} ");
            Console.WriteLine($"The average price is: {averagePrice}");
            


        }
    }
}
