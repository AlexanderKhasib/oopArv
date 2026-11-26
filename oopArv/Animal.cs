using System.Drawing;
namespace oopArv
{
    public class Animal
    {
        // My properties for the Animal class, with the default value shared for all animals made
        public string Name { get; set; } = "";
        public int Age { get; set; } = 0;
        public int Weight { get; set; } = 0;
        public int HowLongAtZoo { get; set; } = 0;
        public bool IsCarnivore { get; set; } = false;

        // Constructor for Animal class
        // Allowing me to create new animals with custom values for the base properties
        public Animal(string name, int age, int weight, int howLongAtZoo, bool isCarnivore)
        {
            Name = name;
            Age = age;
            Weight = weight;
            HowLongAtZoo = howLongAtZoo;
            IsCarnivore = isCarnivore;
        }

        // Method to check what type of food the animal eats with true or false with the IsCarnivore property
        public void Eat()
        {
            if (IsCarnivore)
            {
                // Prints out if IsCarnivore is TRUE
                Console.WriteLine($"{Name} äter kött!");
            }
            else
            {
                // Prints out the else statment if IsCarnivore is FALSE
                Console.WriteLine($"{Name} äter växter!");
            }
        }

        // Base method to print out the animal name and sound.
        // It is overridden and replaced later in the subclasses to print each animal's name and unique sound
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name}");
        }

        // Method to see how long an animal has stayed at the zoo,
        // by printing out the name and lenght of stay with HowLongAtZoo property
        public void TimeAtZoo()
        {
            Console.WriteLine($"{Name} har bott här i {HowLongAtZoo} år!");
        }
    }
}
