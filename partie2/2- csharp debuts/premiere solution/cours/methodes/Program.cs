
namespace LesFonctions
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region fct sans params sans retour
            Bvn();
            #endregion

            #region fct sans params avec retour
            Console.WriteLine(Chiffre());
            Console.WriteLine(Bvn2());
            #endregion

            #region fct avec params sans retour
            Calc(4,8);
            #endregion

            #region fct avec params avec retour
            Console.WriteLine(Calc2(4, 8));
            #endregion


        }
        static void Bvn()
        {
            Console.WriteLine("Hello");
        }
        static string Bvn2()
        {
            return "Hello";
        }
        static int Chiffre()
        {
            int chiffre = 10;
            return chiffre;
        }
        static void Calc(int x, int y)
        {
            Console.WriteLine(x*y);
        }
        static int Calc2(int x, int y)
        {
            return x*y;
        }

    }
}

