using WebAPI_securisee.Datas;
using WebAPI_securisee.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_securisee.Datas;

namespace WebAPI_securisee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class UsersController : ControllerBase
    {
        private readonly DataDbContext _db;
        public UsersController(DataDbContext db)
        {
            _db = db;
        }

        #region get user with optional string firstname params

        [HttpGet("/users")]
        public IActionResult GetAll(string? startFirstName)
        {
            if (startFirstName != null)
                return Ok(
                    _db.Users.Where(c => c.Firstname!.StartsWith(startFirstName)).ToList()
                    );

            return Ok(_db.Users.ToList());
        }

        #endregion

        #region update user

        [HttpPut("/users/{id}")]
        public IActionResult Update(int id, [FromBody] User user)
        {
            var userFromDb = _db.Users.Find(id);
            // on récupère l'objet de la BDD, il est TRACKé par EFCore donc les modifications effectuées dessus sont répercutées sur la BDD au moment du SaveChanges

            if (userFromDb == null) return NotFound(new
            {
                Message = "There is no User with this id."
            });

            // on vient vérifier si les champs on changé AVANT de les modifier pour optimiser
            if (userFromDb.Lastname != user.Lastname)
                userFromDb.Lastname = user.Lastname;
            if (userFromDb.Firstname != user.Firstname)
                userFromDb.Firstname = user.Firstname;
            if (userFromDb.UserGender != user.UserGender)
                userFromDb.UserGender = user.UserGender;
            if (userFromDb.Email != user.Email)
                userFromDb.Email = user.Email;
            if (userFromDb.Phone != user.Phone)
                userFromDb.Phone = user.Phone;
            if (userFromDb.Address != user.Address)
                userFromDb.Address = user.Address;
            if (userFromDb.PassWord != user.PassWord)
                userFromDb.PassWord = user.PassWord;
            if (userFromDb.IsAdmin != user.IsAdmin)
                userFromDb.IsAdmin = user.IsAdmin;

            if (_db.SaveChanges() == 0) return BadRequest("Something went wrong...");

            return Ok("User Updated !");
        }

        #endregion

        #region delete user by id

        [HttpDelete("/users/{id}")]
        public IActionResult Remove(int id)
        {
            var user = _db.Users.Find(id);

            if (user == null) return NotFound(new
            {
                Message = "There is no User with this id."
            });

            _db.Users.Remove(user);

            if (_db.SaveChanges() == 0) return BadRequest("Something went wrong...");

            return Ok("User Deleted !");
        }

        #endregion

        // INUTILES 
        //#region get user by lastname

        //[HttpGet("/users/name/{lastName}")]
        //public IActionResult GetByName(string lastName)
        //{
        //    var user = _db.Users.FirstOrDefault(c => c.Lastname == lastName);

        //    if (user == null) return NotFound(new
        //    {
        //        Message = "There is no User with this lastname."
        //    });

        //    return Ok(new
        //    {
        //        Message = "User found !",
        //        User = user
        //    });
        //}

        //#endregion

        //#region get user by id

        //[HttpGet("/users/{id}")]
        //public IActionResult GetById(int id)
        //{
        //    var user = _db.Users.FirstOrDefault(c => c.Id == id);

        //    if (user == null) return NotFound(new
        //    {
        //        Message = "There is no User with this id."
        //    });

        //    return Ok(new
        //    {
        //        Message = "User found !",
        //        User = user
        //    });
        //}

        //#endregion

        //#region add user 

        //[HttpPost("/users")]
        //public IActionResult Add([FromBody] User user)
        //{
        //    _db.Users.Add(user);
        //    if (_db.SaveChanges() > 0) return Ok("User added.");
        //    return BadRequest("Something went wrong...");
        //}

        //#endregion


    }
}
