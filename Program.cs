namespace ProgrammingAnalystExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var library = new Library(new List<Book>
            {
                new Book("The Great Gatsby"),
                new Book("1984"),
                new Book("To Kill a Mockingbird")
            });

            var newBook = new Book("Great Expectations");

            library.AddBook(newBook);
            library.BorrowBook("Great Expectations");
            library.ReturnBook("Great Expectations");
            library.RemoveBook("Great Expectations");
        }
    }
}
