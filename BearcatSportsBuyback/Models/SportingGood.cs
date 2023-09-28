using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BearcatSportsBuyback.Models
{
    public class SportingGood
    {
        public int Id { get; set; }

        [DisplayName("Item Name")]
        [StringLength(50, MinimumLength = 2)]
        [Required(ErrorMessage = "An Item Name is Required")]
        public string Name { get; set; }

        [DisplayName("Quantity On-Hand")]
        public int Quantity { get; set; }


        public Sport? Sport { get; set; }


        public int? SportId { get; set; }

    }
}
