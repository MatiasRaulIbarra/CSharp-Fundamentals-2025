using CSharpFundamentals.Core.Models.Collections;

namespace CSharpFundamentals
{
    public static class Day14_Collections_ListT_
    {

        public static void ExecuteMusicPlaylistManager()
        {
            List<string> list = new List<string>();
            List<Song> songs = new List<Song>();
            songs.Add(new Song("All of Me", "John Legend"));
            songs.Add(new Song("Out Loud", " Ed Sheeran"));
            songs.Add(new Song("Uptown Funk", "Mark Ronson ft. Bruno Mars"));
            songs.Add(new Song("Happy", "Pharrell Williams"));
            songs.Add(new Song("Rolling in the Deep", " Adele"));

            Console.WriteLine("---- Music Playlist Manager ----");
            Console.WriteLine("Here is the current playlist");


            foreach (Song song in songs)
            {

                Console.WriteLine($"Title: {song.Title}, Artist: {song.Artist}");

            }

            Console.WriteLine("Please choose what artist would like  you delete");
            string inputUser = Console.ReadLine();


            songs.RemoveAll(x => x.Artist.ToLower().Trim().Equals(inputUser));

            Console.WriteLine("Your playlist has been updated.");

            if (songs.Count > 0)
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine($"Title: {song.Title}, Artist: {song.Artist}");
                }

            }
            else
            {
                Console.WriteLine("The playlist is now empty");
            }
        }

        public static void UserEnteredNumbers()
        {
            List<int> numbers = new List<int>();
            int intUser;

            do
            {
                Console.WriteLine("Please enter a number (or 0 for end).");
                string inputUser = Console.ReadLine();
                if (int.TryParse(inputUser, out intUser))
                {
                   
                    if(intUser != 0)
                    {
                        numbers.Add(intUser);
                    }
                    
                }
                else
                {
                    Console.WriteLine("Error: Please enter a valid number.");
                }

            }
            while (intUser != 0);

            Console.WriteLine("The list has been completed");
            Console.WriteLine($"The sum  is : {numbers.Sum()}");

        }
    }
}
