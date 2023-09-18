using System.ComponentModel;

namespace BankAccounts.Models
{
    public class AccountHolder
    {
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Account Holder ID")]
        public int Id { get; set; }
        [DisplayName("Street Address")]
        public string Address { get; set; }
        [DisplayName("City")]
        public string City { get; set; }
        [DisplayName("State")]
        public string State { get; set; }
        [DisplayName("Zip Code")]
        public string Zip { get; set; }
        [DisplayName("Email Address")]
        public string Email { get; set; }
        [DisplayName("Accounts")]
        public List<BankAccount>? AccountNumber { get; set; }

    }
}
