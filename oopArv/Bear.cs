using System.Xml.Linq;
namespace oopArv
{
    // Inherits from the Animal class
    public class Bear : Animal
    {
        // Create a new individual property for the bear class
        public bool IsHibernating { get; set; } = false;

        // Constructor for Bear class
        // Create new default values for the bear then sending them to the base Animal constructor
        public Bear(string name) : base(name, 10, 150, 8, true)
        {
        }

        // Create a new individual method for the bear class
        public void EatingHoney()
        {
            Console.WriteLine($"{Name} äter Dunderhonung!");
        }

        // Method to Override the MakeSound() method fromthe  Animal class
        // Then printing out the bear's new specific sound
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} sjunger Bamses visa!");
        }
    }
}
