using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BearcatSportsBuyback.Models
{
    public class Sport
    {
        public int Id { get; set; }

        [DisplayName("Sport Name")]
        [StringLength(40, MinimumLength = 2)]
        [Required(ErrorMessage = "A Sport Name is Required")]
        public string? SportName { get; set; }

        public List<Member>? Members { get; set; }


        public List<League>? Leagues { get; set; }


        public List<SportingGood>? SportingGoods { get; set; }

    }
}
