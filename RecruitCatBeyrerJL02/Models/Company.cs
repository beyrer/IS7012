using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RecruitCatBeyrerJL02.Models
{
    public class Company
    {
        [DisplayName("Company Name")]
        public string Name { get; set; }
        [DisplayName("Position")]
        public string Position { get; set; }
        [DisplayName("Minimum Salary")]
        public decimal MinimumSalary { get; set; }
        [DisplayName("Maximum Salary")]
        public decimal MaximumSalary { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Start Date")]
        public DateTime? StartDate { get; set; }
        [DisplayName("Company Location")]
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
        public bool? Hiring { get; set; }
        [DisplayName("Company's Revenue Last Year")]
        public decimal? Reveune { get; set; }
        [DisplayName("Number of Full Time Employees")]
        public int FulltimeEmp { get; set; }

    }
}
