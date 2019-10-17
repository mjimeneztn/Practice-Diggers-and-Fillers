using System;

namespace Animals
{
    public class SkyCreature : ICreature, IFly, IWalk
    {
        public string Name {get; set;}


        public string WingSpan { get; set; }
        public void Fly()
        {
            Console.WriteLine($"{Name} is now flying");
        }

        public void Walk()
        {
            Console.WriteLine($"{Name} is now walking");
        }
        public void Run()
        {
            Console.WriteLine($"{Name} is now running");
        }
    }
}