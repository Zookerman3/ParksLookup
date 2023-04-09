using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ParksLookupApi.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        [ForeignKey("Park")]
        public int ParkId { get; set; }

        [StringLength(120)]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        [Range(1, 5, ErrorMessage = "The value must be between 1 and 5")]
        public int Rating {get; set; }
    }
}