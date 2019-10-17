using System;
using System.Collections.Generic;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {

            var Parakeet = new SkyCreature() { Name = "Parakeet" };
            var Earthworm = new LandCreature() { Name = "worm" };
            var Finches = new SkyCreature() { Name = "finches" };
            var  Frog = new Reptile() { Name = "Frog" };
            var Mice = new LandCreature() { Name = "mouse" };
            var  Ants = new LandCreature() { Name = "ants" };
            var Terrapin = new Reptile() { Name = "terrapin" };
            var BettaFish = new WaterCreature() { Name = "fish" };
            var CopperHeadSnake = new LandCreature(){ Name = "Snakehead"};
            var Gerbil = new LandCreature(){Name = "Hammy"};

            var FlyerContainer = new FlyContainer();
            FlyerContainer.Fliers = new List<IFly>() { Parakeet, Finches  };

            var SwimmerContainer = new SwimContainer();
            SwimmerContainer.Swimmers = new List<ISwim>() { BettaFish, Terrapin, Frog};

            var UnderContainer = new UndergroundContainer();
            UnderContainer.Unders = new List<IWalk>() { Ants, Gerbil, Earthworm };
            var OverContainer = new GroundContainer();
            OverContainer.overs = new List<IWalk>() { Mice, Frog, CopperHeadSnake, Terrapin };
        }
    }
}

