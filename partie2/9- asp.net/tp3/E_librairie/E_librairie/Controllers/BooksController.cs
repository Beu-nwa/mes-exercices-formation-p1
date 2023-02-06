using E_librairie.Models;
using E_librairie.Tools;
using Microsoft.AspNetCore.Mvc;

namespace E_librairie.Controllers
{
    public class BooksController : Controller
    {
        private DataDbContext _dataDbContext;

        public BooksController(DataDbContext dataDbContext)
        {
            _dataDbContext = dataDbContext;
        }
        public IActionResult Index(string? message)
        {
            ViewBag.Message = message;
            Library library = new Library
            {
                Authors = _dataDbContext.Auteurs.ToList(),
                Categories = _dataDbContext.Categories.ToList(),
                Books = _dataDbContext.Livres.ToList()
            };
            return View(library);
        }
        public IActionResult SubmitAuthor(Auteur auteur)
        {
            _dataDbContext.Auteurs.Add(auteur);
            string message = "";
            if(_dataDbContext.SaveChanges() > 0)
            {
                message = "auteur ajouté";
            }
            else
            {
                message = "erreur auteur";
            }
            return RedirectToAction("Index", "Books", new { message = message });
        }
        
        public IActionResult SubmitCategory(Categorie categorie)
        {
            _dataDbContext.Categories.Add(categorie);
            string message = "";
            if(_dataDbContext.SaveChanges() > 0)
            {
                message = "catégorie ajoutée";
            }
            else
            {
                message = "erreur catégorie";
            }
            return RedirectToAction("Index", "Books", new { message = message });
        }
        
        public IActionResult SubmitBook(Livre livre)
        {
            _dataDbContext.Livres.Add(livre);
            string message = "";
            if(_dataDbContext.SaveChanges() > 0)
            {
                message = "Livre ajoutée";
            }
            else
            {
                message = "erreur livre";
            }
            return RedirectToAction("Index", "Books", new { message = message });
        }




    }
}
