using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using System.Xml.Linq;


namespace RecruitCatBeyrerJL02.Models
{
    public class Candidate
    {
        [DisplayName("First Name")]
        [StringLength(50, MinimumLength = 1)]
        [Required(ErrorMessage = "A First Name is Required")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [StringLength(50, MinimumLength = 2)]
        [Required(ErrorMessage = "A Last Name is Required")]
        public string LastName { get; set; }

        [DisplayName("Target Salary")]
        [Range(1, 500000)]
        public decimal TargetSalary { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Start Date")]
        public DateTime? StartDate { get; set; }

        [DisplayName("Maximum Salary")]
        [Range(1, 500000)]
        public decimal MaximumSalary { get; set; }

        public Company? Company { get; set; }
       
        [DisplayName("Company Name")]
        public int? CompanyId { get; set; }

        [DisplayName("Candidate ID")]
        public int Id { get; set; }

        [DisplayName("Job Title")]
        public JobTitle Title { get; set; }

        [DisplayName("Job ID")]
        public int TitleId { get; set; }

        [DisplayName("Industry")]
        public Industry Industry { get; set; }

        [DisplayName("Industry ID")]
        public int IndustryId { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date of Birth")]
        [Required(ErrorMessage = "A Date of Birth is Required")]
        public DateTime DOB { get; set; }

        [DisplayName("Veteran Status")]
        public bool IsVeteran { get; set; }

        [DisplayName("Country of Origin")]
        [StringLength(25, MinimumLength = 2)]
        [Required(ErrorMessage = "Country of Origin is Required")]
        public string CountryOfOrigin { get; set; }

        [DisplayName("Email")]
        [EmailAddress]
        [Required(ErrorMessage = "An Email Address is Required")]
        public string Email { get; set; }

        [DisplayName("Phone")]
        [Phone]
        [Required(ErrorMessage = "A Phone Number is Required")]
        public string Phone { get; set; }

    }
}
