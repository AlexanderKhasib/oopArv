namespace oopArv
{
    public class Bear : Animal
    {
        public Bear() : base("Björn", 15, "brun", 14, true, "DUNDER HONUNG", ConsoleColor.DarkYellow,  "[Intro]\r\nBamse! Bamse!\r\nHeja, heja, Bamse!\r\n\r\n[Refräng]\r\nHeja Bamse, starkast är vår Bamse\r\nMen han tycker inte om att slåss\r\nDunderhonung, farmors dunderhoung\r\nÄter han för att bli stark förstås\r\n\r\n[Post-Refräng]\r\nOch kommer någon stöddig typ\r\nOch ger ett litet svaga nyp\r\nDå får han akta sig jamen för Bamse allas vän\r\n\r\n[Refräng]\r\nHeja Bamse\r\nSnällast är vår Bamse\r\nHan är lika snäll som han är stark\r\n\r\n[Mellanspel]\r\n\r\n[Brygga]\r\nOch kommer någon stöddig typ\r\nOch ger ett litet svaga nyp\r\nDå får han akta sig jamen för Bamse allas vän\r\nYou might also like\r\n99 Luftballons\r\nNena\r\nHär kommer Pippi Långstrump\r\nAnna Sahlin\r\nPatient Zero\r\nTaylor Swift\r\n[Refräng]\r\nHeja Bamse, starkast är vår Bamse\r\nMen han tycker inte om att slåss\r\nDunderhonung, farmors dunderhoung\r\nÄter han för att bli stark förstås\r\n\r\n[Stick]\r\nBamse! Bamse!\r\nHeja, heja, Bamse!\r\nBamse! Bamse!\r\nHeja, heja, Bamse!\r\nBamse! Bamse!\r\nHeja, heja, Bamse!\r\nBamse! Bamse!\r\nHeja, heja, Bamse!\r\nBamse! Bamse!\r\nHeja, heja, Bamse!\r\nBamse! Bamse!\r\nHeja, heja, Bamse!\r\nBamse! Bamse!\r\nHeja, heja, Bamse!\r\nBamse! Bamse!\r\nHeja, heja, Bamse!\r\n\r\n[Refräng]\r\nHeja Bamse, starkast är vår Bamse\r\nMen han tycker inte om att slåss\r\nDunderhonung, farmors dunderhoung\r\nÄter han för att bli stark förstås\r\nHeja Bamse, starkast är vår Bamse\r\nMen han tycker inte om att slåss\r\nDunderhonung, farmors dunderhoung\r\nÄter han för att bli stark förstås")
        {
        }
        public override void GetAnimalInfo(string name, int age, int howLongAtZoo)
        {
            Console.WriteLine($"Sen här träffar vi vår {Name}! Som såklart heter BAMSE!\n");
            Console.WriteLine($"Han är {Age} år, Men har levt med oss sen han var 1 år gammal, {HowLongAtZoo} år sedan!");
             Wait();
        }
        public override void AnimalColor(string color)
        {
            Console.Write($"Bamse har en mycket tjock {color}");
            ChangeFontColor();
            Console.WriteLine(" päls!\nMen han ser även till att styla till det lite med sin overall\n");
            Wait();
        }
        public override void FavoriteFoods(string favoriteFood)
        {
            Console.Write($"Och självklart finns det inget Bamse älskar mer än {FavoriteFood}!\n");
            Wait();
        }
        public override void AnimalSounds(string animalSounds)
        {
            Console.WriteLine("Men hur låter egentligen Bamse?...");
            Wait();
            Console.WriteLine("Inget mindre än!!...");
            Wait();
            Program program = new Program();
            Console.Write($"Bamse låter {AnimalSound}...");
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
                    if (userInput == "1")
                    {
                        Console.WriteLine("Börjar om!..");
                        Wait();
                        animals[1].GetAnimalInfo(Name, Age, HowLongAtZoo);
                        animals[1].AnimalColor(Color);
                        animals[1].FavoriteFoods("");
                        animals[1].AnimalSounds(AnimalSound);
                        CheckEndOfAnimal(true);
                        break;
                    }
                    else if (userInput == "2")
                    {
                        Console.WriteLine("Fortsätter!..");
                        Wait();
                        break;
                    }
                    else if (!int.TryParse(userInput, out int number))
                    {
                        Console.WriteLine("Ej gilltigt tal");
                        continue;
                    }
                    break;
                }
            }
        }
    }
}
