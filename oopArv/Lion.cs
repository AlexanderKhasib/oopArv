namespace oopArv
{
    // Inherits from the Animal class
    public class Lion : Animal
    {
        // New individual property for Lion class
        public int LionCubs { get; set; } = 0;

        // Constructor for Lion class
        // Create new default values for lion, then sending them to the base Animal constructor
        public Lion(string name) : base(name, 10, 45, 8, true)
        {
        }

        // New individual method for Lion class
        public void LionPartner()
        {
            Console.WriteLine($"{Name} har en ingen partner!");
        }

        // Method to Override the MakeSound() method from the Animal class
        // Then printing out the Lion's new specific sound
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} låter RARW!");
        }
    }
}
