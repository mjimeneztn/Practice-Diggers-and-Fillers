using System;

namespace Animals
{
    public class Reptile : ICreature, IWalk, ISwim
    {
        public string Name {get;set;}
        public int MaxDepth { get; set; }
        public string Speed { get; set; }
        public void Run()
        {
            Console.WriteLine($"{Name} is now running");
        }

        public void Walk()
        {
            Console.WriteLine($"{Name} is now walking");
        }
        public void Swim()
        {
            Console.WriteLine($"{Name} is now swimming");
        }
    }
}