using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tp_Pizzas_Api.Datas;
using Tp_Pizzas_Api.Models;

namespace Tp_Pizzas_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class PizzaIngredientController : ControllerBase
    {
        private readonly DataDbContext _db;

        public PizzaIngredientController(DataDbContext context)
        {
            _db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PizzaIngredient>>> GetPizzaIngredients()
        {
            return await _db.PizzaIngredients.ToListAsync();
        }

        [HttpGet("{pizzaId}/{ingredientId}")]
        public async Task<ActionResult<PizzaIngredient>> GetPizzaIngredient(int pizzaId, int ingredientId)
        {
            var pizzaIngredient = await _db.PizzaIngredients.FindAsync(pizzaId, ingredientId);

            if (pizzaIngredient == null)
            {
                return NotFound();
            }

            return pizzaIngredient;
        }

        [HttpPost]
        public async Task<ActionResult<PizzaIngredient>> PostPizzaIngredient(PizzaIngredient pizzaIngredient)
        {
            _db.PizzaIngredients.Add(pizzaIngredient);
            await _db.SaveChangesAsync();

            return CreatedAtAction("GetPizzaIngredient", new { pizzaId = pizzaIngredient.PizzaId, ingredientId = pizzaIngredient.IngredientId }, pizzaIngredient);
        }

        [HttpDelete("{pizzaId}/{ingredientId}")]
        public async Task<IActionResult> DeletePizzaIngredient(int pizzaId, int ingredientId)
        {
            var pizzaIngredient = await _db.PizzaIngredients.FindAsync(pizzaId, ingredientId);

            if (pizzaIngredient == null)
            {
                return NotFound();
            }

            _db.PizzaIngredients.Remove(pizzaIngredient);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }

}
