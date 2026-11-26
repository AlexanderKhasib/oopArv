namespace oopArv
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("", 0, 0, 0, false);
          

            Console.WriteLine();

            Bear bear = new Bear("Bamse");
            Console.WriteLine($"Namn: {bear.Name} (Brunbjörn) - Ålder: {bear.Age} år - Vikt: {bear.Weight}kg - I ide: {bear.IsHibernating}\n");
            bear.Eat();
            bear.EatingHoney();
            bear.MakeSound();

            Console.WriteLine();

            Blackbear blackBear = new Blackbear("Pontus");
            Console.WriteLine($"Namn: {blackBear.Name} (Isbjörn) - Ålder: {blackBear.Age} år - Vikt: {blackBear.Weight}kg - I ide: {blackBear.IsHibernating}\n");
            blackBear.TimeAtZoo();
            blackBear.Hibernation();
            blackBear.MakeSound();

            Console.WriteLine();

            Polarbear polarbear = new Polarbear("Glasse");
            Console.WriteLine($"Namn: {polarbear.Name} (Svartbjörn) - Ålder: {polarbear.Age} år - Vikt:{polarbear.Weight}kg - I ide: {polarbear.IsHibernating}\n");
            polarbear.Eat();
            polarbear.CatchingFish();
            polarbear.MakeSound();

            Console.WriteLine();

            Lion lion = new Lion("Mufasa");
            Console.WriteLine($"Namn: {lion.Name} (Lejon) - Ålder: {lion.Age} år - Vikt {lion.Weight}kg - Barn: {lion.LionCubs}\n");
            lion.LionPartner();
            lion.Eat();
            lion.MakeSound();

            Console.WriteLine();

            Sheep sheep = new Sheep("Shaun");
            Console.WriteLine($"Namn: {sheep.Name} (Får) - Ålder: {sheep.Age} år - Vikt {sheep.Weight}kg - Färg: {sheep.FurColor}\n");
            sheep.Eat();
            sheep.Sleeping();
            sheep.MakeSound();

            Console.WriteLine();

            Animal[] animals = { animal, bear, blackBear, polarbear, lion, sheep };

            Console.WriteLine("Alla djur låter så här!");
            foreach (Animal zooAnimals in animals)
            {
                zooAnimals.MakeSound();
            }

        }
    }
}
