using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Week3Exercise1.Models
{
    public class AccountHolder
    {
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Account Holder ID")]
        public int Id { get; set; }
        [DisplayName("Street Address")]
        public string Address { get; set; }
        [DisplayName("City")]
        public string? City { get; set; }
        [DisplayName("State")]
        public string? State { get; set; }
        [DisplayName("Zip Code")]
        public string? Zip { get; set; }
        [DisplayName("Email Address")]
        public string Email { get; set; }
        [DisplayName("Customer Accounts")]
        public List<BankAccount>? BankAccounts { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        public int Age { get
            {
                DateTime today = DateTime.Today;
                int birthYear = DateOfBirth.Year;
                int currentYear = today.Year;

                int yearsSinceBirthYear = currentYear - birthYear;
                DateTime birthdayThisYear = DateOfBirth.AddYears(yearsSinceBirthYear);
                bool hasBirthdayAlreadyPassed = birthdayThisYear <= today;

                int age = yearsSinceBirthYear;

                if (hasBirthdayAlreadyPassed == false)
                {
                    age--;
                }

                return age; 

            } }

    }
}
