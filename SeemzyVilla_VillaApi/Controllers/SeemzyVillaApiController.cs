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
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
            return Ok(DataStore.VillaList);
        }

        //[HttpGet("id")]
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VillaDTO> GetVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var result = DataStore.VillaList.FirstOrDefault(villa => villa.Id == id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
