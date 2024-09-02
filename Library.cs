namespace ProgrammingAnalystExercise
{
   public class Library
    {
        private List<Book> books;

        public Library(List<Book> initialBooks)
        {
            books = initialBooks;
        }

        public void AddBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book), "Cannot add a null book.");
            }

            books.Add(book);
            Console.WriteLine($"The book '{book.Title}' has been added to the Library");
        }

        public void BorrowBook(string title)
        {
            var book = FindBook(title);
            if (book != null)
            {
                if (!book.IsBorrowed)
                {
                    book.Borrow();
                }
                else
                {
                    Console.WriteLine($"The book '{title}' is already checked out.");
                }
            }
            else
            {
                Console.WriteLine($"The book '{title}' was not found in the library.");
            }
        }

        public void ReturnBook(string title)
        {
            var book = FindBook(title);
            if (book != null)
            {
                if (book.IsBorrowed)
                {
                    book.Return();
                }
                else
                {
                    Console.WriteLine($"The book '{title}' was not borrowed.");
                }
            }
            else
            {
                Console.WriteLine($"The book '{title}' was not found in the library.");
            }
        }

        public void RemoveBook(string title)
        {
            var book = FindBook(title);
            if (book != null)
            {
                books.Remove(book);
                Console.WriteLine($"The book '{title}' has been removed from the library.");
            }
            else
            {
                Console.WriteLine($"The book '{title}' was not found in the library.");
            }
        }

        private Book FindBook(string title)
        {
            return books.Find(b => b.Title == title);
        }
    }

}
