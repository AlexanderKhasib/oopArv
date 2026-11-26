using System.Drawing;
namespace oopArv
{
    public class Animal
    {
        // My properties with their default shared values for all animals
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

        // My base method to print the animal's name, and the sound they make.
        // Then overriding it to be able to add add the specific sound the animal makes
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
