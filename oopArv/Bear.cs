using System.Xml.Linq;
namespace oopArv
{
    public class Bear : Animal
    {
        public bool IsHibernating { get; set; } = false;

        public Bear(string name) : base(name, 10, 150, 8, true)
        {

        }
        
        public void EatingHoney()
        {
            Console.WriteLine($"{Name} äter Dunderhonung!");
        }
       
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} sjunger Bamses visa!");
        }
    }
}
