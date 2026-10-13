namespace oopArv
{
    public class Sheep : Animal
    {
        public Sheep() : base("får", 3, "vit", 2, true, "människo blod", ConsoleColor.White,"RAAAWWWR")
        {
        }
        public override void GetAnimalInfo(string name, int age, int howLongAtZoo)
        {
            Console.WriteLine($"Till sist och absolut minst! Har vi vårat {Name} Shaun!");
            Console.Write($"Shaun är {Age} år gammal och har bott med sin nya familj här i {HowLongAtZoo} år!");
            Wait();
        }
        public override void AnimalColor(string color)
        {
            Console.Write($"Shaun har {Color} fluffig");
            ChangeFontColor();
            Console.WriteLine(" päls!");
            Wait();
        }
        public override void FavoriteFoods(string favoriteFood)
        {
            Console.Write($"Shaun har inget annat än {FavoriteFood} som sin favorit mat! Så se till att ha koll på familjen!");
            Wait();
        }
        public override void CheckEndOfAnimal(bool checkEnd)
        {
            Console.WriteLine($"1. För att läsa om!\n");
            Console.WriteLine($"2. För att fortsätta till nästa djur!");
            while (CheckEnd)
            {
                Animal[] animals = { new Lion("", 0, 0), new Bear(), new Sheep() };
                foreach (Animal endOfAnimal in animals)
                {
                    string userInput = Console.ReadLine();
                    if(!int.TryParse(userInput, out int number))
                    {
                    }
                    else if (userInput == "1")
                    {
                        Console.WriteLine("Börjar om!..");
                        Wait();
                        animals[2].GetAnimalInfo(Name, Age, HowLongAtZoo);
                        animals[2].AnimalColor(Color);
                        animals[2].FavoriteFoods("");
                        animals[2].AnimalSounds(AnimalSound);
                        CheckEndOfAnimal(true);
                        break;
                    }
                    else if (userInput == "2")
                    {
                        Console.WriteLine("Fortsätter!..");
                        break;
                    }
                    break;
                }
            }
        }
    }
}
