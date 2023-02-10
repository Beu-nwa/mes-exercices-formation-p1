using ContactsApi.Datas;
using ContactsApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiApp1.Datas;

namespace ContactsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactApiController : ControllerBase
    {
        private readonly DataDbContext _dataDbContext;

        public ContactApiController(DataDbContext dataDbContext)
        {
            _dataDbContext = dataDbContext;
        }

        [HttpGet("/contacts")]
        public IActionResult GetAll(string? startFirstnameSearch)
        {
            if (startFirstnameSearch != null) return Ok(_dataDbContext.GetAll(startFirstnameSearch));

            return Ok(_dataDbContext.GetAll());
        }

        //private readonly FakeDb _fakeDb;

        //public ContactApiController(FakeDb fakeDb)
        //{
        //    _fakeDb = fakeDb;
        //}

        //[HttpGet("/contacts")]
        //public IActionResult GetAll(string? startFirstnameSearch)
        //{
        //    if(startFirstnameSearch != null) return Ok(_fakeDb.GetAll(startFirstnameSearch));

        //    return Ok(_fakeDb.GetAll());
        //}

        //[HttpGet("/contacts/{id}")]
        //public IActionResult GetById(int id)
        //{
        //    var contact = _fakeDb.GetById(id);

        //    if (contact == null) { return NotFound(new { Message = "There is no contact with this id." }); }

        //    return Ok(new { Message = "Contact found", Contact = contact });
        //}

        //[HttpGet("/contacts/name/{name}")]
        //public IActionResult GetByFullname(string FullName)
        //{
        //    var contact = _fakeDb.GetByFullname(FullName);

        //    if (contact == null) { return NotFound(new { Message = "There is no contact with this full name." }); }

        //    return Ok(new { Message = "Contact found", Contact = contact });
        //}
        //[HttpPost("/contacts")]
        //public IActionResult Add([FromBody] Contact contact)
        //{
        //    if (_fakeDb.Add(contact)) return Ok("Contact added");

        //    return BadRequest("Something went wrong");
        //}

        //[HttpDelete("/contacts/{id}")]
        //public IActionResult Remove(int id)
        //{
        //    var contact = _fakeDb.GetById(id);

        //    if (contact == null) { return NotFound("There is no contact with this id."); }

        //    if (!_fakeDb.Delete(id)) return BadRequest("Something went wrong while deleting");

        //    return Ok("Contact deleted");
        //}

        //[HttpPut("/contacts/{id}")]
        //public IActionResult Update(int id)
        //{
        //    var contact = _fakeDb.GetById(id);

        //    if (contact == null) { return NotFound("There is no contact with this id."); }

        //    if (!_fakeDb.Edit(id, contact)) return BadRequest("Something went wrong while updating");

        //    return Ok("Contact updated");
        //}
    }
}
