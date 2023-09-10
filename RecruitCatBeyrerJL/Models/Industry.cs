using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace RecruitCatBeyrerJL.Models
{
    public class Industry
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Company> Companies { get; set; }
        public List<Candidate> Candidates { get; set; }

    }
}
