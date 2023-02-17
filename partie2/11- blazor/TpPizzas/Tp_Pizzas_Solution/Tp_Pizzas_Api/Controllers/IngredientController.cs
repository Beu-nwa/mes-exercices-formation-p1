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
    public class IngredientController : ControllerBase
    {
        private readonly DataDbContext _db;

        public IngredientController(DataDbContext context)
        {
            _db = context;
        }

        // GET: api/Ingredient
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ingredient>>> GetIngredients()
        {
            return await _db.Ingredients.Include(i => i.Pizzas).ToListAsync();
        }
        // GET: api/Ingredient/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ingredient>> GetIngredient(int id)
        {
            var ingredient = await _db.Ingredients.Include(i => i.Pizzas).FirstOrDefaultAsync(i => i.IngredientId == id);

            if (ingredient == null)
            {
                return NotFound();
            }

            return ingredient;
        }

        // PUT: api/Ingredient/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIngredient(int id, Ingredient ingredient)
        {
            if (id != ingredient.IngredientId)
            {
                return BadRequest();
            }

            _db.Entry(ingredient).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IngredientExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Ingredient
        [HttpPost]
        public async Task<ActionResult<Ingredient>> PostIngredient(Ingredient ingredient)
        {
            _db.Ingredients.Add(ingredient);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(GetIngredient), new { id = ingredient.IngredientId }, ingredient);
        }

        // DELETE: api/Ingredient/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIngredient(int id)
        {
            var ingredient = await _db.Ingredients.FindAsync(id);
            if (ingredient == null)
            {
                return NotFound();
            }

            _db.Ingredients.Remove(ingredient);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool IngredientExists(int id)
        {
            return _db.Ingredients.Any(e => e.IngredientId == id);
        }
    }
}
