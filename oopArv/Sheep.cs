namespace oopArv
{
    // Inherits from the Animal class
    public class Sheep : Animal
    {
        // New individual property for Sheep class
        public string FurColor { get; set; } = "Grå";

        // Constructor for Sheep class.
        // Create new default values for lion, then sending them to the base Animal constructor
        public Sheep(string name) : base(name, 4, 30, 4, false)
        {
        }

        // New individual method for Sheep class
        public void Sleeping()
        {
            Console.WriteLine($"{Name} sover..");
        }

        // Method to Override the MakeSound() method from the Animal class
        // Then printing out the Sheep's new specific sound
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} låter Meow!");
        }
    }
}
