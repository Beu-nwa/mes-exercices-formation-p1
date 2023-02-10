using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiApp1.Datas;
using WebApiApp1.Models;

namespace WebApiApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DinosaurController : ControllerBase
    {
        private readonly FakeDb _fakeDb;
        // ctor tab => crée un controller
        public DinosaurController(FakeDb fakeDb)
        {
            _fakeDb = fakeDb;
        }

        [HttpGet("/dinosaurs")]
        public IActionResult GetAll()
        {
            return Ok(_fakeDb.GetAll());
        }

        [HttpGet("/dinosaurs/{id}")]
        public IActionResult GetById(int id)
        {
            var dino = _fakeDb.GetById(id);

            if(dino == null) { return NotFound( new { Message = "There is no dinosaur with this id." }); }

            return Ok(new { Message = "Dinosaur found" , Dinosaure = dino });
        }
        [HttpPost("/dinosaurs")]
        public IActionResult Add([FromBody] Dinosaur dino)
        {
            //if(_fakeDb.Add(dino)) { return Ok(new { Message = "Dino added" });
            if (_fakeDb.Add(dino)) return Ok("Dino added");

            return BadRequest("Something went wrong");
        }

        [HttpDelete("/dinosaurs/{id}")]
        public IActionResult Remove(int id)
        {
            var dino = _fakeDb.GetById(id);

            if (dino == null) { return NotFound("There is no dinosaur with this id."); }

            if (!_fakeDb.Delete(id)) return BadRequest("Something went wrong while deleting");

            return Ok("Dinosaur deleted");
        }

        [HttpPut("/dinosaurs/{id}")]
        public IActionResult Update(int id)
        {
            var dino = _fakeDb.GetById(id);

            if (dino == null) { return NotFound("There is no dinosaur with this id."); }

            if (!_fakeDb.Edit(id, dino)) return BadRequest("Something went wrong while updating");

            return Ok("Dinosaur updated");
        }
    }
}
