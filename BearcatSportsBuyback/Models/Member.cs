using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BearcatSportsBuyback.Models
{
    public class Member
    {
        public int Id { get; set; }

        [DisplayName("First Name")]
        [StringLength(20, MinimumLength = 2)]
        [Required(ErrorMessage = "A First Name is Required")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [StringLength(40, MinimumLength = 2)]
        [Required(ErrorMessage = "A Last Name is Required")]
        public string LastName { get; set; }

        [DisplayName("Street Address")]
        [StringLength(60, MinimumLength = 5)]
        [Required(ErrorMessage = "A Street Address is Required")]
        public string StreetAddress { get; set; }

        [DisplayName("City")]
        [StringLength(60, MinimumLength = 5)]
        [Required(ErrorMessage = "A City is Required")]
        public string City { get; set; }

        [DisplayName("State")]
        [StringLength(15, MinimumLength = 2)]
        [Required(ErrorMessage = "A State is Required")]
        public string State { get; set; }

        [DisplayName("Zip Code")]
        [StringLength(10, MinimumLength = 5)]
        [Required(ErrorMessage = "A Zip Code is Required")]
        public string Zip { get; set; }

        [DisplayName("Email")]
        [EmailAddress]
        [Required(ErrorMessage = "An Email Address is Required")]
        public string Email { get; set; }

        [DisplayName("Phone Number")]
        [Phone]
        //[Required(ErrorMessage = "A Phone Number is Required")]
        public int? Phone { get; set; }

        [DisplayName("Favorite Sport")]
        public Sport? Sport { get; set; }

        public int? SportId { get; set; }

        [DisplayName("Interested in Joining a League?")]
        public bool? LeagueInterest { get; set; }

        public League? LeagueName { get; set; }

        public int? LeagueNameId { get; set; }

    }
}
