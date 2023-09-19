using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RecruitCatBeyrerJL02.Models
{
    public class Industry
    {
        [DisplayName("Industry Name")]
        [StringLength(25, MinimumLength = 3)]
        [Required(ErrorMessage = "An Industry Name is Required")]
        public string IndustryName { get; set; }

        [DisplayName("Industry ID")]
        public int Id { get; set; }

        [DisplayName("Companies in the Industry")]
        public List<Company> Companies { get; set; }
        
        [DisplayName("Cadidates for this Industry")]
        public List<Candidate> Candidates { get; set; }

    }
}
