namespace Game_Of_Bookss.Models
{
    public class Book
    {
        public Book(string title, string author, string genre, int yearOfPublication)
        {
            Title = title;
            Author = author;
            Genre = genre;
            YearOfPublication = yearOfPublication;
            IsAvailable = true;
        }

        public string Title { get; }
        public string Author { get; }
        public string Genre { get; }
        public int YearOfPublication { get; }
        private bool IsAvailable { get; set; }

        public bool CheckAvailability() => IsAvailable;

        public void MarkAsBorrowed()
        {
            if (!IsAvailable) throw new InvalidOperationException("Livro já emprestado.");
            IsAvailable = false;
        }

        public void MarkAsReturned()
        {
            if (IsAvailable) throw new InvalidOperationException("Livro já está disponível.");
            IsAvailable = true;
        }
    }
}