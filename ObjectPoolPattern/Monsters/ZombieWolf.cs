using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPoolPattern.Monsters
{
    class ZombieWolf : Monster
    {
        public override void Loot()
        {
            Console.WriteLine("Rotten meat, yikes!");
        }
    }
}
