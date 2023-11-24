
using Microsoft.AspNetCore.Mvc;
using SeemzyVilla_VillaApi.Models;
using SeemzyVilla_VillaApi.Models.Dtos;

namespace SeemzyVilla_VillaApi.Controllers
{
    [Route("/api/VillaApi")]
    [ApiController]
    public class SeemzyVillaController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return new List<VillaDTO>() { new VillaDTO() { Id = 100, Name = "Vandax Vilka" }, new VillaDTO() { Id = 101, Name = "Higher Heights Villa" }, new Villa() { Id = 102, Name = "Bandox Villa " } };
        }

    }
}