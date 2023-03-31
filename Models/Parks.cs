using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParksLookupApi.Models
{
    public class Park
    {

        public int ParkId { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        public string State { get; set; }
    }
}