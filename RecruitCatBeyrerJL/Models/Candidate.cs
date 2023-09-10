using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace RecruitCatBeyrerJL.Models
{
    public class Candidate
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal TargetSalary { get; set; }
        public string StartDate { get; set; }
        public decimal MaximumSalary { get; set; }
        public Company? Company { get; set; }
        public int? CompanyId { get; set; }
        public int Id { get; set; }
        public JobTitle Title { get; set; }
        public int TitleId { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
        public DateTime? DOB { get; set; }
        public bool IsVeteran { get; set; }
        public string CountryOfOrigin { get; set; }

    }
}
