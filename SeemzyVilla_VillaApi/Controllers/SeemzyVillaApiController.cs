using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using SeemzyVilla_VillaApi.Data;
using SeemzyVilla_VillaApi.Models;
using SeemzyVilla_VillaApi.Models.Dtos;

namespace SeemzyVilla_VillaApi.Controllers
{
    [Route("/api/VillaApi")]
    [ApiController]
    public class SeemzyVillaController : ControllerBase
    {
        private readonly ILogger<SeemzyVillaController> _logger;

        public SeemzyVillaController(ILogger<SeemzyVillaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
            _logger.LogInformation("Getting all villas..");
            return Ok(DataStore.VillaList);
        }

        //[HttpGet("id")]
        [HttpGet("{id:int}", Name = "GetVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VillaDTO> GetVilla(int id)
        {
            if (id == 0)
            {
                _logger.LogError("Get Villa error with Id : {0}", id);
                return BadRequest();
            }

            var result = DataStore.VillaList.FirstOrDefault(villa => villa.Id == id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<VillaDTO> CreateVilla([FromBody] VillaDTO villadto)
        {
            if (
                DataStore
                    .VillaList
                    .FirstOrDefault(villa => villa.Name.ToLower() == villadto.Name.ToLower())
                != null
            )
            {
                ModelState.AddModelError(
                    "Duplicate Villa Error",
                    "Villa already exists in the system"
                );

                return BadRequest(ModelState);
            }

            if (villadto.Id > 0)
            {
                return new BadRequestObjectResult("Charle , make the id 0 wai !");
            }

            villadto.Id =
                DataStore.VillaList.OrderByDescending(villa => villa.Id).FirstOrDefault().Id + 1;

            DataStore.VillaList.Add(villadto);

            return CreatedAtRoute("GetVilla", new { id = villadto.Id }, villadto);
        }

        [HttpDelete("{id:int}", Name = "DeleteVilla")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult DeleteVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var villa = DataStore.VillaList.FirstOrDefault(villa => villa.Id == id);

            if (villa == null)
            {
                return NotFound();
            }

            DataStore.VillaList.Remove(villa);
            return NoContent();
        }

        [HttpPut("{id:int}", Name = "UpdateVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdateVilla(int id, VillaDTO villadto)
        {
            if (id != villadto.Id || villadto == null)
            {
                return BadRequest();
            }

            var villa = DataStore.VillaList.FirstOrDefault(villa => villa.Id == id);

            if (villa == null)
            {
                return NotFound();
            }

            villa.Name = villadto.Name;
            villa.Occupancy = villadto.Occupancy;
            villa.Sqrft = villadto.Sqrft;

            return NoContent();
        }

        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PartialUpdateVilla(int id, JsonPatchDocument<VillaDTO> patchdto)
        {
            if (patchdto == null || id == 0)
            {
                return BadRequest();
            }

            var villa = DataStore.VillaList.FirstOrDefault(villa => villa.Id == id);

            if (villa == null)
            {
                return NotFound();
            }

            patchdto.ApplyTo(villa, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return NoContent();
        }
    }
}
