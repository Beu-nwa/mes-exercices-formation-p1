int x;
Console.Write("------ Tableau de notes ------\n Combien de note comportera le tableau :");
while (!Int32.TryParse(Console.ReadLine(), out x)) Console.WriteLine("Erreure de saisie ! Combien de note comportera le tableau ?");
Console.WriteLine($"Merci de saisir les {x} notes :");
int[] intArray = new int[x];
string display = "";

for(int i = 0; i< intArray.Length; i++)
{
    Console.Write($"\t-Note {i+1} : ");
    while (!Int32.TryParse(Console.ReadLine(), out intArray[i]) || intArray[i] < 0 || intArray[i] > 20)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Erreure de saisie ! Quelle est la {i+1}eme note ?");
        Console.ForegroundColor = ConsoleColor.White;
    }
    display += $"\tLa note {i+1} est de {intArray[i]}\n";
}
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"\n------ Liste de note ------");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(display);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"La note max est : {intArray.Max()}");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"La note min est : {intArray.Min()}");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"La moyenne est : {Math.Round(intArray.Average(), 2)}");
Console.ForegroundColor = ConsoleColor.White;