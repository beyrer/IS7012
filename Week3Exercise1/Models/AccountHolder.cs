namespace Week3Exercise1.Models
{
    public class AccountHolder
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Id { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public List<BankAccount> BankAccounts { get; set; }

    }
}
