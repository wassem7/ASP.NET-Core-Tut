using Microsoft.AspNetCore.Mvc;
using SeemzyVilla_VillaApi.Data;
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
            return DataStore.villas;
        }
    }
}
