using System;
using System.Collections.Generic;
using System.Text;
namespace oopArv
{
    // Inherits from the Bear class
    public class Blackbear : Bear
    {
        // New individual property for Blackbear class
        public int HibernationTime { get; set; } = 5;

        // Constructor for the Blackbear class: calls the base Bear constructor,
        // then updating the inherited properties with the new default values specific to the Blackbear
        public Blackbear(string name) : base(name)
        {
            IsHibernating = true;
            Age = 7;
            Weight = 100;
        }

        // New individual method for the black bear
        // Printing out the name and the time it's been in hibernation with the HibernationTime property
        public void Hibernation()
        {
            Console.WriteLine($"{Name} har vart i ide i {HibernationTime} månader!");
        }

        // Method to Override the MakeSound() method from the Animal class
        // Then printing out the Blackbear's new specific sound
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} låter: Zzzzz...");
        }
    }
}
