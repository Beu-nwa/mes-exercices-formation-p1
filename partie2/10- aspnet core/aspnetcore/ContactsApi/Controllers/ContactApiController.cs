using ContactsApi.Datas;
using ContactsApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
//using WebApiApp1.Datas;

namespace ContactsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactApiController : ControllerBase
    {
        private readonly DataDbContext _db;

        public ContactApiController(DataDbContext dataDbContext)
        {
            _db = dataDbContext;
        }

        #region getAll with option firstname parameter

        [HttpGet("/contacts")]
        public IActionResult GetAll(string? startFirstnameSearch)
        {
            if (startFirstnameSearch != null)
            {
                return Ok(_db.Contacts.Where(c => c.FirstName.StartsWith(startFirstnameSearch)).ToList());
            }

            return Ok(_db.Contacts.ToList());
        }

        #endregion

        #region getByName with LastName parameter

        [HttpGet("/contacts/name/{lastName}")]
        public IActionResult GetByName(string lastName)
        {
            var contact = _db.Contacts.FirstOrDefault(c => c.LastName == lastName);

            if (contact == null) return NotFound(new
            {
                Message = "There is no Contact with this lastname."
            });

            return Ok(new
            {
                Message = "Contact found !",
                Contact = contact
            });
        }

        #endregion

        #region getById

        [HttpGet("/contacts/{id}")]
        public IActionResult GetById(int id)
        {
            var contact = _db.Contacts.FirstOrDefault(c => c.Id == id);

            if (contact == null) return NotFound(new
            {
                Message = "There is no Contact with this id."
            });

            return Ok(new
            {
                Message = "Contact found !",
                Contact = contact
            });
        }

        #endregion

        #region adddContact

        [HttpPost("/contacts")]
        public IActionResult Add([FromBody] Contact contact)
        {
            _db.Contacts.Add(contact);
            if (_db.SaveChanges() > 0) return Ok("Contact added.");
            return BadRequest("Something went wrong...");
        }

        #endregion

        #region updateContact

        [HttpPut("/contacts/{id}")]
        public IActionResult Update(int id, [FromBody] Contact contact)
        {
            var contactFromDb = _db.Contacts.Find(id);
            // on récupère l'objet de la BDD, il est TRACKé par EFCore donc les modifications effectuées dessus sont répercutées sur la BDD au moment du SaveChanges

            if (contactFromDb == null) return NotFound(new
            {
                Message = "There is no Contact with this id."
            });

            // on vient vérifier si les champs on changé AVANT de les modifier pour optimiser
            if (contactFromDb.LastName != contact.LastName)
                contactFromDb.LastName = contact.LastName;
            if (contactFromDb.FirstName != contact.FirstName)
                contactFromDb.FirstName = contact.FirstName;
            if (contactFromDb.Title != contact.Title)
                contactFromDb.Title = contact.Title;
            if (contactFromDb.BirthDate != contact.BirthDate)
                contactFromDb.BirthDate = contact.BirthDate;

            if (_db.SaveChanges() == 0) return BadRequest("Something went wrong...");

            return Ok("Contact Updated !");
        }

        #endregion

        #region deleteContact

        [HttpDelete("/contacts/{id}")]
        public IActionResult Remove(int id)
        {
            var contact = _db.Contacts.Find(id);

            if (contact == null) return NotFound(new
            {
                Message = "There is no Contact with this id."
            });

            _db.Contacts.Remove(contact);

            if (_db.SaveChanges() == 0) return BadRequest("Something went wrong...");

            return Ok("Contact Deleted !");
        }

        #endregion




        #region fakedb comment

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

        #endregion
    }
}
