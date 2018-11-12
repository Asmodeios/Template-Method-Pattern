using ObjectPoolPattern.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPoolPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Dragon dragon = new Dragon();
            dragon.Engage();

            Skeleton skeleton = new Skeleton();
            skeleton.Engage();

            ZombieWolf wolf = new ZombieWolf();
            wolf.Engage();

            Console.ReadKey();
        }
    }
}
