namespace RecruitCatBeyrerJL.Models
{
    public class JobTitle
    {
        public string Title { get; set; }
        public decimal MinimumSalary { get; set; }
        public int Id { get; set; }
        public List<Candidate> Candidates { get; set; }
        public bool RequiresDegree { get; set; }

    }
}
