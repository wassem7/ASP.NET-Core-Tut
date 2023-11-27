using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeemzyVilla_VillaApi.Models
{
    public class Villa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Name { get; set; }
        public int Sqrft { get; set; }
        public string ImageUrl { get; set; }
        public string Amenity { get; set; }
        public double Rate { get; set; }
    }
}
