using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_securisee.Datas;
using WebAPI_securisee.Models;

namespace WebAPI_securisee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PizzasController : ControllerBase
    {
        private readonly DataDbContext _db;
        public PizzasController(DataDbContext db)
        {
            _db = db;
        }

        #region get all pizza (=menu) with startPizzaName optional parameter

        [HttpGet("/menu")]
        [AllowAnonymous]
        public IActionResult GetAll(string? startPizzaName)
        {
            if (startPizzaName != null)
            {
                return Ok(_db.Pizzas.Where(p => p.Name.StartsWith(startPizzaName)).ToList());
            }

            return Ok(_db.Pizzas.ToList());
        }

        #endregion

        #region add pizza

        [HttpPost("/pizza")]
        [Authorize(Roles = "Admin")]
        public IActionResult AddPizza([FromBody] Pizza pizza)
        {
            _db.Pizzas.Add(pizza);
            if (_db.SaveChanges() > 0) return Ok("Pizza added.");
            return BadRequest("Something went wrong...");
        }

        #endregion

        #region add topping with pizza id

        [HttpPost("/pizza/add-topping/{pizzaId}")]
        [Authorize(Roles = "Admin")]
        public IActionResult AddToppingAndUpdatePizza(int pizzaId, [FromBody] Ingredient ingredient)
        {
            var pizzaFromDb = _db.Pizzas.Find(pizzaId);

            if (pizzaFromDb == null) return NotFound(new
            {
                Message = "There is no Pizza with this id."
            });

            //_db.Ingredients.Add(ingredient);
            pizzaFromDb.Ingredients.Add(ingredient);

            if (_db.SaveChanges() == 0) return BadRequest("Something went wrong...");

            return Ok("Pizza Updated with new added topping.");

        }

        #endregion

        #region remove topping with pizza id

        [HttpPost("/pizza/remove-topping/{pizzaId}/{toppingId}")]
        [Authorize(Roles = "Admin")]
        public IActionResult RemoveToppingAndUpdatePizza(int pizzaId, int toppingId)
        {
            var pizzaFromDb = _db.Pizzas.Find(pizzaId);

            if (pizzaFromDb == null) return NotFound(new
            {
                Message = "There is no Pizza with this id."
            });

            //var pizzaToppingFromDb = pizzaFromDb.Ingredients.Where(t => t.Id == toppingId);

            var pizzaToppingFromDb = _db.Ingredients.Where(i => i.PizzaId == pizzaId);
            
            if (pizzaToppingFromDb == null) return NotFound(new
            {
                Message = "There is no topping with this id into Ingredient list from this pizza."
            });

            //pizzaFromDb.Ingredients.Remove(pizzaToppingFromDb.First());

            _db.Ingredients.Remove((Ingredient)pizzaToppingFromDb);

            if (_db.SaveChanges() == 0) return BadRequest("Something went wrong...");

            return Ok("Pizza Updated with deleted topping.");

        }

        #endregion

        #region update pizza with pizza id

        [HttpPut("/pizza/{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult Update(int id, [FromBody] Pizza pizza)
        {
            var pizzaFromDb = _db.Pizzas.Find(id);
            // on récupère l'objet de la BDD, il est TRACKé par EFCore donc les modifications effectuées dessus sont répercutées sur la BDD au moment du SaveChanges

            if (pizzaFromDb == null) return NotFound(new
            {
                Message = "There is no Pizza with this id."
            });

            // on vient vérifier si les champs on changé AVANT de les modifier pour optimiser
            if (pizzaFromDb.Name != pizza.Name)
                pizzaFromDb.Name = pizza.Name;
            if (pizzaFromDb.Description != pizza.Description)
                pizzaFromDb.Description = pizza.Description;
            if (pizzaFromDb.Price != pizza.Price)
                pizzaFromDb.Price = pizza.Price;
            if (pizzaFromDb.Status != pizza.Status)
                pizzaFromDb.Status = pizza.Status;

            if (_db.SaveChanges() == 0) return BadRequest("Something went wrong...");

            return Ok("Pizza Updated !");
        }

        #endregion

        #region delete pizza with id

        [HttpDelete("/pizza/{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult Remove(int id)
        {
            var pizza = _db.Pizzas.Find(id);

            if (pizza == null) return NotFound(new
            {
                Message = "There is no Pizza with this id."
            });

            _db.Pizzas.Remove(pizza);

            if (_db.SaveChanges() == 0) return BadRequest("Something went wrong...");

            return Ok("Pizza Deleted !");
        }

        #endregion

    }
}
