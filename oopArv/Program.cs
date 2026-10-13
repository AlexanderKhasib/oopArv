namespace oopArv
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("", 0, "", 0, true, "", ConsoleColor.Black, "");
            Console.WriteLine("Välkommen till mitt zoo! / Tryck valfri knapp för att fortsätta! \n");
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            Console.Clear();
            animal.AddAllAnimals();
        }
    }
}
