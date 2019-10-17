using System;

namespace Animals
{
    public class LandCreature : ICreature, IWalk
    {
        public string Name {get; set;}
        public int Speed { get; set; }

        public void Run()
        {
            Console.WriteLine($"{Name} is now running");
        }

        public void Walk()
        {
            Console.WriteLine($"{Name} is now walking");
        }
    }
}