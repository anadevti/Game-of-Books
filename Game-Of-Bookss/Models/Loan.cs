namespace Game_Of_Bookss.Models
{
    public class Loan
    {
        public Loan(Book book, User user, DateTime dateLoan, DateTime dateReturn)
        {
            Book = book;
            User = user;
            DateLoan = dateLoan;
            DateReturn = dateReturn;
            book.MarkAsBorrowed();
        }

        public Book Book { get; }
        public User User { get; }
        public DateTime DateLoan { get; }
        public DateTime DateReturn { get; }

        public void ReturnBook() => Book.MarkAsReturned();
    }
}