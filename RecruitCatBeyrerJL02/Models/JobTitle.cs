using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RecruitCatBeyrerJL02.Models
{
    public class JobTitle
    {
        [DisplayName("Job Title")]
        public string Title { get; set; }
        [DisplayName("Minimum Salary")]
        public decimal MinimumSalary { get; set; }
        [DisplayName("Job ID")]
        public int Id { get; set; }
        [DisplayName("List of Candidates")]
        public List<Candidate>? Candidates { get; set; }
        [DisplayName("Does this Job Require a Degree?")]
        public bool RequiresDegree { get; set; }

    }
}
