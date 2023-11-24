
using Microsoft.AspNetCore.Mvc;
using SeemzyVilla_VillaApi.Models;

namespace SeemzyVilla_VillaApi.Controllers
{
    [Route("/api/VillaApi")]
    [ApiController]
    public class SeemzyVillaController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Villa> GetVillas()
        {
            return new List<Villa>() { new Villa() { Id = 100, Name = "Vandax Vilka" }, new Villa() { Id = 101, Name = "Higher Heights Villa" }, new Villa() { Id = 102, Name = "Bandox Villa " } };
        }

    }
}