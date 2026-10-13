namespace oopArv
{
    public class Lion : Animal
    {
        public Lion(string name, int age, int howLongAtZoo) : base("Lejon", 18, "GUL", 15, true, "KÖTTBULLAR", ConsoleColor.Yellow,"Meeeeeooow")
        {
        }
        public override void GetAnimalInfo(string name, int age, int howLongAtZoo)
        {
            Console.WriteLine($"Här är vårat {Name} MUFASA!\n");
            Console.WriteLine($"Mufasa är idag {Age} år gammal. Men han var bara 3 år gammal när vi räddade räddade hans liv i Tanzanie! \nVi tog hem han hit för att ge han ett säkrare liv! {HowLongAtZoo} år sen!");
            Wait();
         }
        public override void AnimalColor(string color)
        {
            Console.Write($"Mufasa har en len men även mycket tjock {color}");
            ChangeFontColor();
            Console.WriteLine(" färgad päls\n");
        }
        public override void FavoriteFoods(string favoriteFood)
        {
            Console.Write($"Mufasas favoritmat är {FavoriteFood} men han gillar även KESO...");
            Console.WriteLine();
        }
        public override void AnimalSounds(string animalSounds)
        {
            Program program = new Program();
            Console.Write($"Mufasa låter {AnimalSound}...\n");
            Wait();
        }
        public override void CheckEndOfAnimal(bool checkEnd)
        {
            Console.WriteLine($"1. För att läsa om!\n");
            Console.WriteLine($"2. För att fortsätta till nästa djur!");
            while (CheckEnd)
            {
                string userInput = Console.ReadLine();
                Animal[] zoo = { new Lion("", 0, 0), new Bear(), new Sheep() };

                Lion[] lion = {  new Lion("", 0, 0) };

                Animal[] newLion = lion;

                foreach (Animal animal in zoo)
                {
                    if (!int.TryParse(userInput, out int number))
                    {
                        Console.WriteLine("Använd gilligt tecken");
                        continue;
                    }
                    else if (userInput == "1")
                    {
                       GetAnimalInfo("", 0, 0);
                        lion[0].AnimalColor("");
                        lion[0].FavoriteFoods("");
                        lion[0].AnimalSounds("");
                        break;
                    }
                    else if (userInput == "2")
                    {
                        Console.WriteLine("Fortsätter!..");
                        Wait();
                        break;
                    }

                }

                break;
            }
        }
    }
}
