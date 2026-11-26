namespace oopArv
{
    public class Lion : Animal
    {
        public int LionCubs { get; set; } = 0;
        public Lion(string name) : base(name, 10, 45, 8, true)
        {
        }
        public void LionPartner()
        {
            Console.WriteLine($"{Name} har en ingen partner!");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} låter RARW!");
        }
    }
}
