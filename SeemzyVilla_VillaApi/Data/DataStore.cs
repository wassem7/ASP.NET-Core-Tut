using SeemzyVilla_VillaApi.Models.Dtos;

namespace SeemzyVilla_VillaApi.Data
{
    public static class DataStore
    {
        public static List<VillaDTO> VillaList = new List<VillaDTO>()
        {
            new VillaDTO() { Id = 100, Name = "Vandax Vilka" },
            new VillaDTO() { Id = 101, Name = "Higher Heights Villa" },
            new VillaDTO() { Id = 102, Name = "Bandox Villa " }
        };
    }
}
