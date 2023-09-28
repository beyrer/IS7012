using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BearcatSportsBuyback.Models
{
    public class League
    {
        public int Id { get; set; }

        [DisplayName("League Name")]
        [StringLength(30, MinimumLength = 2)]
        [Required(ErrorMessage = "A League Name is Required")]
        public string LeagueName { get; set; }




        public Sport? Sport { get; set; }

        public int? SportId { get; set; }

        [DisplayName("League Members")]
        public List<Member>? Members { get; set; }

        //comment out
    }
}
