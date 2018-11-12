using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPoolPattern.Monsters
{
    class Dragon : Monster
    {
        public override void Loot()
        {
            Console.WriteLine("Dragon Fury Sword has been dropped from Dragon");
        }
    }
}
