using System.ComponentModel.DataAnnotations;

namespace SeemzyVilla_VillaApi.Models.Dtos
{
    public class VillaDTO
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        public int Occupancy { get; set; }
        public int Sqrft { get; set; }
        public string ImageUrl { get; set; }
        public string Amenity { get; set; }

        [Required]
        public double Rate { get; set; }
    }
}
