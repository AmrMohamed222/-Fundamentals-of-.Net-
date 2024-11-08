namespace Store_and_Display_Book_Information___Day4
{
    struct Book
    {
        public string title;
        public string author;
        public int publication_year;
        public string genre;
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //Book b1, b2, b3;
            Book[] books = new Book[4] ;
         
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Please, Enter book :{i+1} ");
                Console.Write($"Please, Enter the title of book: ");
                books[i].title = Console.ReadLine();
                Console.Write($"Please, Enter the author of book: ");
                books[i].author = Console.ReadLine();
                Console.Write($"Please, Enter the publication year of book: ");
                books[i].publication_year = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Please, Enter the genre of book: ");
                books[i].genre = Console.ReadLine();
        }
            for (int i = 0;i < 3;i++)
            {
                Console.WriteLine($"\nBook :{i+1} ");
                Console.Write($"Title: {books[i].title}");
                Console.Write($", Author: {books[i].author}");
                Console.Write($", Publication_year: {books[i].publication_year}");
                Console.Write($", Genre: {books[i].genre}");
            }
            
        }
    }
}
