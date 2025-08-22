namespace CSharpFundamentals
{
    public static class Day2_OperatorsAndMethods
    {
        public class Book
        {
            
            //Properties (the characteristics of book)
            public string Title { get; set; }
            public string Author { get; set; }
            public int PublicationYear { get; set; }
            public string ISBN { get; set; }
            public bool IsBorrowed { get; set; }

            //Methods(the actions the book can undergo)
            public void BorrowBook()
            {
                if (IsBorrowed)
                {
                    Console.WriteLine($"Error:The title '{Title}' is already borrewed.");
                }
                else
                {
                    //We change the state of object
                    IsBorrowed = true;
                    Console.WriteLine($"Success: you have borrowed the book '{Title}'.");
                }
            }

            public void ReturnBook()
            {
                if (IsBorrowed)
                {
                    //We change the state of the object
                    IsBorrowed = false;
                    Console.WriteLine($"Success: You have returned the book '{Title}'.");
                }
                else
                {
                   
                    Console.WriteLine($"Error: The book'{Title}' wasn't borrewed in the first place");
                }
            }
            


        }


        public static void Ejecutar()
        {
            Book book1 = new Book();

            book1.Title = "The Lord of the Rings";
            book1.Author = "J. R. Tolkien";
            book1.PublicationYear = 1954;
            book1.ISBN = "978-0-618-64015-7";
            book1.IsBorrowed = false;
            

            Console.WriteLine($"--- Testing '{book1.Title}' ---");
            Console.WriteLine($"1.Initial state, is borrowed? {book1.IsBorrowed}");
            

            Console.WriteLine("\nAttempting to borrow...");
            book1.BorrowBook(); 
            Console.WriteLine($"2. After borrowing. Is borrowed? -> {book1.IsBorrowed}");



            Console.WriteLine("\nAttempting to return...");
            book1.ReturnBook(); 
            Console.WriteLine($"3. After returning. Is borrowed? -> {book1.IsBorrowed}"); 


            Console.WriteLine("\nAttempting to return again...");
            book1.ReturnBook();


        }


    }
    
}
