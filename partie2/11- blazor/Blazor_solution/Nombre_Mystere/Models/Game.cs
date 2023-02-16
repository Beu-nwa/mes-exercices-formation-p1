namespace Nombre_Mystere.Models
{
    public class Game
    {
        public DateTime DateOfTheGame { get; set; }
        public int FoundNumber { get; set; }
        public int TryCounter { get; set; }
        public bool Result { get; set; }

        public Game(int a, int b, bool r)
        {
            DateOfTheGame = DateTime.Now;
            FoundNumber = a;
            TryCounter = b;
            Result = r;
        }
    }
}
