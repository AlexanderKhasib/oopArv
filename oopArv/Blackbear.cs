using System;
using System.Collections.Generic;
using System.Text;

namespace oopArv
{
    public class Blackbear : Bear
    {
        public int HibernationTime { get; set; } = 5;

        public Blackbear(string name) : base(name)
        {
            IsHibernating = true;
            Age = 7;
            Weight = 100;

        }

        public void Hibernation()
        {
            Console.WriteLine($"{Name} har vart i ide i {HibernationTime} månader!");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} låter: Zzzzz...");
        }
    }
}
