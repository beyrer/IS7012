using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace RecruitCatBeyrerJL.Models
{
    public class Candidate
    {
        [DisplayName("First Name")]
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; }
        [DisplayName("Target Salary")]
        public decimal TargetSalary { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Start Date")]
        public DateTime? StartDate { get; set; }
        [DisplayName("Maximum Salary")]
        public decimal MaximumSalary { get; set; }
        [DisplayName("Company")]
        public Company? Company { get; set; }
        [DisplayName("Company ID")]
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
        public DateTime? DOB { get; set; }
        [DisplayName("Veteran Status")]
        public bool IsVeteran { get; set; }
        [DisplayName("Country of Origin")]
        public string? CountryOfOrigin { get; set; }
        [DisplayName("Email")]
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }

    }
}
