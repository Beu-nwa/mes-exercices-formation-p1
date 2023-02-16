using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaApp.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public Type Type { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public int Price { get; set; }
        [ForeignKey("ingredientId")]
        public List<Ingredient>? Ingredients { get; set; }
        public string ImageFileName { get; set; }
        public byte[] ImageFileData { get; set; }

        public enum Types
        {
            Original,
            Spicy,
            Vege,
            Other
        }
        public bool StockAvailable(int valueToTake = 1) //fonctionnera en dehors du dbContext ?
        {
            if (Ingredients == null) return false;

            foreach (Ingredient ing in Ingredients)
            {
                if (!ing.ToppingStockAvailable(valueToTake)) return false;
            }

            return true;
        }
    }
}

//#region chatgpt pour les images a voir

//public class MyController : Controller
//{
//    private readonly IWebHostEnvironment _webHostEnvironment;

//    public MyController(IWebHostEnvironment webHostEnvironment)
//    {
//        _webHostEnvironment = webHostEnvironment;
//    }

//    [HttpPost]
//    public async Task<IActionResult> AddPizza(Pizza pizza, IFormFile image)
//    {
//        if (image != null && image.Length > 0)
//        {
//            // définir le chemin de destination pour le fichier d'image
//            var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", image.FileName);

//            // enregistrer le fichier d'image sur le serveur
//            using (var stream = new FileStream(filePath, FileMode.Create))
//            {
//                await image.CopyToAsync(stream);
//            }

//            // stocker le nom du fichier d'image dans la propriété ImageFileName de l'objet Pizza
//            pizza.ImageFileName = image.FileName;
//        }

//        // sauvegarder la pizza dans la base de données
//        // ...

//        return View("PizzaAdded");
//    }
//}
//Notez que dans cet exemple, IWebHostEnvironment est injecté dans le contrôleur à l'aide de l'injection de dépendances de .NET. Cela vous permet d'accéder au chemin de racine du site web (WebRootPath) et de déterminer le chemin de destination pour le fichier d'image.



//    #endregion