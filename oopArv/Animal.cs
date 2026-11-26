using System.Drawing;
namespace oopArv
{
    public class Animal
    {
        // Properties with default shared values for all animals
        public string Name { get; set; } = "";
        public int Age { get; set; } = 0;
        public int Weight { get; set; } = 0;
        public int HowLongAtZoo { get; set; } = 0;
        public bool IsCarnivore { get; set; } = false;
        public Animal(string name, int age, int weight, int howLongAtZoo, bool isCarnivore)
        {
            Name = name;
            Age = age;
            Weight = weight;
            HowLongAtZoo = howLongAtZoo;
            IsCarnivore = isCarnivore;
        }
        public void Eat()
        {
            if (IsCarnivore)
            {
                Console.WriteLine($"{Name} äter kött!");
            }
            else
            {
                Console.WriteLine($"{Name} äter växter!");
            }
        }
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name}");
        }
        public void TimeAtZoo()
        {
            Console.WriteLine($"{Name} har bott här i {HowLongAtZoo} år!");
        }
    }
}
