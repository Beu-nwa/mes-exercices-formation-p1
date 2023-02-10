using WebApiApp1.Models;

namespace WebApiApp1.Datas
{
    // voir notions sigleton, scoped, transient => création de services
    //
    // transient    => récré à chaque fois que le contrôleur en a besoin.
    // scoped       => une seule fois par connection cliente.
    // sigleton     => une fois puis utilisé par toute l'application.
    public class FakeDb
    {
        // ctrl r r => pour renomer toutes les variables portant le même nom
        private List<Dinosaur> _dinosaurs { get; set;} // "_" est la norme pour les props privées

        public FakeDb()
        {
            _dinosaurs = new List<Dinosaur>()
            {
                new Dinosaur{Id=1, Age=20, Name="Denver", Color=Dinosaur.DinoColor.Green, Specy="Corythosaurus"},
                new Dinosaur{Id=2, Age=16, Name="Petit pieds", Color=Dinosaur.DinoColor.Yellow, Specy="Apathosaurus"}
            };
        }
        public List<Dinosaur> GetAll() { return _dinosaurs; }
        public Dinosaur? GetById(int id) { return _dinosaurs.FirstOrDefault(d => d.Id == id); }
        public bool Add(Dinosaur dinosaur) { _dinosaurs.Add(dinosaur); return true; }
        public bool Edit(int id, Dinosaur dinosaur)
        {
            var dinoFromDb = _dinosaurs.FirstOrDefault(d => d.Id == id);

            if (dinoFromDb == null) return false;

            dinoFromDb.Name = dinosaur.Name;
            dinoFromDb.Specy = dinosaur.Specy;
            dinoFromDb.Age = dinosaur.Age;
            dinoFromDb.Color = dinosaur.Color;
            return true;
        }
        public bool Delete(int id)
        {
            _dinosaurs.RemoveAll(d => d.Id == id);
            return true;
        }
    }
}

