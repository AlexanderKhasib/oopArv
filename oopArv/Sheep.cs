namespace oopArv
{
    public class Sheep : Animal
    {
        public string FurColor { get; set; } = "Grå";

        public Sheep(string name) : base(name, 4, 30, 4, false)
        {
        }

        public void Sleeping()
        {
            Console.WriteLine($"{Name} sover..");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} låter Meow!");
        }
    }
}
