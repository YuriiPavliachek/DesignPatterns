namespace Patterns.Prototype
{
    public class Character : IPrototype<Character>
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public Character(string name, int health)
        {
            Name = name;
            Health = health;
        }
        public Character Clone()
        {
            return (Character)this.MemberwiseClone();
        }
        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Health: {Health}");
        }
    }
}
