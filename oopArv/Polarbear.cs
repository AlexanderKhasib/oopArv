using System;
using System.Collections.Generic;
using System.Text;

namespace oopArv
{
    public class Polarbear : Bear
    {
        public bool Swimming { get; set; } = true;

        public Polarbear(string name) : base(name)
        {
            IsHibernating = false;
            Age = 13;
            Weight = 500;
        }

        public void CatchingFish()
        {
            Console.WriteLine($"{Name} fångade fisk medans han simmade!");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} säger: Blub blub blub...");
        }
    }
}
