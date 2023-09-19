using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RecruitCatBeyrerJL02.Models
{
    public class Company
    {
        [DisplayName("Company Name")]
        [StringLength(40, MinimumLength = 3)]
        [Required(ErrorMessage = "A Company Name is Required")]
        public string CompanyName { get; set; }

        [DisplayName("Position")]
        [StringLength(25, MinimumLength = 3)]
        [Required(ErrorMessage = "A Position is Required")]
        public string Position { get; set; }

        [DisplayName("Minimum Salary")]
        [Range(1, 500000)]
        public decimal? MinimumSalary { get; set; }

        [DisplayName("Maximum Salary")]
        [Range(1, 1500000)]        
        public decimal? MaximumSalary { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Start Date")]
        public DateTime? StartDate { get; set; }

        [DisplayName("Company Location")]
        [StringLength(25, MinimumLength = 3)]
        public string Location { get; set; }

        [DisplayName("Company ID")]
        public int Id { get; set; }

        [DisplayName("Industry ID")]
        public int IndustryId { get; set; }

        [DisplayName("Industry")]
        public Industry Industry { get; set; }

        [DisplayName("Candidates")]
        public List<Candidate> Candidates { get; set; }

        [DisplayName("Is this Company Hiring?")]
        public bool Hiring { get; set; }

        [DisplayName("Company's Revenue Last Year")]
        public decimal? Reveune { get; set; }

        [DisplayName("Number of Full Time Employees")]
        [Range(1, 100000)]
        [Required(ErrorMessage = "Number of Employees is Required")]
        public int FulltimeEmp { get; set; }

    }
}
