namespace Game_Of_Bookss.Models
{
    public class User
    {
        public User(string name, string email)
        {
            Name = name;
            Email = email;
            Id = Guid.NewGuid();
        }

        public string Name { get; }
        public string Email { get; }
        public Guid Id { get; }
        private List<Loan> Loans { get; } = new List<Loan>();

        public void AddLoan(Loan loan) => Loans.Add(loan);
        public void RemoveLoan(Loan loan) => Loans.Remove(loan);
        public List<Loan> GetLoans() => Loans;
    }
}