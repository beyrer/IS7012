using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RecruitCatBeyrerJL02.Models
{
    public class JobTitle
    {
        [DisplayName("Job Title")]
        [StringLength(30, MinimumLength = 3)]
        [Required(ErrorMessage = "A Job Title is Required")]
        public string Title { get; set; }

        [DisplayName("Minimum Salary")]
        [Range(1, 100000)]
        public decimal? MinimumSalary { get; set; }

        [DisplayName("Job ID")]
        public int Id { get; set; }

        [DisplayName("List of Candidates")]
        public List<Candidate>? Candidates { get; set; }

        [DisplayName("Does this Job Require a Degree?")]
        public bool? RequiresDegree { get; set; }

    }
}
