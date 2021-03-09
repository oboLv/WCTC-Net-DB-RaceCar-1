using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class WarRig : RaceCar
    {
        public WarRig()
        {
            Name = "War Rig";
            TopSpeed = 75;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} towers over the competition!");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} cant be stopped!");
            base.Brake();
        }

        public override void StopEngine()
        {
            System.Console.WriteLine($"The {Name} is witnessed!");
        }


    }
}
