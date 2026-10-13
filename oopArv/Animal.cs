using System.Drawing;
namespace oopArv
{
    public class Animal
    {
        // Properties with default shared values for all animals
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public int HowLongAtZoo { get; set; }
        public string FavoriteFood { get; set; }
        public string AnimalSound { get; set; }
        public bool CheckEnd { get; set; } = true;
        public ConsoleColor ConsoleNewColor { get; set; }
        public Animal(string name, int age, string color, int howLongAtZoo, bool checkEnd, string favoriteFood, ConsoleColor consoleNewColor, string animalSound)
        {
            Name = name;
            Age = age;
            Color = color;
            HowLongAtZoo = howLongAtZoo;
            FavoriteFood = favoriteFood;
            ConsoleNewColor = consoleNewColor;
            AnimalSound = animalSound;
            CheckEnd = checkEnd;
        }
        public void Wait()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine();
            Console.WriteLine("\nTryck valfri knapp för att gå vidare...  ");
            Console.ReadKey(true);
            Console.Clear();
            Console.ResetColor();
        }
        public virtual void AddAllAnimals()
        {
            Animal[] zoo = { new Lion("", 0, 0), new Bear(), new Sheep() };
            foreach (Animal animal in zoo)
            {
                animal.GetAnimalInfo("", 0, 0);
                animal.AnimalColor("");
                animal.FavoriteFoods("");
                animal.AnimalSounds("");
                CheckEndOfAnimal(true);
            }
        }
        public virtual void ChangeFontColor()
        {
            Console.ForegroundColor = ConsoleNewColor;
            Console.Write(Color);
            Console.ResetColor();
        }
        public virtual void GetAnimalInfo(string name, int age, int howLongAtZoo)
        {
            Console.WriteLine($"Det är en {Name} som är {Age} år. Den har {HowLongAtZoo} år.");
        }
        public virtual void AnimalColor(string color)
        {
            Console.WriteLine($"{Name} har vart här i {HowLongAtZoo} år");
        }
        public virtual void FavoriteFoods(string favoriteFood)
        {
            Console.WriteLine($"{Name} favorit mat är {FavoriteFood}");
        }
        public virtual void AnimalSounds(string animalSounds)
        {
            Console.WriteLine($"{Name} låter {AnimalSound}");
        }
        public virtual void CheckEndOfAnimal(bool checkEnd)
        {
            Console.WriteLine($"1. För att läsa om!\n");
            Console.WriteLine($"2. För att fortsätta till nästa djur!");
            while (CheckEnd)
            {
                string userInput = Console.ReadLine();
                Animal[] zoo = { new Lion("", 0, 0), new Bear(), new Sheep() };
                foreach (Animal animal in zoo)
                {
                    if (!int.TryParse(userInput, out int number))
                    {
                        Console.WriteLine("Använd gilligt tecken");
                        continue;
                    }else if(userInput == "1")
                    {
                        animal.GetAnimalInfo("", 0, 0);
                        animal.AnimalColor("");
                        animal.FavoriteFoods("");
                        animal.AnimalSounds("");
                        break;
                    }
                    else if (userInput == "2")
                    {
                        Console.WriteLine("Fortsätter!..");
                        break;
                    }

                }

                break;
                
            }
        }
    }
}
