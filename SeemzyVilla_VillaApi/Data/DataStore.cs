using SeemzyVilla_VillaApi.Models.Dtos;

namespace SeemzyVilla_VillaApi.Data
{
    public static class DataStore
    {
        public static List<VillaDTO> VillaList = new List<VillaDTO>()
        {
            new VillaDTO() { Id = 1, Name = "North East Villa" },
            new VillaDTO() { Id = 2, Name = "Higher Heights Villa" },
            new VillaDTO() { Id = 3, Name = "Oasis Villa " }
        };
    }
}
