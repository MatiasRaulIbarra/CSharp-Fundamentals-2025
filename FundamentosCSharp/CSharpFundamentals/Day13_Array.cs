using CSharpFundamentals.Core.Models.Gaming;
using CSharpFundamentals.Core.Models.Inventory;

namespace CSharpFundamentals
{
    public static class Day13_Array
    {

        public static void ExecuteProductInventory()
        {
            Product[] myProducts = new Product[4];

            myProducts[0] = new Product("car", 120000);
            myProducts[1] = new Product("Truck", 130000000);
            myProducts[2] = new Product("Boat", 140045);
            myProducts[3] = new Product("Bicycle", 140045);

            Console.WriteLine("---- Welcome to the Product Inventory ----");


            for (int i = 0; i < myProducts.Length; i++)
            {
                Product product = myProducts[i];
                Console.WriteLine($"Product: {product.Name}, Price: ${product.Price}");
            }


        }


        public static void ExecuteGameRanking()
        {
            VideoGame[] myVideoGame = new VideoGame[5];
            myVideoGame[0] = new VideoGame("Batman", "XBOX");
            myVideoGame[1] = new VideoGame("Street Fighter", "PlayStation 5");
            myVideoGame[2] = new VideoGame("Battlefeld 2", "PC");
            myVideoGame[3] = new VideoGame("Battlefeld 5", "XBOX One");
            myVideoGame[4] = new VideoGame("Mario Bros", "Nintendo Switch");

            Console.WriteLine("---- The  gaming ranking top 5 most populars ----");

            for (int i = 0; i < myVideoGame.Length; i++)
            {
                VideoGame videoGame = myVideoGame[i];
                Console.WriteLine($"{i +1}. Title: {videoGame.Title}, Platform: {videoGame.Platform}.");
            }

        }
    }
}
