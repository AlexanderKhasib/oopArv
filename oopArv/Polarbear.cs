using System;
using System.Collections.Generic;
using System.Text;
namespace oopArv
{
    // Inherits from the Bear class
    public class Polarbear : Bear
    {
        // New individual property for Polarbear class
        public bool Swimming { get; set; } = true;

        // Constructor for the Polarbear class: calls the base Bear constructor,
        // then updating the inherited properties with the new default values specific to the Polarbear 
        public Polarbear(string name) : base(name)
        {
            IsHibernating = false;
            Age = 13;
            Weight = 500;
        }

        // New individual method for the Polarbear class
        public void CatchingFish()
        {
            Console.WriteLine($"{Name} fångade fisk medans han simmade!");
        }

        // Method to Override the MakeSound() method from the Animal class
        // Then printing out the Polarbear's new specific sound
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} säger: Blub blub blub...");
        }
    }
}
