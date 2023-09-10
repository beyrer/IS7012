namespace Week3Exercise1.Models
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal CurrentBalance { get; set; }
        public string AccountName { get; set; }
        public int Id { get; set; }
        public AccountHolder AccountHolder { get; set; }
        public int AccountHolderId { get; set; }
        public decimal PriorBalance { get; set; }
        public string AccountType { get; set; }

    }
}
