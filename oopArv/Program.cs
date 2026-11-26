namespace oopArv
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a new Bear object, inheriting the default values from the Animal and Bear classes
            Bear bear = new Bear("Bamse");

            // Prints out the bear's properties set in the Bear constructor
            Console.WriteLine($"Namn: {bear.Name} (Brunbjörn) - Ålder: {bear.Age} år - Vikt: {bear.Weight}kg - I ide: {bear.IsHibernating}\n");

            // Then call after the bear's inherited, unique and overridden method
            bear.Eat();
            bear.EatingHoney();
            bear.MakeSound();
            Console.WriteLine();


            // Create a new Blackbear object, inheriting the default values from the Animal, Bear, and Blackbear classes
            Blackbear blackBear = new Blackbear("Pontus");

            // Prints out the Blackbear's properties set in the Blackbear constructor
            Console.WriteLine($"Namn: {blackBear.Name} (Svartbjörn) - Ålder: {blackBear.Age} år - Vikt: {blackBear.Weight}kg - I ide: {blackBear.IsHibernating}\n");

            // Then call after the Blackbear's inherited, unique and overridden method
            blackBear.TimeAtZoo();
            blackBear.Hibernation();
            blackBear.MakeSound();
            Console.WriteLine();


            // Create a new Polarbear object, inheriting the default values from the Animal, Bear, and Polarbear classes
            Polarbear polarbear = new Polarbear("Glasse");

            // Prints out the Polarbear's properties set in the Polarbear constructor
            Console.WriteLine($"Namn: {polarbear.Name} (Isbjörn) - Ålder: {polarbear.Age} år - Vikt:{polarbear.Weight}kg - I ide: {polarbear.IsHibernating}\n");

            // Then call after the Polarbear's inherited, unique and overridden method
            polarbear.Eat();
            polarbear.CatchingFish();
            polarbear.MakeSound();
            Console.WriteLine();


            // Create a new Lion object, inheriting the default values from the Animal and Lion classes
            Lion lion = new Lion("Mufasa");

            // Prints out the Lion's properties set in the Lion constructor
            Console.WriteLine($"Namn: {lion.Name} (Lejon) - Ålder: {lion.Age} år - Vikt {lion.Weight}kg - Barn: {lion.LionCubs}\n");

            // Then call after the Lion's inherited, unique and overridden method
            lion.Eat();
            lion.LionPartner();
            lion.MakeSound();
            Console.WriteLine();


            // Create a new Sheep object, inheriting the default values from the Animal and Sheep classes
            Sheep sheep = new Sheep("Shaun");

            // Prints out the Sheep's properties set in the Sheep constructor
            Console.WriteLine($"Namn: {sheep.Name} (Får) - Ålder: {sheep.Age} år - Vikt {sheep.Weight}kg - Färg: {sheep.FurColor}\n");

            // Then call after the Sheep's inherited, unique and overridden method
            sheep.Eat();
            sheep.Sleeping();
            sheep.MakeSound();
            Console.WriteLine();


            // Create an array to store all the animals
            Animal[] animals = { bear, blackBear, polarbear, lion, sheep };
            Console.WriteLine("Alla djur låter så här!");

            // Loop through each animal in the animals array with the foreach loop
            // Then print out all animals but with their unique sound from MakeSound() method attached 
            foreach (Animal zooAnimals in animals)
            {
                zooAnimals.MakeSound();
            }
        }
    }
}
