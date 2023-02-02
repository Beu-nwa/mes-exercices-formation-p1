using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class PersonController : Controller
    {
        public List<Person> persons= new List<Person>();
        public string PersonList()
        {
            string chaine = "liste de personne : ";
            persons.ForEach(p => chaine += p.ToString() + " ,    ");
            return chaine;
        }
        public string Person(int? id)
        {
            return "information de la personne : " + id;
        }
        public IActionResult AddPerson(string nom, string prenom)
        {
            persons.Add(new Person(prenom, nom));
            return View();
        }

        public string CustomDetail(string fn, string ln) // pb : n'affiche pas nom et prenom
        {
            // /custom-person/benoit/combe
            return fn + " " + ln;
        }
        public IActionResult Test()
        {
            // return new ContentResult() { Content = "<h1>test</h1>", ContentType = "text/html" };
            // return new ViewResult() { ViewName= "" };
            return View();
        }

    }
}
