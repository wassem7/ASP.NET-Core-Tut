using SeemzyVilla_VillaApi.Models.Dtos;

namespace SeemzyVilla_VillaApi.Data
{
    public static class DataStore
    {
        public static List<VillaDTO> VillaList = new List<VillaDTO>()
        {
            new VillaDTO()
            {
                Id = 1,
                Name = "North East Villa",
                Occupancy = 200,
                Sqrft = 1200
            },
            new VillaDTO()
            {
                Id = 2,
                Name = "Higher Heights Villa",
                Occupancy = 340,
                Sqrft = 4500
            },
            new VillaDTO()
            {
                Id = 3,
                Name = "Oasis Villa ",
                Occupancy = 670,
                Sqrft = 980
            }
        };
    }
}
