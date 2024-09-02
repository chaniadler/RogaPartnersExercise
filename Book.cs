namespace ProgrammingAnalystExercise
{
 public class Book
    {
        public string Title { get; private set; }
        public bool IsBorrowed { get; private set; }

        public Book(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Title cannot be null, empty, or whitespace.", nameof(title));
            }

            Title = title;
            IsBorrowed = false;
        }

        public void Borrow()
        {
            if (IsBorrowed)
            {
                throw new InvalidOperationException("The book is already checked out.");
            }

            IsBorrowed = true;
            Console.WriteLine($"The book '{Title}' has been checked out.");
        }

        public void Return()
        {
            if (!IsBorrowed)
            {
                throw new InvalidOperationException("The book was not borrowed.");
            }

            IsBorrowed = false;
            Console.WriteLine($"The book '{Title}' has been returned.");
        }
    }
}
