//using ContactsApi.Models;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using static ContactsApi.Models.Contact;

//namespace WebApiApp1.Datas
//{
//    // voir notions sigleton, scoped, transient => création de services
//    //
//    // transient    => récré à chaque fois que le contrôleur en a besoin.
//    // scoped       => une seule fois par connection cliente.
//    // sigleton     => une fois puis utilisé par toute l'application.
//    public class FakeDb
//    {
//        // ctrl r r => pour renomer toutes les variables portant le même nom
//        private List<Contact> _contacts { get; set;} // "_" est la norme pour les props privées

//        public FakeDb()
//        {
//            _contacts = new List<Contact>()
//            {
//                new Contact("Lelaitier", "Maxou", new DateTime(1314, 5, 18), ContactGender.MALE),
//                new Contact("Kombini", "Benot", new DateTime(1977, 11, 06), ContactGender.MALE)
//        };
//        }
//        public List<Contact> GetAll() { return _contacts; }
//        public List<Contact> GetAll(string recherchePrenom) 
//        { 
//            return _contacts.FindAll(c => c.FirstName.StartsWith(recherchePrenom)); 
//        }
//        public Contact? GetById(int id) { return _contacts.FirstOrDefault(d => d.Id == id); }
//        public Contact? GetByFullname(string fn)
//        {
//            return _contacts.FirstOrDefault(d => d.FullName == fn);
//        }
//        public bool Add(Contact dinosaur) { _contacts.Add(dinosaur); return true; }
//        public bool Edit(int id, Contact contact)
//        {
//            var contactFromDb = _contacts.FirstOrDefault(d => d.Id == id);

//            if (contactFromDb == null) return false;

//            contactFromDb.LastName = contact.LastName;
//            contactFromDb.FirstName = contact.FirstName;
//            contactFromDb.FullName = contact.FirstName + " " + contact.LastName;
//            contactFromDb.BirthDate= contact.BirthDate;
//            contactFromDb.Age = (int)Math.Round((DateTime.Now - contact.BirthDate).TotalDays / 365.25);
//            contactFromDb.Title= contact.Title;
//            contactFromDb.AvatarUrl = contact.AvatarUrl;

//            return true;
//        }
//        public bool Delete(int id)
//        {
//            _contacts.RemoveAll(d => d.Id == id);
//            return true;
//        }
//    }
//}

