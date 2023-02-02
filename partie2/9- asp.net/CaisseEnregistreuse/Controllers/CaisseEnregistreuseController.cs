using CaisseEnregistreuse.Models;
using CaisseEnregistreuse.Tools;
using Microsoft.AspNetCore.Mvc;

namespace CaisseEnregistreuse.Controllers
{
    public class CaisseEnregistreuseController : Controller
    {
        private DataDbContext _dbContext;

        List<ProductViewModel> productList = new List<ProductViewModel>()
            {
                new ProductViewModel("Fraise",10, 1),
                new ProductViewModel("Abricot",50, 1),
                new ProductViewModel("Banane",80, 1),
                new ProductViewModel("Panais",20, 2),
            };
        List<Category> CategoryList = new List<Category>()
            {
                new Category(1,"Fruit"),
                new Category(2,"Légume"),
            };
        public CaisseEnregistreuseController()
        {
            _dbContext = new DataDbContext();
        }
        public IActionResult Index(int? id)
        {
            return View("Index");
        }
        //public IActionResult Product(int? id)
        //{
        //    //ViewData["Index"] = index;
        //    //return View();

        //    return View("Index");


        //    //Console.WriteLine("Received index value: " + index);
        //    //var model = new ProductViewModel { Index = index };
        //    //return View(model);
        //}
        public IActionResult Product(int? id)
        {
            ViewBag.ProductId = id;
            return View();
        }
        public IActionResult Product_List()
        {
            // v1 viewdata
            ViewData["products"] = productList;
            ViewData["categories"] = CategoryList;

            // v2 viewbag
            //ViewBag.Products = productList;


            //ViewData["products"] = _dbContext.Products.ToList();
            //ViewBag.products = _dbContext.Products.ToList();
            return View();
        }

        //public IActionResult Product_List()
        //{
        //    ViewData["categories"] = _dbContext.Categories.ToList();
        //    ViewData["products"] = _dbContext.Products.ToList();
        //    //ViewBag.products = _dbContext.Products.ToList();
        //    return View();
        //}

        public IActionResult Product_Add()
        {
            return View();
        }
        public IActionResult ShoppingCart()
        {
            return View();
        }

        public IActionResult Category_List()
        {

            ViewData["categories"] = CategoryList;
            return View();
        }
        public IActionResult Category(int? id)
        {
            List<ProductViewModel> Products = productList.Where(p => p.CategoryId == id).ToList();
            //List<Category> Categories = CategoryList.Where(c => c.CategoryId == id).ToList();

            return View("~/Views/CaisseEnregistreuse/Category.cshtml", Products);
        }
    }
}
