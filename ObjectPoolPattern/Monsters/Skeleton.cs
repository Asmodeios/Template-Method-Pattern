using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPoolPattern.Monsters
{
    class Skeleton : Monster
    {
        public override void Loot()
        {
            Console.WriteLine("Nothing dropped, this is just a pile of bones");
        }
    }
}
